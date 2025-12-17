using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace Student_Management_System
{
    internal class STUDENT
    {
        MY_DB db = new MY_DB();

        //Create a function to add new student for database
        public bool insertStudent(int id, string name, string gender, DateTime bdate, string contact, string address, string fname, string fcnum,string subject)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `student`(`id`, `name`, `gender`, `date_of_birth`, `contact_number`, `address`, `father_name`, `father_con_no`, `subject`) VALUES (@id,@nm,@gen,@dob,@cno,@addr,@fnm,@fcn,@sub)", db.GetConnection);

            //@nm,@gen,@dob,@cno,@addr,@fnm,@sub
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@gen", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@dob", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@cno", MySqlDbType.VarChar).Value = contact;
            command.Parameters.Add("@addr", MySqlDbType.Text).Value = address;
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@fcn", MySqlDbType.VarChar).Value = fcnum;
            command.Parameters.Add("@sub", MySqlDbType.VarChar).Value = subject;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        //Create a function to retun a table of student data

        public DataTable getSudents(MySqlCommand command)
        {
            command.Connection = db.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command); ;
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;

        }

        //create a funtion to update student information 
        public bool updateStudent(int id, string name, string gender, DateTime bdate, string contact, string address, string fname, string fcnum, string subject)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `student` SET `id`=@id, `name`=@nm, `name`=@nm,`gender`=@gen,`date_of_birth`=@dob,`contact_number`=@cno,`address`=@addr,`father_name`=@fnm,`father_con_no`=@fcn,`subject`=@sub WHERE `id`=@id", db.GetConnection);

            //@id,@nm,@gen,@dob,@cno,@addr,@fnm,fcn,@sub
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@gen", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@dob", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@cno", MySqlDbType.VarChar).Value = contact;
            command.Parameters.Add("@addr", MySqlDbType.Text).Value = address;
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@fcn", MySqlDbType.VarChar).Value = fcnum;
            command.Parameters.Add("@sub", MySqlDbType.VarChar).Value = subject;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        //create a function to delete the selected student
        public bool deteleStudent(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `student` WHERE `id`=@studentid", db.GetConnection);

            //@studentid
            command.Parameters.Add("@studentid", MySqlDbType.VarChar).Value = id;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        // create a function to execute the count queries
        public string execCount(String query)
        {
            MySqlCommand command = new MySqlCommand(query, db.GetConnection);

            db.openConnection();
            string count = command.ExecuteScalar().ToString();
            db.closeConnection() ;

            return count;
        }

        //get the total student
        public string totalStudent()
        {
            return execCount("SELECT COUNT(*) FROM `student`");
        }

        //get the total MALE
        public string totalMale()
        {
            return execCount("SELECT COUNT(*) FROM `student` WHERE `gender`='Male'");
        }

        //get the total student
        public string totalFemale()
        {
            return execCount("SELECT COUNT(*) FROM `student` WHERE `gender`='Female'");
        }
    }
}
