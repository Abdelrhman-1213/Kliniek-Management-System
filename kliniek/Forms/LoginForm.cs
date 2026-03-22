using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin2DotNet;
using MaterialSkin2DotNet.Controls;
using kliniek.Data;
using kliniek.Models;

namespace kliniek.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox21_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.DataStore data = Program.SharedData;
            
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("البيانات ناقصة.");
                return;
            }

            if (radioButton1.Checked) // Patient
            {
                Patient? foundPatient = null;
                foreach (var p in data.patient)
                {
                    if (p.UserName == textBox1.Text)
                    {
                        foundPatient = p;
                        break;
                    }
                }

                if (foundPatient == null) MessageBox.Show("اسم المستخدم غير موجود.");
                else if (foundPatient.Password != textBox2.Text) MessageBox.Show("كلمة المرور خاطئة.");
                else
                {
                    data.LoggedInPatient = foundPatient;
                        
                    MessageBox.Show($"{foundPatient.FullName} أهلا بك");
                    new PatientForm(data).Show();
                    //this.Hide();
                }
            }
             
            else if (radioButton2.Checked) // Doctor
            {
                
                foreach (var d in data.doctor)
                {
                    if (d.UserName == textBox1.Text)
                    {
                        Program.SharedData.LogedInDoc = d;
                        break;
                    }
                }

                if (Program.SharedData.LogedInDoc == null)
                    MessageBox.Show("اسم المستخدم غير موجود.");
                else if (Program.SharedData.LogedInDoc.Password != textBox2.Text)
                    MessageBox.Show("كلمة المرور خاطئة.");
                else
                {
                    new DoctorForm().Show();
                    MessageBox.Show($"د. {Program.SharedData.LogedInDoc.FullName} أهلا بك");
                    this.Hide();
                }

            }
        }
    }
}
