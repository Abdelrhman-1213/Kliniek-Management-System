using kliniek.Models;
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
    public partial class PatientDetailsForm : Form
    {
        public PatientDetailsForm(Patient p)
        {
            InitializeComponent();

            _patient = p;

            lblName.Text = p.FullName;
            lblAge.Text = p.Age.ToString();
            lblBlood.Text = p.BloodType;
            lblGender.Text = p.Gender;
            lblUser.Text = p.UserName;
        }
        private Patient _patient;
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void PatientDetailsForm_Load(object sender, EventArgs e)
        {
            Data.DataStore data = Program.SharedData;

            var lastAppt = data.appointments
                .Where(a => a.PatientUserName == _patient.UserName &&
                            a.DoctorUserName == data.LogedInDoc.UserName)
                .OrderByDescending(a => a.Date)
                .FirstOrDefault();

                lblLastAppt.Text = lastAppt != null
                ? $" اخر ميعاد:{lastAppt.Date.ToString("dd/MM/yyyy hh:mm tt")}"
                : "لا يوجد مواعيد";
        }
    }
}
