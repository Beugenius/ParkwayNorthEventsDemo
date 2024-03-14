using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class Transaction
    {
        [Key]
        public Guid TransactionId { get; set; }
        public Guid BookingId { get; set; }
        public string StripeTransactionId { get; set; }
        [Required]
        [Display(Name = "Transaction Date")]
        public DateTime TransactionDate { get; set; }
        [Required]
        [Display(Name = "Transaction Amount")]
        public Decimal TransactionAmount { get; set; }
        [Required]
        [Display(Name = "Status")]
        public string Status { get; set; }
    }
}
