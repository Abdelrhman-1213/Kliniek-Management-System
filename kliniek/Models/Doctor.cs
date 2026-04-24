using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kliniek.Models
{
    public class Doctor(string userName, string password, string fullName, string specialization) : Person(userName, password, fullName)
    {
        public string specialization { get; set; } = specialization;
        public float Rating { get; set; } = 0;
        public int Number { get; set; } = 0;
        public string Description { get; set; } = "";
    }
}
