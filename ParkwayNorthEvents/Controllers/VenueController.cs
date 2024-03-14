using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ParkwayNorthEvents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VenueController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public VenueController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Json(new { data = _unitOfWork.Venues.List() });
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {

            // remove all venues that has particular booking 
            var venueToDelete = await _unitOfWork.Venues.GetAsync(x => x.VenueId.ToString() == id);

            if (venueToDelete is null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            var listOfVenuesBooked = await _unitOfWork.VenuesBooked.ListAsync(x => x.VenueId == venueToDelete.VenueId);
            // if any bookings have this venue, remove the vendor from the booking 
            if (listOfVenuesBooked.Any())
            {
                foreach (var venueBooked in listOfVenuesBooked)
                {
                    _unitOfWork.VenuesBooked.Delete(venueBooked);
                    await _unitOfWork.CommitAsync();
                }
            }
            // delete the venue 
            _unitOfWork.Venues.Delete(venueToDelete);
            await _unitOfWork.CommitAsync();
            return Json(new { success = true, message = " Delete Successful" });
        }
    }
}
