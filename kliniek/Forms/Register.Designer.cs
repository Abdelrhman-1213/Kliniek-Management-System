namespace kliniek.Forms
{
    partial class Register
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel1 = new Panel();
            txtDescription = new TextBox();
            DoctorCode = new TextBox();
            label15 = new Label();
            label14 = new Label();
            comboBox2 = new ComboBox();
            Age = new TextBox();
            label13 = new Label();
            FullName = new TextBox();
            label12 = new Label();
            label11 = new Label();
            comboBox1 = new ComboBox();
            linkLabel1 = new LinkLabel();
            label10 = new Label();
            button1 = new Button();
            PassWord = new TextBox();
            label9 = new Label();
            UserName = new TextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            patient = new RadioButton();
            Doctor = new RadioButton();
            label7 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(13, 17, 23);
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(DoctorCode);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(Age);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(FullName);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(PassWord);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(UserName);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(370, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(590, 595);
            panel1.TabIndex = 0;
           
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(21, 32, 43);
            txtDescription.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescription.ForeColor = Color.White;
            txtDescription.Location = new Point(127, 415);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "...اكتب نبذة عنك";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(347, 88);
            txtDescription.TabIndex = 38;
            txtDescription.TextAlign = HorizontalAlignment.Center;
            txtDescription.UseSystemPasswordChar = true;
            txtDescription.Visible = false;
  
            // 
            // DoctorCode
            // 
            DoctorCode.BackColor = Color.FromArgb(21, 32, 43);
            DoctorCode.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DoctorCode.ForeColor = Color.White;
            DoctorCode.Location = new Point(88, 150);
            DoctorCode.Name = "DoctorCode";
            DoctorCode.PlaceholderText = "الكود";
            DoctorCode.Size = new Size(131, 37);
            DoctorCode.TabIndex = 37;
            DoctorCode.TextAlign = HorizontalAlignment.Center;
         
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.White;
            label15.Location = new Point(150, 130);
            label15.Name = "label15";
            label15.Size = new Size(77, 18);
            label15.TabIndex = 36;
            label15.Text = "كود الطبيب";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(21, 32, 43);
            label14.ForeColor = Color.White;
            label14.Location = new Point(171, 203);
            label14.Name = "label14";
            label14.Size = new Size(50, 18);
            label14.TabIndex = 35;
            label14.Text = "الجنس";
            label14.Visible = false;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(21, 32, 43);
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox2.ForeColor = Color.White;
            comboBox2.FormattingEnabled = true;
            comboBox2.ItemHeight = 21;
            comboBox2.Items.AddRange(new object[] { "ذكر", "أنثى" });
            comboBox2.Location = new Point(88, 229);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(131, 29);
            comboBox2.TabIndex = 34;
            // 
            // Age
            // 
            Age.BackColor = Color.FromArgb(21, 32, 43);
            Age.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Age.ForeColor = Color.White;
            Age.Location = new Point(88, 152);
            Age.Name = "Age";
            Age.PlaceholderText = "العمر";
            Age.Size = new Size(131, 37);
            Age.TabIndex = 33;
            Age.TextAlign = HorizontalAlignment.Center;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.White;
            label13.Location = new Point(182, 131);
            label13.Name = "label13";
            label13.Size = new Size(38, 18);
            label13.TabIndex = 32;
            label13.Text = "العمر";
           
            // 
            // FullName
            // 
            FullName.BackColor = Color.FromArgb(21, 32, 43);
            FullName.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FullName.ForeColor = Color.White;
            FullName.Location = new Point(241, 150);
            FullName.Name = "FullName";
            FullName.PlaceholderText = "الإسم الثلاثي";
            FullName.Size = new Size(294, 37);
            FullName.TabIndex = 31;
            FullName.TextAlign = HorizontalAlignment.Center;
          
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(435, 130);
            label12.Name = "label12";
            label12.Size = new Size(94, 18);
            label12.TabIndex = 30;
            label12.Text = "الإسم الثلاثي";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(353, 345);
            label11.Name = "label11";
            label11.Size = new Size(61, 18);
            label11.TabIndex = 29;
            label11.Text = "التخصص";
            label11.Visible = false;
        
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(21, 32, 43);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.ItemHeight = 21;
            comboBox1.Items.AddRange(new object[] { "GeneralPractice,", "    Cardiology,", "    Pediatrics,", "    Dermatology,", "    Orthopedics,", "    Neurology,", "    Psychiatry,", "    Ophthalmology,", "    GeneralSurgery," });
            comboBox1.Location = new Point(174, 369);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(252, 29);
            comboBox1.TabIndex = 28;
         
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(33, 100, 180);
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.FromArgb(33, 100, 180);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = Color.FromArgb(33, 100, 180);
            linkLabel1.Location = new Point(193, 553);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(27, 18);
            linkLabel1.TabIndex = 27;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "هنا";
            linkLabel1.VisitedLinkColor = Color.FromArgb(33, 100, 180);
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(221, 557);
            label10.Name = "label10";
            label10.Size = new Size(215, 17);
            label10.TabIndex = 26;
            label10.Text = "لديك حساب بالفعل؟ سجل الدخول من ";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(37, 99, 235);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(33, 100, 180);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(231, 513);
            button1.Name = "button1";
            button1.Size = new Size(138, 36);
            button1.TabIndex = 25;
            button1.Text = "إنشاء حساب";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PassWord
            // 
            PassWord.BackColor = Color.FromArgb(21, 32, 43);
            PassWord.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PassWord.ForeColor = Color.White;
            PassWord.Location = new Point(90, 297);
            PassWord.Name = "PassWord";
            PassWord.PlaceholderText = "كلمة المرور";
            PassWord.Size = new Size(435, 37);
            PassWord.TabIndex = 24;
            PassWord.TextAlign = HorizontalAlignment.Center;
            PassWord.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(445, 275);
            label9.Name = "label9";
            label9.Size = new Size(77, 18);
            label9.TabIndex = 23;
            label9.Text = "كلمة المرور";
            
            // 
            // UserName
            // 
            UserName.BackColor = Color.FromArgb(21, 32, 43);
            UserName.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserName.ForeColor = Color.White;
            UserName.Location = new Point(241, 224);
            UserName.Name = "UserName";
            UserName.PlaceholderText = "اسم المستخدم";
            UserName.Size = new Size(294, 37);
            UserName.TabIndex = 22;
            UserName.TextAlign = HorizontalAlignment.Center;
            UserName.TextChanged += UserName_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(424, 203);
            label8.Name = "label8";
            label8.Size = new Size(107, 18);
            label8.TabIndex = 21;
            label8.Text = "اسم المستخدم";
          
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(patient);
            groupBox1.Controls.Add(Doctor);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(127, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 67);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // patient
            // 
            patient.Appearance = Appearance.Button;
            patient.Cursor = Cursors.Hand;
            patient.FlatAppearance.BorderSize = 0;
            patient.FlatAppearance.CheckedBackColor = Color.FromArgb(37, 99, 235);
            patient.FlatStyle = FlatStyle.Flat;
            patient.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            patient.ForeColor = Color.White;
            patient.Location = new Point(179, 17);
            patient.Name = "patient";
            patient.Size = new Size(162, 41);
            patient.TabIndex = 7;
            patient.TabStop = true;
            patient.Text = "مريض";
            patient.TextAlign = ContentAlignment.MiddleCenter;
            patient.UseVisualStyleBackColor = true;
            patient.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Doctor
            // 
            Doctor.Appearance = Appearance.Button;
            Doctor.Cursor = Cursors.Hand;
            Doctor.FlatAppearance.BorderSize = 0;
            Doctor.FlatAppearance.CheckedBackColor = Color.FromArgb(37, 99, 235);
            Doctor.FlatStyle = FlatStyle.Flat;
            Doctor.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Doctor.ForeColor = Color.White;
            Doctor.Location = new Point(6, 17);
            Doctor.Name = "Doctor";
            Doctor.Size = new Size(167, 41);
            Doctor.TabIndex = 8;
            Doctor.TabStop = true;
            Doctor.Text = "طبيب";
            Doctor.TextAlign = ContentAlignment.MiddleCenter;
            Doctor.UseVisualStyleBackColor = true;
            Doctor.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(403, 35);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(145, 25);
            label7.TabIndex = 19;
            label7.Text = "أنشئ حسابا للمتابعة";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(480, 10);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(105, 24);
            label6.TabIndex = 18;
            label6.Text = "مرحبا بك..";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(21, 32, 43);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-7, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(381, 598);
            panel2.TabIndex = 1;
           
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(131, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(117, 253);
            label5.Name = "label5";
            label5.Size = new Size(150, 22);
            label5.TabIndex = 10;
            label5.Text = "نظام إداري كامل";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(83, 458);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(198, 22);
            label4.TabIndex = 9;
            label4.Text = "وصفات طبية رقمية ✅";
            label4.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(83, 419);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(218, 22);
            label3.TabIndex = 8;
            label3.Text = "سجلات المرضى آمنة ✅";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(83, 374);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(222, 22);
            label2.TabIndex = 7;
            label2.Text = "إدارة المواعيد بسهولة ✅";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(131, 220);
            label1.Name = "label1";
            label1.Size = new Size(111, 34);
            label1.TabIndex = 6;
            label1.Text = "Kliniek";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 564);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(972, 611);
            MinimumSize = new Size(972, 611);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إنشاء حساب";
           
            Load += Register_Load;
            
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private LinkLabel linkLabel1;
        private Label label10;
        private Button button1;
        private TextBox PassWord;
        private Label label9;
        private TextBox UserName;
        private Label label8;
        private GroupBox groupBox1;
        private RadioButton patient;
        private RadioButton Doctor;
        private Label label7;
        private Label label6;
        private ComboBox comboBox1;
        private Label label11;
        private TextBox FullName;
        private Label label12;
        private TextBox Age;
        private Label label13;
        private Label label14;
        private ComboBox comboBox2;
        private TextBox DoctorCode;
        private Label label15;
        private TextBox txtDescription;
        private ToolTip toolTip1;
    }
}