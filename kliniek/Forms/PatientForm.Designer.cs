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
            panelRating = new Panel();
            btnSubmitRating = new Button();
            numRating = new NumericUpDown();
            comboBoxRatingDoctors = new ComboBox();
            lblRatingTitle = new Label();
            panelPatientPresc = new Panel();
            flowPrescriptions = new FlowLayoutPanel();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel10.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panelRating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRating).BeginInit();
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
            panel1.Location = new Point(-7, -8);
            panel1.MaximumSize = new Size(269, 702);
            panel1.MinimumSize = new Size(269, 702);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 702);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
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
            radioButton3.Location = new Point(19, 226);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(233, 41);
            radioButton3.TabIndex = 12;
            radioButton3.Text = "📑 الروشتات";
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
            radioButton4.Location = new Point(19, 273);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(233, 41);
            radioButton4.TabIndex = 11;
            radioButton4.Text = "💎 قيم الدكتور";
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
            button2.Location = new Point(19, 617);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(289, 60);
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
            button1.Location = new Point(19, 572);
            button1.Name = "button1";
            button1.Size = new Size(304, 60);
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
            radioButton1.Location = new Point(19, 135);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(233, 41);
            radioButton1.TabIndex = 5;
            radioButton1.Text = "🏠    الرئيسية\n";
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
            radioButton2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            radioButton2.ForeColor = Color.White;
            radioButton2.ImageAlign = ContentAlignment.MiddleLeft;
            radioButton2.Location = new Point(19, 180);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(233, 41);
            radioButton2.TabIndex = 7;
            radioButton2.Text = "📅  حجز موعد";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(142, 78);
            label1.Name = "label1";
            label1.Size = new Size(120, 22);
            label1.TabIndex = 1;
            label1.Text = "اسم المريض";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(21, 32, 43);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Location = new Point(0, 567);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(269, 3);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Location = new Point(0, 120);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(269, 3);
            panel2.TabIndex = 1;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.White;
            label20.Location = new Point(86, 19);
            label20.Name = "label20";
            label20.Size = new Size(106, 28);
            label20.TabIndex = 0;
            label20.Text = "الرئيسية\n";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(21, 32, 43);
            flowLayoutPanel1.Location = new Point(109, 180);
            flowLayoutPanel1.Margin = new Padding(246, 5, 0, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(982, 476);
            flowLayoutPanel1.TabIndex = 12;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(13, 17, 23);
            panel10.Controls.Add(label2);
            panel10.Controls.Add(label20);
            panel10.Controls.Add(flowLayoutPanel1);
            panel10.Location = new Point(251, -1);
            panel10.MaximumSize = new Size(1179, 702);
            panel10.MinimumSize = new Size(1179, 702);
            panel10.Name = "panel10";
            panel10.Size = new Size(1179, 702);
            panel10.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1013, 19);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 28);
            label2.TabIndex = 14;
            label2.Text = "التاريخ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(13, 17, 23);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(251, -1);
            panel4.Name = "panel4";
            panel4.Size = new Size(1189, 708);
            panel4.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(241, 245, 249);
            label3.Location = new Point(86, 19);
            label3.Name = "label3";
            label3.Size = new Size(121, 28);
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
            panel5.Location = new Point(86, 145);
            panel5.Name = "panel5";
            panel5.Size = new Size(1005, 487);
            panel5.TabIndex = 13;
            // 
            // lblDoctorInfo
            // 
            lblDoctorInfo.BackColor = Color.FromArgb(13, 17, 23);
            lblDoctorInfo.BorderStyle = BorderStyle.None;
            lblDoctorInfo.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDoctorInfo.ForeColor = Color.Silver;
            lblDoctorInfo.Location = new Point(379, 197);
            lblDoctorInfo.Margin = new Padding(2, 1, 2, 1);
            lblDoctorInfo.Name = "lblDoctorInfo";
            lblDoctorInfo.ReadOnly = true;
            lblDoctorInfo.Size = new Size(287, 120);
            lblDoctorInfo.TabIndex = 5;
            lblDoctorInfo.Text = "";
            lblDoctorInfo.Visible = false;
            // 
            // Ok
            // 
            Ok.BackColor = Color.FromArgb(33, 100, 180);
            Ok.FlatAppearance.BorderColor = Color.FromArgb(33, 100, 180);
            Ok.FlatStyle = FlatStyle.Flat;
            Ok.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Ok.ForeColor = Color.White;
            Ok.Location = new Point(406, 427);
            Ok.Name = "Ok";
            Ok.Size = new Size(233, 39);
            Ok.TabIndex = 4;
            Ok.Text = "حجز";
            Ok.UseVisualStyleBackColor = false;
            Ok.Click += Ok_Click;
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.FromArgb(13, 17, 23);
            comboBox3.FlatStyle = FlatStyle.Flat;
            comboBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox3.ForeColor = Color.White;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(379, 378);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(287, 30);
            comboBox3.TabIndex = 3;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.White;
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(13, 17, 23);
            dateTimePicker1.CalendarTitleBackColor = Color.FromArgb(13, 17, 23);
            dateTimePicker1.CalendarTitleForeColor = Color.White;
            dateTimePicker1.CalendarTrailingForeColor = Color.FromArgb(13, 17, 23);
            dateTimePicker1.Location = new Point(379, 333);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(287, 27);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(13, 17, 23);
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.ForeColor = Color.White;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(379, 150);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(287, 30);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(13, 17, 23);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(379, 77);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(287, 30);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // panelRating
            // 
            panelRating.BackColor = Color.FromArgb(21, 32, 43);
            panelRating.Controls.Add(btnSubmitRating);
            panelRating.Controls.Add(numRating);
            panelRating.Controls.Add(comboBoxRatingDoctors);
            panelRating.Controls.Add(lblRatingTitle);
            panelRating.Location = new Point(265, 0);
            panelRating.Margin = new Padding(3, 4, 3, 4);
            panelRating.Name = "panelRating";
            panelRating.Size = new Size(1179, 702);
            panelRating.TabIndex = 13;
            panelRating.Visible = false;
            panelRating.Paint += panelRating_Paint;
            // 
            // btnSubmitRating
            // 
            btnSubmitRating.BackColor = SystemColors.Highlight;
            btnSubmitRating.Cursor = Cursors.Hand;
            btnSubmitRating.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitRating.Location = new Point(406, 369);
            btnSubmitRating.Margin = new Padding(3, 4, 3, 4);
            btnSubmitRating.Name = "btnSubmitRating";
            btnSubmitRating.Size = new Size(179, 69);
            btnSubmitRating.TabIndex = 8;
            btnSubmitRating.Text = "تأكيد التقييم";
            btnSubmitRating.UseVisualStyleBackColor = false;
            btnSubmitRating.Click += btnSubmitRating_Click;
            // 
            // numRating
            // 
            numRating.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numRating.Location = new Point(378, 252);
            numRating.Margin = new Padding(3, 4, 3, 4);
            numRating.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numRating.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRating.Name = "numRating";
            numRating.Size = new Size(232, 45);
            numRating.TabIndex = 7;
            numRating.TextAlign = HorizontalAlignment.Center;
            numRating.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // comboBoxRatingDoctors
            // 
            comboBoxRatingDoctors.FormattingEnabled = true;
            comboBoxRatingDoctors.Location = new Point(352, 152);
            comboBoxRatingDoctors.Margin = new Padding(3, 4, 3, 4);
            comboBoxRatingDoctors.Name = "comboBoxRatingDoctors";
            comboBoxRatingDoctors.Size = new Size(300, 26);
            comboBoxRatingDoctors.TabIndex = 6;
            toolTip1.SetToolTip(comboBoxRatingDoctors, "قيم من 10");
            // 
            // lblRatingTitle
            // 
            lblRatingTitle.AutoSize = true;
            lblRatingTitle.Font = new Font("Bauhaus 93", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRatingTitle.ForeColor = Color.White;
            lblRatingTitle.Location = new Point(352, 48);
            lblRatingTitle.Name = "lblRatingTitle";
            lblRatingTitle.Size = new Size(292, 50);
            lblRatingTitle.TabIndex = 5;
            lblRatingTitle.Text = "اختر الدكتور لتقييمه";
            // 
            // panelPatientPresc
            // 
            panelPatientPresc.BackColor = Color.FromArgb(13, 17, 23);
            panelPatientPresc.Controls.Add(flowPrescriptions);
            panelPatientPresc.Location = new Point(265, 0);
            panelPatientPresc.Margin = new Padding(3, 4, 3, 4);
            panelPatientPresc.Name = "panelPatientPresc";
            panelPatientPresc.Size = new Size(1179, 702);
            panelPatientPresc.TabIndex = 7;
            panelPatientPresc.Visible = false;
            // 
            // flowPrescriptions
            // 
            flowPrescriptions.AutoScroll = true;
            flowPrescriptions.Location = new Point(3, 0);
            flowPrescriptions.Margin = new Padding(3, 4, 3, 4);
            flowPrescriptions.Name = "flowPrescriptions";
            flowPrescriptions.Size = new Size(1005, 487);
            flowPrescriptions.TabIndex = 0;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1417, 658);
            Controls.Add(panelPatientPresc);
            Controls.Add(panelRating);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel10);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            MaximumSize = new Size(1439, 713);
            MinimumSize = new Size(1186, 662);
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
            panelRating.ResumeLayout(false);
            panelRating.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numRating).EndInit();
            panelPatientPresc.ResumeLayout(false);
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
        private Panel panelRating;
        private ToolTip toolTip1;
        private Button btnSubmitRating;
        private NumericUpDown numRating;
        private ComboBox comboBoxRatingDoctors;
        private Label lblRatingTitle;
    }
}