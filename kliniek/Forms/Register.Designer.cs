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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel1 = new Panel();
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
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 23, 42);
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
            panel1.Location = new Point(370, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(594, 661);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(21, 32, 43);
            label14.ForeColor = Color.White;
            label14.Location = new Point(171, 274);
            label14.Name = "label14";
            label14.Size = new Size(50, 20);
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
            comboBox2.ItemHeight = 23;
            comboBox2.Items.AddRange(new object[] { "ذكر", "أنثى" });
            comboBox2.Location = new Point(90, 303);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(131, 31);
            comboBox2.TabIndex = 34;
            // 
            // Age
            // 
            Age.BackColor = Color.FromArgb(21, 32, 43);
            Age.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Age.ForeColor = Color.White;
            Age.Location = new Point(90, 216);
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
            label13.Location = new Point(179, 193);
            label13.Name = "label13";
            label13.Size = new Size(42, 20);
            label13.TabIndex = 32;
            label13.Text = "العمر";
            // 
            // FullName
            // 
            FullName.BackColor = Color.FromArgb(21, 32, 43);
            FullName.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FullName.ForeColor = Color.White;
            FullName.Location = new Point(231, 216);
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
            label12.Location = new Point(436, 193);
            label12.Name = "label12";
            label12.Size = new Size(89, 20);
            label12.TabIndex = 30;
            label12.Text = "الإسم الثلاثي";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(353, 432);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 29;
            label11.Text = "التخصص";
            label11.Visible = false;
            label11.Click += label11_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(21, 32, 43);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.ItemHeight = 23;
            comboBox1.Items.AddRange(new object[] { "GeneralPractice,", "    Cardiology,", "    Pediatrics,", "    Dermatology,", "    Orthopedics,", "    Neurology,", "    Psychiatry,", "    Ophthalmology,", "    GeneralSurgery," });
            comboBox1.Location = new Point(174, 459);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(252, 31);
            comboBox1.TabIndex = 28;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(33, 100, 180);
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.FromArgb(33, 100, 180);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = Color.FromArgb(33, 100, 180);
            linkLabel1.Location = new Point(193, 615);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(28, 20);
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
            label10.Location = new Point(221, 618);
            label10.Name = "label10";
            label10.Size = new Size(217, 17);
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
            button1.Location = new Point(231, 509);
            button1.Name = "button1";
            button1.Size = new Size(138, 40);
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
            PassWord.Location = new Point(90, 378);
            PassWord.Name = "PassWord";
            PassWord.PlaceholderText = "كلمة المرور";
            PassWord.Size = new Size(435, 37);
            PassWord.TabIndex = 24;
            PassWord.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(445, 355);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 23;
            label9.Text = "كلمة المرور";
            label9.Click += label9_Click;
            // 
            // UserName
            // 
            UserName.BackColor = Color.FromArgb(21, 32, 43);
            UserName.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserName.ForeColor = Color.White;
            UserName.Location = new Point(231, 297);
            UserName.Name = "UserName";
            UserName.PlaceholderText = "اسم المستخدم";
            UserName.Size = new Size(294, 37);
            UserName.TabIndex = 22;
            UserName.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(424, 274);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 21;
            label8.Text = "اسم المستخدم";
            label8.Click += label8_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(patient);
            groupBox1.Controls.Add(Doctor);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(127, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 75);
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
            patient.Location = new Point(179, 18);
            patient.Name = "patient";
            patient.Size = new Size(162, 46);
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
            Doctor.Location = new Point(6, 18);
            Doctor.Name = "Doctor";
            Doctor.Size = new Size(167, 45);
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
            label7.Location = new Point(403, 39);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(161, 25);
            label7.TabIndex = 19;
            label7.Text = "أنشئ حسابا للمتابعة";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(480, 11);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(96, 28);
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
            panel2.Location = new Point(-7, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(380, 664);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(142, 142);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(117, 282);
            label5.Name = "label5";
            label5.Size = new Size(135, 25);
            label5.TabIndex = 10;
            label5.Text = "نظام إداري كامل";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(84, 509);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(188, 25);
            label4.TabIndex = 9;
            label4.Text = "وصفات طبية رقمية ✅";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(84, 465);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(195, 25);
            label3.TabIndex = 8;
            label3.Text = "سجلات المرضى آمنة ✅";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(84, 416);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(203, 25);
            label2.TabIndex = 7;
            label2.Text = "إدارة المواعيد بسهولة ✅";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(142, 244);
            label1.Name = "label1";
            label1.Size = new Size(88, 38);
            label1.TabIndex = 6;
            label1.Text = "Clinic";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 642);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MaximumSize = new Size(976, 689);
            MinimumSize = new Size(976, 689);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            FormClosed += Register_FormClosed;
            Load += Register_Load;
            Leave += Register_Leave;
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
    }
}