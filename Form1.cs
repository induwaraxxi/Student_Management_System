using System.Data;
using MySql.Data.MySqlClient;

namespace Student_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username`=@usn AND `password`=@pass",db.GetConnection);

            command.Parameters.Add("@usn",MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("pass",MySqlDbType.VarChar).Value = textBox2.Text;

            adapter.SelectCommand = command;

            adapter.Fill(table);
            
            if(table.Rows.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password","Login Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
