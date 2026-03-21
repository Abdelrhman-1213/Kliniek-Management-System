using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kliniek.Models
{
    public class Appointment
    {
        public string DoctorUserName { get; set; }
        public string PatientUserName { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }

        public Appointment(string doctorUserName, string patientUserName, DateTime date, string status)
        {
            DoctorUserName = doctorUserName;
            PatientUserName = patientUserName;
            Date = date;
            Status = status;
        }
    }
}
