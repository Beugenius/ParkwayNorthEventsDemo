using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ParkwayNorthEvents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesBookedController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ServicesBookedController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Json(new { data = _unitOfWork.ServicesBooked.List() });
        }
        [HttpPost("{details}")]
        public async Task<IActionResult> OnPost(string supplierBookedId, string bookingId, string status, string supplierPhoneNumber, string supplierName)
        {
            var selectedBooking = await _unitOfWork.Bookings.GetAsync(x => x.BookingId.ToString() == bookingId);
            if (selectedBooking is not null)
            {
                if (supplierBookedId == new Guid().ToString())
                {
                    // check if supplier already in db 
                    var supplierInDatabase = await _unitOfWork.Suppliers.GetAsync(x => x.SupplierPhoneNumber == supplierPhoneNumber);
                    // if not create a new one 
                    if (supplierInDatabase is null)
                    {
                        supplierInDatabase = new Supplier()
                        {
                            SupplierId = Guid.NewGuid(),
                            SupplierName = supplierName,
                            SupplierPhoneNumber = supplierPhoneNumber

                        };
                        _unitOfWork.Suppliers.Add(supplierInDatabase);
                        await _unitOfWork.CommitAsync();
                    }
                    // create new supplier booked
                    var supplierBooked = new ServicesBooked()
                    {
                        Id = Guid.NewGuid(),
                        BookingId = bookingId,
                        SupplierId = supplierInDatabase.SupplierId.ToString(),
                        ServiceStatus = "New"
                    };
                    _unitOfWork.ServicesBooked.Add(supplierBooked);
                    await _unitOfWork.CommitAsync();
                    return Json(new { success = true, message = "Added successfully!" });
                }
                else
                {
                    var bookedSupplier = await _unitOfWork.ServicesBooked.GetAsync(x => x.Id.ToString() == supplierBookedId);
                    if (bookedSupplier is not null)
                    {
                        var supplierInDatabase = await _unitOfWork.Suppliers.GetAsync(x => x.SupplierId.ToString() == bookedSupplier.SupplierId);
                        if (supplierInDatabase is not null)
                        {
                            supplierInDatabase.SupplierPhoneNumber = supplierPhoneNumber;
                            supplierInDatabase.SupplierName = supplierName;
                            // TODO - venue status update 
                            _unitOfWork.Suppliers.Update(supplierInDatabase);
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
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {

            // remove all servicesbooked that has particular booking 
            var serviceBookedToDelete = await _unitOfWork.ServicesBooked.GetAsync(x => x.Id.ToString() == id);

            if (serviceBookedToDelete is null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.ServicesBooked.Delete(serviceBookedToDelete);
            await _unitOfWork.CommitAsync();
            return Json(new { success = true, message = " Delete Successful" });
        }
    }
}
