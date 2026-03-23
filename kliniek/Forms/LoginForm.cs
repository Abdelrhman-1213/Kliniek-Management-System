using kliniek.Models;

namespace kliniek.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();


        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_Click(object sender, EventArgs e)
        {

        }

        private void MaterialTextBox21_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new();
            this.Hide();
            register.Show();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
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
                    if (p.username == textBox1.Text)
                    {
                        foundPatient = p;
                        break;
                    }
                }

                if (foundPatient == null) MessageBox.Show("اسم المستخدم غير موجود.");
                else if (foundPatient.password != textBox2.Text)
                {
                    Program.SharedData.LoggedInPatient = null;
                    MessageBox.Show("كلمة المرور خاطئة."); 
                }
                else
                {
                    data.LoggedInPatient = foundPatient;
                    new PatientForm().Show();
                    this.Hide();
                }
            }

            else if (radioButton2.Checked) // Doctor
            {
                Program.SharedData.LogedInDoc = null;
                foreach (var d in data.doctor)
                {
                    if (d.username == textBox1.Text)
                    {
                        Program.SharedData.LogedInDoc = d;
                        break;
                    }
                }

                if (Program.SharedData.LogedInDoc == null)
                    MessageBox.Show("اسم المستخدم غير موجود.");
                else if (Program.SharedData.LogedInDoc.password != textBox2.Text)
                {
                    Program.SharedData.LogedInDoc = null;
                    MessageBox.Show("كلمة المرور خاطئة.");
                }
                else
                {

                    new DoctorForm().Show();
                    this.Hide();
                }

            }
        }
    }
}
