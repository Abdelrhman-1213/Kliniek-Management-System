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

        Panel panelHistory = new Panel();
        FlowLayoutPanel flowHistory = new FlowLayoutPanel();

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

            int weekPresc = data.prescriptions.Count(p =>
                p.doctorusername == data.LogedInDoc?.username &&
                p.date >= DateTime.Today.AddDays(-7)
            );


            lblPatientsCount.Text = myPatientsCount.ToString();
            lblTodayAppts.Text = todayAppts.ToString();
            lblWeekPresc.Text = weekPresc.ToString();

            LoadPatients();
            LoadTodayAppointments();

            panelHistory.Location = panelPrescriptions.Location;
            panelHistory.Size = panelPrescriptions.Size;
            panelHistory.Anchor = panelPrescriptions.Anchor;
            panelHistory.BackColor = panelPrescriptions.BackColor;
            panelHistory.Visible = false;

          
            flowHistory.Dock = DockStyle.Fill;
            flowHistory.AutoScroll = true;
            flowHistory.Padding = new Padding(10);
            panelHistory.Controls.Add(flowHistory);

           
            if (panelPrescriptions.Parent != null)
            {
                panelPrescriptions.Parent.Controls.Add(panelHistory);
            }
            else
            {
                this.Controls.Add(panelHistory);
            }

            panelHistory.BringToFront();

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
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    Location = new Point(card.Width - 90, 20)
                };

                // --- تحديد اللون حسب الحالة وإضافة زرار التأكيد ---
                if (appt.status == "مؤكد")
                {
                    lblStatus.ForeColor = Color.FromArgb(106, 191, 106);
                    lblStatus.BackColor = Color.FromArgb(26, 61, 26);
                }
                else if (appt.status == "انتظار")
                {
                    lblStatus.ForeColor = Color.FromArgb(220, 180, 50);
                    lblStatus.BackColor = Color.FromArgb(61, 49, 15);

                    // إنشاء زرار التأكيد
                    Button btnConfirm = new()
                    {
                        Text = "تأكيد ✔",
                        Width = 70,
                        Height = 28,
                        Location = new Point(card.Width - 170, 16), // مكانه قبل كلمة انتظار
                        BackColor = Color.FromArgb(24, 95, 165),
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("Segoe UI", 9, FontStyle.Bold),
                        Cursor = Cursors.Hand
                    };
                    btnConfirm.FlatAppearance.BorderSize = 0;

                    // برمجة الزرار: لما الدكتور يدوس عليه يغير الحالة ويعمل ريفريش
                    btnConfirm.Click += (s, e) =>
                    {
                        appt.status = "مؤكد"; // تغيير الحالة
                        LoadTodayAppointments(); // إعادة تحميل القائمة عشان اللون يتحدث
                        if (panelHistory.Visible) LoadHistory(); // لو السجل مفتوح نحدثه كمان
                    };

                    card.Controls.Add(btnConfirm);
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


                Button btnDelete = new()
                {
                    Text = "حذف",
                    Width = 90,
                    Height = 35,
                    Location = new Point(150, 90),
                    BackColor = Color.FromArgb(180, 50, 50),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Padding = new Padding(0)
                };
                btnDelete.FlatAppearance.BorderSize = 0;
                var patient = p;




                btnDelete.Click += async (s, e) =>
                {
                    var confirm = MessageBox.Show("هل أنت متأكد من حذف المريض؟ ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                    
                        data.patient.Remove(patient);                        
                        LoadPatients();
                        MessageBox.Show("تم حذف المريض بنجاح مع الاحتفاظ بسجلاته.");
                    }
                };
                btnView.Click += (s, e) =>
                {
                    new PatientDetailsForm(patient).ShowDialog();
                };

                card.Controls.AddRange([lblName, lblInfo, btnView, btnDelete]);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel10.Visible = true;
            panelPrescriptions.Visible = false;
            panelHistory.Visible = false;
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel10.Visible = false;
            panelPrescriptions.Visible = false;
            panelHistory.Visible = false;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel10.Visible = false;
            panelPrescriptions.Visible = true;
            panelHistory.Visible = false;
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



        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                panel4.Visible = false;
                panel10.Visible = false;
                panelPrescriptions.Visible = false;
                panelHistory.Visible = true;

                panelHistory.BringToFront();
                LoadHistory();

                panel1.BringToFront(); 
            }

        }


        private void LoadHistory()
        {
            flowHistory.Controls.Clear();
            Data.DataStore data = Program.SharedData;

            // 1. تجميع المواعيد والروشتات بنفس الستايل بتاعك
            var appts = data.appointments
                .Where(a => a.doctorusername == data.LogedInDoc?.username)
                .Select(a => new
                {
                    Date = a.date,
                    Type = "موعد " + (a.status == "مؤكد" ? "✅" : (a.status == "انتظار" ? "⏳" : "❌")),
                    PatientUsername = a.patientusername,
                    Details = $"الحالة: {a.status}"
                });

            var prescs = data.prescriptions
                .Where(p => p.doctorusername == data.LogedInDoc?.username)
                .Select(p => new
                {
                    Date = p.date,
                    Type = "روشتة 💊",
                    PatientUsername = p.patientusername,
                    Details = $"التشخيص: {p.diagnosis}"
                });

            // دمج وترتيب (نفس الـ OrderByDescending اللي إنت مستخدمه في الروشتات)
            var fullHistory = appts.Concat(prescs)
                                   .OrderByDescending(x => x.Date)
                                   .ToList();

            if (fullHistory.Count == 0)
            {
                Label lblEmpty = new()
                {
                    Text = "لا توجد سجلات للطبيب حتى الآن",
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 16, FontStyle.Bold),
                    AutoSize = true,
                    Margin = new Padding(30)
                };
                flowHistory.Controls.Add(lblEmpty);
                return;
            }

            foreach (var item in fullHistory)
            {
                // نفس سطر البحث اللي إنت بتستخدمه دايماً
                var patient = data.patient.FirstOrDefault(p => p.username == item.PatientUsername);

                Panel card = new()
                {
                    Width = flowHistory.Width > 50 ? flowHistory.Width - 40 : 600,
                    Height = 100,
                    BackColor = Color.FromArgb(30, 40, 50),
                    Margin = new Padding(10, 5, 10, 5)
                };

                Label lblPatient = new()
                {
                    // هنا التعديل اللي بيجيب اليوزرنيم لو المريض اتمسح
                    Text = "👤 " + (patient?.fullname ?? item.PatientUsername),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(15, 10)
                };

                Label lblType = new()
                {
                    Text = item.Type,
                    ForeColor = item.Type.Contains("موعد") ? Color.FromArgb(150, 175, 210) : Color.FromArgb(106, 191, 106),
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(card.Width - 120, 10)
                };

                Label lblDate = new()
                {
                    Text = item.Date.ToString("dd/MM/yyyy hh:mm tt"),
                    ForeColor = Color.FromArgb(148, 163, 184),
                    Font = new Font("Segoe UI", 9),
                    AutoSize = true,
                    Location = new Point(15, 40)
                };

                Label lblDetails = new()
                {
                    // نفس طريقة قص النص اللي إنت عاملها في الروشتات
                    Text = item.Details.Length > 80 ? item.Details[..80] + "..." : item.Details,
                    ForeColor = Color.FromArgb(200, 200, 200),
                    Font = new Font("Segoe UI", 9),
                    AutoSize = true,
                    Location = new Point(15, 65)
                };

                // نفس طريقة إضافة العناصر اللي إنت بتستخدمها
                card.Controls.AddRange([lblPatient, lblType, lblDate, lblDetails]);
                flowHistory.Controls.Add(card);
            }
        }
    }
}
