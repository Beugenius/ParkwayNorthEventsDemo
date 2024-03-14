using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ParkwayNorthEvents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultationDatesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ConsultationDatesController(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;

        [HttpGet]
        public IActionResult Get()
        {
            var bookings = _unitOfWork.Bookings.List();
            List<object> datesOfEvents = new();
            foreach (var booking in bookings)
            {
                datesOfEvents.Add(new
                {
                    date = booking.DateOfEvent.ToString("yyyy-MM-dd").Replace("/", "-")
                });

            }
            var eventsArray = datesOfEvents.ToArray();
            return Json(eventsArray);
        }
    }
}
