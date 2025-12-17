namespace Student_Management_System
{
    partial class ManageStudentForm
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
            buttonAdd = new Button();
            buttonRemove = new Button();
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
            labelid = new Label();
            dataGridView1 = new DataGridView();
            textBoxSearch = new TextBox();
            label1 = new Label();
            buttonEdit = new Button();
            buttonReset = new Button();
            buttonSearch = new Button();
            labelTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(280, 372);
            textBoxAddress.Margin = new Padding(4, 3, 4, 3);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(351, 134);
            textBoxAddress.TabIndex = 48;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(52, 381);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(88, 23);
            label10.TabIndex = 47;
            label10.Text = "Address";
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(406, 178);
            radioButtonFemale.Margin = new Padding(4, 3, 4, 3);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(105, 27);
            radioButtonFemale.TabIndex = 46;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(280, 176);
            radioButtonMale.Margin = new Padding(4, 3, 4, 3);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(80, 27);
            radioButtonMale.TabIndex = 45;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // textBoxSubject
            // 
            textBoxSubject.Location = new Point(280, 672);
            textBoxSubject.Margin = new Padding(4, 3, 4, 3);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(351, 32);
            textBoxSubject.TabIndex = 44;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(52, 681);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(82, 23);
            label9.TabIndex = 43;
            label9.Text = "Subject";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.SteelBlue;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(43, 739);
            buttonAdd.Margin = new Padding(4, 3, 4, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(141, 52);
            buttonAdd.TabIndex = 42;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.SteelBlue;
            buttonRemove.FlatStyle = FlatStyle.Flat;
            buttonRemove.ForeColor = Color.White;
            buttonRemove.Location = new Point(341, 739);
            buttonRemove.Margin = new Padding(4, 3, 4, 3);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(141, 52);
            buttonRemove.TabIndex = 41;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Format = DateTimePickerFormat.Short;
            dateTimePickerDOB.Location = new Point(280, 242);
            dateTimePickerDOB.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(351, 32);
            dateTimePickerDOB.TabIndex = 40;
            // 
            // textBoxFCN
            // 
            textBoxFCN.Location = new Point(280, 601);
            textBoxFCN.Margin = new Padding(4, 3, 4, 3);
            textBoxFCN.Name = "textBoxFCN";
            textBoxFCN.Size = new Size(351, 32);
            textBoxFCN.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(52, 610);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(178, 46);
            label8.TabIndex = 38;
            label8.Text = "Father's Contact \r\nNumber";
            // 
            // textBoxFName
            // 
            textBoxFName.Location = new Point(280, 534);
            textBoxFName.Margin = new Padding(4, 3, 4, 3);
            textBoxFName.Name = "textBoxFName";
            textBoxFName.Size = new Size(351, 32);
            textBoxFName.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 543);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(151, 23);
            label7.TabIndex = 36;
            label7.Text = "Father's Name";
            // 
            // textBoxCNO
            // 
            textBoxCNO.Location = new Point(280, 304);
            textBoxCNO.Margin = new Padding(4, 3, 4, 3);
            textBoxCNO.Name = "textBoxCNO";
            textBoxCNO.Size = new Size(351, 32);
            textBoxCNO.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 313);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(177, 23);
            label6.TabIndex = 34;
            label6.Text = "Contact Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 240);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(144, 23);
            label5.TabIndex = 33;
            label5.Text = "Date Of Birthy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 176);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(85, 23);
            label4.TabIndex = 32;
            label4.Text = "Gender";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(280, 99);
            textBoxName.Margin = new Padding(4, 3, 4, 3);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(351, 32);
            textBoxName.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 107);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 30;
            label3.Text = "Name";
            // 
            // textBoxid
            // 
            textBoxid.Location = new Point(280, 32);
            textBoxid.Margin = new Padding(4, 3, 4, 3);
            textBoxid.Name = "textBoxid";
            textBoxid.Size = new Size(351, 32);
            textBoxid.TabIndex = 50;
            // 
            // labelid
            // 
            labelid.AutoSize = true;
            labelid.Location = new Point(52, 40);
            labelid.Margin = new Padding(4, 0, 4, 0);
            labelid.Name = "labelid";
            labelid.Size = new Size(30, 23);
            labelid.TabIndex = 49;
            labelid.Text = "ID";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(655, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1112, 572);
            dataGridView1.TabIndex = 51;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(1415, 40);
            textBoxSearch.Margin = new Padding(4, 3, 4, 3);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(351, 32);
            textBoxSearch.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1162, 49);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(245, 23);
            label1.TabIndex = 52;
            label1.Text = "Enter a value to search:";
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.SteelBlue;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Location = new Point(192, 739);
            buttonEdit.Margin = new Padding(4, 3, 4, 3);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(141, 52);
            buttonEdit.TabIndex = 54;
            buttonEdit.Text = "Update";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.SteelBlue;
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.ForeColor = Color.White;
            buttonReset.Location = new Point(490, 739);
            buttonReset.Margin = new Padding(4, 3, 4, 3);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(141, 52);
            buttonReset.TabIndex = 55;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.SteelBlue;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(1622, 80);
            buttonSearch.Margin = new Padding(4, 3, 4, 3);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(145, 36);
            buttonSearch.TabIndex = 56;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotal.Location = new Point(1504, 707);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(263, 34);
            labelTotal.TabIndex = 57;
            labelTotal.Text = "Total students: 100";
            // 
            // ManageStudentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1779, 837);
            Controls.Add(labelTotal);
            Controls.Add(buttonSearch);
            Controls.Add(buttonReset);
            Controls.Add(buttonEdit);
            Controls.Add(textBoxSearch);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxid);
            Controls.Add(labelid);
            Controls.Add(textBoxAddress);
            Controls.Add(label10);
            Controls.Add(radioButtonFemale);
            Controls.Add(radioButtonMale);
            Controls.Add(textBoxSubject);
            Controls.Add(label9);
            Controls.Add(buttonAdd);
            Controls.Add(buttonRemove);
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
            Name = "ManageStudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageStudentForm";
            Load += ManageStudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAddress;
        private Label label10;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private TextBox textBoxSubject;
        private Label label9;
        private Button buttonAdd;
        private Button buttonRemove;
        private DateTimePicker dateTimePickerDOB;
        private TextBox textBoxFCN;
        private Label label8;
        private TextBox textBoxFName;
        private Label label7;
        private TextBox textBoxCNO;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBoxName;
        private Label label3;
        private TextBox textBoxid;
        private Label labelid;
        private DataGridView dataGridView1;
        private TextBox textBoxSearch;
        private Label label1;
        private Button buttonEdit;
        private Button buttonReset;
        private Button buttonSearch;
        private Label labelTotal;
    }
}