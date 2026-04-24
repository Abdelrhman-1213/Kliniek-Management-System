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


            // getting the name of current doctor
            label1.Text = $"د. {Program.SharedData.LogedInDoc?.fullname}";
            label2.Text = Program.SharedData.LogedInDoc?.specialization;
            panel1.Dock = DockStyle.Left;

            //the current date label 
            label4.Text = DateTime.Now.ToString("d");

            //getting the number of the all the patient of the doctor
            int myPatientsCount = Program.SharedData.patient.Count(p =>
                Program.SharedData.appointments.Any(a =>
                    a.doctorusername == Program.SharedData.LogedInDoc?.username &&
                    a.patientusername == p.username
                )
            );

            //getting the number of the today appointments
            int todayAppts = Program.SharedData.appointments.Count(a =>
                a.doctorusername == Program.SharedData.LogedInDoc?.username &&
                a.date.Date == DateTime.Today
            );


            //the prescriptions of the week
            int weekPresc = Program.SharedData.prescriptions.Count(p =>
                p.doctorusername == Program.SharedData.LogedInDoc?.username &&
                p.date >= DateTime.Today.AddDays(-7)
            );


            lblPatientsCount.Text = myPatientsCount.ToString();
            lblTodayAppts.Text = todayAppts.ToString();
            lblWeekPresc.Text = weekPresc.ToString();




            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            LoadTodayAppointments();

            var doc = Program.SharedData.LogedInDoc;

            if (doc != null)
            {
                if (doc.Number == 0)
                    lblRatingDisplay.Text = "⭐ لا يوجد تقييم بعد";
                else
                    lblRatingDisplay.Text = $"⭐ {doc.Rating:F1} / 10  ({doc.Number} تقييم)";
            }
        }




        //bool for logout
        bool logO;
        //logout button
        private void Button1_Click(object sender, EventArgs e)
        {
            logO = true;
            Program.SharedData.LogedInDoc = null;
            new LoginForm().Show();
            this.Close();
        }

        private void DoctorForm_SizeChanged(object sender, EventArgs e)
        {
            panel1.Height = this.Height;
        }


        //making a card in the flow panel foreach patient that have an appointment today
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
                    Height = 80,
                    BackColor = Color.FromArgb(38, 48, 68)
                };

                Label lblName = new()
                {
                    Text = "👤 " + (patient?.fullname ?? "غير معروف"),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(10, 0)
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
                Button del_app = new()
                {
                    Text = "الغاء",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 9),
                    BackColor = Color.FromArgb(24, 95, 165),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Location = new Point(1350, 20)
                };
                card.Controls.AddRange([lblName, lblTime, lblStatus, del_app]);
                flowLayoutPanel2.Controls.Add(card);
            }
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        //search text box
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



        //loading the searched patient
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
                    Height = 132,
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
                    Height = 40,
                    Location = new Point(10, 90),
                    BackColor = Color.FromArgb(24, 95, 165),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 9)
                };
                btnView.FlatAppearance.BorderSize = 0;

                btnView.Click += (s, e) =>
                {
                    new PatientDetailsForm(p).ShowDialog();
                };





                Button btnAddPrec = new()
                {
                    Text = "كتابه روشته",
                    Width = 80,
                    Height = 40,
                    Location = new Point(130, 90),
                    BackColor = Color.FromArgb(24, 95, 165),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 9)
                };

                btnAddPrec.Click += async (s, e) =>
                {
                    var form = new PrescriptionForm(p);
                    form.ShowDialog();


                };
                card.Controls.AddRange([lblName, lblInfo, btnView, btnAddPrec]);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        // patients menu
        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panelPrescriptions.Visible = false;
            panel10.Visible = true;
            LoadPatients();
        }

        // main menu 
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

            panel4.Visible = true;
            panel10.Visible = false;
            panelPrescriptions.Visible = false;


        }


        //Prescriptions menu
        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel10.Visible = false;
            panelPrescriptions.Visible = true;
            LoadPrescriptions();
        }

        private void LoadPrescriptions()
        {
            flowLayoutPanelPrescriptions.Controls.Clear();
            Data.DataStore data = Program.SharedData;
            var myPrescriptions = data.prescriptions
                .Where(p => p.doctorusername == data.LogedInDoc?.username)
                .OrderByDescending(p => p.date)
                .ToList();

            if (myPrescriptions.Count == 0)
            {
                Label lblEmpty = new()
                {
                    Text = "لا توجد روشتات بعد",
                    ForeColor = Color.Gray,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    AutoSize = true,
                    Margin = new Padding(20)
                };
                flowLayoutPanelPrescriptions.Controls.Add(lblEmpty);
                return;
            }

            foreach (var presc in myPrescriptions)
            {
                var patient = data.patient.FirstOrDefault(p => p.username == presc.patientusername);

                Panel card = new()
                {
                    Width = flowLayoutPanelPrescriptions.Width - 40,
                    Height = 120,
                    BackColor = Color.FromArgb(21, 32, 43),
                    Margin = new Padding(10, 5, 10, 5),
                    Padding = new Padding(15)
                };

                Label lblName = new()
                {
                    Text = "👤 " + (patient?.fullname ?? "غير معروف"),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(15, 10)
                };

                Label lblDate = new()
                {
                    Text = presc.date.ToString("dd/MM/yyyy hh:mm tt"),
                    ForeColor = Color.FromArgb(148, 163, 184),
                    Font = new Font("Segoe UI", 9),
                    AutoSize = true,
                    Location = new Point(15, 38)
                };

                Label lblDiag = new()
                {
                    Text = "التشخيص: " + (presc.diagnosis.Length > 60 ? presc.diagnosis[..60] + "..." : presc.diagnosis),
                    ForeColor = Color.FromArgb(200, 200, 200),
                    Font = new Font("Segoe UI", 9),
                    AutoSize = true,
                    Location = new Point(15, 62)
                };

                Label lblMeds = new()
                {
                    Text = "الأدوية: " + (presc.medications.Length > 60 ? presc.medications[..60] + "..." : presc.medications),
                    ForeColor = Color.FromArgb(106, 191, 106),
                    Font = new Font("Segoe UI", 9),
                    AutoSize = true,
                    Location = new Point(15, 86)
                };

                card.Controls.AddRange([lblName, lblDate, lblDiag, lblMeds]);
                flowLayoutPanelPrescriptions.Controls.Add(card);
            }
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
