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

namespace kliniek.Forms
{
    public partial class RatingForm : Form
    {
        public RatingForm()
        {
            InitializeComponent();
            var data = Program.SharedData;
            var myDoctors = data.doctor
                .Where(d => data.appointments.Any(a =>
                    a.patientusername == data.LoggedInPatient?.username &&
                    a.doctorusername == d.username))
                .ToList();

            comboBoxRatingDoctors.DataSource = myDoctors;
            comboBoxRatingDoctors.DisplayMember = "fullname";
            comboBoxRatingDoctors.ValueMember = "username";
        }
        private async void btnSubmitRating_Click(object sender, EventArgs e)
        {
            var selected = comboBoxRatingDoctors.SelectedItem as Doctor;

            if (selected == null)
            {
                MessageBox.Show("من فضلك اختر دكتور");
                return;
            }

            float score = (float)numRating.Value;

            var result = MessageBox.Show(
                $"هتقيم د. {selected.fullname} بـ {score} من 10 ؟",
                "تأكيد",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                await Program.SharedData.UpdateDoctorRating(selected.username, score);
                MessageBox.Show("تم التقييم بنجاح ");
                this.Close();
            }
        }

        private void RatingForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmitRating_Click_1(object sender, EventArgs e)
        {

        }
        private void lblRatingTitle_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxRatingDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numRating_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
