namespace kliniek.Forms
{
    partial class DoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            panel1 = new Panel();
            button1 = new Button();
            radioButton4 = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel10 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel15 = new Panel();
            textBox1 = new TextBox();
            button2 = new Button();
            label20 = new Label();
            panel9 = new Panel();
            label10 = new Label();
            panel8 = new Panel();
            label5 = new Label();
            label9 = new Label();
            panel7 = new Panel();
            label7 = new Label();
            label8 = new Label();
            panel6 = new Panel();
            label11 = new Label();
            label6 = new Label();
            panel5 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel10.SuspendLayout();
            panel15.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 26, 46);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(radioButton4);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-7, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 780);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.FlatAppearance.BorderColor = Color.Gray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(19, 699);
            button1.Name = "button1";
            button1.Size = new Size(233, 42);
            button1.TabIndex = 9;
            button1.Text = "🚪    تسجيل الخروج";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton4
            // 
            radioButton4.Appearance = Appearance.Button;
            radioButton4.FlatAppearance.BorderColor = Color.Gray;
            radioButton4.FlatAppearance.BorderSize = 0;
            radioButton4.FlatAppearance.CheckedBackColor = Color.FromArgb(33, 100, 180);
            radioButton4.FlatStyle = FlatStyle.Flat;
            radioButton4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            radioButton4.ForeColor = Color.White;
            radioButton4.ImageAlign = ContentAlignment.MiddleLeft;
            radioButton4.Location = new Point(19, 338);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(233, 45);
            radioButton4.TabIndex = 8;
            radioButton4.TabStop = true;
            radioButton4.Text = "📋    الوصفات\n";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.Appearance = Appearance.Button;
            radioButton1.FlatAppearance.BorderColor = Color.Gray;
            radioButton1.FlatAppearance.BorderSize = 0;
            radioButton1.FlatAppearance.CheckedBackColor = Color.FromArgb(33, 100, 180);
            radioButton1.FlatStyle = FlatStyle.Flat;
            radioButton1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            radioButton1.ForeColor = Color.White;
            radioButton1.ImageAlign = ContentAlignment.MiddleLeft;
            radioButton1.Location = new Point(19, 185);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(233, 45);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "🏠    الرئيسية\n";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.Appearance = Appearance.Button;
            radioButton2.FlatAppearance.BorderColor = Color.Gray;
            radioButton2.FlatAppearance.BorderSize = 0;
            radioButton2.FlatAppearance.CheckedBackColor = Color.FromArgb(33, 100, 180);
            radioButton2.FlatStyle = FlatStyle.Flat;
            radioButton2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            radioButton2.ForeColor = Color.White;
            radioButton2.ImageAlign = ContentAlignment.MiddleLeft;
            radioButton2.Location = new Point(19, 236);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(233, 45);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "👥    المرضى";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.Appearance = Appearance.Button;
            radioButton3.FlatAppearance.BorderColor = Color.Gray;
            radioButton3.FlatAppearance.BorderSize = 0;
            radioButton3.FlatAppearance.CheckedBackColor = Color.FromArgb(33, 100, 180);
            radioButton3.FlatStyle = FlatStyle.Flat;
            radioButton3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            radioButton3.ForeColor = Color.White;
            radioButton3.ImageAlign = ContentAlignment.MiddleLeft;
            radioButton3.Location = new Point(19, 287);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(233, 45);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "📅    المواعيد\n";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(19, 120);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 4;
            label2.Text = "التخصص";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 95);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 1;
            label1.Text = "اسم الطبيب";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(26, 26, 46);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Location = new Point(0, 674);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(269, 2);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Location = new Point(0, 161);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(269, 2);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(28, 28, 28);
            panel4.Controls.Add(panel10);
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(251, -1);
            panel4.Name = "panel4";
            panel4.Size = new Size(1179, 780);
            panel4.TabIndex = 1;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(50, 50, 80);
            panel10.Controls.Add(flowLayoutPanel1);
            panel10.Controls.Add(panel15);
            panel10.Controls.Add(button2);
            panel10.Controls.Add(label20);
            panel10.Location = new Point(8, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(1179, 777);
            panel10.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(42, 42, 62);
            flowLayoutPanel1.Location = new Point(82, 135);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1005, 485);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(26, 26, 46);
            panel15.Controls.Add(textBox1);
            panel15.Location = new Point(647, 23);
            panel15.Name = "panel15";
            panel15.Padding = new Padding(20);
            panel15.Size = new Size(290, 61);
            panel15.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(26, 26, 46);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(20, 20);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "بحث عن مريض...";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(250, 24);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(24, 95, 165);
            button2.FlatAppearance.BorderColor = Color.FromArgb(24, 95, 165);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 95, 165);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(943, 23);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(144, 61);
            button2.TabIndex = 10;
            button2.Text = "إضافة مريض ➕";
            button2.UseVisualStyleBackColor = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.White;
            label20.Location = new Point(82, 35);
            label20.Name = "label20";
            label20.Size = new Size(142, 31);
            label20.TabIndex = 0;
            label20.Text = "قائمة المرضى";
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(38, 38, 38);
            panel9.Controls.Add(label10);
            panel9.Location = new Point(109, 322);
            panel9.Name = "panel9";
            panel9.Size = new Size(978, 403);
            panel9.TabIndex = 3;
            panel9.Paint += panel9_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(25, 12);
            label10.Name = "label10";
            label10.Size = new Size(98, 23);
            label10.TabIndex = 7;
            label10.Text = "مواعيد اليوم";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(38, 38, 38);
            panel8.Controls.Add(label5);
            panel8.Controls.Add(label9);
            panel8.Location = new Point(454, 112);
            panel8.Name = "panel8";
            panel8.Size = new Size(281, 169);
            panel8.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(19, 12);
            label5.Name = "label5";
            label5.Size = new Size(98, 23);
            label5.TabIndex = 7;
            label5.Text = "مواعيد اليوم";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(24, 95, 165);
            label9.Location = new Point(19, 86);
            label9.Name = "label9";
            label9.Size = new Size(40, 46);
            label9.TabIndex = 6;
            label9.Text = "5";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(38, 38, 38);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(label8);
            panel7.Location = new Point(806, 112);
            panel7.Name = "panel7";
            panel7.Size = new Size(281, 169);
            panel7.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(22, 12);
            label7.Name = "label7";
            label7.Size = new Size(116, 23);
            label7.TabIndex = 7;
            label7.Text = "إجمالي المرضى";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(24, 95, 165);
            label8.Location = new Point(22, 86);
            label8.Name = "label8";
            label8.Size = new Size(60, 46);
            label8.TabIndex = 6;
            label8.Text = "10";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(38, 38, 38);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(109, 112);
            panel6.Name = "panel6";
            panel6.Size = new Size(281, 169);
            panel6.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(25, 12);
            label11.Name = "label11";
            label11.Size = new Size(116, 23);
            label11.TabIndex = 5;
            label11.Text = "إجمالي المرضى";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(25, 86);
            label6.Name = "label6";
            label6.Size = new Size(60, 46);
            label6.TabIndex = 0;
            label6.Text = "10";
            label6.Click += label6_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(38, 38, 38);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(1176, 72);
            panel5.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1009, 19);
            label4.Name = "label4";
            label4.Size = new Size(75, 31);
            label4.TabIndex = 1;
            label4.Text = "التاريخ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(45, 19);
            label3.Name = "label3";
            label3.Size = new Size(91, 31);
            label3.TabIndex = 0;
            label3.Text = "الرئيسية";
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1427, 767);
            Controls.Add(panel1);
            Controls.Add(panel4);
            MaximizeBox = false;
            MaximumSize = new Size(1445, 814);
            MinimumSize = new Size(1445, 814);
            Name = "DoctorForm";
            Text = "DoctorForm";
            Load += DoctorForm_Load;
            SizeChanged += DoctorForm_SizeChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private Panel panel4;
        private Panel panel5;
        private Label label3;
        private Label label4;
        private Panel panel6;
        private Label label6;
        private Panel panel8;
        private Panel panel7;
        private Label label5;
        private Label label9;
        private Label label11;
        private Panel panel9;
        private Label label10;
        private Label label7;
        private Label label8;
        private Panel panel10;
        private Button button2;
        private Label label20;
        private TextBox textBox1;
        private Panel panel15;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}