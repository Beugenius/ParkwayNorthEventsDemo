using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class AuthSenderOptions
    {
        private readonly string user = "ENTER AUTH SENDER USER";
        private readonly string key = "ENTER AUTH KEY";
        public string SendGridUser { get { return user; } }
        public string SendGridKey { get { return key; } }
    }
}
