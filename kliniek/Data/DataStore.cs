using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kliniek.Models;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;

namespace kliniek.Data
{
    public class DataStore
    {
        public Doctor LogedInDoc = null;
        public Patient LoggedInPatient = null;
        public List<Patient> patient = [];
        public List<Doctor> doctor = [];
        public List<Appointment> appointments = [];
        public List<string> bloodtybe =
        [
            "اختر فصيلة الدم...",
            "A+","A-","B+","B-","AB+","AB-","O+","O-"
        ];

        public List<string> specializations = [
        
            "اختر التخصص...", // نص إرشادي في البداية
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
        public void Save()
        {
            try
            {
                var obj = new { patients = patient, doctors = doctor, appointments = appointments };
                string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
                File.WriteAllText("data.json", json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في الحفظ: {ex.Message}");
            }
        }

        // Load
        public void Load()
        {
            try
            {
                if (!File.Exists("data.json")) return;
                string json = File.ReadAllText("data.json");
                var obj = JsonConvert.DeserializeObject<SaveData>(json);
                if (obj == null) return;
                if (obj.patients != null) patient = obj.patients;
                if (obj.doctors != null) doctor = obj.doctors;
                if (obj.appointments != null) appointments = obj.appointments;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في التحميل: {ex.Message}");
            }
        }

    }
    public class SaveData
    {
        public List<Patient>? patients { get; set; }
        public List<Doctor>? doctors { get; set; }
        public List<Appointment>? appointments { get; set; }
    }
}
