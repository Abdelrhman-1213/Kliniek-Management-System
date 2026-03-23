using kliniek.Models;
using System.Data;
using System.Threading.Tasks;

namespace kliniek.Forms
{
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {

            Data.DataStore data = Program.SharedData;

            label1.Text = $"د. {data.LogedInDoc?.fullname}";
            label2.Text = data.LogedInDoc?.specialization;
            panel1.Dock = DockStyle.Left;
            label4.Text = DateTime.Now.ToString("d");

            int myPatientsCount = data.patient.Count(p =>
                data.appointments.Any(a =>
                    a.doctorusername == data.LogedInDoc?.username &&
                    a.patientusername == p.username
                )
            );


            int todayAppts = data.appointments.Count(a =>
                a.doctorusername == data.LogedInDoc?.username &&
                a.date.Date == DateTime.Today
            );


            //int weekPresc = 0; // عند إضافة ميزة الروشتة للبرنامج


            lblPatientsCount.Text = myPatientsCount.ToString();
            lblTodayAppts.Text = todayAppts.ToString();
            //lblWeekPresc.Text = weekPresc.ToString(); // عند إضافة ميزة الروشتة للبرنامج

            LoadPatients();
            LoadTodayAppointments();

            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {


        }
        bool logO;
        private void Button1_Click(object sender, EventArgs e)
        {
            logO = true;
            new LoginForm().Show();
            this.Close();
        }

        private void DoctorForm_SizeChanged(object sender, EventArgs e)
        {
            panel1.Height = this.Height;
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Panel9_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadTodayAppointments()
        {
            flowLayoutPanel2.Controls.Clear();
            Data.DataStore data = Program.SharedData;

            var todayAppts = data.appointments
                .Where(a =>
                    a.doctorusername == Program.SharedData.LogedInDoc?.username &&
                    a.date.Date == DateTime.Today)
                .Take(7)
                .ToList();

            foreach (var appt in todayAppts)
            {
                var patient = data.patient
                    .FirstOrDefault(p => p.username == appt.patientusername);

                Panel card = new()
                {
                    Width = flowLayoutPanel2.Width - 40,
                    Margin = new Padding(20, 5, 20, 5),
                    Height = 60,
                    BackColor = Color.FromArgb(38, 48, 68)
                };

                Label lblName = new()
                {
                    Text = "👤 " + (patient?.fullname ?? "غير معروف"),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(10, 8)
                };

                Label lblTime = new()
                {
                    Text = appt.date.ToString("hh:mm tt"),
                    ForeColor = Color.FromArgb(150, 175, 210),
                    Font = new Font("Segoe UI", 9),
                    AutoSize = true,
                    Location = new Point(10, 32)
                };

                Label lblStatus = new()
                {
                    Text = appt.status,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 9),
                    Location = new Point(card.Width - 90, 20)
                };

                if (appt.status == "مؤكد")
                {
                    lblStatus.ForeColor = Color.FromArgb(106, 191, 106);
                    lblStatus.BackColor = Color.FromArgb(26, 61, 26);
                }
                else if (appt.status == "انتظار")
                {
                    lblStatus.ForeColor = Color.FromArgb(220, 180, 50);
                    lblStatus.BackColor = Color.FromArgb(61, 49, 15);
                }
                else
                {
                    lblStatus.ForeColor = Color.FromArgb(255, 107, 107);
                    lblStatus.BackColor = Color.FromArgb(74, 26, 26);
                }

                card.Controls.AddRange([lblName, lblTime, lblStatus]);
                flowLayoutPanel2.Controls.Add(card);
            }
        }
        // زهجججججججججججججججججججججت
        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string search = textBox1.Text.ToLower(); // بياخد الحرف بحرفه
            Data.DataStore data = Program.SharedData;

            var filtered = data.patient.Where(p =>  //  بتبحث
                p.fullname.Contains(search, StringComparison.CurrentCultureIgnoreCase) && // عن الي يحتوي على الكلمات
                data.appointments.Any(a => // any بتشوف الأول هل فيه المريض دا عند الطبيب دا ولا لععع
                    a.doctorusername == data.LogedInDoc?.username &&
                    a.patientusername == p.username)
            ).ToList();

            LoadPatients(filtered);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadPatients(List<Patient>? list = null)
        {
            flowLayoutPanel1.Controls.Clear();
            Data.DataStore data = Program.SharedData;

            // جيب المرضى الخاصين بالدكتور دعع بس
            var myPatients = list ?? [.. data.patient.Where(p =>
                data.appointments.Any(a =>
                    a.doctorusername == Program.SharedData.LogedInDoc?.username &&
                    a.patientusername == p.username
                )
            )];

            foreach (var p in myPatients)
            {
                Panel card = new()
                {
                    Width = 220,
                    Height = 130,
                    BackColor = Color.FromArgb(13, 17, 23),
                    Margin = new Padding(12)
                };

                Label lblName = new()
                {
                    Text = "👤 " + p.fullname,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(10, 12)
                };

                Label lblInfo = new()
                {
                    Text = $"السن: {p.age}   |   {p.bloodtype}",
                    ForeColor = Color.FromArgb(160, 160, 160),
                    Font = new Font("Segoe UI", 9),
                    AutoSize = true,
                    Location = new Point(10, 40)
                };

                Button btnView = new()
                {
                    Text = "عرض",
                    Width = 80,
                    Height = 28,
                    Location = new Point(10, 85),
                    BackColor = Color.FromArgb(24, 95, 165),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 9)
                };
                btnView.FlatAppearance.BorderSize = 0;

                //Button btnDelete = new()
                //{
                //    Text = "حذف",
                //    Width = 80,
                //    Height = 28,
                //    Location = new Point(100, 85),
                //    BackColor = Color.FromArgb(74, 26, 26),
                //    ForeColor = Color.FromArgb(255, 107, 107),
                //    FlatStyle = FlatStyle.Flat,
                //    Font = new Font("Segoe UI", 9)
                //};
                //btnDelete.FlatAppearance.BorderSize = 0;
                var patient = p;
                //btnDelete.Click += async (s, e) =>
                //{
                //    data.patient.Remove(patient);
                //    await data.DeleteApp();
                //    LoadPatients();
                //};
                btnView.Click += (s, e) =>
                {
                    new PatientDetailsForm(patient).ShowDialog();
                };

                card.Controls.AddRange([lblName, lblInfo, btnView]);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel10.Visible = true;
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel10.Visible = false;
        }

        private void DoctorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (logO) this.Hide();
            else Application.Exit();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("هل أنت متأكد من حذف الحساب؟", "تأكيد", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (Program.SharedData.LogedInDoc != null)
                {
                    await Program.SharedData.DeleteDoctor(Program.SharedData.LogedInDoc.username);
                    Program.SharedData.doctor.Remove(Program.SharedData.LogedInDoc);
                    logO = true;
                    new LoginForm().Show();
                    if (logO) this.Close();
                }
            }
        }
    }
}
