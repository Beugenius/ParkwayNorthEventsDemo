using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ParkwayNorthEvents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserBookingController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserBookingController(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;

        [HttpGet]
        public IActionResult Get()
        {
            var bookings = _unitOfWork.Bookings.List();
            List<object> events = new();
            foreach (var booking in bookings)
            {
                events.Add(new
                {
                    id = booking.BookingId,
                    title = booking.ClientName,
                    start = booking.DateOfEvent,
                    url = $"/Admin/ViewBooking?id={booking.BookingId}"
                });

            }
            var eventsArray = events.ToArray();
            return Json(eventsArray);
        }

        [HttpPost("{details}")]
        public async Task<IActionResult> Post(string id, string title, string description)
        {
            var bookingToEdit = await _unitOfWork.Bookings.GetAsync(x => x.BookingId.ToString() == id);
            if (bookingToEdit is not null)
            {
                bookingToEdit.EventTitle = title;
                bookingToEdit.Description = description;
                _unitOfWork.Bookings.Update(bookingToEdit);
                await _unitOfWork.CommitAsync();
                return Json(new { success = true, message = "Update successful!" });
            }
            return Json(new { success = false, message = "Error while updating" });
        }
    }
}
