using kliniek.Models;
using Newtonsoft.Json;
using System.Text;

namespace kliniek.Data
{
    public class DataStore
    {

        // variables to save the current logged in user
        public Doctor? LogedInDoc = null;
        public Patient? LoggedInPatient = null;


        public const string SecretCode = "#3107ML";//code only the doctors know to prevent the patient  form signing up as a doctor

        //lists of objects
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

            "اختر التخصص...",
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
            "11:00 AM",
            "01:00 PM",
            "03:00 PM",
            "05:00 PM"
        ];



        // Data handling 


        private static readonly HttpClient client = new();//connect to the internet


        public DataStore()
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("apikey", SupabaseConfig.Key);
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {SupabaseConfig.Key}");
        }





        //Loading the data from the database
        public async Task Load()
        {
            try
            {

                //api call -- returns the data in Json format
                var patientsJson = await client.GetStringAsync(
                    $"{SupabaseConfig.Url}/rest/v1/patients?select=*"
                );
                //convert the data to C# format
                patient = JsonConvert.DeserializeObject<List<Patient>>(patientsJson) ?? [];

                var doctorsJson = await client.GetStringAsync(
                    $"{SupabaseConfig.Url}/rest/v1/doctors?select=*"
                );
                doctor = JsonConvert.DeserializeObject<List<Doctor>>(doctorsJson) ?? [];


                var apptsJson = await client.GetStringAsync(
                    $"{SupabaseConfig.Url}/rest/v1/appointments?select=*"
                );
                appointments = JsonConvert.DeserializeObject<List<Appointment>>(apptsJson) ?? [];
                //appointments.RemoveAll(app => app.date < DateTime.Now);
              var expired = appointments.Where(a => a.date < DateTime.Now).ToList();
              appointments.RemoveAll(a => a.date < DateTime.Now);
               foreach (var app in expired)
                await DeleteApp(app.id);


                var prescJson = await client.GetStringAsync(
                    $"{SupabaseConfig.Url}/rest/v1/prescriptions?select=*"
                );
                prescriptions = JsonConvert.DeserializeObject<List<Prescription>>(prescJson) ?? [];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في التحميل\n {ex.Message}");
            }
        }



        //saving new data to the database


        //saving new patients
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


        //saving new Doctors
        public async Task SaveDoctor(Doctor d)
        {

            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post,
                    $"{SupabaseConfig.Url}/rest/v1/doctors");
                request.Headers.Add("Prefer", "return=minimal");

                var obj = new
                {
                    username = d.username,
                    password = d.password,
                    fullname = d.fullname,
                    specialization = d.specialization,
                    Rating = d.Rating,
                    Number = d.Number,
                    description = d.Description
                };

                request.Content = new StringContent(
                    JsonConvert.SerializeObject(obj),
                    Encoding.UTF8, "application/json");

                var response = await client.SendAsync(request);
                var body = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                    MessageBox.Show($"خطأ من Supabase: {body}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ: {ex.Message}");
            }
        }


        //saving new appointments
        public async Task SaveAppointment(Appointment a)
        {
            //sending the data table 
            var request = new HttpRequestMessage(HttpMethod.Post,
       $"{SupabaseConfig.Url}/rest/v1/appointments");
            //prevent crashing if it is duplicated 
            request.Headers.Add("Prefer", "return=minimal");

            var obj = new
            {
                doctorusername = a.doctorusername,
                patientusername = a.patientusername,
                date = a.date,
                status = a.status
            };


            //converting the C# data to json
            request.Content = new StringContent(
                JsonConvert.SerializeObject(obj),
                Encoding.UTF8, "application/json");
            await client.SendAsync(request);
        }

        //saving new prescription
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


        //deleting doctor
        public async Task DeleteDoctor(string username)
        {
            try
            {
                //deleting all the app of the doctor 
                await client.DeleteAsync(
                    $"{SupabaseConfig.Url}/rest/v1/appointments?doctorusername=eq.{username}"
                );
                //deleting all the doctor  
                await client.DeleteAsync(
                    $"{SupabaseConfig.Url}/rest/v1/doctors?username=eq.{username}"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في الحذف: {ex.Message}");
            }
        }


        //deleting patient 
        public async Task DeletePatient(string username)
        {
            try
            {
                await client.DeleteAsync(
                    $"{SupabaseConfig.Url}/rest/v1/appointments?patientusername=eq.{username}"
                );
                await client.DeleteAsync(
                   $"{SupabaseConfig.Url}/rest/v1/prescriptions?patientusername=eq.{username}"
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


        //deleting appointment
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
        public async Task UpdateDoctorRating(string username, float newScore)
        {
            try
            {
                // جيب الدكتور من الليست
                var doctor = this.doctor.FirstOrDefault(d => d.username == username);
                if (doctor == null) return;

                // احسب التقييم الجديد
                doctor.Number += 1;
                doctor.Rating = ((doctor.Rating * (doctor.Number - 1)) + newScore) / doctor.Number;

                // ابعت التحديث لـ Supabase
                var request = new HttpRequestMessage(new HttpMethod("PATCH"),
                    $"{SupabaseConfig.Url}/rest/v1/doctors?username=eq.{username}");
                request.Headers.Add("Prefer", "return=minimal");

                var obj = new { Rating = doctor.Rating, Number = doctor.Number };
                request.Content = new StringContent(
                    JsonConvert.SerializeObject(obj),
                    Encoding.UTF8, "application/json");

                await client.SendAsync(request);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في التقييم: {ex.Message}");
            }
        }
    }
}



//    public class SaveData
//    {
//        public List<Patient>? Patients { get; set; }
//        public List<Doctor>? Doctors { get; set; }
//        public List<Appointment>? Appointments { get; set; }
//        public List<Prescription>? Prescriptions { get; set; }
//    }
//}
