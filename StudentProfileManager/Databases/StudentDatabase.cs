using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace StudentProfileManager
{
    class StudentDatabase
    {
        public SqlConnection connection;
        private SqlCommand cmd;
        public string connectionString;
        public string addquery;
        private DataTable dT;
        private SqlDataAdapter dAdapter;

        public StudentDatabase()
        {
            OpenConnection();
        }

        private void OpenConnection()
        {
            connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\toxic\\source\\repos\\StudentProfileManager\\StudentProfileManager\\StudentProfileManagerDatabase.mdf; Integrated Security = True";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public int cud(string query)
        {
            cmd = new SqlCommand(query, connection);
            return cmd.ExecuteNonQuery();
        }

        public DataTable GetStudentData(string query)
        {
            DataTable dTable = new DataTable();
            dTable.Columns.Add("Id", typeof(string));
            dTable.Columns.Add("StudentId", typeof(string));
            dTable.Columns.Add("StudentName", typeof(string));
            dTable.Columns.Add("Course", typeof(string));
            dTable.Columns.Add("YearSection", typeof(string));
            dTable.Columns.Add("StudentType", typeof(string));

            SqlDataAdapter dAdapter = new SqlDataAdapter(query, connection);
            DataTable origDTable = new DataTable();
            dAdapter.Fill(origDTable);

            foreach (DataRow row in origDTable.Rows)
            {
                string id = row["Id"].ToString().Trim();
                string studentId = row["StudentId"].ToString().Trim();
                string fName = row["StudentFName"].ToString().Trim();
                string mName = row["StudentMName"].ToString().Trim();
                string lName = row["StudentLName"].ToString().Trim();
                string s = row["StudentSuffix"].ToString().Trim();
                string fullName = $"{lName}, {fName} {mName} {s}";
                string course = row["Course"].ToString().Trim();
                string yearSection = row["YearSection"].ToString().Trim() ;
                string typeOfStudent = row["StudentType"].ToString().Trim();

                dTable.Rows.Add(id, studentId, fullName, course, yearSection, typeOfStudent);
            }
            return dTable;
        }

        public void DeleteStudent(string query, string id)
        {
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ID", id);

            cmd.ExecuteNonQuery();
        }

        public string StudentCount()
        {
            string query = "SELECT COUNT(*) FROM StudentInfo";
            cmd = new SqlCommand(query, connection);
            int rowCount = (int)cmd.ExecuteScalar();

            return rowCount.ToString();
        }
    }
}
