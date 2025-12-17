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
    public partial class StaticsForm : Form
    {
        public StaticsForm()
        {
            InitializeComponent();
        }

        //Color variebles
        Color panTotStudentrColor;
        Color panMaleColor;
        Color panFemale;
        private void StaticsForm_Load(object sender, EventArgs e)
        {
            //display valuews
            STUDENT student = new STUDENT();
            double totalStudent = Convert.ToDouble(student.totalStudent());
            double totalMale = Convert.ToDouble(student.totalMale());
            double totalFemale = Convert.ToDouble(student.totalFemale());

            //count the %
            double malePercentage = totalMale * 100 / totalStudent;
            double femalePercentage = totalFemale * 100 / totalStudent;

            labelTotStudent.Text = "Total Students: " + totalStudent.ToString();
            labelMale.Text = "Male: " + malePercentage.ToString("0.00")+"%";
            labelFemale.Text = "Female: " + femalePercentage.ToString("0.00")+"%";
        }
    }
}
