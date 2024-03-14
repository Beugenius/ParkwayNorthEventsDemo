using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ParkwayNorthEvents.Pages.Admin
{
    public class BookingUpdateModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        [BindProperty]
        public Booking BookingObject { get; set; }
        public BookingUpdateModel(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }
        public async Task<IActionResult> OnGet(string? id)
        {
            BookingObject = new Booking();
            BookingObject = await _unitOfWork.Bookings.GetAsync(b => b.BookingId.ToString() == id);
            if (BookingObject == null)
            {
                return NotFound();
            }
            return Page(); // assume insert new mode 
        }
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _unitOfWork.Bookings.Update(BookingObject);
            await _unitOfWork.CommitAsync();
            return RedirectToPage("./Calendar");

        }
    }
}
