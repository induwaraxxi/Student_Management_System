namespace Student_Management_System
{
    partial class StaticsForm
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
            panelMale = new Panel();
            labelMale = new Label();
            panel3 = new Panel();
            panelFemale = new Panel();
            labelFemale = new Label();
            panel5 = new Panel();
            labelTotStudent = new Label();
            panelTotStudent = new Panel();
            panelMale.SuspendLayout();
            panelFemale.SuspendLayout();
            panelTotStudent.SuspendLayout();
            SuspendLayout();
            // 
            // panelMale
            // 
            panelMale.BackColor = Color.SteelBlue;
            panelMale.Controls.Add(labelMale);
            panelMale.Controls.Add(panel3);
            panelMale.Location = new Point(9, 205);
            panelMale.Name = "panelMale";
            panelMale.Size = new Size(363, 175);
            panelMale.TabIndex = 1;
            // 
            // labelMale
            // 
            labelMale.AutoSize = true;
            labelMale.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMale.ForeColor = Color.White;
            labelMale.Location = new Point(83, 67);
            labelMale.Name = "labelMale";
            labelMale.Size = new Size(164, 37);
            labelMale.TabIndex = 3;
            labelMale.Text = "Male: 50%";
            labelMale.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Location = new Point(380, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(343, 181);
            panel3.TabIndex = 2;
            // 
            // panelFemale
            // 
            panelFemale.BackColor = Color.SteelBlue;
            panelFemale.Controls.Add(labelFemale);
            panelFemale.Controls.Add(panel5);
            panelFemale.Location = new Point(378, 205);
            panelFemale.Name = "panelFemale";
            panelFemale.Size = new Size(360, 175);
            panelFemale.TabIndex = 3;
            // 
            // labelFemale
            // 
            labelFemale.AutoSize = true;
            labelFemale.BackColor = Color.SteelBlue;
            labelFemale.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFemale.ForeColor = Color.White;
            labelFemale.Location = new Point(86, 67);
            labelFemale.Name = "labelFemale";
            labelFemale.Size = new Size(197, 37);
            labelFemale.TabIndex = 4;
            labelFemale.Text = "Female: 50%";
            labelFemale.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SteelBlue;
            panel5.Location = new Point(380, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(343, 181);
            panel5.TabIndex = 2;
            // 
            // labelTotStudent
            // 
            labelTotStudent.AutoSize = true;
            labelTotStudent.BackColor = Color.SteelBlue;
            labelTotStudent.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotStudent.ForeColor = Color.White;
            labelTotStudent.Location = new Point(227, 75);
            labelTotStudent.Name = "labelTotStudent";
            labelTotStudent.Size = new Size(272, 37);
            labelTotStudent.TabIndex = 0;
            labelTotStudent.Text = "Total Student: 100";
            labelTotStudent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTotStudent
            // 
            panelTotStudent.BackColor = Color.SteelBlue;
            panelTotStudent.Controls.Add(labelTotStudent);
            panelTotStudent.Location = new Point(9, 12);
            panelTotStudent.Name = "panelTotStudent";
            panelTotStudent.Size = new Size(729, 187);
            panelTotStudent.TabIndex = 0;
            // 
            // StaticsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(747, 389);
            Controls.Add(panelFemale);
            Controls.Add(panelMale);
            Controls.Add(panelTotStudent);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "StaticsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaticsForm";
            Load += StaticsForm_Load;
            panelMale.ResumeLayout(false);
            panelMale.PerformLayout();
            panelFemale.ResumeLayout(false);
            panelFemale.PerformLayout();
            panelTotStudent.ResumeLayout(false);
            panelTotStudent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMale;
        private Panel panel3;
        private Panel panelFemale;
        private Panel panel5;
        private Label labelMale;
        private Label labelFemale;
        private Label labelTotStudent;
        private Panel panelTotStudent;
    }
}