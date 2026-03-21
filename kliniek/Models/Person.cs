using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kliniek.Models
{
    public class Person(string userName, string password, string fullName)
    {
        public string UserName { get; set; } = userName;
        public string Password { get; set; } = password;
        public string FullName { get; set; } = fullName;
    }
}
