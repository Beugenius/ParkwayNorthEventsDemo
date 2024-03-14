using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Infrastructure.Data.AzureStorage;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ParkwayNorthEvents.Pages.Gallery
{
    public class CreateNewModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        [BindProperty]
        public EventGallery NewGallery { get; set; } = new();
        public CreateNewModel(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            string webRootPath = _webHostEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;
            NewGallery.Id = Guid.NewGuid();
            AzureStorage azureStorage = new();
            var id = Guid.NewGuid();
            string uri = await azureStorage.UploadImageAsync(files[0], id);
            // create gallery image and link to gallery 
            var galleryImage = new GalleryImage()
            {
                Id = id,
                EventGalleryId = NewGallery.Id,
                Image = uri
            };
            
            // add gallery object to database
            NewGallery.DisplayImage = galleryImage.Image;
            _unitOfWork.EventGallery.Add(NewGallery);
            await _unitOfWork.CommitAsync();
            // commit gallery image
            _unitOfWork.GalleryImages.Add(galleryImage);
            await _unitOfWork.CommitAsync();
            return RedirectToPage("/Gallery/Index");
        }

        public IActionResult OnPostBack()
        {
            return RedirectToPage("/Gallery/Index");
        }
    }
}
