using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentProfileManager
{
    public partial class ViewStudentForm : Form
    {
        private string selectedIdentifier;
        StudentDatabase sd;

        public ViewStudentForm(string studentId)
        {
            InitializeComponent();
            selectedIdentifier = studentId;
        }

        private void ViewStudentForm_Load(object sender, EventArgs e)
        {
            sd = new StudentDatabase();
            SetStudentData();
        }

        public void SetStudentData()
        {
            using (SqlConnection connection = new SqlConnection(sd.connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM StudentInfo WHERE StudentId = @StudentId";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@StudentId", selectedIdentifier);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // Retrieve the data fields from the reader
                    string studentId = reader["StudentId"].ToString();
                    string studentFName = reader["StudentFName"].ToString();
                    string studentMName = reader["StudentMName"].ToString();
                    string studentLName = reader["StudentLName"].ToString();
                    string studentName = $"{studentFName} {studentMName} {studentLName}";
                    string studentCourse = reader["Course"].ToString();
                    DateTime studentBirthDateTime = (DateTime) reader["BirthDate"];
                    string studentBirthDate = studentBirthDateTime.ToString("MM/dd/yyyy");
                    // Retrieve other data fields as needed

                    // Display the fetched data in labels
                    lblStudentId.Text = studentId;
                    lblStudentName.Text = studentName;
                    lblStudentCourse.Text = studentCourse;
                    lblStudentBirthDate.Text = studentBirthDate;
                    // Display other data fields accordingly
                }

                reader.Close();
            }
        }
    }
}
