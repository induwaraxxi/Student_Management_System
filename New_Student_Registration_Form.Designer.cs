namespace Student_Management_System
{
    partial class New_Student_Registration_Form
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
            textBoxName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxCNO = new TextBox();
            label6 = new Label();
            textBoxFName = new TextBox();
            label7 = new Label();
            textBoxFCN = new TextBox();
            label8 = new Label();
            dateTimePickerDOB = new DateTimePicker();
            buttonCancel = new Button();
            buttonAddNewStudent = new Button();
            textBoxSubject = new TextBox();
            label9 = new Label();
            radioButtonMale = new RadioButton();
            radioButtonFemale = new RadioButton();
            textBoxAddress = new TextBox();
            label10 = new Label();
            label2 = new Label();
            textBoxid = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(244, 138);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(292, 32);
            textBoxName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 147);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 6;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 207);
            label4.Name = "label4";
            label4.Size = new Size(85, 23);
            label4.TabIndex = 8;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 263);
            label5.Name = "label5";
            label5.Size = new Size(144, 23);
            label5.TabIndex = 10;
            label5.Text = "Date Of Birthy";
            // 
            // textBoxCNO
            // 
            textBoxCNO.Location = new Point(244, 317);
            textBoxCNO.Name = "textBoxCNO";
            textBoxCNO.Size = new Size(292, 32);
            textBoxCNO.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 326);
            label6.Name = "label6";
            label6.Size = new Size(177, 23);
            label6.TabIndex = 12;
            label6.Text = "Contact Number";
            // 
            // textBoxFName
            // 
            textBoxFName.Location = new Point(244, 517);
            textBoxFName.Name = "textBoxFName";
            textBoxFName.Size = new Size(292, 32);
            textBoxFName.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 526);
            label7.Name = "label7";
            label7.Size = new Size(151, 23);
            label7.TabIndex = 14;
            label7.Text = "Father's Name";
            // 
            // textBoxFCN
            // 
            textBoxFCN.Location = new Point(244, 575);
            textBoxFCN.Name = "textBoxFCN";
            textBoxFCN.Size = new Size(292, 32);
            textBoxFCN.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 584);
            label8.Name = "label8";
            label8.Size = new Size(178, 46);
            label8.TabIndex = 16;
            label8.Text = "Father's Contact \r\nNumber";
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Format = DateTimePickerFormat.Short;
            dateTimePickerDOB.Location = new Point(244, 263);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(292, 32);
            dateTimePickerDOB.TabIndex = 19;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.SteelBlue;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(316, 712);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(138, 45);
            buttonCancel.TabIndex = 21;
            buttonCancel.Text = "Close";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += button3_Click_1;
            // 
            // buttonAddNewStudent
            // 
            buttonAddNewStudent.BackColor = Color.SteelBlue;
            buttonAddNewStudent.FlatStyle = FlatStyle.Flat;
            buttonAddNewStudent.ForeColor = Color.White;
            buttonAddNewStudent.Location = new Point(460, 712);
            buttonAddNewStudent.Name = "buttonAddNewStudent";
            buttonAddNewStudent.Size = new Size(138, 45);
            buttonAddNewStudent.TabIndex = 22;
            buttonAddNewStudent.Text = "Save";
            buttonAddNewStudent.UseVisualStyleBackColor = false;
            buttonAddNewStudent.Click += buttonAddNewStudent_Click;
            // 
            // textBoxSubject
            // 
            textBoxSubject.Location = new Point(244, 637);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(292, 32);
            textBoxSubject.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 646);
            label9.Name = "label9";
            label9.Size = new Size(82, 23);
            label9.TabIndex = 23;
            label9.Text = "Subject";
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(244, 205);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(80, 27);
            radioButtonMale.TabIndex = 25;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(350, 207);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(105, 27);
            radioButtonFemale.TabIndex = 26;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(244, 376);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(292, 117);
            textBoxAddress.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(35, 385);
            label10.Name = "label10";
            label10.Size = new Size(88, 23);
            label10.TabIndex = 27;
            label10.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(179, 19);
            label2.Name = "label2";
            label2.Size = new Size(269, 37);
            label2.TabIndex = 29;
            label2.Text = "Add New Student";
            // 
            // textBoxid
            // 
            textBoxid.Location = new Point(244, 79);
            textBoxid.Name = "textBoxid";
            textBoxid.Size = new Size(292, 32);
            textBoxid.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 88);
            label1.Name = "label1";
            label1.Size = new Size(30, 23);
            label1.TabIndex = 30;
            label1.Text = "ID";
            // 
            // New_Student_Registration_Form
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 780);
            Controls.Add(textBoxid);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBoxAddress);
            Controls.Add(label10);
            Controls.Add(radioButtonFemale);
            Controls.Add(radioButtonMale);
            Controls.Add(textBoxSubject);
            Controls.Add(label9);
            Controls.Add(buttonAddNewStudent);
            Controls.Add(buttonCancel);
            Controls.Add(dateTimePickerDOB);
            Controls.Add(textBoxFCN);
            Controls.Add(label8);
            Controls.Add(textBoxFName);
            Controls.Add(label7);
            Controls.Add(textBoxCNO);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "New_Student_Registration_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New_Student_Registration_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxName;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxCNO;
        private Label label6;
        private TextBox textBoxFName;
        private Label label7;
        private TextBox textBoxFCN;
        private Label label8;
        private DateTimePicker dateTimePickerDOB;
        private Button buttonCancel;
        private Button buttonAddNewStudent;
        private TextBox textBoxSubject;
        private Label label9;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonFemale;
        private TextBox textBoxAddress;
        private Label label10;
        private Label label2;
        private TextBox textBoxid;
        private Label label1;
    }
}