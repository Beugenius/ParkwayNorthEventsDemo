using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class ServicesBooked
    {
        [Key]
        public Guid Id { get; set; }
        public string SupplierId { get; set; }
        public string BookingId { get; set; }
        [Display(Name = "Status")]
        public string ServiceStatus { get; set; }   
    }
}
