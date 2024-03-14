using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ParkwayNorthEvents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalleryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public GalleryController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = hostEnvironment;
        }

        [HttpPost("{details}")]
        public async Task<IActionResult> Post(string id, string title)
        {
            var galleryToEdit = await _unitOfWork.EventGallery.GetAsync(x => x.Id.ToString() == id);
            if (galleryToEdit is not null)
            {
                galleryToEdit.NameOfEvent = title;
                _unitOfWork.EventGallery.Update(galleryToEdit);
                await _unitOfWork.CommitAsync();
                return Json(new { success = true, message = "Update successful!" });
            }
            return Json(new { success = false, message = "Error while updating" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var galleryToDelete = await _unitOfWork.EventGallery.GetAsync(x => x.Id.ToString() == id);
            if (galleryToDelete is not null)
            {
                // re-using DeleteImageController to delete all images
                ImageController ImageController = new(_unitOfWork, _webHostEnvironment);
                var imagesInGalleryToDelete = await _unitOfWork.GalleryImages.ListAsync(x => x.EventGalleryId == galleryToDelete.Id);
                foreach(var image in imagesInGalleryToDelete)
                {
                    var result = await ImageController.Delete(image.Id.ToString());
                }
                // delete the gallery 
                _unitOfWork.EventGallery.Delete(galleryToDelete);   
                await _unitOfWork.CommitAsync();
                return Json(new { success = true, message = "Delete Successful" });
            }
            return Json(new { success = false, message = "Error while deleting" });
        }
    }
}
