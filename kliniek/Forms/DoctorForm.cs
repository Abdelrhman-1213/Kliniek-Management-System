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
            
            label1.Text = $"د. {Program.SharedData.LogedInDoc.FullName}";
            label2.Text = Program.SharedData.LogedInDoc.Specialization;

            panel1.Dock = DockStyle.Left;
            label4.Text = DateTime.Now.ToString("d");

            LoadPatients();

            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;

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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadPatients()
        {
            flowLayoutPanel1.Controls.Clear();
            Data.DataStore data = Program.SharedData;

            var myPatients = data.patient.Where(p =>
                data.appointments.Any(a =>
                    a.DoctorUserName == Program.SharedData.LogedInDoc.UserName &&
                    a.PatientUserName == p.UserName
                )
            ).ToList();

            foreach (var p in myPatients)
            {
            
                Panel card = new Panel
                {
                    Width = 220,
                    Height = 130,
                    BackColor = Color.FromArgb(42, 42, 62),
                    Margin = new Padding(10)
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

                var patient = p; 
                btnDelete.Click += (s, e) =>
                {
                    data.patient.Remove(patient);
                    data.Save();
                    LoadPatients(); 
                };

                card.Controls.AddRange(new Control[] { lblName, lblInfo, btnView, btnDelete });
                flowLayoutPanel1.Controls.Add(card);
            }
        }
    }
}
