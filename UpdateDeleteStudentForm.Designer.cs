namespace Student_Management_System
{
    partial class UpdateDeleteStudentForm
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
            textBoxAddress = new TextBox();
            label10 = new Label();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            textBoxSubject = new TextBox();
            label9 = new Label();
            buttonRemove = new Button();
            buttonEdit = new Button();
            dateTimePickerDOB = new DateTimePicker();
            textBoxFCN = new TextBox();
            label8 = new Label();
            textBoxFName = new TextBox();
            label7 = new Label();
            textBoxCNO = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBoxName = new TextBox();
            label3 = new Label();
            textBoxid = new TextBox();
            label1 = new Label();
            buttonFind = new Button();
            SuspendLayout();
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(851, 35);
            textBoxAddress.Margin = new Padding(4, 3, 4, 3);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(245, 134);
            textBoxAddress.TabIndex = 47;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F);
            label10.Location = new Point(628, 35);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(88, 23);
            label10.TabIndex = 46;
            label10.Text = "Address";
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Font = new Font("Century Gothic", 12F);
            radioButtonFemale.Location = new Point(413, 179);
            radioButtonFemale.Margin = new Padding(4, 3, 4, 3);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(105, 27);
            radioButtonFemale.TabIndex = 45;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Font = new Font("Century Gothic", 12F);
            radioButtonMale.Location = new Point(254, 177);
            radioButtonMale.Margin = new Padding(4, 3, 4, 3);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(80, 27);
            radioButtonMale.TabIndex = 44;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // textBoxSubject
            // 
            textBoxSubject.Location = new Point(851, 331);
            textBoxSubject.Margin = new Padding(4, 3, 4, 3);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(245, 32);
            textBoxSubject.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F);
            label9.Location = new Point(628, 331);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(82, 23);
            label9.TabIndex = 42;
            label9.Text = "Subject";
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.SteelBlue;
            buttonRemove.FlatStyle = FlatStyle.Flat;
            buttonRemove.Font = new Font("Century Gothic", 12F);
            buttonRemove.ForeColor = Color.White;
            buttonRemove.Location = new Point(281, 423);
            buttonRemove.Margin = new Padding(4, 3, 4, 3);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(218, 52);
            buttonRemove.TabIndex = 41;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.SteelBlue;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Century Gothic", 12F);
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Location = new Point(31, 423);
            buttonEdit.Margin = new Padding(4, 3, 4, 3);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(218, 52);
            buttonEdit.TabIndex = 40;
            buttonEdit.Text = "Update";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Format = DateTimePickerFormat.Short;
            dateTimePickerDOB.Location = new Point(254, 241);
            dateTimePickerDOB.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(245, 32);
            dateTimePickerDOB.TabIndex = 39;
            // 
            // textBoxFCN
            // 
            textBoxFCN.Location = new Point(851, 264);
            textBoxFCN.Margin = new Padding(4, 3, 4, 3);
            textBoxFCN.Name = "textBoxFCN";
            textBoxFCN.Size = new Size(245, 32);
            textBoxFCN.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F);
            label8.Location = new Point(628, 264);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(178, 46);
            label8.TabIndex = 37;
            label8.Text = "Father's Contact \r\nNumber";
            // 
            // textBoxFName
            // 
            textBoxFName.Location = new Point(851, 197);
            textBoxFName.Margin = new Padding(4, 3, 4, 3);
            textBoxFName.Name = "textBoxFName";
            textBoxFName.Size = new Size(245, 32);
            textBoxFName.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F);
            label7.Location = new Point(628, 197);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(151, 23);
            label7.TabIndex = 35;
            label7.Text = "Father's Name";
            // 
            // textBoxCNO
            // 
            textBoxCNO.Location = new Point(254, 314);
            textBoxCNO.Margin = new Padding(4, 3, 4, 3);
            textBoxCNO.Name = "textBoxCNO";
            textBoxCNO.Size = new Size(245, 32);
            textBoxCNO.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F);
            label6.Location = new Point(31, 314);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(177, 23);
            label6.TabIndex = 33;
            label6.Text = "Contact Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F);
            label5.Location = new Point(31, 241);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(144, 23);
            label5.TabIndex = 32;
            label5.Text = "Date Of Birthy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F);
            label4.Location = new Point(31, 177);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(85, 23);
            label4.TabIndex = 31;
            label4.Text = "Gender";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(254, 108);
            textBoxName.Margin = new Padding(4, 3, 4, 3);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(245, 32);
            textBoxName.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F);
            label3.Location = new Point(31, 108);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 29;
            label3.Text = "Name";
            // 
            // textBoxid
            // 
            textBoxid.Location = new Point(254, 42);
            textBoxid.Margin = new Padding(4, 3, 4, 3);
            textBoxid.Name = "textBoxid";
            textBoxid.Size = new Size(149, 32);
            textBoxid.TabIndex = 49;
            textBoxid.KeyPress += textBoxid_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F);
            label1.Location = new Point(31, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 23);
            label1.TabIndex = 48;
            label1.Text = "ID Number";
            // 
            // buttonFind
            // 
            buttonFind.BackColor = Color.SteelBlue;
            buttonFind.FlatStyle = FlatStyle.Flat;
            buttonFind.Font = new Font("Century Gothic", 12F);
            buttonFind.ForeColor = Color.White;
            buttonFind.Location = new Point(411, 42);
            buttonFind.Margin = new Padding(4, 3, 4, 3);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(88, 33);
            buttonFind.TabIndex = 50;
            buttonFind.Text = "Find";
            buttonFind.UseVisualStyleBackColor = false;
            buttonFind.Click += buttonFind_Click;
            // 
            // UpdateDeleteStudentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1133, 500);
            Controls.Add(buttonFind);
            Controls.Add(textBoxid);
            Controls.Add(label1);
            Controls.Add(textBoxAddress);
            Controls.Add(label10);
            Controls.Add(radioButtonFemale);
            Controls.Add(radioButtonMale);
            Controls.Add(textBoxSubject);
            Controls.Add(label9);
            Controls.Add(buttonRemove);
            Controls.Add(buttonEdit);
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
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UpdateDeleteStudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateDeleteStudentForm";
            Load += UpdateDeleteStudentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label10;
        private Label label9;
        private Button buttonRemove;
        private Button buttonEdit;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button buttonFind;
        internal TextBox textBoxid;
        internal TextBox textBoxName;
        internal TextBox textBoxAddress;
        internal RadioButton radioButtonFemale;
        internal RadioButton radioButtonMale;
        internal TextBox textBoxSubject;
        internal DateTimePicker dateTimePickerDOB;
        internal TextBox textBoxFCN;
        internal TextBox textBoxFName;
        internal TextBox textBoxCNO;
    }
}