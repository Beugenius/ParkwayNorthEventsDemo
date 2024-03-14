using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Infrastructure.Data.AzureStorage;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ParkwayNorthEvents.Pages.Gallery
{
    public class AddImageModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public string RootPathForImageStorage; 
        [BindProperty]
        public EventGallery SelectedGallery { get; set; }
        public AddImageModel(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
            RootPathForImageStorage = _webHostEnvironment.WebRootPath; 
        }

        public async Task OnGet(string id)
        {
            SelectedGallery = await _unitOfWork.EventGallery.GetAsync(x => x.Id.ToString() == id);

        }

        public async Task<IActionResult> OnPost()
        {
            string webRootPath = _webHostEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;
            AzureStorage azureStorage = new();
            // for each file 
            foreach (var file in files)
            {
                var id = Guid.NewGuid();
                string uri = await azureStorage.UploadImageAsync(file, id);
                GalleryImage newImage = new()
                {
                    Id = id,
                    EventGalleryId = SelectedGallery.Id,
                    Image = uri
                }; 
                
                // commit gallery image
                _unitOfWork.GalleryImages.Add(newImage);
                await _unitOfWork.CommitAsync();
            }
            
            
            return RedirectToPage("View", new { id = SelectedGallery.Id });
        }

        public IActionResult OnPostBack()
        {
            return RedirectToPage("View", new { id = SelectedGallery.Id });
        }
    }
}
