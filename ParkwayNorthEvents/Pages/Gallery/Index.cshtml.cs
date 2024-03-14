using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ParkwayNorthEvents.Pages.Gallery
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public IEnumerable<EventGallery> Galleries { get; set; }

        public IndexModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public void OnGet()
        {
            Galleries = _unitOfWork.EventGallery.List();
        }
        public IActionResult OnPostGallery(string galleryId)
        {
            return RedirectToPage("/Gallery/View", new { id = galleryId });
        }
    }
}
