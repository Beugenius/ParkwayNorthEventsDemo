using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Infrastructure.Data.AzureStorage;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ParkwayNorthEvents.Controllers;

namespace ParkwayNorthEvents.Pages.Gallery
{
    public class ViewModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        [BindProperty]
        public EventGallery SelectedGallery { get; set; }
        public List<GalleryImage> Images { get; set; } = new();
        public ViewModel(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task OnGet(string id)
        {
            SelectedGallery = await _unitOfWork.EventGallery.GetAsync(x => x.Id.ToString() == id);
            var imagesEnumerable = await _unitOfWork.GalleryImages.ListAsync(x => x.EventGalleryId.ToString() == id);
            Images = imagesEnumerable.ToList();
            var headerImg = Images.Where(x => x.Image == SelectedGallery.DisplayImage).FirstOrDefault();
            if (headerImg != null)
            {
                Images.Remove(headerImg);
                Images.Insert(0, headerImg);
            }
        }
        public IActionResult OnPost(string id)
        {
            return RedirectToPage("/Gallery/AddImage", new { id });
        }
        public IActionResult OnPostBack()
        {
            return RedirectToPage("/Gallery/Index");
        }

        public async Task<IActionResult> OnPostReplace(string id)
        {
            SelectedGallery = await _unitOfWork.EventGallery.GetAsync(x => x.Id.ToString() == id);
            string webRootPath = _webHostEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;

            // delete the header image 
            var imageToDelete = await _unitOfWork.GalleryImages.GetAsync(x => x.Image == SelectedGallery.DisplayImage);
            if (imageToDelete is not null)
            {
                ImageController imgController = new(_unitOfWork, _webHostEnvironment);
                await imgController.Delete(imageToDelete.Id.ToString());
            }
            // store the new image
            var newId = Guid.NewGuid();

            AzureStorage azureStorage = new();
            var uri = await azureStorage.UploadImageAsync(files[0], newId); 

            GalleryImage newImage = new()
            {
                Id = newId,
                EventGalleryId = SelectedGallery.Id,
                Image = uri
            };
            
            // commit gallery image
            _unitOfWork.GalleryImages.Add(newImage);
            await _unitOfWork.CommitAsync();
            // set the event selected image as the new image
            SelectedGallery.DisplayImage = newImage.Image;
            _unitOfWork.EventGallery.Update(SelectedGallery);
            await _unitOfWork.CommitAsync();
            // return page with selected galleryId 
            return RedirectToPage("/Gallery/View", new { id = SelectedGallery.Id });
        }
    }
}
