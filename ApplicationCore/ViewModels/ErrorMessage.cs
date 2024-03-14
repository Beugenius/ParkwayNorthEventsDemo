using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ViewModels
{
    public class ErrorMessage
    {
        public string? InvalidPhoneNumber { get; set; } = null;
        public string? InvalidEmail { get; set; } = null;
        public string? EmptyName { get; set; } = null;

    }
}
