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
    public partial class DashBoardPanelForm : Form
    {
        private StudentDatabase sd;
        public DashBoardPanelForm()
        {
            InitializeComponent();
            sd = new StudentDatabase();
        }

        private void DashBoardPanelForm_Load(object sender, EventArgs e)
        {
            studentButtonPanel.BackColor = Color.FromArgb(100, Color.Black);
            coursesButtonPanel.BackColor = Color.FromArgb(100, Color.Black);
            sectionButtonPanel.BackColor = Color.FromArgb(100, Color.Black);

            lblStudentCount.Text = sd.StudentCount();
        }

        private void lnkStudentCountMoreInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ParentForm is DashBoardForm dashboardForm)
            {
                dashboardForm.OpenChildForm(new StudentPanelPage(), dashboardForm.btnStudentPage);
            }
        }

        private void lnkCourseMoreInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CoursesForm cF = new CoursesForm();
            cF.Show();
        }
    }
}
