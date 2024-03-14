using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Infrastructure.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq.Expressions;
using System.Web;

namespace ParkwayNorthEvents.Pages.Scheduling
{
    public class EventModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmailSender _emailSender;
        private readonly IUserStore<ApplicationUser> _userStore;
        [BindProperty]
        public Supplier SupplierObject { get; set; }
        [BindProperty]
        public Booking BookingObject { get; set; }
        [BindProperty]
        public ApplicationUser ApplicationUser { get; set; } = new();
        public bool IsError { get; set; } = false;
        // TODO - get current user ID 
        public int UserID { get; set; }
        public EventModel(IUnitOfWork unitOfWork,
            UserManager<ApplicationUser> userManager,
            IEmailSender emailSender,
            IUserStore<ApplicationUser> userStore)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _emailSender = emailSender;
            _userStore = userStore;
        }
        public void OnGet(bool isError = false)
        {
            IsError = isError;
        }

        public async Task<IActionResult> OnPost()
        {
            try
            {
                var user = await _unitOfWork.ApplicationUsers.GetAsync(x => x.Email == ApplicationUser.Email);
                if (user is not null) // if client is already in database, find and link them
                {
                    // Todo create update async method 
                    ApplicationUser = user;
                    _unitOfWork.ApplicationUsers.Update(ApplicationUser);
                    await _unitOfWork.CommitAsync();
                }
                else // create a new client 
                {
                    ApplicationUser.UserName = ApplicationUser.Email;
                    ApplicationUser.NormalizedEmail = ApplicationUser.Email.ToUpper();
                    ApplicationUser.NormalizedEmail = ApplicationUser.Email.ToUpper();
                    await _userManager.CreateAsync(ApplicationUser);
                    await _userManager.AddToRoleAsync(ApplicationUser, SD.UnregisteredClient);
                }
                BookingObject.ClientId = ApplicationUser.Id;
                BookingObject.ClientName = ApplicationUser.FullName;
                
                // Add the booking object to database 
                _unitOfWork.Bookings.Add(BookingObject);
                await _unitOfWork.CommitAsync();

                var supplierInDatabase = await _unitOfWork.Suppliers.GetAsync(x => x.SupplierName == SupplierObject.SupplierName);
                if (supplierInDatabase != null) // check if supplier is already in database 
                {
                    SupplierObject = supplierInDatabase;
                    _unitOfWork.ServicesBooked.Add(
                    new ServicesBooked()
                    {
                        SupplierId = SupplierObject.SupplierId.ToString(),
                        BookingId = BookingObject.BookingId.ToString(),
                        ServiceStatus = "New"
                    });
                    await _unitOfWork.CommitAsync();
                }
                else if (SupplierObject.SupplierName is null || SupplierObject.SupplierName == string.Empty ||
                    SupplierObject.SupplierPhoneNumber is null || SupplierObject.SupplierPhoneNumber == string.Empty)
                {
                    // if no supplier provided, do nothing 
                }
                else // else add new supplier into database 
                {
                    _unitOfWork.Suppliers.Add(SupplierObject);
                    await _unitOfWork.CommitAsync();
                    _unitOfWork.ServicesBooked.Add(
                    new ServicesBooked()
                    {
                        SupplierId = SupplierObject.SupplierId.ToString(),
                        BookingId = BookingObject.BookingId.ToString(),
                        ServiceStatus = "New"
                    });
                    await _unitOfWork.CommitAsync();
                }
                // send email to user letting them know a new event has been added to their account 
                await _emailSender.SendEmailAsync(ApplicationUser.Email, "A new event has been added to your account!", $"Hello {ApplicationUser.FirstName}" +
                    $"<br><br>A new event has been added to your account! Please sign in or create an account with this email to view your event." +
                    $"<br><br>-ParkwayNorthEvents<br><br>Please do not reply to this email as it is unmonitored and we will not hear from you! If you have any questions please refer to our contact page.");
                return RedirectToPage("/Admin/Calendar");
            }
            catch (Exception ex)
            {
                return RedirectToPage("/Scheduling/Event", new { isError = true });
            }

        }
    }
}
