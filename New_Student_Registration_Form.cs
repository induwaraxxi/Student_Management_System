using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class New_Student_Registration_Form : Form
    {
        public New_Student_Registration_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //Button Close
        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddNewStudent_Click(object sender, EventArgs e)
        {
            //Add new student
            if (!int.TryParse(textBoxid.Text, out int id))
            {
                MessageBox.Show("Please enter a valid numeric ID", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            STUDENT student = new STUDENT();
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

            if (student.insertStudent(id, name, gender, bdate, contact, address,fname, fcnum, subject))
            {
                MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Create a function to verify data
        bool verif()
        {
            if ((textBoxid.Text.Trim() == "") ||
                (textBoxName.Text.Trim() == "") ||
                (textBoxCNO.Text.Trim() == "") ||
                (textBoxAddress.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
