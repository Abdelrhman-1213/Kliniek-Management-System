using kliniek.Models;

namespace kliniek.Forms
{
    public partial class PrescriptionForm : Form
    {
        private readonly Patient _patient;

        public PrescriptionForm(Patient patient)
        {
            InitializeComponent();
            _patient = patient;
            lblPatientName.Text = $"المريض: {patient.fullname}";
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDiagnosis.Text))
            {
                MessageBox.Show("برجاء كتابة التشخيص", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMedications.Text))
            {
                MessageBox.Show("برجاء كتابة الأدوية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var docUsername = Program.SharedData.LogedInDoc?.username;
            if (docUsername == null)
            {
                MessageBox.Show("خطأ: لم يتم التعرف على الطبيب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnSave.Enabled = false;
            btnSave.Text = "جاري الحفظ...";

            try
            {
                var prescription = new Prescription(
                    docUsername,
                    _patient.username,
                    txtDiagnosis.Text.Trim(),
                    txtMedications.Text.Trim(),
                    txtNotes.Text.Trim()
                );

                await Program.SharedData.SavePrescription(prescription);
                Program.SharedData.prescriptions.Add(prescription);

                MessageBox.Show("تم حفظ الروشتة بنجاح ✅", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في حفظ الروشتة: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = true;
                btnSave.Text = "💾 حفظ الروشتة";
            }
        }
    }
}
