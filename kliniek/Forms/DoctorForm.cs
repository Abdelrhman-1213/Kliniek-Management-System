using kliniek.Models;
using MaterialSkin2DotNet.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            label1.Text = $"د. {data.LogedInDoc.FullName}";
            label2.Text = data.LogedInDoc.Specialization;
            panel1.Dock = DockStyle.Left;
            label4.Text = DateTime.Now.ToString("d");

            int myPatientsCount = data.patient.Count(p =>
                data.appointments.Any(a =>
                    a.DoctorUserName == data.LogedInDoc.UserName &&
                    a.PatientUserName == p.UserName
                )
            );


            int todayAppts = data.appointments.Count(a =>
                a.DoctorUserName == data.LogedInDoc.UserName &&
                a.Date.Date == DateTime.Today
            );


            int weekPresc = 0;


            lblPatientsCount.Text = myPatientsCount.ToString();
            lblTodayAppts.Text = todayAppts.ToString();
            lblWeekPresc.Text = weekPresc.ToString();

            LoadPatients();
            LoadTodayAppointments();

            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }

        private void DoctorForm_SizeChanged(object sender, EventArgs e)
        {
            panel1.Height = this.Height;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadTodayAppointments()
        {
            flowLayoutPanel2.Controls.Clear();
            Data.DataStore data = Program.SharedData;

            var todayAppts = data.appointments
                .Where(a =>
                    a.DoctorUserName == Program.SharedData.LogedInDoc.UserName &&
                    a.Date.Date == DateTime.Today)
                .Take(7)
                .ToList();

            foreach (var appt in todayAppts)
            {
                var patient = data.patient
                    .FirstOrDefault(p => p.UserName == appt.PatientUserName);

                Panel card = new()
                {
                    Width = flowLayoutPanel2.Width - 40,
                    Margin = new Padding(20, 5, 20, 5),
                    Height = 60,
                    BackColor = Color.FromArgb(38, 48, 68)                 
                };

                Label lblName = new()
                {
                    Text = "👤 " + (patient?.FullName ?? "غير معروف"),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(10, 8)
                };

                Label lblTime = new()
                {
                    Text = appt.Date.ToString("hh:mm tt"),
                    ForeColor = Color.FromArgb(150, 175, 210),
                    Font = new Font("Segoe UI", 9),
                    AutoSize = true,
                    Location = new Point(10, 32)
                };

                Label lblStatus = new()
                {
                    Text = appt.Status,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 9),
                    Location = new Point(card.Width - 90, 20)
                };
                
                if (appt.Status == "مؤكد")
                {
                    lblStatus.ForeColor = Color.FromArgb(106, 191, 106);
                    lblStatus.BackColor = Color.FromArgb(26, 61, 26);
                }
                else if (appt.Status == "انتظار")
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
        } // لعرض المواعيد
        // زهجججججججججججججججججججججت
        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Data.DataStore data = Program.SharedData;
            string search = textBox1.Text.ToLower(); // بياخد الكتابة

            var filtered = data.patient.Where(p =>
                p.FullName.ToLower().Contains(search) // بيجيب كل الي يحتوي على الحروف دي
            ).ToList(); // يخزن

            LoadPatients(filtered); // يبعت للعرض
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadPatients(List<Patient> list = null)
        {
            flowLayoutPanel1.Controls.Clear();
            Data.DataStore data = Program.SharedData;

            // جيب المرضى الخاصين بالدكتور ده بس
            var myPatients = data.patient.Where(p =>
                data.appointments.Any(a =>
                    a.DoctorUserName == Program.SharedData.LogedInDoc.UserName &&
                    a.PatientUserName == p.UserName
                )
            )];

            foreach (var p in myPatients)
            {
                Panel card = new Panel
                {
                    Width = 220,
                    Height = 130,
                    BackColor = Color.FromArgb(13, 17, 23),
                    Margin = new Padding(12)
                };

                Label lblName = new Label
                {
                    Text = "👤 " + p.FullName,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(10, 12)
                };

                Label lblInfo = new Label
                {
                    Text = $"السن: {p.Age}   |   {p.BloodType}",
                    ForeColor = Color.FromArgb(160, 160, 160),
                    Font = new Font("Segoe UI", 9),
                    AutoSize = true,
                    Location = new Point(10, 40)
                };

                Button btnView = new Button
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

                Button btnDelete = new Button
                {
                    Text = "حذف",
                    Width = 80,
                    Height = 28,
                    Location = new Point(100, 85),
                    BackColor = Color.FromArgb(74, 26, 26),
                    ForeColor = Color.FromArgb(255, 107, 107),
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 9)
                };
                btnDelete.FlatAppearance.BorderSize = 0;

                // لما تضغط حذف
                var patient = p; // مهم عشان الـ closure
                btnDelete.Click += (s, e) =>
                {
                    data.patient.Remove(patient);
                    data.Save();
                    LoadPatients(); // تحديث الكروت
                };

                card.Controls.AddRange([lblName, lblInfo, btnView, btnDelete]);
                flowLayoutPanel1.Controls.Add(card);
            }
        } // لعرض المرضى 

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel10.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel10.Visible = false;
        }

        private void DoctorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
