namespace kliniek.Forms
{
    partial class PatientDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientDetailsForm));
            panel1 = new Panel();
            label2 = new Label();
            lblName = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            btnPrescription = new Button();
            panelLastPresc = new Panel();
            lblLastPresc = new Label();
            panel7 = new Panel();
            lblLastAppt = new Label();
            panel4 = new Panel();
            label5 = new Label();
            lblUser = new Label();
            panel5 = new Panel();
            label3 = new Label();
            lblAge = new Label();
            panel6 = new Panel();
            label4 = new Label();
            lblGender = new Label();
            panel3 = new Panel();
            label1 = new Label();
            lblBlood = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panelLastPresc.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(21, 32, 43);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-10, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(510, 72);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(94, 44);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(35, 14);
            label2.TabIndex = 2;
            label2.Text = "مريض";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(94, 25);
            lblName.Name = "lblName";
            lblName.RightToLeft = RightToLeft.Yes;
            lblName.Size = new Size(54, 19);
            lblName.TabIndex = 1;
            lblName.Text = "الإسم";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(13, 17, 23);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnPrescription);
            panel2.Controls.Add(panelLastPresc);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(-7, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(510, 513);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(21, 32, 43);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(28, 442);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(451, 35);
            button1.TabIndex = 3;
            button1.Text = "خروج";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnPrescription
            // 
            btnPrescription.BackColor = Color.FromArgb(37, 99, 235);
            btnPrescription.FlatAppearance.BorderSize = 0;
            btnPrescription.FlatStyle = FlatStyle.Flat;
            btnPrescription.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrescription.ForeColor = Color.White;
            btnPrescription.Location = new Point(28, 392);
            btnPrescription.Margin = new Padding(3, 2, 3, 2);
            btnPrescription.Name = "btnPrescription";
            btnPrescription.Size = new Size(451, 35);
            btnPrescription.TabIndex = 4;
            btnPrescription.Text = "📝 كتابة روشتة";
            btnPrescription.UseVisualStyleBackColor = false;
            btnPrescription.Click += btnPrescription_Click;
            // 
            // panelLastPresc
            // 
            panelLastPresc.BackColor = Color.FromArgb(21, 32, 43);
            panelLastPresc.Controls.Add(lblLastPresc);
            panelLastPresc.Location = new Point(28, 311);
            panelLastPresc.Margin = new Padding(3, 2, 3, 2);
            panelLastPresc.Name = "panelLastPresc";
            panelLastPresc.Size = new Size(451, 73);
            panelLastPresc.TabIndex = 5;
            // 
            // lblLastPresc
            // 
            lblLastPresc.AutoSize = true;
            lblLastPresc.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastPresc.ForeColor = Color.FromArgb(106, 191, 106);
            lblLastPresc.Location = new Point(192, 33);
            lblLastPresc.Name = "lblLastPresc";
            lblLastPresc.Size = new Size(48, 18);
            lblLastPresc.TabIndex = 0;
            lblLastPresc.Text = "........";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(21, 32, 43);
            panel7.Controls.Add(lblLastAppt);
            panel7.Location = new Point(272, 212);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(206, 73);
            panel7.TabIndex = 2;
            panel7.Paint += Panel7_Paint;
            // 
            // lblLastAppt
            // 
            lblLastAppt.AutoSize = true;
            lblLastAppt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastAppt.ForeColor = Color.White;
            lblLastAppt.Location = new Point(62, 28);
            lblLastAppt.Name = "lblLastAppt";
            lblLastAppt.Size = new Size(58, 23);
            lblLastAppt.TabIndex = 6;
            lblLastAppt.Text = "........";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(21, 32, 43);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(lblUser);
            panel4.Location = new Point(272, 212);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(206, 73);
            panel4.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(116, 8);
            label5.Name = "label5";
            label5.Size = new Size(86, 14);
            label5.TabIndex = 12;
            label5.Text = "اسم المستخدم";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(70, 28);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(58, 23);
            lblUser.TabIndex = 11;
            lblUser.Text = "........";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(21, 32, 43);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(lblAge);
            panel5.Location = new Point(28, 111);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(206, 73);
            panel5.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(167, 6);
            label3.Name = "label3";
            label3.Size = new Size(31, 14);
            label3.TabIndex = 10;
            label3.Text = "العمر";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.ForeColor = Color.White;
            lblAge.Location = new Point(68, 26);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(58, 23);
            lblAge.TabIndex = 9;
            lblAge.Text = "........";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(21, 32, 43);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(lblGender);
            panel6.Location = new Point(272, 111);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(206, 73);
            panel6.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(160, 6);
            label4.Name = "label4";
            label4.Size = new Size(41, 14);
            label4.TabIndex = 10;
            label4.Text = "الجنس";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGender.ForeColor = Color.White;
            lblGender.Location = new Point(83, 26);
            lblGender.Name = "lblGender";
            lblGender.RightToLeft = RightToLeft.Yes;
            lblGender.Size = new Size(58, 23);
            lblGender.TabIndex = 9;
            lblGender.Text = "........";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(21, 32, 43);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(lblBlood);
            panel3.Location = new Point(28, 212);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(206, 73);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(134, 8);
            label1.Name = "label1";
            label1.Size = new Size(60, 14);
            label1.TabIndex = 6;
            label1.Text = "فصيلة الدم";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlood
            // 
            lblBlood.AutoSize = true;
            lblBlood.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBlood.ForeColor = Color.White;
            lblBlood.Location = new Point(68, 28);
            lblBlood.Name = "lblBlood";
            lblBlood.Size = new Size(58, 23);
            lblBlood.TabIndex = 5;
            lblBlood.Text = "........";
            // 
            // PatientDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 492);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(510, 543);
            MinimumSize = new Size(510, 470);
            Name = "PatientDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PatientDetailsForm";
            Load += PatientDetailsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panelLastPresc.ResumeLayout(false);
            panelLastPresc.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel3;
        private Button button1;
        private Panel panel7;
        private Label label2;
        private Label lblName;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblBlood;
        private Label label3;
        private Label lblAge;
        private Label label4;
        private Label lblGender;
        private Label label5;
        private Label lblUser;
        private Label lblLastAppt;
        private Button btnPrescription;
        private Panel panelLastPresc;
        private Label lblLastPresc;
    }
}