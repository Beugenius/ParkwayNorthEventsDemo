using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Infrastructure.Utility;
using Newtonsoft.Json.Linq;

namespace ParkwayNorthEvents.Pages.User.MyEvents
{
    public class EditModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        [BindProperty]
        public Booking SelectedBooking { get; set; }
        public List<Supplier> SupplierList { get; set; } = new();
        public IEnumerable<ServicesBooked> ServicesBookedList { get; set; }
        public IEnumerable<VenuesBooked> VenuesBookedList { get; set; }
        public List<Venue> VenuesList { get; set; } = new();
        public ApplicationUser Client { get; set; }
        public IEnumerable<Transaction> TransactionList { get; set; }
        public EditModel(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }
        public async Task OnGet(string id)
        {
            // get the booking object
            SelectedBooking = await _unitOfWork.Bookings.GetAsync(x => x.BookingId.ToString() == id);
            // get the booked services
            ServicesBookedList = await _unitOfWork.ServicesBooked.ListAsync(x => x.BookingId == id);
            // get the associated suppliers in a list 
            foreach (var supplier in ServicesBookedList)
            {
                Supplier supplierToAdd = await _unitOfWork.Suppliers.GetAsync(x => x.SupplierId.ToString() == supplier.SupplierId);
                // add the supplier to the list
                SupplierList.Add(supplierToAdd);
                await _unitOfWork.CommitAsync();
            }
            // get the booked venues 
            VenuesBookedList = await _unitOfWork.VenuesBooked.ListAsync(x => x.BookingId == SelectedBooking.BookingId);
            foreach (var venue in VenuesBookedList)
            {
                Venue venueToAdd = await _unitOfWork.Venues.GetAsync(x => x.VenueId == venue.VenueId);
                VenuesList.Add(venueToAdd);
            }
            // get the transactions 
            TransactionList = await _unitOfWork.Transactions.ListAsync(x => x.BookingId == SelectedBooking.BookingId);
            TransactionList = TransactionList.OrderByDescending(x => x.TransactionDate);
            Client = await _userManager.FindByIdAsync(SelectedBooking.ClientId);
            HttpContext.Session.SetString(SD.BookingId, SelectedBooking.BookingId.ToString());
        }
        public IActionResult OnPostPayment()
        {
            HttpContext.Session.SetString(SD.BookingId, SelectedBooking.BookingId.ToString());
            return RedirectToPage("/User/Pay/Amount", new { id = SelectedBooking.BookingId.ToString() });
        }
        public string GetBookingTypeString(BookingType Type)
        {
            switch (Type)
            {
                case BookingType.DayOfWeddingCoordination:
                    return "Day of wedding coordination";
                case BookingType.HourlyConsulting:
                    return "Hourly Consulting";
                case BookingType.ProposalAssistance:
                    return "Proposal Assistance";
                case BookingType.Other:
                    return "Other";
                case BookingType.DIY:
                    return "DIY";
                default:
                    return "Error";
            }
        }
    }
}
