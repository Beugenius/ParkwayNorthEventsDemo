using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Infrastructure.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NuGet.Packaging;

namespace ParkwayNorthEvents.Pages.Admin.Clients
{
    public class ClientsModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        public IList<ApplicationUser> Clients { get; set; }
        public ClientsModel(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }

        public async Task OnGet()
        {
            Clients = await _userManager.GetUsersInRoleAsync(SD.ClientRole);
            var unregisteredClients = await _userManager.GetUsersInRoleAsync(SD.UnregisteredClient);
            // add in the unregistered clients as well
            Clients.AddRange(unregisteredClients);
        }
    }
}
