using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace Student_Management_System
{
    public partial class UpdateDeleteStudentForm : Form
    {
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();

        private void UpdateDeleteStudentForm_Load(object sender, EventArgs e)
        {

        }

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

        //Create a function to verify data
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

        private void buttonFind_Click(object sender, EventArgs e)
        {
            //Search student by id
            try
            {
                int id = Convert.ToInt32(textBoxid.Text);
                MySqlCommand command = new MySqlCommand("SELECT `id`, `name`, `gender`, `date_of_birth`, `contact_number`, `address`, `father_name`, `father_con_no`, `subject` FROM `student` WHERE `id`=" + id);

                DataTable table = student.getSudents(command);

                if (table.Rows.Count > 0)
                {
                    textBoxName.Text = table.Rows[0]["name"].ToString();

                    //gender
                    if (table.Rows[0]["gender"].ToString() == "Female")
                    {
                        radioButtonFemale.Checked = true;
                    }
                    else
                    {
                        radioButtonMale.Checked = true;
                    }

                    dateTimePickerDOB.Value = (DateTime)table.Rows[0]["date_of_birth"];
                    textBoxCNO.Text = table.Rows[0]["contact_number"].ToString();
                    textBoxAddress.Text = table.Rows[0]["address"].ToString();
                    textBoxFName.Text = table.Rows[0]["father_name"].ToString();
                    textBoxFCN.Text = table.Rows[0]["father_con_no"].ToString();
                    textBoxSubject.Text = table.Rows[0]["subject"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Enter a valid student ID", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxid_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allowonly numbers on key press
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
