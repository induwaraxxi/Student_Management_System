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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (New_Student_Registration_Form nwe = new Student_Management_System.New_Student_Registration_Form())
            {
                nwe.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            studenListForm stdListF = new studenListForm();
            stdListF.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm upDelStdf = new UpdateDeleteStudentForm();
            upDelStdf.Show(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StaticsForm stcF = new StaticsForm();
            stcF.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageStudentForm mngStdf = new ManageStudentForm();
            mngStdf.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintStudentForm prStdF = new PrintStudentForm();
            prStdF.Show(this);
        }
    }
}
