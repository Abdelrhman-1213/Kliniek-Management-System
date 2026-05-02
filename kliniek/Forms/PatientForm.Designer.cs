namespace kliniek.Forms
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            panel1 = new Panel();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            button2 = new Button();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            flowPrescriptions = new FlowLayoutPanel();
            label20 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel10 = new Panel();
            label2 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            panel4 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            lblDoctorInfo = new RichTextBox();
            Ok = new Button();
            comboBox3 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            panelPatientPresc = new Panel();
            label5 = new Label();
            label4 = new Label();
            toolTip1 = new ToolTip(components);
            panel6 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel10.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panelPatientPresc.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(21, 32, 43);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-6, -9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.MaximumSize = new Size(235, 585);
            panel1.MinimumSize = new Size(235, 585);
            panel1.Name = "panel1";
            panel1.Size = new Size(235, 585);
            panel1.TabIndex = 0;

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
            radioButton3.Location = new Point(17, 189);
            radioButton3.Margin = new Padding(3, 2, 3, 2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(204, 34);
            radioButton3.TabIndex = 12;
            radioButton3.Text = "الروشتات 📑 ";
            radioButton3.TextAlign = ContentAlignment.MiddleRight;
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged_1;
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
            radioButton4.Location = new Point(17, 227);
            radioButton4.Margin = new Padding(3, 2, 3, 2);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(204, 34);
            radioButton4.TabIndex = 11;
            radioButton4.Text = "قيم الدكتور 💎 ";
            radioButton4.TextAlign = ContentAlignment.MiddleRight;
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.FlatAppearance.BorderColor = Color.Gray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 33, 33);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(192, 0, 0);
            button2.Location = new Point(17, 514);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(253, 50);
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
            button1.Location = new Point(17, 477);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(266, 50);
            button1.TabIndex = 9;
            button1.Text = "🚪    تسجيل الخروج";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            radioButton1.Location = new Point(17, 112);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(204, 34);
            radioButton1.TabIndex = 5;
            radioButton1.Text = "الصفحة الرئيسية 🏠\r\n";
            radioButton1.TextAlign = ContentAlignment.MiddleRight;
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.Appearance = Appearance.Button;
            radioButton2.FlatAppearance.BorderColor = Color.Gray;
            radioButton2.FlatAppearance.BorderSize = 0;
            radioButton2.FlatAppearance.CheckedBackColor = Color.FromArgb(33, 100, 180);
            radioButton2.FlatStyle = FlatStyle.Flat;
            radioButton2.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = Color.White;
            radioButton2.ImageAlign = ContentAlignment.MiddleLeft;
            radioButton2.Location = new Point(17, 150);
            radioButton2.Margin = new Padding(3, 2, 3, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(204, 34);
            radioButton2.TabIndex = 7;
            radioButton2.Text = "حجز موعد  📅";
            radioButton2.TextAlign = ContentAlignment.MiddleRight;
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(49, 68);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 1;
            label1.Text = "اسم المريض";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(21, 32, 43);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 10);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Location = new Point(0, 472);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(235, 2);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Location = new Point(0, 100);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 2);
            panel2.TabIndex = 1;
            // 
            // flowPrescriptions
            // 
            flowPrescriptions.AutoScroll = true;
            flowPrescriptions.BackColor = Color.FromArgb(13, 17, 23);
            flowPrescriptions.Location = new Point(12, 44);
            flowPrescriptions.Name = "flowPrescriptions";
            flowPrescriptions.Size = new Size(1028, 525);
            flowPrescriptions.TabIndex = 0;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.White;
            label20.Location = new Point(66, 16);
            label20.Name = "label20";
            label20.Size = new Size(73, 25);
            label20.TabIndex = 0;
            label20.Text = "الرئيسية\n";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(21, 32, 43);
            flowLayoutPanel1.Location = new Point(75, 106);
            flowLayoutPanel1.Margin = new Padding(215, 4, 0, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(879, 461);
            flowLayoutPanel1.TabIndex = 12;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(13, 17, 23);
            panel10.Controls.Add(label2);
            panel10.Controls.Add(label20);
            panel10.Controls.Add(flowLayoutPanel1);
            panel10.Location = new Point(220, -1);
            panel10.Margin = new Padding(3, 2, 3, 2);
            panel10.MaximumSize = new Size(1032, 585);
            panel10.MinimumSize = new Size(1032, 585);
            panel10.Name = "panel10";
            panel10.Size = new Size(1032, 585);
            panel10.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(886, 16);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 14;
            label2.Text = "التاريخ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(13, 17, 23);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(220, -1);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1040, 590);
            panel4.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(241, 245, 249);
            label3.Location = new Point(75, 16);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 0;
            label3.Text = "حجز موعد";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(21, 32, 43);
            panel5.Controls.Add(lblDoctorInfo);
            panel5.Controls.Add(Ok);
            panel5.Controls.Add(comboBox3);
            panel5.Controls.Add(dateTimePicker1);
            panel5.Controls.Add(comboBox2);
            panel5.Controls.Add(comboBox1);
            panel5.Location = new Point(75, 121);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(879, 406);
            panel5.TabIndex = 13;
            // 
            // lblDoctorInfo
            // 
            lblDoctorInfo.BackColor = Color.FromArgb(13, 17, 23);
            lblDoctorInfo.BorderStyle = BorderStyle.None;
            lblDoctorInfo.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDoctorInfo.ForeColor = Color.Silver;
            lblDoctorInfo.Location = new Point(332, 164);
            lblDoctorInfo.Margin = new Padding(2, 1, 2, 1);
            lblDoctorInfo.Name = "lblDoctorInfo";
            lblDoctorInfo.ReadOnly = true;
            lblDoctorInfo.Size = new Size(251, 100);
            lblDoctorInfo.TabIndex = 5;
            lblDoctorInfo.Text = "";
            // 
            // Ok
            // 
            Ok.BackColor = Color.FromArgb(33, 100, 180);
            Ok.FlatAppearance.BorderColor = Color.FromArgb(33, 100, 180);
            Ok.FlatStyle = FlatStyle.Flat;
            Ok.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Ok.ForeColor = Color.White;
            Ok.Location = new Point(355, 356);
            Ok.Margin = new Padding(3, 2, 3, 2);
            Ok.Name = "Ok";
            Ok.Size = new Size(204, 32);
            Ok.TabIndex = 4;
            Ok.Text = "حجز";
            Ok.UseVisualStyleBackColor = false;
            Ok.Click += Ok_Click;
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.FromArgb(13, 17, 23);
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FlatStyle = FlatStyle.Flat;
            comboBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox3.ForeColor = Color.White;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(332, 315);
            comboBox3.Margin = new Padding(3, 2, 3, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(252, 27);
            comboBox3.TabIndex = 3;
         
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.Black;
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(13, 17, 23);
            dateTimePicker1.CalendarTitleBackColor = Color.FromArgb(13, 17, 23);
            dateTimePicker1.CalendarTitleForeColor = Color.Black;
            dateTimePicker1.CalendarTrailingForeColor = Color.FromArgb(13, 17, 23);
            dateTimePicker1.Location = new Point(332, 278);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(252, 23);
            dateTimePicker1.TabIndex = 2;
          
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(13, 17, 23);
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.ForeColor = Color.White;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(332, 125);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(252, 27);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(13, 17, 23);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(332, 64);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(252, 27);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // panelPatientPresc
            // 
            panelPatientPresc.BackColor = Color.FromArgb(13, 17, 23);
            panelPatientPresc.Controls.Add(label5);
            panelPatientPresc.Controls.Add(label4);
            panelPatientPresc.Controls.Add(flowPrescriptions);
            panelPatientPresc.Location = new Point(220, -1);
            panelPatientPresc.Name = "panelPatientPresc";
            panelPatientPresc.Size = new Size(1032, 585);
            panelPatientPresc.TabIndex = 7;
            panelPatientPresc.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(241, 245, 249);
            label5.Location = new Point(31, 10);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 2;
            label5.Text = "الروشتات ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(241, 245, 249);
            label4.Location = new Point(15, 10);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 1;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(13, 17, 23);
            panel6.Location = new Point(223, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1066, 605);
            panel6.TabIndex = 8;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 561);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel10);
            Controls.Add(panel6);
            Controls.Add(panelPatientPresc);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximumSize = new Size(1261, 600);
            MinimumSize = new Size(1040, 559);
            Name = "PatientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PatientForm";
            FormClosed += PatientForm_FormClosed;
            Load += PatientForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panelPatientPresc.ResumeLayout(false);
            panelPatientPresc.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel2;
        private Label label20;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel10;
        private Label label2;
        private Button button2;
        private System.Windows.Forms.Timer timer2;
        private Panel panel4;
        private Label label3;
        private Panel panel5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox3;
        private Button Ok;
        private RichTextBox lblDoctorInfo;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Panel panelPatientPresc;
        private FlowLayoutPanel flowPrescriptions;
        private ToolTip toolTip1;
        private Label label4;
        private Label label5;
        private Panel panel6;
    }
}