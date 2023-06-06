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
                dashboardForm.OpenChildForm(new AddStudentPanelPage(), sender);
            }
        }
    }
}
