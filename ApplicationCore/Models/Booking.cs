using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class Booking
    {
        [Key]
        public Guid BookingId { get; set; }
        public BookingType Type { get; set; }
        public Decimal Balance { get; set; } 
        [Required]
        public string EventTitle { get; set; }
        [Display(Name = "Booking Status")]
        public string BookingStatus { get; set; }
        [Required]
        [Display(Name = "Description of Event")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Date of Event")]
        public DateTime DateOfEvent { get; set; }
        // TODO -- make foreign key 
        public string ClientId { get; set; }
        public string ClientName { get; set; }
    }

    public enum BookingType
    {
        DayOfWeddingCoordination,
        HourlyConsulting, 
        ProposalAssistance,
        Other,
        DIY
    }
}
