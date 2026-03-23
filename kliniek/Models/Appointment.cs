namespace kliniek.Models
{
    public class Appointment(string doctorUserName, string patientUserName, DateTime date, string status)
    {
        public string doctorusername { get; set; } = doctorUserName;
        public string patientusername { get; set; } = patientUserName;
        public DateTime date { get; set; } = date;
        public string status { get; set; } = status;
    }
}
