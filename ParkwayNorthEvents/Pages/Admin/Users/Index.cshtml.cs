using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ParkwayNorthEvents.Pages.Admin.Users
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        public IndexModel(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }
        public IEnumerable<ApplicationUser> ApplicationUsers { get; set; }
        public Dictionary<string, string> UserRoles { get; set; }
        public bool Success { get; set; }
        public string? Message { get; set; }
        public async Task OnGetAsync(bool success = false, string? message = null)
        {
            Success = success;
            Message = message;
            UserRoles = new();
            ApplicationUsers = _unitOfWork.ApplicationUsers.List();
            foreach (var user in ApplicationUsers)
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                // for the way the app is set up now, user shouldn't have more than one role 
                UserRoles.Add(user.Id, userRoles.First());
            }
        }

        public async Task<IActionResult> OnPostLockUnlock(string id)
        {
            var user = await _unitOfWork.ApplicationUsers.GetAsync(u => u.Id == id);
            if (user.LockoutEnd == null)
            {
                user.LockoutEnd = DateTime.Now.AddYears(100);
                user.LockoutEnabled = true;
            }
            else if (user.LockoutEnd > DateTime.Now)
            {
                user.LockoutEnd = DateTime.Now;
                user.LockoutEnabled = false;
            }
            else
            {
                user.LockoutEnd = DateTime.Now.AddYears(100);
                user.LockoutEnabled = true;
            }
            _unitOfWork.ApplicationUsers.Update(user);
            await _unitOfWork.CommitAsync();
            return RedirectToPage();
        }
    }
}
