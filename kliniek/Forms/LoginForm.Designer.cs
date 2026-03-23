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
            linkLabel1 = new LinkLabel();
            label10 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            label9 = new Label();
            textBox1 = new TextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
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
            panel1.Size = new Size(401, 558);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(163, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(138, 209);
            label5.Name = "label5";
            label5.Size = new Size(135, 25);
            label5.TabIndex = 4;
            label5.Text = "نظام إداري كامل";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(101, 412);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(188, 25);
            label4.TabIndex = 3;
            label4.Text = "وصفات طبية رقمية ✅";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(101, 368);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(195, 25);
            label3.TabIndex = 2;
            label3.Text = "سجلات المرضى آمنة ✅";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(101, 319);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(203, 25);
            label2.TabIndex = 1;
            label2.Text = "إدارة المواعيد بسهولة ✅";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(163, 171);
            label1.Name = "label1";
            label1.Size = new Size(88, 38);
            label1.TabIndex = 0;
            label1.Text = "Clinic";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(13, 17, 23);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(359, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(518, 558);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(33, 100, 180);
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.FromArgb(33, 100, 180);
            linkLabel1.LinkColor = Color.FromArgb(33, 100, 180);
            linkLabel1.Location = new Point(157, 496);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(28, 20);
            linkLabel1.TabIndex = 17;
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
            label10.Location = new Point(185, 499);
            label10.Name = "label10";
            label10.Size = new Size(195, 17);
            label10.TabIndex = 16;
            label10.Text = "ليس لديك حساب؟ أنشء حسابا من ";
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
            button1.Location = new Point(199, 368);
            button1.Name = "button1";
            button1.Size = new Size(111, 40);
            button1.TabIndex = 15;
            button1.Text = "دخول";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(21, 32, 43);
            textBox2.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(89, 316);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "كلمة المرور";
            textBox2.Size = new Size(347, 37);
            textBox2.TabIndex = 14;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(350, 293);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 13;
            label9.Text = "كلمة المرور";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(21, 32, 43);
            textBox1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(89, 237);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "اسم المستخدم";
            textBox1.Size = new Size(347, 37);
            textBox1.TabIndex = 12;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(335, 214);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 10;
            label8.Text = "اسم المستخدم";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(13, 17, 23);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(89, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 75);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.Appearance = Appearance.Button;
            radioButton1.Cursor = Cursors.Hand;
            radioButton1.FlatAppearance.BorderSize = 0;
            radioButton1.FlatAppearance.CheckedBackColor = Color.FromArgb(37, 99, 235);
            radioButton1.FlatStyle = FlatStyle.Flat;
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(179, 18);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(162, 46);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "مريض";
            radioButton1.TextAlign = ContentAlignment.MiddleCenter;
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Click += radioButton1_Click;
            // 
            // radioButton2
            // 
            radioButton2.Appearance = Appearance.Button;
            radioButton2.Cursor = Cursors.Hand;
            radioButton2.FlatAppearance.BorderSize = 0;
            radioButton2.FlatAppearance.CheckedBackColor = Color.FromArgb(37, 99, 235);
            radioButton2.FlatStyle = FlatStyle.Flat;
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(6, 18);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(167, 45);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "طبيب";
            radioButton2.TextAlign = ContentAlignment.MiddleCenter;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(311, 48);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(176, 25);
            label7.TabIndex = 6;
            label7.Text = "سجل الدخول للمتابعة.";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(394, 20);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(96, 28);
            label6.TabIndex = 5;
            label6.Text = "مرحبا بك..";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(870, 540);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MaximizeBox = false;
            MaximumSize = new Size(888, 587);
            MinimumSize = new Size(888, 587);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "2";
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
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label8;
        private TextBox textBox2;
        private Label label9;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label10;
    }
}