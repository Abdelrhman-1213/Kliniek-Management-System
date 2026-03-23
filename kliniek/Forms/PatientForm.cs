using kliniek.Data;
using kliniek.Models;
using MaterialSkin2DotNet.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace kliniek.Forms
{
    public partial class PatientForm : MaterialForm
    {
        private DataStore patient_data;
        public PatientForm(DataStore Data)
        {
            InitializeComponent();
            //load patient data
            patient_data = Data;
            //remove the appointment passed
            patient_data.appointments.RemoveAll(app => app.Date_ < DateTime.Now);
        }



        private void PatientForm_Load(object sender, EventArgs e)
        {
            timer2.Start();
            label1.Text = patient_data.LoggedInPatient.FullName;
            radioButton1.Checked = true;

        }

        //main menu
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            label20.Text = "الرئيسية\r\n";
            flowLayoutPanel1.Location = new Point(167, 186);
            flowLayoutPanel1.Size = new Size(1200, 1012);
            flowLayoutPanel1.Controls.Clear();
            //the date label
            label2.Visible = true;
            LoadAppointments();
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
                a.PatientUserName == data.LoggedInPatient.UserName
            ).ToList();

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = true;
            flowLayoutPanel1.AutoScroll = true;
            //displaing the app
            foreach (var a in myAppointments)
            {

                var doctor = data.doctor.FirstOrDefault(d => d.UserName == a.DoctorUserName);

                Panel card = new Panel
                {
                    Width = 300,
                    Height = 140,
                    BackColor = Color.FromArgb(42, 42, 62),
                    Margin = new Padding(10)
                };

                Label lblDoctor = new Label
                {
                    Text = "👨‍⚕️ " + (doctor?.FullName ?? "غير معروف"),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(10, 10)
                };

                Label lblDate = new Label
                {
                    Text = $"📅 {a.Date_:yyyy-MM-dd hh:mm tt}",
                    ForeColor = Color.FromArgb(160, 160, 160),
                    Font = new Font("Segoe UI", 9),
                    AutoSize = true,
                    Location = new Point(10, 40)
                };



                Button btnDelete = new Button
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

                btnDelete.Click += (s, e) =>
                {
                    var result = MessageBox.Show("هل تريد إلغاء الموعد؟", "تأكيد", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        data.appointments.Remove(appointment);
                        data.Save();
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
            flowLayoutPanel1.Controls.Clear();
            label20.Text = "حجز موعد";
            flowLayoutPanel1.Location = new Point(169, 364);
            flowLayoutPanel1.Size = new Size(1200, 594);
            Create_Appointment();
        }

        private void Create_Appointment()
        {
            //combo box for specializations
            ComboBox comboBox1 = new ComboBox();
            comboBox1.BackColor = Color.FromArgb(26, 26, 46);
            comboBox1.ForeColor = Color.White;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.DataSource = patient_data.specializations;
            flowLayoutPanel1.Controls.Add(comboBox1);
            comboBox1.Width = 300;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            //combo box for names 
            ComboBox comboBox2 = new ComboBox();
            comboBox2.BackColor = Color.FromArgb(26, 26, 46);
            comboBox2.ForeColor = Color.White;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.Width = 300;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            flowLayoutPanel1.Controls.Add(comboBox2);
            comboBox1.SelectedIndexChanged += (s, e) =>
            {
                string selected = comboBox1.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selected) || selected == "اختر التخصص...")
                {
                    comboBox2.DataSource = null;
                    return;
                }

                var doctorsList = patient_data.doctor
                    .Where(d => d.Specialization == selected)
                    .ToList();
                doctorsList.Insert(0, new Doctor("none", "none", "اختر اسم الدكتور", "none"));


                comboBox2.DataSource = doctorsList;
                comboBox2.DisplayMember = "FullName";
                comboBox2.ValueMember = "UserName";
            };

            comboBox1.SelectedIndex = 0;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;

            int center = (flowLayoutPanel1.Width - 250) / 2;

            comboBox1.Margin = new Padding(center, 20, 0, 10);
            comboBox2.Margin = new Padding(center, 5, 0, 10);
            //DATE TIME PICKER
            DateTimePicker dateTimePicker1 = new DateTimePicker();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.ShowUpDown = true;

            dateTimePicker1.Width = 300;
            dateTimePicker1.Margin = new Padding(center, 10, 0, 10);
            dateTimePicker1.BackColor = Color.FromArgb(26, 26, 46);
            dateTimePicker1.ForeColor = Color.White;

            flowLayoutPanel1.Controls.Add(dateTimePicker1);
            ComboBox comboBox3 = new ComboBox();
            comboBox3.DataSource = patient_data.time;
            comboBox3.BackColor = Color.FromArgb(26, 26, 46);
            comboBox3.ForeColor = Color.White;
            comboBox3.FlatStyle = FlatStyle.Flat;
            comboBox3.Width = 300;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Margin = new Padding(center, 10, 0, 10);
            flowLayoutPanel1.Controls.Add(comboBox3);

            // Prevent past dates
            dateTimePicker1.MinDate = DateTime.Today;
            // INITIAL TIME 
            DateTime now = DateTime.Now;

            dateTimePicker1.ShowUpDown = true;

            if (now.Hour >= 17)
            {
                now = now.Date.AddDays(1);
            }
            dateTimePicker1.MinDate = now;
            dateTimePicker1.Value = now;

            //OK BUTTON 
            Button Ok = new Button();

            Ok.Text = "تأكيد";
            Ok.Width = 300;
            Ok.Height = 35;

            Ok.BackColor = Color.FromArgb(24, 95, 165);
            Ok.ForeColor = Color.White;
            Ok.FlatStyle = FlatStyle.Flat;
            Ok.FlatAppearance.BorderSize = 0;

            Ok.Margin = new Padding(center, 15, 0, 10);

            flowLayoutPanel1.Controls.Add(Ok);



            Ok.Click += (s, e) =>
            {
                if (comboBox3.SelectedItem == null || comboBox3.SelectedItem?.ToString() == "اختر الوقت ...")
                {
                    MessageBox.Show("من فضلك اختر الوقت");
                    return;
                }
                DateTime selectedDateTime = dateTimePicker1.Value.Date.Add(DateTime.Parse(comboBox3.SelectedItem.ToString()).TimeOfDay);
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
                string doctorUserName = comboBox2.SelectedValue.ToString();

                bool alreadyBooked = patient_data.appointments.Any(u =>
                    u.DoctorUserName == doctorUserName &&
                    u.Date_.Date == selectedDateTime.Date &&
                    u.Date_.TimeOfDay.TotalMinutes == selectedDateTime.TimeOfDay.TotalMinutes
                );

                if (alreadyBooked)
                {
                    MessageBox.Show("هذا الموعد محجوز بالفعل ❌");
                    return;
                }

                string specialization = comboBox1.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(specialization) || specialization == "اختر التخصص...")
                {
                    MessageBox.Show("من فضلك اختر التخصص");
                    return;
                }

                if (comboBox2.SelectedItem == null )
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
                Appointment newApp = new Appointment(
                    doctorUserName,
                    patient_data.LoggedInPatient.UserName,
                    selectedDateTime
                );
                //saving 
                patient_data.appointments.Add(newApp);
                patient_data.Save();

                MessageBox.Show("تم الحجز بنجاح 🎉");


            };
        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //logout button 
        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("هل تريد تسجيل الخروج؟", "تأكيد", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Program.SharedData.LoggedInPatient = null;

                LoginForm login = new LoginForm();
                login.Show();

                this.Close();
            }
        }


        //deleting the account button
        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("هل تريد مسح الحساب ؟", "تأكيد", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                var currentUser = patient_data.LoggedInPatient;
                patient_data.appointments.RemoveAll(a =>a.PatientUserName == currentUser.UserName);
                patient_data.patient.RemoveAll(p =>p.UserName == currentUser.UserName);
                patient_data.Save();
                patient_data.LoggedInPatient = null;
                MessageBox.Show("تم حذف الحساب بنجاح");

                LoginForm login = new LoginForm();
                login.Show();

                this.Close();
            }
        }
    }
}





