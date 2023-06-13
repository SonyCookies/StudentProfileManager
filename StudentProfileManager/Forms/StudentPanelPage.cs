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
    public partial class StudentPanelPage : Form
    {

        StudentDatabase sd;
        public StudentPanelPage()
        {
            InitializeComponent();
        }

        private void StudentPanelPage_Load(object sender, EventArgs e)
        {
            sd = new StudentDatabase();
            

            RefreshDataGridView();

        }
        public void RefreshDataGridView()
        {
            string query = "SELECT Id, StudentID, StudentFName, StudentMName, StudentLName, StudentSuffix, Course, Year, Section, StudentType FROM StudentInfo";
            dgvStudentManage.DataSource = sd.GetStudentData(query);

            dgvStudentManage.Columns["Id"].HeaderText = "ID";
            dgvStudentManage.Columns["Id"].FillWeight = 5;
            dgvStudentManage.Columns["Id"].Visible = false;
            dgvStudentManage.Columns["StudentId"].HeaderText = "STUDENT ID";
            dgvStudentManage.Columns["StudentId"].FillWeight = 10;
            dgvStudentManage.Columns["StudentName"].HeaderText = "STUDENT NAME";
            dgvStudentManage.Columns["StudentName"].FillWeight = 20;
            dgvStudentManage.Columns["Course"].HeaderText = "COURSE";
            dgvStudentManage.Columns["Course"].FillWeight = 10;
            dgvStudentManage.Columns["YearSection"].HeaderText = "YEAR & SECTION";
            dgvStudentManage.Columns["YearSection"].FillWeight = 10;
            dgvStudentManage.Columns["StudentType"].HeaderText = "TYPE OF STUDENT";
            dgvStudentManage.Columns["StudentType"].FillWeight = 10;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (ParentForm is DashBoardForm dashboardForm)
            {
                dashboardForm.OpenChildForm(new AddStudentPanelPage(), dashboardForm.btnAddStudentPage);
            }
        }

        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudentManage.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvStudentManage.SelectedRows[0];

                // Get the ID from the selected row
                string studentId = selectedRow.Cells["Id"].Value.ToString();

                // Create an instance of the ViewStudent form
                ViewStudentForm viewStudentForm = new ViewStudentForm(studentId);
                // Show the ViewStudent form
                viewStudentForm.Show();
            }
            else
            {
                MessageBox.Show("Select Student to View.");
            }
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudentManage.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvStudentManage.SelectedRows[0];

                // Get the ID from the selected row
                string studentId = selectedRow.Cells["Id"].Value.ToString();

                // Create an instance of the ViewStudent form
                EditStudentForm editStudentForm = new EditStudentForm(studentId);
                // Show the ViewStudent form
                editStudentForm.Show();

            }
            else
            {
                MessageBox.Show("Select Student to Edit.");
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            sd = new StudentDatabase();
            if (dgvStudentManage.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvStudentManage.SelectedRows[0];
                string id = selectedRow.Cells["Id"].Value.ToString();

                string query = "DELETE FROM StudentInfo WHERE Id = @ID";
                sd.DeleteStudent(query, id);

                dgvStudentManage.Rows.RemoveAt(selectedRow.Index);

                MessageBox.Show("Student Deleted Successfully.");
            }
            else
            {
                MessageBox.Show("Select Student to Delete.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;

            //TODO
            /*
            using (SqlConnection connection = new SqlConnection(sd.connectionString))
            {
                connection.Open();
                // Construct the SQL query
                string query = "SELECT * FROM StudentInfo WHERE StudentId LIKE '%' + @SearchTerm + '%' OR StudentFName LIKE '%' + @SearchTerm + '%'" +
                    "OR StudentLName LIKE '%' + @SearchTerm + '%' OR StudentMName LIKE '%' + @SearchTerm + '%' OR Course LIKE '%' + @SearchTerm + '%'" +
                    "OR Year LIKE '%' + @SearchTerm + '%' OR Section LIKE '%' + @SearchTerm + '%' OR StudentType LIKE '%' + @SearchTerm + '%';";

                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add a parameter for the search term
                    command.Parameters.AddWithValue("@SearchTerm", searchTerm);
                    

                    // Create a SqlDataAdapter to retrieve the data
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    // Create a DataTable to hold the data
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with the data from the database
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dgvStudentManage.DataSource = dataTable;
                }
            }
            */
        }
    }
}
