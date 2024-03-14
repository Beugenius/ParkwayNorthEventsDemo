using ApplicationCore.Interfaces;
using Infrastructure.Data.AzureStorage;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Hosting;

namespace ParkwayNorthEvents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ImageController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = hostEnvironment;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            string webRootPath = _webHostEnvironment.WebRootPath;
            AzureStorage azureStorage = new();
            // get the image from the database 
            var imageToDelete = await _unitOfWork.GalleryImages.GetAsync(x => x.Id.ToString() == id);
            if (imageToDelete is not null)
            {
                // delete image on Azure Storage Account
                await azureStorage.DeleteImageAsync(imageToDelete.Id.ToString());

                // delete the image from the database 
                _unitOfWork.GalleryImages.Delete(imageToDelete);
                await _unitOfWork.CommitAsync();
                return Json(new { success = true, message = "Delete Successful" });
            }
            return Json(new { success = false, message = "Error while deleting" });
        }
    }
}
