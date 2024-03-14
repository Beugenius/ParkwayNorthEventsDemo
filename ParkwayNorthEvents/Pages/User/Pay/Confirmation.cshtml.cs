using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Infrastructure.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ParkwayNorthEvents.Pages.User.Pay
{
    public class ConfirmationModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public Transaction Transaction { get; set; }
        public Booking SelectedBooking { get; set; }
        public ConfirmationModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task OnGet(string id)
        {
            Transaction = await _unitOfWork.Transactions.GetAsync(x => x.TransactionId.ToString() == id);
            SelectedBooking = await _unitOfWork.Bookings.GetAsync(x => x.BookingId == Transaction.BookingId);
        }
        public IActionResult OnPostBack()
        {
            return RedirectToPage("/User/MyEvents/Edit", new { id = HttpContext.Session.GetString(SD.BookingId) });
        }
    }
}
