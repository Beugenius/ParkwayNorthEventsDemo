using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace ParkwayNorthEvents.Pages.User.MyEvents
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public List<Booking> UserBookings;
        public IndexModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task OnGet()
        {
            // Get the logged in users values 
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            ApplicationUser applicationUser = await _unitOfWork.ApplicationUsers.GetAsync(c => c.Id == claim.Value);
            var bookings = await _unitOfWork.Bookings.ListAsync(x => x.ClientId == applicationUser.Id);
            UserBookings = bookings.ToList();
            UserBookings = UserBookings.OrderByDescending(x => x.DateOfEvent).ToList();
        }
    }
}
