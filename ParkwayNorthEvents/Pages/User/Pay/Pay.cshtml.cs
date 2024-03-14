using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Infrastructure.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Linq;
using Stripe;
using System.Security.Claims;

namespace ParkwayNorthEvents.Pages.User.Pay
{
    public class PayModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        [BindProperty]
        public Booking SelectedBooking { get; set; }
        public ApplicationUser Client { get; set; }
        [BindProperty]
        public Transaction TransactionDetails { get; set; }
        //internal PayPalAPI PayPalApi { get; set; } = new();
        //internal readonly JToken _clientToken;
        //internal JObject Order { get; set; }
        public PayModel(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            //_clientToken = PayPalApi.CreateClientToken().Result;
            //Order = PayPalApi.CreateOrder().Result;
        }
        public async Task OnGet(string id, Decimal amount)
        {
            SelectedBooking = await _unitOfWork.Bookings.GetAsync(x => x.BookingId.ToString() == id);
            // create a payment with user information 
            TransactionDetails = new Transaction()
            {
                TransactionId = Guid.NewGuid(),
                BookingId = SelectedBooking.BookingId,
                Status = SD.PaymentCreated,
                TransactionAmount = amount,
                TransactionDate = DateTime.MinValue,
                StripeTransactionId = string.Empty
            };
        }

        public async Task<IActionResult> OnPost(string stripeToken)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var selectedBooking = await _unitOfWork.Bookings.GetAsync(x => x.BookingId == SelectedBooking.BookingId);
            if (stripeToken is not null)
            {
                var options = new ChargeCreateOptions()
                {
                    Amount = Convert.ToInt32(TransactionDetails.TransactionAmount * 100),
                    Currency = "usd",
                    Description = "Transaction Id: " + TransactionDetails.TransactionId,
                    Source = stripeToken
                };
                var service = new ChargeService();
                Charge charge = service.Create(options);
                TransactionDetails.StripeTransactionId = charge.Id;
                TransactionDetails.Status = charge.Status.ToLower() == "succeeded" ? SD.PaymentStatusApproved : SD.PaymentStatusRejected;
            }
            if (TransactionDetails.Status == SD.PaymentStatusApproved)
            {
                TransactionDetails.TransactionDate = DateTime.Now;
                // Intentionally do not create a transaction in the db until the payment has been approved
                // To prevent extra unfulfilled transactions
                _unitOfWork.Transactions.Add(TransactionDetails);
                await _unitOfWork.CommitAsync();
                selectedBooking.Balance = selectedBooking.Balance - TransactionDetails.TransactionAmount;
                _unitOfWork.Bookings.Update(selectedBooking);
                await _unitOfWork.CommitAsync();
                // send to confirmation page 
                return RedirectToPage("/User/Pay/Confirmation", new { id = TransactionDetails.TransactionId });
            }
            return Page();
        }

        public IActionResult OnPostBack(string id)
        {
            return RedirectToPage("/User/MyEvents/Id", new { id = id });
        }
    }
}
