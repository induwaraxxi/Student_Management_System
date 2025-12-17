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

namespace Student_Management_System
{
    public partial class studenListForm : Form
    {
        public studenListForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();
        private void studenListForm_Load(object sender, EventArgs e)
        {
            //populate the datagrid with student data

            MySqlCommand command = new MySqlCommand("SELECT * FROM `student`");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getSudents(command);
            dataGridView1.AllowUserToAddRows = false;
        }

        private void studenListForm_DoubleClick(object sender, EventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            //refresh the datagride data

            MySqlCommand command = new MySqlCommand("SELECT * FROM `student`");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getSudents(command);
            dataGridView1.AllowUserToAddRows = false;

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //disply the selected student in a form edit or remove
            UpdateDeleteStudentForm UpdateDeleteF = new UpdateDeleteStudentForm();
            UpdateDeleteF.textBoxid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            UpdateDeleteF.textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            //gender
            if (dataGridView1.CurrentRow.Cells[2].Value.ToString() == "Female")
            {
                UpdateDeleteF.radioButtonFemale.Checked = true;
            }
            else
            {
                UpdateDeleteF.radioButtonMale.Checked = true;
            }

            UpdateDeleteF.dateTimePickerDOB.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            UpdateDeleteF.textBoxCNO.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            UpdateDeleteF.textBoxAddress.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            UpdateDeleteF.textBoxFName.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            UpdateDeleteF.textBoxFCN.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            UpdateDeleteF.textBoxSubject.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            UpdateDeleteF.Show();
        }
    }
}
