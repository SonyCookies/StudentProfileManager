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
    public partial class AddStudentPanelPage : Form
    {

        StudentDatabase sd;
        public AddStudentPanelPage()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            txtStudentId.Clear();
            txtYear.Clear();
            cmbCourse.SelectedIndex = 0;
            cmbStudentType.SelectedIndex = 0;
            txtSection.Clear();
            txtFName.Clear();
            txtMName.Clear();
            txtLName.Clear();
            txtSuffix.Clear();
            txtStudentAge.Clear();
            txtStudentPhone.Clear();
            txtStudentEmail.Clear();
            txtStudentPoB.Clear();
            txtStudentAddress.Clear();
            txtStudentReligion.Clear();

            txtFatherName.Clear();
            txtFatherOcc.Clear();
            txtFatherAddress.Clear();
            txtFatherAge.Clear();
            txtFatherPhone.Clear();
            txtFatherEmail.Clear();

            txtMotherName.Clear();
            txtMotherOcc.Clear();
            txtMotherAddress.Clear();
            txtMotherAge.Clear();
            txtMotherPhone.Clear();
            txtMotherEmail.Clear();

            txtGuardianName.Clear();
            txtGuardianRS.Clear();
            txtGuardianOcc.Clear();
            txtGuardianPhone.Clear();
            txtGuardianAge.Clear();
            txtGuardianAddress.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void AddStudentPanelPage_Load(object sender, EventArgs e)
        {
            sd = new StudentDatabase();

            dtpStudentBirth.Format = DateTimePickerFormat.Custom;
            dtpStudentBirth.CustomFormat = "MM/dd/yyyy";
        }


        private void btnAddStud_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudentId.Text) || string.IsNullOrEmpty(txtYear.Text) ||
                string.IsNullOrEmpty(txtSection.Text) || string.IsNullOrEmpty(cmbCourse.Text) ||
                string.IsNullOrEmpty(cmbStudentType.Text) || string.IsNullOrEmpty(txtFName.Text) ||
                string.IsNullOrEmpty(txtMName.Text) || string.IsNullOrEmpty(txtLName.Text) ||
                string.IsNullOrEmpty(txtStudentReligion.Text) || string.IsNullOrEmpty(txtStudentAge.Text) ||
                string.IsNullOrEmpty(txtStudentPhone.Text) || string.IsNullOrEmpty(txtStudentEmail.Text) ||
                string.IsNullOrEmpty(txtStudentPoB.Text) || string.IsNullOrEmpty(txtStudentAddress.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            string query = "INSERT INTO StudentInfo (StudentId, Year, Section, Course, StudentType," +
                "StudentFName, StudentMName, StudentLName, StudentSuffix, Religion, BirthDate, Age," +
                "PhoneNumber, EmailAdress, PlaceOfBirth, Address, FaName, FaOccupation, FaAddress, FaAge," +
                " FaBirthDate," +
                "FaPhoneNumber, FaEmailAddress, MoName, MoOccupation, MoAddress, MoBirthDate, MoAge," +
                "MoPhoneNumber, MoEmailAddress, GuName, GuRelation, GuOccupation, GuPhoneNumber, " +
                "GuBirthDate, GuAge, GuAddress) VALUES ('" + txtStudentId.Text + "', '" + txtYear.Text + "'" +
                ", '" + txtSection.Text + "', '" + cmbCourse.Text + "', '" + cmbStudentType.Text + "'" +
                ", '" + txtFName.Text + "', '" + txtMName.Text + "', '" + txtLName.Text + "'" +
                ", '" + txtSuffix.Text + "', '" + txtStudentReligion.Text + "', '" + dtpStudentBirth.Value + "'" +
                ", '" + txtStudentAge.Text + "', '" + txtStudentPhone.Text + "', '" + txtStudentEmail.Text + "', " +
                "'" + txtStudentPoB.Text + "', '" + txtStudentAddress.Text + "', '" + txtFatherName.Text + "', " +
                "'" + txtFatherOcc.Text + "', '" + txtFatherAddress.Text + "', '" + txtFatherAge.Text + "', '" + dtpFatherBirth.Value + "'," +
                "'" + txtFatherPhone.Text + "', '" + txtFatherEmail.Text + "', '" + txtMotherName.Text + "', " +
                "'" + txtMotherOcc.Text + "', '" + txtMotherAddress.Text + "', '" + dtpMotherBirth.Value + "', " +
                "'" + txtMotherAge.Text + "', '" + txtMotherPhone.Text + "', '" + txtMotherEmail.Text + "', " +
                "'" + txtGuardianName.Text + "', '" + txtGuardianRS.Text + "', '" + txtGuardianOcc.Text + "', " +
                "'" + txtGuardianPhone.Text + "', '" + dtpGuardianBirth.Value + "', '" + txtGuardianAge.Text + "', " +
                "'" + txtGuardianAddress.Text + "')";
            sd.cud(query);
            Clear();

            MessageBox.Show("Student Added Successfully");

            if (ParentForm is DashBoardForm dashboardForm)
            {
                dashboardForm.OpenChildForm(new StudentPanelPage(), dashboardForm.btnStudentPage);
            }
        }
    }
}
