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
            panel1.Location = new Point(-11, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(583, 102);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(107, 63);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "مريض";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(107, 35);
            lblName.Name = "lblName";
            lblName.RightToLeft = RightToLeft.Yes;
            lblName.Size = new Size(58, 28);
            lblName.TabIndex = 1;
            lblName.Text = "الإسم";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(13, 17, 23);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(-8, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(583, 692);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(21, 32, 43);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(32, 591);
            button1.Name = "button1";
            button1.Size = new Size(515, 58);
            button1.TabIndex = 3;
            button1.Text = "خروج";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(21, 32, 43);
            panel7.Controls.Add(lblLastAppt);
            panel7.Location = new Point(32, 445);
            panel7.Name = "panel7";
            panel7.Size = new Size(515, 105);
            panel7.TabIndex = 2;
            panel7.Paint += panel7_Paint;
            // 
            // lblLastAppt
            // 
            lblLastAppt.AutoSize = true;
            lblLastAppt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastAppt.ForeColor = Color.White;
            lblLastAppt.Location = new Point(120, 36);
            lblLastAppt.Name = "lblLastAppt";
            lblLastAppt.Size = new Size(62, 31);
            lblLastAppt.TabIndex = 6;
            lblLastAppt.Text = "........";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(21, 32, 43);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(lblUser);
            panel4.Location = new Point(311, 302);
            panel4.Name = "panel4";
            panel4.Size = new Size(236, 105);
            panel4.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(132, 11);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 12;
            label5.Text = "اسم المستخدم";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(80, 40);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(62, 31);
            lblUser.TabIndex = 11;
            lblUser.Text = "........";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(21, 32, 43);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(lblAge);
            panel5.Location = new Point(32, 159);
            panel5.Name = "panel5";
            panel5.Size = new Size(236, 105);
            panel5.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(191, 9);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 10;
            label3.Text = "العمر";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.ForeColor = Color.White;
            lblAge.Location = new Point(78, 36);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(62, 31);
            lblAge.TabIndex = 9;
            lblAge.Text = "........";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(21, 32, 43);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(lblGender);
            panel6.Location = new Point(311, 159);
            panel6.Name = "panel6";
            panel6.Size = new Size(236, 105);
            panel6.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(183, 9);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 10;
            label4.Text = "الجنس";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGender.ForeColor = Color.White;
            lblGender.Location = new Point(80, 36);
            lblGender.Name = "lblGender";
            lblGender.RightToLeft = RightToLeft.Yes;
            lblGender.Size = new Size(62, 31);
            lblGender.TabIndex = 9;
            lblGender.Text = "........";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(21, 32, 43);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(lblBlood);
            panel3.Location = new Point(32, 302);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 105);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(153, 11);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 6;
            label1.Text = "فصيلة الدم";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlood
            // 
            lblBlood.AutoSize = true;
            lblBlood.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBlood.ForeColor = Color.White;
            lblBlood.Location = new Point(78, 40);
            lblBlood.Name = "lblBlood";
            lblBlood.Size = new Size(62, 31);
            lblBlood.TabIndex = 5;
            lblBlood.Text = "........";
            // 
            // PatientDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 678);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MaximumSize = new Size(584, 725);
            MinimumSize = new Size(584, 725);
            Name = "PatientDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PatientDetailsForm";
            Load += PatientDetailsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
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
    }
}