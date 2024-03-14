using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ParkwayNorthEvents.Pages.Admin.Users
{
    public class UpdateModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UpdateModel(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        [BindProperty]
        public ApplicationUser AppUser { get; set; }
        public string UserRole { get; set; }
        public List<string> AllRoles { get; set; }
        public string OldRole { get; set; }
        public async Task OnGet(string id)
        {
            AppUser = await _unitOfWork.ApplicationUsers.GetAsync(u => u.Id == id);
            var roles = await _userManager.GetRolesAsync(AppUser);
            UserRole = roles.First();
            OldRole = roles.First();
            AllRoles = _roleManager.Roles.Select(r => r.Name).ToList();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            var newRole = Request.Form["roles"].ToString();
            UserRole = newRole;
            var OldRole = await _userManager.GetRolesAsync(AppUser);
            var user = await _unitOfWork.ApplicationUsers.GetAsync(u => u.Id == AppUser.Id);

            user.FirstName = AppUser.FirstName;
            user.LastName = AppUser.LastName;
            user.Email = AppUser.Email;
            user.PhoneNumber = AppUser.PhoneNumber;
            _unitOfWork.ApplicationUsers.Update(user);
            await _unitOfWork.CommitAsync();

            // update their role
            var result = await _userManager.RemoveFromRoleAsync(user, OldRole.First());
            var result1 = await _userManager.AddToRolesAsync(user, new List<string>() { newRole });
            return RedirectToPage("./Index", new { success = true, message = "Update Successful" });
        }
    }
}
