using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class Supplier
    {
        [Key]
        public Guid SupplierId { get; set; }
        [Display(Name = "Service Name")]
        public string SupplierName { get; set; }
        [Display(Name = "Service Phone Number")]
        public string SupplierPhoneNumber { get; set; }
    }
}
