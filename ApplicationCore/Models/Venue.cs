using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class Venue
    {
        [Key]
        public Guid VenueId { get; set; }
        [Display(Name = "Venue Name")]
        public string VenueName { get; set; }
        [Display(Name = "Venue Phone Number")]
        public string VenuePhoneNumber { get; set; }
    }
}
