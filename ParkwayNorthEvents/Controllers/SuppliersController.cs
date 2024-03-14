using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ParkwayNorthEvents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public SuppliersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Json(new { data = _unitOfWork.Suppliers.List() });
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {

            // remove all servicesbooked that has particular booking 
            var supplierToDelete = await _unitOfWork.Suppliers.GetAsync(x => x.SupplierId.ToString() == id);

            if (supplierToDelete is null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            var listOfServicesBooked = _unitOfWork.ServicesBooked.List();
            if (listOfServicesBooked.Any(x => x.SupplierId == supplierToDelete.SupplierId.ToString()))
            {
                listOfServicesBooked = listOfServicesBooked.Where(x => x.SupplierId == supplierToDelete.SupplierId.ToString()).ToList();
                foreach (var serviceBooked in listOfServicesBooked)
                {
                    _unitOfWork.ServicesBooked.Delete(serviceBooked);
                }
                await _unitOfWork.CommitAsync();
            }
            _unitOfWork.Suppliers.Delete(supplierToDelete);
            await _unitOfWork.CommitAsync();
            return Json(new { success = true, message = " Delete Successful" });
        }
    }
}
