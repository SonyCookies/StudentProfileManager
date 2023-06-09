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
    public partial class EditStudentForm : Form
    {
        private string selectedIdentifier;
        StudentDatabase sd;
        public EditStudentForm(string studentId)
        {
            InitializeComponent();
            selectedIdentifier = studentId;
        }

        private void EditStudentForm_Load(object sender, EventArgs e)
        {
            sd = new StudentDatabase();
            SetStudentData();
        }

        private void SetStudentData()
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
                    txtStudentId.Text = reader["StudentId"].ToString();
                    txtStudentId.ReadOnly = true;
                    txtStudentId.Enabled = true;
                    txtFName.Text = reader["StudentFName"].ToString();
                    txtMName.Text = reader["StudentMName"].ToString();
                    txtLName.Text = reader["StudentLName"].ToString();
                    cmbCourse.Text = reader["Course"].ToString();
                    dtpStudentBirth.Text = ((DateTime)reader["BirthDate"]).ToString("MM/dd/yyyy");
                    txtYear.Text = reader["Year"].ToString();
                    cmbStudentType.Text = reader["StudentType"].ToString();
                    cmbGender.Text = reader["Gender"].ToString();
                    txtStudentAge.Text = reader["Age"].ToString();
                    txtStudentPhone.Text = reader["PhoneNumber"].ToString();
                    txtStudentEmail.Text = reader["EmailAdress"].ToString();
                    txtStudentReligion.Text = reader["Religion"].ToString();
                    txtStudentPoB.Text = reader["PlaceOfBirth"].ToString();
                    txtStudentAddress.Text = reader["Address"].ToString();
                    txtSection.Text = reader["Section"].ToString();
                }
            }
        }

        /*string query = "INSERT INTO StudentInfo (StudentId, Year, Section, Course, StudentType," +
                "StudentFName, StudentMName, StudentLName, StudentSuffix, Religion, BirthDate, Age, Gender, " +
                "PhoneNumber, EmailAdress, PlaceOfBirth, Address, FaName, FaOccupation, FaAddress, FaAge," +
                " FaBirthDate," +
                "FaPhoneNumber, FaEmailAddress, MoName, MoOccupation, MoAddress, MoBirthDate, MoAge," +
                "MoPhoneNumber, MoEmailAddress, GuName, GuRelation, GuOccupation, GuPhoneNumber, " +
                "GuBirthDate, GuAge, GuAddress) VALUES ('" + txtStudentId.Text + "', '" + txtYear.Text + "'" +
                ", '" + txtSection.Text + "', '" + cmbCourse.Text + "', '" + cmbStudentType.Text + "'" +
                ", '" + txtFName.Text + "', '" + txtMName.Text + "', '" + txtLName.Text + "'" +
                ", '" + txtSuffix.Text + "', '" + txtStudentReligion.Text + "', '" + dtpStudentBirth.Value + "'" +
                ", '" + txtStudentAge.Text + "', '" + cmbGender.Text + "', '" + txtStudentPhone.Text + "', '" + txtStudentEmail.Text + "', " +
                "'" + txtStudentPoB.Text + "', '" + txtStudentAddress.Text + "', '" + txtFatherName.Text + "', " +
                "'" + txtFatherOcc.Text + "', '" + txtFatherAddress.Text + "', '" + txtFatherAge.Text + "', '" + dtpFatherBirth.Value + "'," +
                "'" + txtFatherPhone.Text + "', '" + txtFatherEmail.Text + "', '" + txtMotherName.Text + "', " +
                "'" + txtMotherOcc.Text + "', '" + txtMotherAddress.Text + "', '" + dtpMotherBirth.Value + "', " +
                "'" + txtMotherAge.Text + "', '" + txtMotherPhone.Text + "', '" + txtMotherEmail.Text + "', " +
                "'" + txtGuardianName.Text + "', '" + txtGuardianRS.Text + "', '" + txtGuardianOcc.Text + "', " +
                "'" + txtGuardianPhone.Text + "', '" + dtpGuardianBirth.Value + "', '" + txtGuardianAge.Text + "', " +
                "'" + txtGuardianAddress.Text + "')";*/
        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {

            string query = "UPDATE StudentInfo SET Year = '" + txtYear.Text + "', " +
                "Section = '" + txtSection.Text + "', Course = '" + cmbCourse.Text + "', StudentType = '" + cmbStudentType.Text + "', " +
                "StudentFName = '" + txtFName.Text + "', StudentMName = '" + txtMName.Text + "', StudentLName = '" + txtLName.Text + "', " +
                "StudentSuffix = '" + txtSuffix.Text + "', Religion = '" + txtStudentReligion.Text + "', BirthDate = '" + dtpStudentBirth.Value + "', " +
                "Age = '" + txtStudentAge.Text + "', Gender = '" + cmbGender.Text + "', PhoneNumber = '" + txtStudentPhone.Text + "', " +
                "EmailAdress = '" + txtStudentEmail.Text + "', PlaceOfBirth = '" + txtStudentPoB.Text + "', Address = '" + txtStudentAddress.Text + "' WHERE StudentId = '" + txtStudentId.Text + "'";

            if (sd.cud(query) > 0)
            {
                MessageBox.Show("Student Update Successfully");
                StudentPanelPage studentPanelPage = Application.OpenForms.OfType<StudentPanelPage>().FirstOrDefault();

                // Update the DataGridView in the StudentPanelPage form
                studentPanelPage?.RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Student Update Not Successfull");
            }

            // 
            Close();
        }
    }
}
