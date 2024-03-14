using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ParkwayNorthEvents.Pages.Admin.Roles
{
    public class UpdateModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly RoleManager<IdentityRole> _roleManager;
        public UpdateModel(IUnitOfWork unitOfWork, RoleManager<IdentityRole> roleManager)
        {
            _unitOfWork = unitOfWork;
            _roleManager = roleManager;
        }
        [BindProperty]
        public IdentityRole Role { get; set; }
        public void OnGet(string id)
        {
            if (id.Equals(new Guid().ToString()))
            {
                Role = new();
            }
            else
            {
                Role = _roleManager.Roles.Where(r => r.Id == id).Select(r => r).First();
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!_roleManager.Roles.Any(x => x.Id == Role.Id))
            {
                await _roleManager.CreateAsync(Role);
                return RedirectToPage("./Index", new { success = true, message = "Created Successfully" });
            }
            else
            {
                var role = _roleManager.Roles.FirstOrDefault(r => r.Id == Role.Id);
                if (role == null)
                {
                    return NotFound();
                }
                role.Name = Role.Name;
                await _roleManager.UpdateAsync(role);
                return RedirectToPage("./Index", new { success = true, message = "Update Successful" });

            }

        }
    }
}
