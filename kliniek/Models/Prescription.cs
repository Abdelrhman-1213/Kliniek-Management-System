namespace kliniek.Models
{
    public class Prescription(string doctorusername, string patientusername, string diagnosis, string medications, string notes = "")
    {
        public int id { get; set; }
        public string doctorusername { get; set; } = doctorusername;
        public string patientusername { get; set; } = patientusername;
        public string diagnosis { get; set; } = diagnosis;
        public string medications { get; set; } = medications;
        public string notes { get; set; } = notes;
        public DateTime date { get; set; } = DateTime.Now;
    }
}
