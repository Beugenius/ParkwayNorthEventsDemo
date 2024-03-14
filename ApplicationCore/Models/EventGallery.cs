using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class EventGallery
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [Display(Name = "Name of Event")]
        public string NameOfEvent { get; set; }
        public int DisplayOrder { get; set; } = 0;
        [Required]
        public string DisplayImage { get; set; }
    }
}
