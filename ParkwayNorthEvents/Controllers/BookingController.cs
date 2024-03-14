using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace ParkwayNorthEvents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public BookingController(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;

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
        public async Task<IActionResult> Post(string id, string title, string type, string date, string description, string balance, string status)
        {
            try
            {
                var bookingToEdit = await _unitOfWork.Bookings.GetAsync(x => x.BookingId.ToString() == id);
                switch (type)
                {
                    case "0":
                        bookingToEdit.Type = BookingType.DayOfWeddingCoordination;
                        break;
                    case "1":
                        bookingToEdit.Type = BookingType.HourlyConsulting;
                        break;
                    case "2":
                        bookingToEdit.Type = BookingType.ProposalAssistance;
                        break;
                    case "3":
                        bookingToEdit.Type = BookingType.Other;
                        break;
                    case "4":
                        bookingToEdit.Type = BookingType.DIY;
                        break;
                    default:
                        bookingToEdit.Type = BookingType.Other;
                        break;
                }
                var newBalance = Decimal.Parse(balance);
                if (newBalance != bookingToEdit.Balance)
                {
                    if (newBalance > bookingToEdit.Balance)
                    {
                        // create a new transaction
                        Transaction newTrans = new()
                        {
                            TransactionId = Guid.NewGuid(),
                            BookingId = bookingToEdit.BookingId,
                            TransactionAmount = newBalance - bookingToEdit.Balance,
                            TransactionDate = DateTime.Now,
                            StripeTransactionId = "AdminAdjustedNA",
                            Status = "Admin adjusted balance"
                        };
                        _unitOfWork.Transactions.Add(newTrans);
                        await _unitOfWork.CommitAsync();
                    }
                    else
                    {
                        // create a new transaction
                        Transaction newTrans = new()
                        {
                            TransactionId = Guid.NewGuid(),
                            BookingId = bookingToEdit.BookingId,
                            TransactionAmount = bookingToEdit.Balance - newBalance,
                            TransactionDate = DateTime.Now,
                            StripeTransactionId = "AdminAdjustedNA",
                            Status = "Admin adjusted balance"
                        };
                        _unitOfWork.Transactions.Add(newTrans);
                        await _unitOfWork.CommitAsync();
                    }
                }
                bookingToEdit.EventTitle = title;
                bookingToEdit.DateOfEvent = DateTime.Parse(date);
                bookingToEdit.Description = description;
                bookingToEdit.Balance = newBalance;
                bookingToEdit.BookingStatus = status;
                _unitOfWork.Bookings.Update(bookingToEdit);
                await _unitOfWork.CommitAsync();
                if (bookingToEdit is not null)
                {
                    return Json(new { success = true, message = "Update successful!" });
                }
                return Json(new { success = false, message = "Error while updating" });
            }
            catch
            {
                return Json(new { success = false, message = "Error while updating" });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            // Get the booking object and all associated objects in DB
            /*
             Things to delete: 
            The booking itself
            Associated Suppliers (if they exist) 
             */

            var bookingObjToDelete = await _unitOfWork.Bookings.GetAsync(x => x.BookingId.ToString() == id);
            var listOfBookedSuppliers = _unitOfWork.ServicesBooked.List();
            bool hasSuppliers = listOfBookedSuppliers.Any(x => x.BookingId == bookingObjToDelete.BookingId.ToString());

            if (bookingObjToDelete == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            // Remove the booking and associated suppliers 
            if (hasSuppliers) // only attempt to remove booked suppliers if booking has suppliers
            {
                listOfBookedSuppliers = listOfBookedSuppliers.Where(x => x.BookingId == bookingObjToDelete.BookingId.ToString()).Select(x => x).ToList();
                foreach (var vendorBookingToDelete in listOfBookedSuppliers)
                {
                    _unitOfWork.ServicesBooked.Delete(vendorBookingToDelete);
                }
                await _unitOfWork.CommitAsync();
            }

            _unitOfWork.Bookings.Delete(bookingObjToDelete);
            await _unitOfWork.CommitAsync();
            return Json(new { success = true, message = " Delete Successful" });
        }
    }
}
