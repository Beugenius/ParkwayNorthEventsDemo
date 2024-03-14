using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class VenuesBooked
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid VenueId { get; set; }
        [Required]
        public Guid BookingId { get; set; }
        [Required]
        public VenueStatus Status { get; set; }
    }

    public enum VenueStatus
    {
        Unconfirmed,
        Confirmed
    }
}
