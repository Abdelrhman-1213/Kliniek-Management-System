namespace kliniek.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            sign_up_button = new LinkLabel();
            label10 = new Label();
            enter_button = new Button();
            password_text = new TextBox();
            label9 = new Label();
            username_text = new TextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            patient_button = new RadioButton();
            doctor_button = new RadioButton();
            label7 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(21, 32, 43);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-33, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 502);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(163, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(138, 188);
            label5.Name = "label5";
            label5.Size = new Size(150, 22);
            label5.TabIndex = 4;
            label5.Text = "نظام إداري كامل";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(101, 371);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(198, 22);
            label4.TabIndex = 3;
            label4.Text = "وصفات طبية رقمية ✅";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(101, 331);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(218, 22);
            label3.TabIndex = 2;
            label3.Text = "سجلات المرضى آمنة ✅";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(101, 287);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(222, 22);
            label2.TabIndex = 1;
            label2.Text = "إدارة المواعيد بسهولة ✅";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(163, 154);
            label1.Name = "label1";
            label1.Size = new Size(91, 34);
            label1.TabIndex = 0;
            label1.Text = "Clinic";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(13, 17, 23);
            panel2.Controls.Add(sign_up_button);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(enter_button);
            panel2.Controls.Add(password_text);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(username_text);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(359, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(518, 502);
            panel2.TabIndex = 1;
            // 
            // sign_up_button
            // 
            sign_up_button.ActiveLinkColor = Color.FromArgb(33, 100, 180);
            sign_up_button.AutoSize = true;
            sign_up_button.DisabledLinkColor = Color.FromArgb(33, 100, 180);
            sign_up_button.LinkColor = Color.FromArgb(33, 100, 180);
            sign_up_button.Location = new Point(157, 447);
            sign_up_button.Name = "sign_up_button";
            sign_up_button.Size = new Size(27, 18);
            sign_up_button.TabIndex = 17;
            sign_up_button.TabStop = true;
            sign_up_button.Text = "هنا";
            sign_up_button.VisitedLinkColor = Color.FromArgb(33, 100, 180);
            sign_up_button.LinkClicked += LinkLabel1_LinkClicked;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(185, 449);
            label10.Name = "label10";
            label10.Size = new Size(206, 17);
            label10.TabIndex = 16;
            label10.Text = "ليس لديك حساب؟ أنشء حسابا من ";
            // 
            // enter_button
            // 
            enter_button.BackColor = Color.FromArgb(37, 99, 235);
            enter_button.Cursor = Cursors.Hand;
            enter_button.FlatAppearance.BorderColor = Color.FromArgb(33, 100, 180);
            enter_button.FlatAppearance.BorderSize = 0;
            enter_button.FlatStyle = FlatStyle.Flat;
            enter_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enter_button.ForeColor = Color.White;
            enter_button.Location = new Point(199, 331);
            enter_button.Name = "enter_button";
            enter_button.Size = new Size(111, 36);
            enter_button.TabIndex = 15;
            enter_button.Text = "دخول";
            enter_button.UseVisualStyleBackColor = false;
            enter_button.Click += Button1_Click;
            // 
            // password_text
            // 
            password_text.BackColor = Color.FromArgb(21, 32, 43);
            password_text.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password_text.ForeColor = Color.White;
            password_text.Location = new Point(89, 285);
            password_text.Name = "password_text";
            password_text.PlaceholderText = "كلمة المرور";
            password_text.Size = new Size(347, 37);
            password_text.TabIndex = 14;
            password_text.TextAlign = HorizontalAlignment.Center;
            password_text.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(350, 264);
            label9.Name = "label9";
            label9.Size = new Size(77, 18);
            label9.TabIndex = 13;
            label9.Text = "كلمة المرور";
            // 
            // username_text
            // 
            username_text.BackColor = Color.FromArgb(21, 32, 43);
            username_text.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username_text.ForeColor = Color.White;
            username_text.Location = new Point(89, 213);
            username_text.Name = "username_text";
            username_text.PlaceholderText = "اسم المستخدم";
            username_text.Size = new Size(347, 37);
            username_text.TabIndex = 12;
            username_text.TextAlign = HorizontalAlignment.Center;
            username_text.KeyDown += TextBox1_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(335, 192);
            label8.Name = "label8";
            label8.Size = new Size(107, 18);
            label8.TabIndex = 10;
            label8.Text = "اسم المستخدم";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(13, 17, 23);
            groupBox1.Controls.Add(patient_button);
            groupBox1.Controls.Add(doctor_button);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(89, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 68);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // patient_button
            // 
            patient_button.Appearance = Appearance.Button;
            patient_button.Cursor = Cursors.Hand;
            patient_button.FlatAppearance.BorderSize = 0;
            patient_button.FlatAppearance.CheckedBackColor = Color.FromArgb(37, 99, 235);
            patient_button.FlatStyle = FlatStyle.Flat;
            patient_button.ForeColor = Color.White;
            patient_button.Location = new Point(179, 16);
            patient_button.Name = "patient_button";
            patient_button.Size = new Size(162, 42);
            patient_button.TabIndex = 7;
            patient_button.TabStop = true;
            patient_button.Text = "مريض";
            patient_button.TextAlign = ContentAlignment.MiddleCenter;
            patient_button.UseVisualStyleBackColor = true;
            // 
            // doctor_button
            // 
            doctor_button.Appearance = Appearance.Button;
            doctor_button.Cursor = Cursors.Hand;
            doctor_button.FlatAppearance.BorderSize = 0;
            doctor_button.FlatAppearance.CheckedBackColor = Color.FromArgb(37, 99, 235);
            doctor_button.FlatStyle = FlatStyle.Flat;
            doctor_button.ForeColor = Color.White;
            doctor_button.Location = new Point(6, 16);
            doctor_button.Name = "doctor_button";
            doctor_button.Size = new Size(167, 40);
            doctor_button.TabIndex = 8;
            doctor_button.TabStop = true;
            doctor_button.Text = "طبيب";
            doctor_button.TextAlign = ContentAlignment.MiddleCenter;
            doctor_button.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(311, 43);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(159, 25);
            label7.TabIndex = 6;
            label7.Text = "سجل الدخول للمتابعة.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(394, 18);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(105, 24);
            label6.TabIndex = 5;
            label6.Text = "مرحبا بك..";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(867, 478);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(885, 525);
            MinimizeBox = false;
            MinimumSize = new Size(885, 525);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تسجيل الدخول";
            FormClosed += LoginForm_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label6;
        private RadioButton doctor_button;
        private RadioButton patient_button;
        private GroupBox groupBox1;
        private TextBox username_text;
        private Label label8;
        private TextBox password_text;
        private Label label9;
        private Button enter_button;
        private LinkLabel sign_up_button;
        private Label label10;
    }
}