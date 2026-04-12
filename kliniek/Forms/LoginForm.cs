using kliniek.Models;

namespace kliniek.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            this.AcceptButton = button1;
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
                Button1_Click(sender, e);
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
            register.FormClosed += async (s, args) =>
            {
                // إعادة تحميل البيانات عشان لو المستخدم سجل حساب جديد
                await Program.SharedData.Load();
                textBox1.Text = "";
                textBox2.Text = "";
                this.Show();
            };
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

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("البيانات ناقصة.");
                return;
            }

            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("برجاء اختيار نوع الحساب (مريض / طبيب)");
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
                    var patientForm = new PatientForm();
                    patientForm.FormClosed += async (s, args) =>
                    {
                        if (data.LoggedInPatient == null)
                        {
                            // المستخدم عمل تسجيل خروج - نرجع لصفحة تسجيل الدخول
                            await Program.SharedData.Load();
                            textBox1.Text = "";
                            textBox2.Text = "";
                            this.Show();
                        }
                        else
                        {
                            // المستخدم قفل الفورم من زرار X - نقفل التطبيق
                            this.Close();
                        }
                    };
                    patientForm.Show();
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
                    var doctorForm = new DoctorForm();
                    doctorForm.FormClosed += async (s, args) =>
                    {
                        if (data.LogedInDoc == null)
                        {
                            // المستخدم عمل تسجيل خروج - نرجع لصفحة تسجيل الدخول
                            await Program.SharedData.Load();
                            textBox1.Text = "";
                            textBox2.Text = "";
                            this.Show();
                        }
                        else
                        {
                            // المستخدم قفل الفورم من زرار X - نقفل التطبيق
                            this.Close();
                        }
                    };
                    doctorForm.Show();
                    this.Hide();
                }

            }
        }
    }
}
