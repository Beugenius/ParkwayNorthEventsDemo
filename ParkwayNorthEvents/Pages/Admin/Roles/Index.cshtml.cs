using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ParkwayNorthEvents.Pages.Admin.Roles
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly RoleManager<IdentityRole> _roleManager;
        public IndexModel(IUnitOfWork unitOfWork, RoleManager<IdentityRole> roleManager)
        {
            _unitOfWork = unitOfWork;
            _roleManager = roleManager;
        }
        public IEnumerable<IdentityRole> Roles { get; set; }
        public bool Success { get; set; }
        public string? Message { get; set; }

        public void OnGetAsync(bool success = false, string? message = null)
        {
            Success = success;
            Message = message;
            Roles = _roleManager.Roles.ToList();
        }
    }
}
