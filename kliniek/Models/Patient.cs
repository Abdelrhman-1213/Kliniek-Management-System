using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kliniek.Data;
namespace kliniek.Models
{
    

    
    public class Patient(string userName, string password, string fullName, string bloodtybe, int age, string gender) : Person(userName, password, fullName)
    {
        public string bloodtype { get; set; } = bloodtybe;
        public string gender { get; set; } = gender;
        public int age { get; set; } = age;
    }
}
