using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Infrastructure.Utility;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Drawing;
using PhoneNumbers;
using ApplicationCore.ViewModels;

namespace ParkwayNorthEvents.Pages.Scheduling
{
    public class ConsultationModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmailSender _emailSender;
        private readonly IUserStore<ApplicationUser> _userStore;
        private readonly RoleManager<IdentityUserRole<string>> _roleManager;
        
        [BindProperty]
        public ApplicationUser ClientObject { get; set; } = new();
        [BindProperty]
        public string VisionOfEvent { get; set; } = string.Empty;
        [BindProperty]
        public string YourLoveStory { get; set; } = string.Empty;
        [BindProperty]
        public DateTime DateOfEvent { get; set; }
        public ErrorMessage ErrorMessage { get; set; }
        public ConsultationModel(IUnitOfWork unitOfWork,
            UserManager<ApplicationUser> userManager,
            IEmailSender emailSender,
            IUserStore<ApplicationUser> userStore)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _emailSender = emailSender;
            _userStore = userStore;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            // check phonenumber and email first 
            PhoneNumberUtil phoneUtil = PhoneNumberUtil.GetInstance();
            var userEnteredPhoneNumber = ClientObject.PhoneNumber;
            PhoneNumber validUserPhoneNumber = new(); 
            try
            {
                validUserPhoneNumber = phoneUtil.Parse(userEnteredPhoneNumber, "US");
            }
            catch (NumberParseException ex)
            {
                int i = 0;
            }
            if(phoneUtil.IsValidNumber(validUserPhoneNumber) == false)
            {
                ErrorMessage = new()
                {
                    InvalidPhoneNumber = "Please enter a valid phone number."
                };
                return Page(); 
            }
            ClientObject.PhoneNumber = validUserPhoneNumber.NationalNumber.ToString();
            var clientInDatabase = await _userManager.FindByEmailAsync(ClientObject.Email);
            if (clientInDatabase != null) // if client is already in database, find them and link them 
            {
                ClientObject = clientInDatabase;
            }
            
            // intentionally not saving consultations as objects anymore by client request 
            // instead send email 
            // first email to client letting them know we've heard from them and will be in contact 
            await _emailSender.SendEmailAsync(ClientObject.Email, "New Consultation", 
                $"Hey {ClientObject.FirstName},<br><br>We've received your request for a consultation. One of our event coordinators will be in contact shortly!" +
                $"<br><br>We are looking forward to helping you ensure your big day is a success.<br>Talk to you soon,<br>-ParkwayNorthEvents<br><br>Please do not reply to this" +
                $" email as it is unmonitored and we will not hear from you! If you have any questions please refer to our contact page.");

            // second email containing details for admin to reach out with 
            await _emailSender.SendEmailAsync("bryce.eugene@outlook.com", $"New Consultation - {ClientObject.FullName}", "Details:<br><br>" +
                $"Name: {ClientObject.FullName}<br>Phone Number: {ClientObject.PhoneNumber}<br>Email: {ClientObject.Email}<br><br>Their love story: <br><br>{YourLoveStory}<br><br>" +
                $"Vision of Event: <br><br>{VisionOfEvent}<br><br>Date of event: {DateOfEvent.Date:MM/dd/yyyy}");
            return RedirectToPage("./ConsultationConfirmed");
        }

        private IUserEmailStore<ApplicationUser> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<ApplicationUser>)_userStore;
        }
    }
}
