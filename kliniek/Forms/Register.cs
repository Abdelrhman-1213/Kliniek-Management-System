using kliniek.Data;
using kliniek.Models;
using System.Threading.Tasks;

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

            // تأكد ان الحقول المبدئية ظاهرة صح لنوع "مريض"
            Age.Visible = true;
            label13.Visible = true;
            DoctorCode.Visible = false;
            label15.Visible = false;
            comboBox2.Visible = true;
            label14.Visible = true;
            label11.Visible = true;
            label11.Text = "فصيلة الدم";
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
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
            label11.Visible = true;
            label11.Text = "التخصص";
            comboBox1.DataSource = data.specializations;

            Age.Visible = false;
            label13.Visible = false;
            DoctorCode.Visible = true;
            label15.Visible = true;


            comboBox2.Visible = false;
            label14.Visible = false;
            UserName.Width = 435;
            UserName.Location = new Point(90, 297);
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
            FullName.Width = 294;
            FullName.Location = new Point(231, 216);

            comboBox2.Visible = true;
            label14.Visible = true;
            UserName.Width = 294;
            UserName.Location = new Point(231, 297);
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

            bool userExists = false;
            foreach (var p in data.patient)
            {
                if (p.username == UserName.Text) { userExists = true; break; }
            }
            if (!userExists)
            {
                foreach (var d in data.doctor)
                {
                    if (d.username == UserName.Text) { userExists = true; break; }
                }
            }

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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FullName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

