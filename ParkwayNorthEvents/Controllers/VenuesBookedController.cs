using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace ParkwayNorthEvents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VenuesBookedController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public VenuesBookedController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpPost("{details}")]
        public async Task<IActionResult> OnPost(string venueBookedId, string bookingId, string status, string venuePhoneNumber, string venueName)
        {
            var selectedBooking = await _unitOfWork.Bookings.GetAsync(x => x.BookingId.ToString() == bookingId);
            if (selectedBooking is not null)
            {
                if (venueBookedId == new Guid().ToString())
                {
                    // check if venue already in db 
                    var venueInDatabase = await _unitOfWork.Venues.GetAsync(x => x.VenuePhoneNumber == venuePhoneNumber);
                    // if not create a new one 
                    if (venueInDatabase is null)
                    {
                        venueInDatabase = new Venue()
                        {
                            VenueId = Guid.NewGuid(),
                            VenueName = venueName,
                            VenuePhoneNumber = venuePhoneNumber

                        };
                        _unitOfWork.Venues.Add(venueInDatabase);
                        await _unitOfWork.CommitAsync();
                    }
                    // create new venue booked
                    var venueBooked = new VenuesBooked()
                    {
                        Id = Guid.NewGuid(),
                        BookingId = new Guid(bookingId),
                        Status = VenueStatus.Unconfirmed,
                        VenueId = venueInDatabase.VenueId
                    };
                    _unitOfWork.VenuesBooked.Add(venueBooked);
                    await _unitOfWork.CommitAsync();
                    return Json(new { success = true, message = "Added successfully!" });
                }
                else
                {
                    var bookedVenue = await _unitOfWork.VenuesBooked.GetAsync(x => x.Id.ToString() == venueBookedId);
                    if (bookedVenue is not null)
                    {
                        var venueInDatabase = await _unitOfWork.Venues.GetAsync(x => x.VenueId == bookedVenue.VenueId);
                        if (venueInDatabase is not null)
                        {
                            venueInDatabase.VenuePhoneNumber = venuePhoneNumber;
                            venueInDatabase.VenueName = venueName;
                            // TODO - venue status update 
                            _unitOfWork.Venues.Update(venueInDatabase);
                            await _unitOfWork.CommitAsync();
                            return Json(new { success = true, message = "Added successfully!" });
                        }
                        else
                        {
                            return Json(new { success = false, message = "Error while deleting" });
                        }
                    }
                    else
                    {
                        return Json(new { success = false, message = "Error while deleting" });
                    }
                }
            }
            else
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
        }
        /// <summary>
        /// This is used to delete a venue from a booking without deleting
        /// the booking itself
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            // remove booked venue, don't delete actual venue
            var bookedVenueToDelete = await _unitOfWork.VenuesBooked.GetAsync(x => x.Id.ToString() == id);

            if (bookedVenueToDelete is null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.VenuesBooked.Delete(bookedVenueToDelete);
            await _unitOfWork.CommitAsync();
            return Json(new { success = true, message = " Delete Successful" });
        }
    }
}
