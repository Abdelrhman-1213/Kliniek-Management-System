using kliniek.Models;
using System.Data;

namespace kliniek.Forms
{
    public partial class PatientDetailsForm : Form
    {
        public PatientDetailsForm(Patient p)
        {
            InitializeComponent();

            _patient = p;

            lblName.Text = p.fullname;
            lblAge.Text = p.age.ToString();
            lblBlood.Text = p.bloodtype;
            lblGender.Text = p.gender;
            lblUser.Text = p.username;
        }
        private readonly Patient _patient;


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PatientDetailsForm_Load(object sender, EventArgs e)
        {
            Data.DataStore data = Program.SharedData;

            var lastAppt = data.appointments
                .Where(a => a.patientusername == _patient.username &&
                            a.doctorusername == data.LogedInDoc?.username)
                .OrderByDescending(a => a.date)
                .FirstOrDefault();

            lblLastAppt.Text = lastAppt != null
            ? $" اخر ميعاد:{lastAppt.date:dd/MM/yyyy hh:mm tt}"
            : "لا يوجد مواعيد";
        }
    }
}
