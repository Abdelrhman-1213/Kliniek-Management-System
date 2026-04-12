using kliniek.Models;
using Newtonsoft.Json;
using System.Text;

namespace kliniek.Data
{
    public class DataStore
    {
        public Doctor? LogedInDoc = null;
        public Patient? LoggedInPatient = null;
        
        public const string SecretCode = "#3107ML";
        public List<Patient> patient = [];
        public List<Doctor> doctor = [];
        public List<Appointment> appointments = [];
        public List<Prescription> prescriptions = [];

        public List<string> bloodtybe =
        [
            "اختر فصيلة الدم...",
            "A+","A-","B+","B-","AB+","AB-","O+","O-"
        ];

        public List<string> specializations = [

            "اختر التخصص...", // هتجاهلها يا دكتور في الكود
            "طب الباطنة","طب الأطفال",
            "أمراض القلب","الجراحة العامة",
            "طب العظام","الجلدية والتجميل",
            "النساء والتوليد","طب العيون",
            "أنف وأذن وحنجرة","المخ والأعصاب",
            "الطب النفسي", "المسالك البولية",
        ];
      

        public List<string> time = [

         "اختر الوقت ...", // نص إرشادي في البداية
            "09:00 AM",
            "11:00 AM",
            "01:00 PM",
            "3:00 PM",
            "05:00 PM"
        ];

        /*
        public void Save()
        {
            try
            {
                var obj = new { Patients = patient, Doctors = doctor, Appointments = appointments};
                string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
                File.WriteAllText("data.json", json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في الحفظ: {ex.Message}");
            }
        }
        public void Load()
        {
            try
            {
                if (!File.Exists("data.json")) return;
                string json = File.ReadAllText("data.json");
                var obj = JsonConvert.DeserializeObject<SaveData>(json);
                if (obj == null) return;
                if (obj.Patients != null) patient = obj.Patients;
                if (obj.Doctors != null) doctor = obj.Doctors;
                if (obj.Appointments != null) appointments = obj.Appointments;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في التحميل: {ex.Message}");
            }
        }*/


        private static readonly HttpClient client = new();
        public DataStore()
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("apikey", SupabaseConfig.Key);
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {SupabaseConfig.Key}");
        }
        // ==================
        // التحمييييييييييييل
        // ==================
        public async Task Load()
        {
            try
            {
                
                var patientsJson = await client.GetStringAsync(
                    $"{SupabaseConfig.Url}/rest/v1/patients?select=*"
                );
                patient = JsonConvert.DeserializeObject<List<Patient>>(patientsJson) ?? [];

                
                var doctorsJson = await client.GetStringAsync(
                    $"{SupabaseConfig.Url}/rest/v1/doctors?select=*"
                );
                doctor = JsonConvert.DeserializeObject<List<Doctor>>(doctorsJson) ?? [];

               
                var apptsJson = await client.GetStringAsync(
                    $"{SupabaseConfig.Url}/rest/v1/appointments?select=*"
                );
                appointments = JsonConvert.DeserializeObject<List<Appointment>>(apptsJson) ?? [];

                var prescJson = await client.GetStringAsync(
                    $"{SupabaseConfig.Url}/rest/v1/prescriptions?select=*"
                );
                prescriptions = JsonConvert.DeserializeObject<List<Prescription>>(prescJson) ?? [];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في التحميل: {ex.Message}");
            }
        }
        // ==================
        // الحففففففففففففففظ
        // ==================
        public async Task SavePatient(Patient p)
        {
            var request = new HttpRequestMessage(HttpMethod.Post,
                $"{SupabaseConfig.Url}/rest/v1/patients");
            request.Headers.Add("Prefer", "resolution=merge-duplicates");
            request.Content = new StringContent(
                JsonConvert.SerializeObject(new List<Patient> { p }),
                Encoding.UTF8, "application/json");
            await client.SendAsync(request);
        }

        public async Task SaveDoctor(Doctor d)
        {
            var request = new HttpRequestMessage(HttpMethod.Post,
                $"{SupabaseConfig.Url}/rest/v1/doctors");
            request.Headers.Add("Prefer", "resolution=merge-duplicates");
            request.Content = new StringContent(
                JsonConvert.SerializeObject(new List<Doctor> { d }),
                Encoding.UTF8, "application/json");
            await client.SendAsync(request);
        }

        public async Task SaveAppointment(Appointment a)
        {
            var request = new HttpRequestMessage(HttpMethod.Post,
       $"{SupabaseConfig.Url}/rest/v1/appointments");

            // مش "resolution=merge-duplicates" عشان دايماً يضيف جديد
            request.Headers.Add("Prefer", "return=minimal");

            var obj = new
            {
                doctorusername = a.doctorusername,
                patientusername = a.patientusername,
                date = a.date,
                status = a.status
            };

            request.Content = new StringContent(
                JsonConvert.SerializeObject(obj),
                Encoding.UTF8, "application/json");
            await client.SendAsync(request);
        }

        public async Task DeleteDoctor(string username)
        {
            try
            {
                await client.DeleteAsync(
                    $"{SupabaseConfig.Url}/rest/v1/appointments?doctorusername=eq.{username}"
                );

                await client.DeleteAsync(
                    $"{SupabaseConfig.Url}/rest/v1/doctors?username=eq.{username}"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في الحذف: {ex.Message}");
            }
        }
        public async Task DeletePatient(string username)
        {
            try
            {
                await client.DeleteAsync(
                    $"{SupabaseConfig.Url}/rest/v1/appointments?patientusername=eq.{username}"
                );

                await client.DeleteAsync(
                    $"{SupabaseConfig.Url}/rest/v1/patients?username=eq.{username}"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في الحذف: {ex.Message}");
            }
        }
        public async Task DeleteApp(int id)
        {
            try
            {
                await client.DeleteAsync(
                    $"{SupabaseConfig.Url}/rest/v1/appointments?id=eq.{id}"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في الحذف: {ex.Message}");
            }
        }

        public async Task SavePrescription(Prescription p)
        {
            var request = new HttpRequestMessage(HttpMethod.Post,
                $"{SupabaseConfig.Url}/rest/v1/prescriptions");
            request.Headers.Add("Prefer", "return=minimal");

            var obj = new
            {
                doctorusername = p.doctorusername,
                patientusername = p.patientusername,
                diagnosis = p.diagnosis,
                medications = p.medications,
                notes = p.notes,
                date = p.date
            };

            request.Content = new StringContent(
                JsonConvert.SerializeObject(obj),
                Encoding.UTF8, "application/json");
            await client.SendAsync(request);
        }

        public async Task DeletePrescription(int id)
        {
            try
            {
                await client.DeleteAsync(
                    $"{SupabaseConfig.Url}/rest/v1/prescriptions?id=eq.{id}"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في الحذف: {ex.Message}");
            }
        }

    }
    public class SaveData
    {
        public List<Patient>? Patients { get; set; }
        public List<Doctor>? Doctors { get; set; }
        public List<Appointment>? Appointments { get; set; }
        public List<Prescription>? Prescriptions { get; set; }
    }
}
