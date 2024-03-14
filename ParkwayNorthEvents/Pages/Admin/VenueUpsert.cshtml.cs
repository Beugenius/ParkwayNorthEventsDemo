using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ParkwayNorthEvents.Pages.Admin
{
    public class VenueUpsertModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        [BindProperty]
        public Venue VenueObject { get; set; }  
        public VenueUpsertModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork= unitOfWork;
        }
        public async Task<IActionResult> OnGet(string? id) 
        {
            VenueObject = new Venue();
            if (id != new Guid().ToString()) // edit mode 
            {
                VenueObject = await _unitOfWork.Venues.GetAsync(x => x.VenueId.ToString() == id);
            }
            if (VenueObject == null)
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
            if (VenueObject.VenueId == new Guid())
            {
                _unitOfWork.Venues.Add(VenueObject);

            }
            else
            {
                _unitOfWork.Venues.Update(VenueObject);
            }

            await _unitOfWork.CommitAsync();
            return RedirectToPage("./Calendar");
        }
    }
}
