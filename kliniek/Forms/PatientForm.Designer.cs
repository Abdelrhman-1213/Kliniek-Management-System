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
            button2 = new Button();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton3 = new RadioButton();
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
            Ok = new Button();
            comboBox3 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel10.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(21, 32, 43);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-7, -1);
            panel1.MaximumSize = new Size(269, 780);
            panel1.MinimumSize = new Size(269, 780);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 780);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
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
            button2.Location = new Point(19, 704);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(233, 42);
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
            button1.Location = new Point(19, 656);
            button1.Name = "button1";
            button1.Size = new Size(233, 42);
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
            radioButton1.Location = new Point(19, 149);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(233, 45);
            radioButton1.TabIndex = 5;
            radioButton1.Text = "🏠    الرئيسية\n";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
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
            radioButton3.Location = new Point(19, 200);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(233, 45);
            radioButton3.TabIndex = 7;
            radioButton3.Text = "📅  حجز موعد";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(142, 87);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 1;
            label1.Text = "اسم المريض";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(21, 32, 43);
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
            panel3.Location = new Point(0, 631);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(269, 2);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Location = new Point(0, 134);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(269, 2);
            panel2.TabIndex = 1;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.White;
            label20.Location = new Point(86, 22);
            label20.Name = "label20";
            label20.Size = new Size(91, 31);
            label20.TabIndex = 0;
            label20.Text = "الرئيسية\n";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(21, 32, 43);
            flowLayoutPanel1.Location = new Point(109, 200);
            flowLayoutPanel1.Margin = new Padding(246, 6, 0, 6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(982, 528);
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
            panel10.MaximumSize = new Size(1179, 780);
            panel10.MinimumSize = new Size(1179, 780);
            panel10.Name = "panel10";
            panel10.Size = new Size(1179, 780);
            panel10.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1012, 22);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 31);
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
            panel4.Size = new Size(1189, 787);
            panel4.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(241, 245, 249);
            label3.Location = new Point(86, 22);
            label3.Name = "label3";
            label3.Size = new Size(106, 31);
            label3.TabIndex = 0;
            label3.Text = "حجز موعد";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(21, 32, 43);
            panel5.Controls.Add(Ok);
            panel5.Controls.Add(comboBox3);
            panel5.Controls.Add(dateTimePicker1);
            panel5.Controls.Add(comboBox2);
            panel5.Controls.Add(comboBox1);
            panel5.Location = new Point(86, 161);
            panel5.Name = "panel5";
            panel5.Size = new Size(1005, 541);
            panel5.TabIndex = 13;
            // 
            // Ok
            // 
            Ok.BackColor = Color.FromArgb(33, 100, 180);
            Ok.FlatAppearance.BorderColor = Color.FromArgb(33, 100, 180);
            Ok.FlatStyle = FlatStyle.Flat;
            Ok.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Ok.ForeColor = Color.White;
            Ok.Location = new Point(411, 405);
            Ok.Name = "Ok";
            Ok.Size = new Size(233, 42);
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
            comboBox3.Location = new Point(380, 303);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(288, 33);
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
            dateTimePicker1.Location = new Point(380, 243);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(288, 27);
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
            comboBox2.Location = new Point(380, 167);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(288, 33);
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
            comboBox1.Location = new Point(380, 86);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(288, 33);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1427, 767);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel10);
            Margin = new Padding(2);
            MaximumSize = new Size(1445, 814);
            MinimumSize = new Size(1445, 814);
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
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
    }
}