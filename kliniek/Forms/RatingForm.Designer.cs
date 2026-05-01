using System.Windows.Forms;
using System.Drawing;

namespace kliniek.Forms
{
    partial class RatingForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RatingForm));
            lblRatingTitle = new Label();
            comboBoxRatingDoctors = new ComboBox();
            numRating = new NumericUpDown();
            btnSubmitRating = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)numRating).BeginInit();
            SuspendLayout();
            // 
            // lblRatingTitle
            // 
            lblRatingTitle.AutoSize = true;
            lblRatingTitle.Font = new Font("Bauhaus 93", 22F, FontStyle.Bold);
            lblRatingTitle.ForeColor = Color.White;
            lblRatingTitle.Location = new Point(113, 22);
            lblRatingTitle.Name = "lblRatingTitle";
            lblRatingTitle.Size = new Size(196, 34);
            lblRatingTitle.TabIndex = 0;
            lblRatingTitle.Text = "اختر الدكتور لتقييمه";
            lblRatingTitle.Click += lblRatingTitle_Click;
            // 
            // comboBoxRatingDoctors
            // 
            comboBoxRatingDoctors.FormattingEnabled = true;
            comboBoxRatingDoctors.Location = new Point(79, 105);
            comboBoxRatingDoctors.Name = "comboBoxRatingDoctors";
            comboBoxRatingDoctors.RightToLeft = RightToLeft.No;
            comboBoxRatingDoctors.Size = new Size(263, 23);
            comboBoxRatingDoctors.TabIndex = 0;
            comboBoxRatingDoctors.SelectedIndexChanged += comboBoxRatingDoctors_SelectedIndexChanged;
            // 
            // numRating
            // 
            numRating.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold);
            numRating.Location = new Point(157, 193);
            numRating.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numRating.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRating.Name = "numRating";
            numRating.Size = new Size(117, 37);
            numRating.TabIndex = 1;
            numRating.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(numRating, "التقييم من 10");
            numRating.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numRating.ValueChanged += numRating_ValueChanged;
            // 
            // btnSubmitRating
            // 
            btnSubmitRating.BackColor = Color.FromArgb(33, 100, 180);
            btnSubmitRating.Cursor = Cursors.Hand;
            btnSubmitRating.FlatAppearance.BorderSize = 0;
            btnSubmitRating.FlatStyle = FlatStyle.Flat;
            btnSubmitRating.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSubmitRating.ForeColor = Color.WhiteSmoke;
            btnSubmitRating.Location = new Point(115, 277);
            btnSubmitRating.Name = "btnSubmitRating";
            btnSubmitRating.Size = new Size(200, 45);
            btnSubmitRating.TabIndex = 2;
            btnSubmitRating.Text = "تأكيد التقييم ";
            btnSubmitRating.UseVisualStyleBackColor = false;
            btnSubmitRating.Click += btnSubmitRating_Click;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // RatingForm
            // 
            BackColor = Color.FromArgb(21, 32, 43);
            ClientSize = new Size(420, 360);
            Controls.Add(lblRatingTitle);
            Controls.Add(comboBoxRatingDoctors);
            Controls.Add(numRating);
            Controls.Add(btnSubmitRating);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RatingForm";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "تقييم الدكتور";
            ((System.ComponentModel.ISupportInitialize)numRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblRatingTitle;
        private ComboBox comboBoxRatingDoctors;
        private NumericUpDown numRating;
        private Button btnSubmitRating;
        private ToolTip toolTip1;
    }
}