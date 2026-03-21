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
using System.Xml.Linq;

namespace kliniek.Forms
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            Data.DataStore data = Program.SharedData;
            comboBox1.DataSource = data.specializations;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();

        }

        private void Register_Leave(object sender, EventArgs e)
        {


        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Data.DataStore data = Program.SharedData;
            label11.Text = "التخصص";
            comboBox1.DataSource = data.specializations;

            Age.Visible = false;
            label13.Visible = false;
            FullName.Width = 435;
            FullName.Location = new Point(90, 216);

            comboBox2.Visible = false;
            label14.Visible = false;
            UserName.Width = 435;
            UserName.Location = new Point(90, 297);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Data.DataStore data = Program.SharedData;
            label11.Text = "فصيلة الدم";
            comboBox1.DataSource = data.bloodtybe;

            Age.Visible = true;
            label13.Visible = true;
            FullName.Width = 294;
            FullName.Location = new Point(231, 216);

            comboBox2.Visible = true;
            label14.Visible = true;
            UserName.Width = 294;
            UserName.Location = new Point(231, 297);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.DataStore data = Program.SharedData;
            string TypeOfUser = patient.Checked ? "Patient" : "Doctor";

            bool userExists = false;
            foreach (var p in data.patient)
            {
                if (p.UserName == UserName.Text) { userExists = true; break; }
            }
            if (!userExists)
            {
                foreach (var d in data.doctor)
                {
                    if (d.UserName == UserName.Text) { userExists = true; break; }
                }
            }

            if (TypeOfUser == "Patient")
            {
                if (!(UserName.Text.Length < 1) && !(PassWord.Text.Length < 1) && !(FullName.Text.Length < 1) && !(Age.Text.Length < 1) && !(comboBox1.SelectedIndex == 0) && !(comboBox2.SelectedItem == null))
                {
                    if (userExists)
                    {
                        MessageBox.Show("اسم المستخدم موجود بالفعل");
                    }
                    else
                    {
                        Patient Patient1 = new(
                            UserName.Text,
                            PassWord.Text,
                            FullName.Text,
                            comboBox1.SelectedItem?.ToString()??"",
                            int.Parse(Age.Text),
                            comboBox2.SelectedItem?.ToString() ?? ""
                        );
                        data.patient.Add(Patient1);
                        data.Save();
                        MessageBox.Show("تم التسجيل بنجاح!");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("البيانات ناقصة ...");
                }
            }
            else if (TypeOfUser == "Doctor")
            {
                if (!(UserName.Text.Length < 1) && !(PassWord.Text.Length < 1) && !(FullName.Text.Length < 1) && !(comboBox1.SelectedIndex == 0))
                {
                    if (userExists)
                    {
                        MessageBox.Show("اسم المستخدم موجود بالفعل");
                    }
                    else
                    {
                        Doctor doctor1 = new(
                            UserName.Text,
                            PassWord.Text,
                            FullName.Text,
                            comboBox1.SelectedItem?.ToString() ?? ""
                        );
                        data.doctor.Add(doctor1);
                        data.Save();
                        MessageBox.Show("تم التسجيل بنجاح!");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("البيانات ناقصة ...");
                }
            }
            
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

