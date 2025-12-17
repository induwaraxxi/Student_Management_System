using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Student_Management_System
{
    public partial class PrintStudentForm : Form
    {
        public PrintStudentForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();

        private void PrintStudentForm_Load(object sender, EventArgs e)
        {
            fillGrid(new MySqlCommand("SELECT * FROM `student`"));

            if (radioButtonNo.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        // Create a function to the populate datagridview
        public void fillGrid(MySqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getSudents(command);
            dataGridView1.AllowUserToAddRows = false;
        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //display data onthe datagridview dipending on what the userhave selected

            MySqlCommand command;
            string query;

            //check if the radio button checked
            if (radioButtonYes.Checked)
            {
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                if (radioButtonMale.Checked)
                {
                    query = "SELECT* FROM `student` WHERE `date_of_birth` BETWEEN '" + date1 + "' AND '" + date2 + "' AND gender = 'Male'";
                }
                else if (radioButtonFemale.Checked)
                {
                    query = "SELECT* FROM `student` WHERE `date_of_birth` BETWEEN '" + date1 + "' AND '" + date2 + "' AND gender = 'Female'";
                }
                else
                {
                    query = "SELECT* FROM `student` WHERE `date_of_birth` BETWEEN '" + date1 + "' AND '" + date2 + "'";
                }

                command = new MySqlCommand(query);
                fillGrid(command);
            }
            //display with a birth day range
            else
            {
                if (radioButtonMale.Checked)
                {
                    query = "SELECT* FROM `student` WHERE gender = 'Male'";
                }
                else if (radioButtonFemale.Checked)
                {
                    query = "SELECT* FROM `student` WHERE gender = 'Female'";
                }
                else
                {
                    query = "SELECT* FROM `student`";
                }

                command = new MySqlCommand(query);
                fillGrid(command);
            }
        }

        //print data to text file
        //print data to text file with equal spacing
        private void buttonAddNewStudent_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Students_list.txt";

            try
            {
                using (var writer = new StreamWriter(path))
                {
                    // Calculate maximum width for each column
                    int[] maxWidths = new int[dataGridView1.Columns.Count];

                    // Initialize with header lengths
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        maxWidths[j] = dataGridView1.Columns[j].HeaderText.Length;
                    }

                    // Find maximum width for each column from data
                    for (int i = 0; i < dataGridView1.Rows.Count; i++) // -1 to exclude new row
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            if (dataGridView1.Rows[i].Cells[j].Value != null)
                            {
                                string cellValue = dataGridView1.Rows[i].Cells[j].Value.ToString();

                                // Format date
                                if (j == 3 && DateTime.TryParse(cellValue, out DateTime bdate))
                                {
                                    cellValue = bdate.ToString("yyyy-MM-dd");
                                }

                                if (cellValue.Length > maxWidths[j])
                                {
                                    maxWidths[j] = cellValue.Length;
                                }
                            }
                        }
                    }

                    // Add some padding
                    for (int j = 0; j < maxWidths.Length; j++)
                    {
                        maxWidths[j] += 4; // Add padding
                    }

                    // Write header row with centered text
                    string headerRow = "";
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        string header = dataGridView1.Columns[j].HeaderText;
                        int spaces = maxWidths[j] - header.Length;
                        int leftSpaces = spaces / 2;
                        int rightSpaces = spaces - leftSpaces;

                        headerRow += new string(' ', leftSpaces) + header + new string(' ', rightSpaces);

                        if (j < dataGridView1.Columns.Count - 1)
                        {
                            headerRow += "|";
                        }
                    }
                    writer.WriteLine(headerRow);

                    // Write separator line
                    string separator = "";
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        separator += new string('-', maxWidths[j]);
                        if (j < dataGridView1.Columns.Count - 1)
                        {
                            separator += "|";
                        }
                    }
                    writer.WriteLine(separator);

                    // Write data rows with centered content
                    for (int i = 0; i < dataGridView1.Rows.Count; i++) // -1 to exclude new row
                    {
                        string dataRow = "";

                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            string cellValue = " ";

                            if (dataGridView1.Rows[i].Cells[j].Value != null)
                            {
                                cellValue = dataGridView1.Rows[i].Cells[j].Value.ToString();

                                // Format date
                                if (j == 3 && DateTime.TryParse(cellValue, out DateTime bdate))
                                {
                                    cellValue = bdate.ToString("yyyy-MM-dd");
                                }
                            }

                            // Center the content within the column width
                            int spaces = maxWidths[j] - cellValue.Length;
                            int leftSpaces = spaces / 2;
                            int rightSpaces = spaces - leftSpaces;

                            dataRow += new string(' ', leftSpaces) + cellValue + new string(' ', rightSpaces);

                            if (j < dataGridView1.Columns.Count - 1)
                            {
                                dataRow += "|";
                            }
                        }

                        writer.WriteLine(dataRow);
                    }

                    writer.WriteLine(separator);
                    writer.WriteLine("Total Students: " + (dataGridView1.Rows.Count - 1));

                    MessageBox.Show("Data exported successfully!\nFile: " + path, "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting data: " + ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
