using kliniek.Data;
using kliniek.Models;
using Microsoft.VisualBasic.Logging;
using System.Data;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace kliniek.Forms
{
    public partial class PatientForm : Form
    {

        public PatientForm()
        {
            InitializeComponent();
            //load patient data

            //remove the appointment passed
            //Program.SharedData.appointments.RemoveAll(app => app.date < DateTime.Now);
        }



        private void PatientForm_Load(object sender, EventArgs e)
        {

            timer2.Start();
            label1.Text = Program.SharedData.LoggedInPatient?.fullname;
            radioButton1.Checked = true;
            label2.Text = DateTime.Now.ToString("d");

            dateTimePicker1.MinDate = DateTime.Today;
            comboBox3.DataSource = Program.SharedData.time;
            DateTime now = DateTime.Now;
            if (now.Hour >= 17)
            {
                now = now.Date.AddDays(1);
            }
            dateTimePicker1.MinDate = now;
            dateTimePicker1.Value = now;
        }

        //main menu
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            label20.Text = "الرئيسية\r\n";
            //the date label
            label2.Visible = true;
            LoadAppointments();

            panel10.Visible = true;
            panel4.Visible = false;
            panelPatientPresc.Visible = false;
            panelRating.Visible = false;
        }



        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortDateString();
        }


        //loading the appointment in the main menu
        private void LoadAppointments()
        {

            var data = Program.SharedData;

            //loading the current user's appointment only
            var myAppointments = data.appointments.Where(a =>
                a.patientusername == data.LoggedInPatient?.username
            ).ToList();

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = true;
            flowLayoutPanel1.AutoScroll = true;
            //displaing the app
            foreach (var a in myAppointments)
            {

                var doctor = data.doctor.FirstOrDefault(d => d.username == a.doctorusername);

                Panel card = new Panel
                {
                    Width = 300,
                    Height = 140,
                    BackColor = Color.FromArgb(42, 42, 62),
                    Margin = new Padding(10)
                };

                Label lblDoctor = new Label
                {
                    Text = "👨‍⚕️ " + (doctor?.fullname ?? "غير معروف"),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(10, 10)
                };

                Label lblDate = new Label
                {
                    Text = $"📅 {a.date:yyyy-MM-dd hh:mm tt}",
                    ForeColor = Color.FromArgb(160, 160, 160),
                    Font = new Font("Segoe UI", 9),
                    AutoSize = true,
                    Location = new Point(10, 40)
                };



                Button btnDelete = new()
                {
                    Text = "إلغاء",
                    Width = 150,
                    Height = 35,
                    Location = new Point(10, 100),
                    BackColor = Color.FromArgb(74, 26, 26),
                    ForeColor = Color.FromArgb(255, 107, 107),
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 9)
                };
                btnDelete.FlatAppearance.BorderSize = 0;

                var appointment = a;

                btnDelete.Click += async (s, e) =>
                {
                    var result = MessageBox.Show("هل تريد إلغاء الموعد؟", "تأكيد", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        await data.DeleteApp(a.id);
                        data.appointments.Remove(appointment);
                        LoadAppointments();
                    }
                };

                card.Controls.AddRange(new Control[] { lblDoctor, lblDate, btnDelete });
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        // the reservation tab 
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel10.Visible = false;
            comboBox1.DataSource = Program.SharedData.specializations;
            panelPatientPresc.Visible = false;
            panelRating.Visible = false;
        }





        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        bool logOFP;
        //logout button 
        private void button1_Click(object sender, EventArgs e)
        {

            Program.SharedData.LoggedInPatient = null;
            logOFP = true;
            new LoginForm().Show();
            this.Close();

        }


        //deleting the account button
        private async void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("هل تريد مسح الحساب ؟", "تأكيد", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                var currentUser = Program.SharedData.LoggedInPatient;
                Program.SharedData.appointments.RemoveAll(a => a.patientusername == currentUser?.username);
                Program.SharedData.patient.RemoveAll(p => p.username == currentUser?.username);
                await Program.SharedData.DeletePatient(currentUser?.username ?? "");
                Program.SharedData.LoggedInPatient = null;
                MessageBox.Show("تم حذف الحساب بنجاح");

                logOFP = true;
                new LoginForm().Show();
                if (logOFP) this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            string selected = comboBox1.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrEmpty(selected) || selected == "اختر التخصص...")
            {
                comboBox2.DataSource = null;
                return;
            }

            var doctorsList = Program.SharedData.doctor
                .Where(d => d.specialization == selected)
                .ToList();
            doctorsList.Insert(0, new Doctor("none", "none", "اختر اسم الدكتور", "none"));


            comboBox2.DataSource = doctorsList;
            comboBox2.DisplayMember = "fullname";
            comboBox2.ValueMember = "username";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void Ok_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem == null || comboBox3.SelectedItem?.ToString() == "اختر الوقت ...")
            {
                MessageBox.Show("من فضلك اختر الوقت");
                return;
            }
            DateTime selectedDateTime = dateTimePicker1.Value.Date.Add(DateTime.Parse(comboBox3.SelectedItem?.ToString() ?? "").TimeOfDay);
            if (selectedDateTime < DateTime.Now)
            {
                MessageBox.Show("من فضلك اختر توقيت صحيح");
                return;

            }

            if (comboBox2.SelectedIndex == 0 || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("من فضلك اختر الدكتور");
                return;
            }
            string doctorUserName = comboBox2.SelectedValue?.ToString() ?? "";

            bool alreadyBooked = Program.SharedData.appointments.Any(u =>
                u.doctorusername == doctorUserName &&
                u.date.Date == selectedDateTime.Date &&
                u.date.TimeOfDay.TotalMinutes == selectedDateTime.TimeOfDay.TotalMinutes
            );

            if (alreadyBooked)
            {
                MessageBox.Show("هذا الموعد محجوز بالفعل ❌");
                return;
            }

            string specialization = comboBox1.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrEmpty(specialization) || specialization == "اختر التخصص...")
            {
                MessageBox.Show("من فضلك اختر التخصص");
                return;
            }

            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("من فضلك اختر الدكتور");
                return;
            }
            else if (comboBox2.SelectedIndex == 0)
            {
                MessageBox.Show("من فضلك اختر الدكتور");
                return;
            }


            //creating the appointment
            Appointment newApp = new(
                doctorUserName,
                Program.SharedData.LoggedInPatient?.username ?? "",
                selectedDateTime
            );
            //saving 
            Program.SharedData.appointments.Add(newApp);
            await Program.SharedData.SaveAppointment(newApp);

            MessageBox.Show("تم الحجز بنجاح 🎉");



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = comboBox2.SelectedItem as Doctor;

            if (selected == null || selected.username == "none")
            {
                lblDoctorInfo.Visible = false;
                return;
            }

            string ratingText = selected.Number == 0
                ? "لا يوجد تقييم بعد"
                : $"💎 {selected.Rating:F1} / 10";

            string descText = string.IsNullOrWhiteSpace(selected.Description)
                ? "لا يوجد وصف"
                : selected.Description;

            lblDoctorInfo.Text = $"{ratingText}\n{descText}";
            lblDoctorInfo.Visible = true;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PatientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (logOFP) this.Hide();
            else Application.Exit();
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            panel10.Visible = false;
            panel4.Visible = false;
            panelPatientPresc.Visible = true;
            LoadPatientPrescriptions();
        }
        private void LoadPatientPrescriptions()
        {
            flowPrescriptions.Controls.Clear();
            var data = Program.SharedData;

            var myPrescriptions = data.prescriptions
                .Where(p => p.patientusername == data.LoggedInPatient?.username)
                .OrderByDescending(p => p.date)
                .ToList();

            if (myPrescriptions.Count == 0)
            {
                flowPrescriptions.Controls.Add(new Label
                {
                    Text = "لا توجد روشتات بعد",
                    ForeColor = Color.Gray,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    AutoSize = true,
                    Margin = new Padding(20)
                });
                return;
            }

            foreach (var presc in myPrescriptions)
            {
                var doctor = data.doctor.FirstOrDefault(d => d.username == presc.doctorusername);

                Panel card = new()
                {
                    Width = 300,
                    Height = 175,
                    BackColor = Color.FromArgb(21, 32, 43),
                    Margin = new Padding(10)
                };

                Label lblDoctor = new()
                {
                    Text = "👨‍⚕️ د. " + (doctor?.fullname ?? "غير معروف"),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(12, 10)
                };

                Label lblSpec = new()
                {
                    Text = doctor?.specialization ?? "",
                    ForeColor = Color.FromArgb(100, 160, 220),
                    Font = new Font("Segoe UI", 9),
                    AutoSize = true,
                    Location = new Point(12, 33)
                };

                Label lblDate = new()
                {
                    Text = "📅 " + presc.date.ToString("dd/MM/yyyy"),
                    ForeColor = Color.FromArgb(148, 163, 184),
                    Font = new Font("Segoe UI", 9),
                    AutoSize = true,
                    Location = new Point(12, 55)
                };

                Label lblDiag = new()
                {
                    Text = "🔍 " + (presc.diagnosis.Length > 35
                                  ? presc.diagnosis[..35] + "..."
                                  : presc.diagnosis),
                    ForeColor = Color.FromArgb(200, 200, 200),
                    Font = new Font("Segoe UI", 9),
                    AutoSize = true,
                    Location = new Point(12, 78)
                };

                Label lblMeds = new()
                {
                    Text = "💊 " + (presc.medications.Length > 35
                                  ? presc.medications[..35] + "..."
                                  : presc.medications),
                    ForeColor = Color.FromArgb(106, 191, 106),
                    Font = new Font("Segoe UI", 9),
                    AutoSize = true,
                    Location = new Point(12, 100)
                };

                Button btnView = new()
                {
                    Text = "عرض",
                    Width = 120,
                    Height = 32,
                    Location = new Point(12, 130),
                    BackColor = Color.FromArgb(24, 95, 165),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 9)
                };
                btnView.FlatAppearance.BorderSize = 0;

                var currentPresc = presc;
                btnView.Click += (s, e) =>
                {
                    new PrescriptionForm(currentPresc).ShowDialog();
                };

                card.Controls.AddRange([lblDoctor, lblSpec, lblDate, lblDiag, lblMeds, btnView]);
                flowPrescriptions.Controls.Add(card);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxRatingDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numRating_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            panel10.Visible = false;
            panel4.Visible = false;
            panelPatientPresc.Visible = false;
            panelRating.Visible = true;

            // جيب الدكاترة اللي المريض عنده مواعيد معاهم بس
            var data = Program.SharedData;
            var myDoctors = data.doctor
                .Where(d => data.appointments.Any(a =>
                    a.patientusername == data.LoggedInPatient?.username &&
                    a.doctorusername == d.username))
                .ToList();

            comboBoxRatingDoctors.DataSource = myDoctors;
            comboBoxRatingDoctors.DisplayMember = "fullname";
            comboBoxRatingDoctors.ValueMember = "username";
        }

        private async void btnSubmitRating_Click(object sender, EventArgs e)
        {
            var selected = comboBoxRatingDoctors.SelectedItem as Doctor;

            if (selected == null)
            {
                MessageBox.Show("من فضلك اختر دكتور");
                return;
            }

            float score = (float)numRating.Value;

            var result = MessageBox.Show(
                $"هتقيم د. {selected.fullname} بـ {score} من 10 ؟",
                "تأكيد",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                await Program.SharedData.UpdateDoctorRating(selected.username, score);
                MessageBox.Show("تم التقييم بنجاح ⭐");
            }
        }

        private void panelRating_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}





