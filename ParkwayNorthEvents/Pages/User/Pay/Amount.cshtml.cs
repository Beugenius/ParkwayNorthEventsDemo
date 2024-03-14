using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Infrastructure.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Linq;

namespace ParkwayNorthEvents.Pages.User.Pay
{
    public class AmountModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        //private readonly UserManager<ApplicationUser> _userManager;
        [BindProperty]
        public Booking SelectedBooking { get; set; }
        public ApplicationUser Client { get; set; }
        public Transaction TransactionDetails { get; set; }
        [BindProperty]
        public Decimal Amount { get; set; } = new decimal(0.5);
        public AmountModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task OnGet(string id)
        {
            SelectedBooking = await _unitOfWork.Bookings.GetAsync(x=>x.BookingId.ToString() == id);
        }
        public async Task<IActionResult> OnPostPayment(Decimal amount)
        {
            HttpContext.Session.SetString(SD.BookingId, SelectedBooking.BookingId.ToString());
            return RedirectToPage("/User/Pay/Pay", new { id = SelectedBooking.BookingId, amount = amount });
        }
    }
}
