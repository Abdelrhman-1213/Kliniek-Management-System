namespace kliniek.Models
{
    public class Appointment(string doctorusername, string patientusername, DateTime date, string status = "انتظار")
    {
        public int id { get; set; } 
        public string doctorusername { get; set; } = doctorusername;
        public string patientusername { get; set; } = patientusername;
        public DateTime date { get; set; } = date;
        public string status { get; set; } = status;
    }

}
