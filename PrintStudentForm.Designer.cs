namespace Student_Management_System
{
    partial class PrintStudentForm
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
            buttonAddNewStudent = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            radioButtonNo = new RadioButton();
            radioButtonYes = new RadioButton();
            label1 = new Label();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            radioButtonAll = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAddNewStudent
            // 
            buttonAddNewStudent.BackColor = Color.SteelBlue;
            buttonAddNewStudent.FlatAppearance.BorderSize = 0;
            buttonAddNewStudent.FlatStyle = FlatStyle.Flat;
            buttonAddNewStudent.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddNewStudent.ForeColor = Color.White;
            buttonAddNewStudent.Location = new Point(12, 793);
            buttonAddNewStudent.Margin = new Padding(4, 3, 4, 3);
            buttonAddNewStudent.Name = "buttonAddNewStudent";
            buttonAddNewStudent.Size = new Size(1282, 64);
            buttonAddNewStudent.TabIndex = 36;
            buttonAddNewStudent.Text = "Print to text file";
            buttonAddNewStudent.UseVisualStyleBackColor = false;
            buttonAddNewStudent.Click += buttonAddNewStudent_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 153);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1282, 623);
            dataGridView1.TabIndex = 35;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1282, 127);
            panel1.TabIndex = 37;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(radioButtonFemale);
            groupBox1.Controls.Add(radioButtonMale);
            groupBox1.Controls.Add(radioButtonAll);
            groupBox1.Location = new Point(3, -9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1276, 133);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1108, 24);
            button1.Name = "button1";
            button1.Size = new Size(152, 90);
            button1.TabIndex = 39;
            button1.Text = "Go";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(radioButtonNo);
            groupBox2.Controls.Add(radioButtonYes);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(468, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(634, 102);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(468, 57);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(152, 32);
            dateTimePicker2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(408, 64);
            label3.Name = "label3";
            label3.Size = new Size(50, 23);
            label3.TabIndex = 8;
            label3.Text = "and";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(245, 59);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(152, 32);
            dateTimePicker1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(228, 23);
            label2.TabIndex = 6;
            label2.Text = "Date of birth between";
            // 
            // radioButtonNo
            // 
            radioButtonNo.AutoSize = true;
            radioButtonNo.Checked = true;
            radioButtonNo.ForeColor = Color.White;
            radioButtonNo.Location = new Point(329, 20);
            radioButtonNo.Name = "radioButtonNo";
            radioButtonNo.Size = new Size(59, 27);
            radioButtonNo.TabIndex = 5;
            radioButtonNo.TabStop = true;
            radioButtonNo.Text = "No";
            radioButtonNo.UseVisualStyleBackColor = true;
            radioButtonNo.CheckedChanged += radioButtonNo_CheckedChanged;
            // 
            // radioButtonYes
            // 
            radioButtonYes.AutoSize = true;
            radioButtonYes.ForeColor = Color.White;
            radioButtonYes.Location = new Point(246, 20);
            radioButtonYes.Name = "radioButtonYes";
            radioButtonYes.Size = new Size(65, 27);
            radioButtonYes.TabIndex = 4;
            radioButtonYes.TabStop = true;
            radioButtonYes.Text = "Yes";
            radioButtonYes.UseVisualStyleBackColor = true;
            radioButtonYes.CheckedChanged += radioButtonYes_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(168, 23);
            label1.TabIndex = 0;
            label1.Text = "Use data range:";
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.ForeColor = Color.White;
            radioButtonFemale.Location = new Point(232, 55);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(105, 27);
            radioButtonFemale.TabIndex = 2;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.ForeColor = Color.White;
            radioButtonMale.Location = new Point(127, 55);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(80, 27);
            radioButtonMale.TabIndex = 1;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonAll
            // 
            radioButtonAll.AutoSize = true;
            radioButtonAll.Checked = true;
            radioButtonAll.ForeColor = Color.White;
            radioButtonAll.Location = new Point(44, 55);
            radioButtonAll.Name = "radioButtonAll";
            radioButtonAll.Size = new Size(56, 27);
            radioButtonAll.TabIndex = 0;
            radioButtonAll.TabStop = true;
            radioButtonAll.Text = "All";
            radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // PrintStudentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1307, 873);
            Controls.Add(buttonAddNewStudent);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PrintStudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrintStudentForm";
            Load += PrintStudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAddNewStudent;
        private DataGridView dataGridView1;
        private Panel panel1;
        private GroupBox groupBox1;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonAll;
        private GroupBox groupBox2;
        private RadioButton radioButtonNo;
        private RadioButton radioButtonYes;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Button button1;
    }
}