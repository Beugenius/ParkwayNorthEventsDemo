using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ParkwayNorthEvents.Pages.Admin
{
    public class SupplierUpsertModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        [BindProperty]
        public Supplier SupplierObject { get; set; }
        public SupplierUpsertModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> OnGet(string? id)
        {
            SupplierObject = new Supplier();
            if (id != new Guid().ToString()) // edit mode 
            {
                SupplierObject = await _unitOfWork.Suppliers.GetAsync(x => x.SupplierId.ToString() == id);
            }
            if (SupplierObject == null)
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
            if (SupplierObject.SupplierId == new Guid())
            {
                _unitOfWork.Suppliers.Add(SupplierObject);

            }
            else
            {
                _unitOfWork.Suppliers.Update(SupplierObject);
            }

            await _unitOfWork.CommitAsync();
            return RedirectToPage("./Calendar");
        }
    }
}
