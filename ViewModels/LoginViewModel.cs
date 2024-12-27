using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medica.ViewModels
{
    public class LoginViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public bool Authenticate()
        {
            // Example authentication logic
            return Username == "22" && Password == "22";
        }
    }
}
