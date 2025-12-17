using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Management_System
{
    public partial class ManageStudentForm : Form
    {
        public ManageStudentForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();
        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            // Populate the datagridview with student data
            fillGrid(new MySqlCommand("SELECT * FROM `student`"));
        }

        // Create a function to the populate datagridview
        public void fillGrid(MySqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getSudents(command);
            dataGridView1.AllowUserToAddRows = false;

            // show the total of students

            labelTotal.Text = "Total students: "+dataGridView1.Rows.Count;
        }

        // Search adn display student datagrid view
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM `student` WHERE CONCAT(`id`,`address`,`gender`,`date_of_birth`,`contact_number`,`father_name`,`father_con_no`,`subject`) LIKE'%" + textBoxSearch.Text + "%'";
            MySqlCommand command = new MySqlCommand(query);
            fillGrid(command);
        }

        // add a new student
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Add new student
            STUDENT student = new STUDENT();
            if (!int.TryParse(textBoxid.Text, out int id))
            {
                MessageBox.Show("Please enter a valid numeric ID", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string name = textBoxName.Text;
            string gender = "Male";
            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }
            DateTime bdate = dateTimePickerDOB.Value;
            string contact = textBoxCNO.Text;
            string address = textBoxAddress.Text;
            string fname = textBoxFName.Text;
            string fcnum = textBoxFCN.Text;
            string subject = textBoxSubject.Text;

            if (student.insertStudent(id, name, gender, bdate, contact, address, fname, fcnum, subject))
            {
                MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillGrid(new MySqlCommand("SELECT * FROM `student`"));
            }
            else
            {
                MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //edit the selected student
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // Update the selected student
            //Add new student
            try
            {
                int id = Convert.ToInt32(textBoxid.Text);
                string name = textBoxName.Text;
                string gender = "Male";
                if (radioButtonFemale.Checked)
                {
                    gender = "Female";
                }
                DateTime bdate = dateTimePickerDOB.Value;
                string contact = textBoxCNO.Text;
                string address = textBoxAddress.Text;
                string fname = textBoxFName.Text;
                string fcnum = textBoxFCN.Text;
                string subject = textBoxSubject.Text;

                if (student.updateStudent(id, name, gender, bdate, contact, address, fname, fcnum, subject))
                {
                    MessageBox.Show("Student information updated", "Edit student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillGrid(new MySqlCommand("SELECT * FROM `student`"));
                }
                else
                {
                    MessageBox.Show("Error", "Edit student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid student ID", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //remove the selected student
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            //Remove the selected student
            try
            {
                int id = Convert.ToInt32(textBoxid.Text);
                //Show a confirmation messag befor the deleting the student
                if (MessageBox.Show("Are you sure You want to delete this student?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (student.deteleStudent(id))
                    {
                        MessageBox.Show("Student deleted", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid(new MySqlCommand("SELECT * FROM `student`"));
                        //Clear fields
                        textBoxid.Text = "";
                        textBoxName.Text = "";
                        dateTimePickerDOB.Value = DateTime.Now;
                        textBoxCNO.Text = "";
                        textBoxAddress.Text = "";
                        textBoxFName.Text = "";
                        textBoxFCN.Text = "";
                        textBoxSubject.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Student not deleted", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid student ID", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //create funtion to verify data
        bool verif()
        {
            if ((textBoxName.Text.Trim() == "") ||
                (textBoxCNO.Text.Trim() == "") ||
                (textBoxName.Text.Trim() == "") ||
                (textBoxAddress.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // clear all fields
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxid.Text = "";
            textBoxName.Text = "";
            radioButtonMale.Checked = true;
            dateTimePickerDOB.Value = DateTime.Now;
            textBoxCNO.Text = "";
            textBoxAddress.Text = "";
            textBoxFName.Text = "";
            textBoxFCN.Text = "";
            textBoxSubject.Text = "";
        }

        // display student data on datagridview click
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            if (dataGridView1.CurrentRow.Cells[2].Value.ToString() == "Female")
            {
                radioButtonFemale.Checked = true;
            }
            else
            {
                radioButtonMale .Checked = true;
            }

            dateTimePickerDOB.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            textBoxCNO.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxAddress.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxFName.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBoxFCN.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBoxSubject.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

        }
    }
}
