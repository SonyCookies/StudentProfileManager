using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string query = "SELECT StudentID, StudentFName, StudentMName, StudentLName, StudentSuffix, Course, Year, Section, StudentType FROM StudentInfo";
            dgvStudentManage.DataSource = sd.GetStudentData(query);

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
                string studentId = selectedRow.Cells["StudentId"].Value.ToString();

                // Create an instance of the ViewStudent form
                ViewStudentForm viewStudentForm = new ViewStudentForm(studentId);

                // Show the ViewStudent form
                viewStudentForm.Show();
            }
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            EditStudentForm esForm = new EditStudentForm();
            esForm.Show();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            sd = new StudentDatabase();
            if (dgvStudentManage.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvStudentManage.SelectedRows[0];
                string id = selectedRow.Cells["StudentId"].Value.ToString();

                string query = "DELETE FROM StudentInfo WHERE StudentId = @ID";
                sd.DeleteStudent(query, id);

                dgvStudentManage.Rows.RemoveAt(selectedRow.Index);

                MessageBox.Show("Student Deleted Successfully.");
            }
        }
    }
}
