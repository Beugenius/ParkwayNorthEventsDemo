using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ParkwayNorthEvents.Pages
{
    public class VenuesModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public VenuesModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public List<Venue> Venues { get; set; }
        public void OnGet()
        {
            Venues = _unitOfWork.Venues.List().ToList();
        }
    }
}
