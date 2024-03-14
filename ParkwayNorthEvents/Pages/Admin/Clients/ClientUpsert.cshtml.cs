using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ParkwayNorthEvents.Pages.Admin.Clients
{
    public class ClientsUpsertModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        [BindProperty]
        public ApplicationUser ClientObject { get; set; }
        public ClientsUpsertModel(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }
        public async Task<IActionResult> OnGet(string? id)
        {
            ClientObject = new ApplicationUser();
            if (id != new Guid().ToString()) // new
            {
                ClientObject = await _userManager.FindByIdAsync(id);
            }
            if (ClientObject == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            // If this is new 
            if (ClientObject.Id == new Guid().ToString())
            {
                await _userManager.CreateAsync(ClientObject);
            }
            else
            {
                var client = await _unitOfWork.ApplicationUsers.GetAsync(x => x.Id == ClientObject.Id);
                client.FirstName = ClientObject.FirstName;
                client.LastName = ClientObject.LastName;
                client.Email = ClientObject.Email;
                client.PhoneNumber = ClientObject.PhoneNumber;
                _unitOfWork.ApplicationUsers.Update(client);
                await _unitOfWork.CommitAsync();
            }
            return RedirectToPage("./Clients");
        }
    }
}
