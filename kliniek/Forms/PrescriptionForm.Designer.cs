namespace kliniek.Forms
{
    partial class PrescriptionForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblPatientName = new Label();
            lblTitle = new Label();
            panelBody = new Panel();
            btnSave = new Button();
            lblNotesLabel = new Label();
            txtNotes = new TextBox();
            lblMedsLabel = new Label();
            txtMedications = new TextBox();
            lblDiagLabel = new Label();
            txtDiagnosis = new TextBox();
            panelHeader.SuspendLayout();
            panelBody.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(21, 32, 43);
            panelHeader.Controls.Add(lblPatientName);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(550, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(150, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📝 كتابة روشتة";
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPatientName.ForeColor = Color.FromArgb(148, 163, 184);
            lblPatientName.Location = new Point(20, 48);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(100, 23);
            lblPatientName.TabIndex = 1;
            lblPatientName.Text = "المريض: ...";
            // 
            // panelBody
            // 
            panelBody.BackColor = Color.FromArgb(13, 17, 23);
            panelBody.Controls.Add(btnSave);
            panelBody.Controls.Add(lblNotesLabel);
            panelBody.Controls.Add(txtNotes);
            panelBody.Controls.Add(lblMedsLabel);
            panelBody.Controls.Add(txtMedications);
            panelBody.Controls.Add(lblDiagLabel);
            panelBody.Controls.Add(txtDiagnosis);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 80);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(550, 520);
            panelBody.TabIndex = 1;
            // 
            // lblDiagLabel
            // 
            lblDiagLabel.AutoSize = true;
            lblDiagLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiagLabel.ForeColor = Color.FromArgb(148, 163, 184);
            lblDiagLabel.Location = new Point(20, 20);
            lblDiagLabel.Name = "lblDiagLabel";
            lblDiagLabel.Size = new Size(70, 23);
            lblDiagLabel.TabIndex = 0;
            lblDiagLabel.Text = "التشخيص";
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.BackColor = Color.FromArgb(21, 32, 43);
            txtDiagnosis.BorderStyle = BorderStyle.None;
            txtDiagnosis.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiagnosis.ForeColor = Color.White;
            txtDiagnosis.Location = new Point(20, 48);
            txtDiagnosis.Multiline = true;
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.RightToLeft = RightToLeft.Yes;
            txtDiagnosis.ScrollBars = ScrollBars.Vertical;
            txtDiagnosis.Size = new Size(510, 90);
            txtDiagnosis.TabIndex = 1;
            txtDiagnosis.PlaceholderText = "اكتب التشخيص هنا...";
            // 
            // lblMedsLabel
            // 
            lblMedsLabel.AutoSize = true;
            lblMedsLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMedsLabel.ForeColor = Color.FromArgb(148, 163, 184);
            lblMedsLabel.Location = new Point(20, 155);
            lblMedsLabel.Name = "lblMedsLabel";
            lblMedsLabel.Size = new Size(60, 23);
            lblMedsLabel.TabIndex = 2;
            lblMedsLabel.Text = "الأدوية";
            // 
            // txtMedications
            // 
            txtMedications.BackColor = Color.FromArgb(21, 32, 43);
            txtMedications.BorderStyle = BorderStyle.None;
            txtMedications.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMedications.ForeColor = Color.White;
            txtMedications.Location = new Point(20, 183);
            txtMedications.Multiline = true;
            txtMedications.Name = "txtMedications";
            txtMedications.RightToLeft = RightToLeft.Yes;
            txtMedications.ScrollBars = ScrollBars.Vertical;
            txtMedications.Size = new Size(510, 110);
            txtMedications.TabIndex = 3;
            txtMedications.PlaceholderText = "اكتب الأدوية هنا (دواء في كل سطر)...";
            // 
            // lblNotesLabel
            // 
            lblNotesLabel.AutoSize = true;
            lblNotesLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotesLabel.ForeColor = Color.FromArgb(148, 163, 184);
            lblNotesLabel.Location = new Point(20, 310);
            lblNotesLabel.Name = "lblNotesLabel";
            lblNotesLabel.Size = new Size(70, 23);
            lblNotesLabel.TabIndex = 4;
            lblNotesLabel.Text = "ملاحظات";
            // 
            // txtNotes
            // 
            txtNotes.BackColor = Color.FromArgb(21, 32, 43);
            txtNotes.BorderStyle = BorderStyle.None;
            txtNotes.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNotes.ForeColor = Color.White;
            txtNotes.Location = new Point(20, 338);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.RightToLeft = RightToLeft.Yes;
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(510, 80);
            txtNotes.TabIndex = 5;
            txtNotes.PlaceholderText = "ملاحظات إضافية (اختياري)...";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(37, 99, 235);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(20, 440);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(510, 50);
            btnSave.TabIndex = 6;
            btnSave.Text = "💾 حفظ الروشتة";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // PrescriptionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 17, 23);
            ClientSize = new Size(550, 600);
            Controls.Add(panelBody);
            Controls.Add(panelHeader);
            MaximizeBox = false;
            MaximumSize = new Size(568, 647);
            MinimumSize = new Size(568, 647);
            Name = "PrescriptionForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "كتابة روشتة";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblPatientName;
        private Panel panelBody;
        private Label lblDiagLabel;
        private TextBox txtDiagnosis;
        private Label lblMedsLabel;
        private TextBox txtMedications;
        private Label lblNotesLabel;
        private TextBox txtNotes;
        private Button btnSave;
    }
}
