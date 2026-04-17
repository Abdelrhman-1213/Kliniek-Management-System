using kliniek.Models;

namespace kliniek.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            patient_button.Checked = true;
            this.AcceptButton = enter_button;
        }


        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Button1_Click(sender, e);
            }
        }

   
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new();
            register.FormClosed += async (s, args) =>
            {
                // إعادة تحميل البيانات عشان لو المستخدم سجل حساب جديد
                await Program.SharedData.Load();
                username_text.Text = "";
                password_text.Text = "";
                this.Show();
            };
            this.Hide();
            register.Show();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        //login button
        private void Button1_Click(object sender, EventArgs e)
        {
            Data.DataStore data = Program.SharedData;


            // in case user did not enter the username or password
            if (string.IsNullOrWhiteSpace(username_text.Text) || string.IsNullOrWhiteSpace(password_text.Text))
            {
                MessageBox.Show("البيانات ناقصة.");
                return;
            }
            // in case the user did not choose the account type
            if (!patient_button.Checked && !doctor_button.Checked)
            {
                MessageBox.Show("برجاء اختيار نوع الحساب (مريض / طبيب)");
                return;
            }

            if (patient_button.Checked) // Patient
            {
                Patient? foundPatient =data.patient.FirstOrDefault(p => p.username == username_text.Text); 
                
                
                //foreach (var p in data.patient)
                //{
                //    if (p.username == username_text.Text)
                //    {
                //        foundPatient = p;
                //        break;
                //    }
                //}

                // no user found
                if (foundPatient == null) MessageBox.Show("اسم المستخدم غير موجود.");

                // wrong password
                else if (foundPatient.password != password_text.Text)
                {
                    Program.SharedData.LoggedInPatient = null;
                    MessageBox.Show("كلمة المرور خاطئة."); 
                }
                else
                {
                    //successful login
                    data.LoggedInPatient = foundPatient;
                    var patientForm = new PatientForm();

                    patientForm.FormClosed += async (s, args) =>
                    {
                        if (data.LoggedInPatient == null)
                        {
                            // المستخدم عمل تسجيل خروج - نرجع لصفحة تسجيل الدخول
                            await Program.SharedData.Load();
                            username_text.Text = "";
                            password_text.Text = "";
                            
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


            //doctor 
            else if (doctor_button.Checked) 
            {
                //check if the doctor username exist
                Doctor? foundDoc = data.doctor.FirstOrDefault(p => p.username == username_text.Text);

                //foreach (var d in data.doctor)
                //{
                //    if (d.username == username_text.Text)
                //    {
                //        Program.SharedData.LogedInDoc = d;
                //        break;
                //    }
                //}

                //not found
                if (foundDoc == null)
                    MessageBox.Show("اسم المستخدم غير موجود.");


                //wrong password
                else if (foundDoc.password != password_text.Text)
                {
                    //Program.SharedData.LogedInDoc = null;
                    MessageBox.Show("كلمة المرور خاطئة.");
                }
                else
                {
                    //successful login
                    data.LogedInDoc = foundDoc;
                    var doctorForm = new DoctorForm();

                    doctorForm.FormClosed += async (s, args) =>
                    {
                        if (data.LogedInDoc == null)
                        {
                            // المستخدم عمل تسجيل خروج - نرجع لصفحة تسجيل الدخول
                            await Program.SharedData.Load();
                            username_text.Text = "";
                            password_text.Text = "";
                            
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
