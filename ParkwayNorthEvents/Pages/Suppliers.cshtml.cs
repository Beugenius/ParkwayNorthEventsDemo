using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ParkwayNorthEvents.Pages
{
    public class SuppliersModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public SuppliersModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public List<Supplier> Suppliers { get; set; }
        public void OnGet()
        {
            Suppliers = _unitOfWork.Suppliers.List().ToList();
        }
    }
}
