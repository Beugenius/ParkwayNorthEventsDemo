using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ParkwayNorthEvents.Pages.Admin
{
    public class CalendarModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        [BindProperty]
        public List<Booking> BookingList { get; set; }
        [BindProperty]
        public List<Venue> VenueList { get; set; } = new();
        [BindProperty]
        public List<Supplier> SupplierList { get; set; } = new();
        [BindProperty]
        public List<ServicesBooked> ServicesBookedList { get; set; } = new();
        [BindProperty]
        public List<ApplicationUser> ClientsList { get; set; } = new();
        public CalendarModel(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }
        public void OnGet()
        {
            BookingList = _unitOfWork.Bookings.List().OrderBy(x => x.DateOfEvent).ToList();
            VenueList = _unitOfWork.Venues.List().ToList();
            SupplierList = _unitOfWork.Suppliers.List().ToList();
            ServicesBookedList = _unitOfWork.ServicesBooked.List().ToList();
            ClientsList = _userManager.Users.ToList();
        }
    }
}
