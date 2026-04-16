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
            button2 = new Button();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label10 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel8 = new Panel();
            label5 = new Label();
            lblTodayAppts = new Label();
            panel6 = new Panel();
            label11 = new Label();
            lblPatientsCount = new Label();
            panelWeekPresc = new Panel();
            lblWeekPrescTitle = new Label();
            lblWeekPresc = new Label();
            panel10 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel15 = new Panel();
            textBox1 = new TextBox();
            label20 = new Label();
            panelPrescriptions = new Panel();
            flowLayoutPanelPrescriptions = new FlowLayoutPanel();
            lblPrescTitle = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panelWeekPresc.SuspendLayout();
            panel10.SuspendLayout();
            panel15.SuspendLayout();
            panelPrescriptions.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(21, 32, 43);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-11, -2);
            panel1.Margin = new Padding(5, 5, 5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(437, 1248);
            panel1.TabIndex = 0;
            panel1.Paint += Panel1_Paint;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.FlatAppearance.BorderColor = Color.Gray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Firebrick;
            button2.Location = new Point(31, 1126);
            button2.Margin = new Padding(5, 5, 5, 5);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(411, 80);
            button2.TabIndex = 10;
            button2.Text = "حذف الحساب   🗑️";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            button1.Location = new Point(31, 1050);
            button1.Margin = new Padding(5, 5, 5, 5);
            button1.Name = "button1";
            button1.Size = new Size(432, 80);
            button1.TabIndex = 9;
            button1.Text = "🚪    تسجيل الخروج";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // radioButton1
            // 
            radioButton1.Appearance = Appearance.Button;
            radioButton1.FlatAppearance.BorderColor = Color.Gray;
            radioButton1.FlatAppearance.BorderSize = 0;
            radioButton1.FlatAppearance.CheckedBackColor = Color.FromArgb(37, 99, 235);
            radioButton1.FlatStyle = FlatStyle.Flat;
            radioButton1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            radioButton1.ForeColor = Color.White;
            radioButton1.ImageAlign = ContentAlignment.MiddleLeft;
            radioButton1.Location = new Point(31, 296);
            radioButton1.Margin = new Padding(5, 5, 5, 5);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(379, 72);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "🏠    الرئيسية\n";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += RadioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.Appearance = Appearance.Button;
            radioButton2.FlatAppearance.BorderColor = Color.Gray;
            radioButton2.FlatAppearance.BorderSize = 0;
            radioButton2.FlatAppearance.CheckedBackColor = Color.FromArgb(37, 99, 235);
            radioButton2.FlatStyle = FlatStyle.Flat;
            radioButton2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            radioButton2.ForeColor = Color.White;
            radioButton2.ImageAlign = ContentAlignment.MiddleLeft;
            radioButton2.Location = new Point(31, 378);
            radioButton2.Margin = new Padding(5, 5, 5, 5);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(379, 72);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "👥    المرضى";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += RadioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.Appearance = Appearance.Button;
            radioButton3.FlatAppearance.BorderColor = Color.Gray;
            radioButton3.FlatAppearance.BorderSize = 0;
            radioButton3.FlatAppearance.CheckedBackColor = Color.FromArgb(37, 99, 235);
            radioButton3.FlatStyle = FlatStyle.Flat;
            radioButton3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            radioButton3.ForeColor = Color.White;
            radioButton3.ImageAlign = ContentAlignment.MiddleLeft;
            radioButton3.Location = new Point(31, 459);
            radioButton3.Margin = new Padding(5, 5, 5, 5);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(379, 72);
            radioButton3.TabIndex = 11;
            radioButton3.TabStop = true;
            radioButton3.Text = "📝    الروشتات";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += RadioButton3_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(148, 163, 184);
            label2.Location = new Point(286, 198);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 38);
            label2.TabIndex = 4;
            label2.Text = "التخصص";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(241, 245, 249);
            label1.Location = new Point(242, 138);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 40);
            label1.TabIndex = 1;
            label1.Text = "اسم الطبيب";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(21, 32, 43);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 21);
            pictureBox1.Margin = new Padding(5, 5, 5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Location = new Point(0, 1010);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(437, 3);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Location = new Point(0, 258);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(437, 3);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(13, 17, 23);
            panel4.Controls.Add(flowLayoutPanel2);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panelWeekPresc);
            panel4.Location = new Point(408, -2);
            panel4.Margin = new Padding(5, 5, 5, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(1916, 1248);
            panel4.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(21, 32, 43);
            flowLayoutPanel2.Controls.Add(label10);
            flowLayoutPanel2.Location = new Point(177, 659);
            flowLayoutPanel2.Margin = new Padding(5, 5, 5, 5);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(0, 16, 0, 0);
            flowLayoutPanel2.Size = new Size(1596, 506);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(5, 16);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(156, 38);
            label10.TabIndex = 7;
            label10.Text = "مواعيد اليوم";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1644, 35);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 50);
            label4.TabIndex = 1;
            label4.Text = "التاريخ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(78, 35);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(141, 50);
            label3.TabIndex = 0;
            label3.Text = "الرئيسية";
            label3.Click += Label3_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(21, 32, 43);
            panel8.Controls.Add(label5);
            panel8.Controls.Add(lblTodayAppts);
            panel8.Location = new Point(1050, 179);
            panel8.Margin = new Padding(5, 5, 5, 5);
            panel8.Name = "panel8";
            panel8.Size = new Size(723, 270);
            panel8.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(0, 0);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(156, 38);
            label5.TabIndex = 7;
            label5.Text = "مواعيد اليوم";
            // 
            // lblTodayAppts
            // 
            lblTodayAppts.AutoSize = true;
            lblTodayAppts.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodayAppts.ForeColor = Color.FromArgb(37, 99, 235);
            lblTodayAppts.Location = new Point(318, 107);
            lblTodayAppts.Margin = new Padding(5, 0, 5, 0);
            lblTodayAppts.Name = "lblTodayAppts";
            lblTodayAppts.Size = new Size(51, 71);
            lblTodayAppts.TabIndex = 6;
            lblTodayAppts.Text = "-";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(21, 32, 43);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(lblPatientsCount);
            panel6.Location = new Point(177, 179);
            panel6.Margin = new Padding(5, 5, 5, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(723, 270);
            panel6.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(0, 0);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(190, 38);
            label11.TabIndex = 5;
            label11.Text = "إجمالي المرضى";
            // 
            // lblPatientsCount
            // 
            lblPatientsCount.AutoSize = true;
            lblPatientsCount.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPatientsCount.ForeColor = Color.White;
            lblPatientsCount.Location = new Point(312, 107);
            lblPatientsCount.Margin = new Padding(5, 0, 5, 0);
            lblPatientsCount.Name = "lblPatientsCount";
            lblPatientsCount.Size = new Size(51, 71);
            lblPatientsCount.TabIndex = 0;
            lblPatientsCount.Text = "-";
            lblPatientsCount.Click += Label6_Click;
            // 
            // panelWeekPresc
            // 
            panelWeekPresc.BackColor = Color.FromArgb(21, 32, 43);
            panelWeekPresc.Controls.Add(lblWeekPrescTitle);
            panelWeekPresc.Controls.Add(lblWeekPresc);
            panelWeekPresc.Location = new Point(177, 515);
            panelWeekPresc.Margin = new Padding(5, 5, 5, 5);
            panelWeekPresc.Name = "panelWeekPresc";
            panelWeekPresc.Size = new Size(1596, 128);
            panelWeekPresc.TabIndex = 8;
            // 
            // lblWeekPrescTitle
            // 
            lblWeekPrescTitle.AutoSize = true;
            lblWeekPrescTitle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWeekPrescTitle.ForeColor = Color.Gray;
            lblWeekPrescTitle.Location = new Point(0, 0);
            lblWeekPrescTitle.Margin = new Padding(5, 0, 5, 0);
            lblWeekPrescTitle.Name = "lblWeekPrescTitle";
            lblWeekPrescTitle.Size = new Size(247, 38);
            lblWeekPrescTitle.TabIndex = 0;
            lblWeekPrescTitle.Text = "روشتات هذا الأسبوع";
            // 
            // lblWeekPresc
            // 
            lblWeekPresc.AutoSize = true;
            lblWeekPresc.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWeekPresc.ForeColor = Color.FromArgb(106, 191, 106);
            lblWeekPresc.Location = new Point(715, 32);
            lblWeekPresc.Margin = new Padding(5, 0, 5, 0);
            lblWeekPresc.Name = "lblWeekPresc";
            lblWeekPresc.Size = new Size(51, 71);
            lblWeekPresc.TabIndex = 1;
            lblWeekPresc.Text = "-";
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(13, 17, 23);
            panel10.Controls.Add(flowLayoutPanel1);
            panel10.Controls.Add(panel15);
            panel10.Controls.Add(label20);
            panel10.Location = new Point(408, -2);
            panel10.Margin = new Padding(5, 5, 5, 5);
            panel10.Name = "panel10";
            panel10.Size = new Size(1932, 1259);
            panel10.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(21, 32, 43);
            flowLayoutPanel1.Location = new Point(140, 258);
            flowLayoutPanel1.Margin = new Padding(5, 5, 5, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1633, 866);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(21, 32, 43);
            panel15.Controls.Add(textBox1);
            panel15.Location = new Point(1295, 138);
            panel15.Margin = new Padding(5, 5, 5, 5);
            panel15.Name = "panel15";
            panel15.Padding = new Padding(32, 32, 32, 32);
            panel15.Size = new Size(471, 98);
            panel15.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(21, 32, 43);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(32, 32);
            textBox1.Margin = new Padding(5, 5, 5, 5);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "بحث عن مريض...";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(407, 39);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += TextBox1_TextChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(241, 245, 249);
            label20.Location = new Point(78, 35);
            label20.Margin = new Padding(5, 0, 5, 0);
            label20.Name = "label20";
            label20.Size = new Size(227, 50);
            label20.TabIndex = 0;
            label20.Text = "قائمة المرضى";
            // 
            // panelPrescriptions
            // 
            panelPrescriptions.BackColor = Color.FromArgb(13, 17, 23);
            panelPrescriptions.Controls.Add(flowLayoutPanelPrescriptions);
            panelPrescriptions.Controls.Add(lblPrescTitle);
            panelPrescriptions.Location = new Point(408, -2);
            panelPrescriptions.Margin = new Padding(5, 5, 5, 5);
            panelPrescriptions.Name = "panelPrescriptions";
            panelPrescriptions.Size = new Size(1932, 1259);
            panelPrescriptions.TabIndex = 5;
            panelPrescriptions.Visible = false;
            // 
            // flowLayoutPanelPrescriptions
            // 
            flowLayoutPanelPrescriptions.AutoScroll = true;
            flowLayoutPanelPrescriptions.BackColor = Color.FromArgb(13, 17, 23);
            flowLayoutPanelPrescriptions.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelPrescriptions.Location = new Point(140, 128);
            flowLayoutPanelPrescriptions.Margin = new Padding(5, 5, 5, 5);
            flowLayoutPanelPrescriptions.Name = "flowLayoutPanelPrescriptions";
            flowLayoutPanelPrescriptions.Size = new Size(1633, 992);
            flowLayoutPanelPrescriptions.TabIndex = 1;
            flowLayoutPanelPrescriptions.WrapContents = false;
            // 
            // lblPrescTitle
            // 
            lblPrescTitle.AutoSize = true;
            lblPrescTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrescTitle.ForeColor = Color.FromArgb(241, 245, 249);
            lblPrescTitle.Location = new Point(78, 35);
            lblPrescTitle.Margin = new Padding(5, 0, 5, 0);
            lblPrescTitle.Name = "lblPrescTitle";
            lblPrescTitle.Size = new Size(251, 50);
            lblPrescTitle.TabIndex = 0;
            lblPrescTitle.Text = "قائمة الروشتات";
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2306, 1189);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel10);
            Controls.Add(panelPrescriptions);
            Margin = new Padding(5, 5, 5, 5);
            MaximizeBox = false;
            MaximumSize = new Size(2332, 1260);
            MinimumSize = new Size(2332, 1260);
            Name = "DoctorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "لوحة تحكم الطبيب";
            FormClosed += DoctorForm_FormClosed;
            Load += DoctorForm_Load;
            SizeChanged += DoctorForm_SizeChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panelWeekPresc.ResumeLayout(false);
            panelWeekPresc.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panelPrescriptions.ResumeLayout(false);
            panelPrescriptions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private Panel panel4;
        private Label label3;
        private Label label4;
        private Panel panel6;
        private Label lblPatientsCount;
        private Panel panel8;
        private Label label5;
        private Label lblTodayAppts;
        private Label label11;
        private Label label10;
        private Panel panel10;
        private Label label20;
        private TextBox textBox1;
        private Panel panel15;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button2;
        private RadioButton radioButton3;
        private Panel panelWeekPresc;
        private Label lblWeekPrescTitle;
        private Label lblWeekPresc;
        private Panel panelPrescriptions;
        private FlowLayoutPanel flowLayoutPanelPrescriptions;
        private Label lblPrescTitle;
    }
}