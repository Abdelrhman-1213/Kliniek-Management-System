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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrescriptionForm));
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
            panelHeader.Size = new Size(550, 72);
            panelHeader.TabIndex = 0;
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPatientName.ForeColor = Color.FromArgb(148, 163, 184);
            lblPatientName.Location = new Point(20, 43);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(87, 21);
            lblPatientName.TabIndex = 1;
            lblPatientName.Text = "المريض: ...";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(186, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📝 كتابة روشتة";
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
            panelBody.Location = new Point(0, 72);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(550, 468);
            panelBody.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(37, 99, 235);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(20, 396);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(510, 45);
            btnSave.TabIndex = 6;
            btnSave.Text = "💾 حفظ الروشتة";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // lblNotesLabel
            // 
            lblNotesLabel.AutoSize = true;
            lblNotesLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotesLabel.ForeColor = Color.FromArgb(148, 163, 184);
            lblNotesLabel.Location = new Point(20, 279);
            lblNotesLabel.Name = "lblNotesLabel";
            lblNotesLabel.Size = new Size(68, 23);
            lblNotesLabel.TabIndex = 4;
            lblNotesLabel.Text = "ملاحظات";
            // 
            // txtNotes
            // 
            txtNotes.BackColor = Color.FromArgb(21, 32, 43);
            txtNotes.BorderStyle = BorderStyle.None;
            txtNotes.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNotes.ForeColor = Color.White;
            txtNotes.Location = new Point(20, 304);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.PlaceholderText = "ملاحظات إضافية (اختياري)...";
            txtNotes.RightToLeft = RightToLeft.Yes;
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(510, 72);
            txtNotes.TabIndex = 5;
            // 
            // lblMedsLabel
            // 
            lblMedsLabel.AutoSize = true;
            lblMedsLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMedsLabel.ForeColor = Color.FromArgb(148, 163, 184);
            lblMedsLabel.Location = new Point(20, 140);
            lblMedsLabel.Name = "lblMedsLabel";
            lblMedsLabel.Size = new Size(52, 23);
            lblMedsLabel.TabIndex = 2;
            lblMedsLabel.Text = "الأدوية";
            // 
            // txtMedications
            // 
            txtMedications.BackColor = Color.FromArgb(21, 32, 43);
            txtMedications.BorderStyle = BorderStyle.None;
            txtMedications.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMedications.ForeColor = Color.White;
            txtMedications.Location = new Point(20, 165);
            txtMedications.Multiline = true;
            txtMedications.Name = "txtMedications";
            txtMedications.PlaceholderText = "اكتب الأدوية هنا (دواء في كل سطر)...";
            txtMedications.RightToLeft = RightToLeft.Yes;
            txtMedications.ScrollBars = ScrollBars.Vertical;
            txtMedications.Size = new Size(510, 99);
            txtMedications.TabIndex = 3;
            // 
            // lblDiagLabel
            // 
            lblDiagLabel.AutoSize = true;
            lblDiagLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiagLabel.ForeColor = Color.FromArgb(148, 163, 184);
            lblDiagLabel.Location = new Point(20, 18);
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
            txtDiagnosis.Location = new Point(20, 43);
            txtDiagnosis.Multiline = true;
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.PlaceholderText = "اكتب التشخيص هنا...";
            txtDiagnosis.RightToLeft = RightToLeft.Yes;
            txtDiagnosis.ScrollBars = ScrollBars.Vertical;
            txtDiagnosis.Size = new Size(510, 81);
            txtDiagnosis.TabIndex = 1;
            // 
            // PrescriptionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 17, 23);
            ClientSize = new Size(550, 540);
            Controls.Add(panelBody);
            Controls.Add(panelHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(568, 587);
            MinimumSize = new Size(568, 587);
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
