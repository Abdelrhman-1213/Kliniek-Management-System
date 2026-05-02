using kliniek.Data;
using kliniek.Models;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            patient.Checked = true;
            comboBox1.DataSource = data.bloodtybe;


            Age.Visible = true;
            label13.Visible = true;
            DoctorCode.Visible = false;
            label15.Visible = false;
            comboBox2.Visible = true;
            label14.Visible = true;
            label11.Visible = true;
            label11.Text = "فصيلة الدم";
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();

        }




        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Data.DataStore data = Program.SharedData;
            label11.Visible = true;
            label11.Text = "التخصص";
            comboBox1.DataSource = data.specializations;

            Age.Visible = false;
            label13.Visible = false;
            DoctorCode.Visible = true;
            label15.Visible = true;


            comboBox2.Visible = false;
            label14.Visible = false;
            txtDescription.Visible = true;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Data.DataStore data = Program.SharedData;
            label11.Visible = true;
            label11.Text = "فصيلة الدم";
            comboBox1.DataSource = data.bloodtybe;

            Age.Visible = true;
            label13.Visible = true;
            DoctorCode.Visible = false;
            label15.Visible = false;



            comboBox2.Visible = true;
            label14.Visible = true;
            txtDescription.Visible = false;

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Data.DataStore data = Program.SharedData;
            string TypeOfUser = patient.Checked ? "Patient" : "Doctor";
            bool PassIsWe = PassWord.Text.Length < 6;

            // التحقق من العمر لو مريض
            if (patient.Checked && !int.TryParse(Age.Text, out _))
            {
                MessageBox.Show("برجاء إدخال عمر صحيح (أرقام فقط)");
                return;
            }

            bool userExists = TypeOfUser == "Patient"
            ? data.patient.Any(p => p.username == UserName.Text)
            : data.doctor.Any(d => d.username == UserName.Text);

            if (TypeOfUser == "Patient")
            {
                if (!(UserName.Text.Length < 1) && !(PassWord.Text.Length < 1) && !(FullName.Text.Length < 1) && !(Age.Text.Length < 1) && !(comboBox1.SelectedIndex == 0) && comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() != "")
                {
                    if (PassIsWe) MessageBox.Show("يجب أن تكون كلمة المرور 6 أحرف على الأقل");
                    else
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
                                comboBox1.SelectedItem?.ToString() ?? "",
                                int.Parse(Age.Text),
                                comboBox2.SelectedItem?.ToString() ?? ""
                            );
                            data.patient.Add(Patient1);
                            await data.SavePatient(Patient1);
                            MessageBox.Show("تم التسجيل بنجاح!");
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("البيانات ناقصة ...");
                }
            }
            else if (TypeOfUser == "Doctor")
            {
                if (!(UserName.Text.Length < 1) && !(PassWord.Text.Length < 1) && !(FullName.Text.Length < 1) && !(comboBox1.SelectedIndex == 0) && !(DoctorCode.Text.Length < 1))
                {
                    if (DoctorCode.Text != DataStore.SecretCode) MessageBox.Show("كود الطبيب خاطئ");
                    else
                    {
                        if (PassIsWe) MessageBox.Show("يجب أن تكون كلمة المرور 6 أحرف على الأقل");
                        else
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
                                doctor1.Description = txtDescription.Text.Trim();
                                data.doctor.Add(doctor1);
                                await data.SaveDoctor(doctor1);
                                MessageBox.Show("تم التسجيل بنجاح!");
                                this.Close();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("البيانات ناقصة ...");
                }
            }


        }

        

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            var data = Program.SharedData;
            string typed = UserName.Text;

            bool exists = patient.Checked
                ? data.patient.Any(p => p.username == typed)
                : data.doctor.Any(d => d.username == typed);

            if (exists)
                toolTip1.SetToolTip(UserName, " اسم المستخدم موجود بالفعل");
            else if (typed.Length >= 3)
                toolTip1.SetToolTip(UserName, " اسم المستخدم متاح");
            else
                toolTip1.SetToolTip(UserName, "");

        }
    }
}

