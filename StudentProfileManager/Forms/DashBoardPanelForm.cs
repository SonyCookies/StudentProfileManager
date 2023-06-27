using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentProfileManager
{
    public partial class DashBoardPanelForm : Form
    {
        private StudentDatabase sd;

        static DateTime currentDT = DateTime.Now;
        static int year = currentDT.Year;
        static int month = currentDT.Month;
        static int day = currentDT.Day;
        public DashBoardPanelForm()
        {
            InitializeComponent();
            sd = new StudentDatabase();
            
        }
        private void displayDays()
        {
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonth.Text = monthName + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);
            int daysOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < daysOfTheWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                dayContainer.Controls.Add(ucBlank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                dayContainer.Controls.Add(ucDays);

                if (i == day && month == currentDT.Month && year == currentDT.Year)
                {
                    Color customColor = Color.FromArgb(46, 181, 83);

                    ucDays.BackColor = customColor;
                    ucDays.day.ForeColor = Color.White;
                }
            }
        }

        private void DashBoardPanelForm_Load(object sender, EventArgs e)
        {
            studentButtonPanel.BackColor = Color.FromArgb(100, Color.Black);
            coursesButtonPanel.BackColor = Color.FromArgb(100, Color.Black);

            lblStudentCount.Text = sd.StudentCount();
            displayDays();


        }

        private void lnkStudentCountMoreInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ParentForm is DashBoardForm dashboardForm)
            {
                dashboardForm.OpenChildForm(new StudentPanelPage(), dashboardForm.btnStudentPage);
            }
        }

        private void lnkCollegeMoreInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CollegesForm cF = new CollegesForm();
            cF.Show();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (month == 1)
            {
                month = 13;
                year--;
            }
            dayContainer.Controls.Clear();
            month--;
            displayDays();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (month == 12)
            {
                month = 0;
                year++;
            }
            dayContainer.Controls.Clear();
            month++;
            displayDays();
        }

        private void studentButtonPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
