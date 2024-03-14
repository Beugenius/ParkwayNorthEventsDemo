using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class GalleryImage
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid EventGalleryId { get; set; }
        [Required]
        public string Image { get; set; } = string.Empty;
    }
}
