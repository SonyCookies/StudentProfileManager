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
using System.IO;

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

            lblAgeES.Hide();
            lblAgeEF.Hide();
            lblAgeEM.Hide();
            lblAgeEG.Hide();

            lblPNES.Hide();
            lblPNEF.Hide();
            lblPNEM.Hide();
            lblPNEG.Hide();

            txtSection.Mask = "0-L0";

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

                string sql = "SELECT * FROM StudentInfo WHERE Id = @Id";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Id", selectedIdentifier);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtStudentId.Text = reader["StudentId"].ToString();
                    txtNum.Text = reader["Id"].ToString();
                    txtFName.Text = reader["StudentFName"].ToString();
                    txtMName.Text = reader["StudentMName"].ToString();
                    txtLName.Text = reader["StudentLName"].ToString();
                    cmbCourse.Text = reader["Course"].ToString();
                    dtpStudentBirth.Text = ((DateTime)reader["BirthDate"]).ToString("MM/dd/yyyy");
                    cmbStudentType.Text = reader["StudentType"].ToString();
                    cmbGender.Text = reader["Gender"].ToString();
                    txtStudentAge.Text = reader["Age"].ToString();
                    txtStudentPhone.Text = reader["PhoneNumber"].ToString();
                    txtStudentEmail.Text = reader["EmailAdress"].ToString();
                    txtStudentReligion.Text = reader["Religion"].ToString();
                    txtStudentPoB.Text = reader["PlaceOfBirth"].ToString();
                    txtStudentAddress.Text = reader["Address"].ToString();
                    txtSection.Text = reader["YearSection"].ToString();
                    txtFileName.Text = reader["StudentImageFileName"].ToString();
                    pbPreview.Image = ConvertByteToArrayToImage((byte[])reader["StudentImage"]);

                    txtFatherName.Text = reader["FaName"].ToString().Trim();
                    txtFatherOcc.Text = reader["FaOccupation"].ToString();
                    txtFatherAddress.Text = reader["FaAddress"].ToString();
                    dtpFatherBirth.Text = ((DateTime) reader["FaBirthDate"]).ToString("MM/dd/yyyy");
                    txtFatherAge.Text = reader["FaAge"].ToString();
                    txtFatherPhone.Text = reader["FaPhoneNumber"].ToString();
                    txtFatherEmail.Text = reader["FaEmailAddress"].ToString();
                    
                    txtMotherName.Text = reader["MoName"].ToString();
                    txtMotherOcc.Text = reader["MoOccupation"].ToString();
                    txtMotherAddress.Text = reader["MoAddress"].ToString();
                    dtpMotherBirth.Text = ((DateTime) reader["MoBirthDate"]).ToString("MM/dd/yyyy");
                    txtMotherAge.Text = reader["MoAge"].ToString();
                    txtMotherPhone.Text = reader["MoPhoneNumber"].ToString();
                    txtMotherEmail.Text = reader["MoEmailAddress"].ToString();

                    txtGuardianName.Text = reader["GuName"].ToString();
                    txtGuardianOcc.Text = reader["GuOccupation"].ToString();
                    txtGuardianAddress.Text = reader["GuAddress"].ToString();
                    dtpGuardianBirth.Text = ((DateTime)reader["GuBirthDate"]).ToString("MM/dd/yyyy");
                    txtGuardianAge.Text = reader["GuAge"].ToString();
                    txtGuardianPhone.Text = reader["GuPhoneNumber"].ToString();
                    txtGuardianRS.Text = reader["GuRelation"].ToString();

                }
            }
        }
        public Image ConvertByteToArrayToImage(byte[] data)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(data))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or output the error message for debugging
                Console.WriteLine($"Error converting byte array to image: {ex.Message}");
                return null; // Return null or a default image in case of an error
            }

        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            byte[] imageData = ConvertImageToBytes(pbPreview.Image);

            sd = new StudentDatabase();

            string query = "UPDATE StudentInfo SET StudentId = @StudentId, YearSection = @YearSection, Course = @Course, " +
               "StudentType = @StudentType, StudentFName = @StudentFName, StudentMName = @StudentMName, " +
               "StudentLName = @StudentLName, StudentSuffix = @StudentSuffix, Religion = @Religion, " +
               "BirthDate = @BirthDate, Age = @Age, Gender = @Gender, PhoneNumber = @PhoneNumber, " +
               "EmailAdress = @EmailAdress, PlaceOfBirth = @PlaceOfBirth, Address = @Address, " +
               "StudentImage = @StudentImage, StudentImageFileName = @StudentImageFileName WHERE Id = @Id";

            DialogResult finallize = MessageBox.Show("Are you sure you want to proceed with the entered data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (finallize == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(sd.connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@StudentId", txtStudentId.Text);
                    command.Parameters.AddWithValue("@Id", txtNum.Text);
                    command.Parameters.AddWithValue("@YearSection", txtSection.Text);
                    command.Parameters.AddWithValue("@Course", cmbCourse.Text);
                    command.Parameters.AddWithValue("@StudentType", cmbStudentType.Text);
                    command.Parameters.AddWithValue("@StudentFName", txtFName.Text);
                    command.Parameters.AddWithValue("@StudentMName", txtMName.Text);
                    command.Parameters.AddWithValue("@StudentLName", txtLName.Text);
                    command.Parameters.AddWithValue("@StudentSuffix", txtSuffix.Text);
                    command.Parameters.AddWithValue("@Religion", txtStudentReligion.Text);
                    command.Parameters.AddWithValue("@BirthDate", dtpStudentBirth.Value);
                    command.Parameters.AddWithValue("@Age", txtStudentAge.Text);
                    command.Parameters.AddWithValue("@Gender", cmbGender.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", txtStudentPhone.Text);
                    command.Parameters.AddWithValue("@EmailAdress", txtStudentEmail.Text);
                    command.Parameters.AddWithValue("@PlaceOfBirth", txtStudentPoB.Text);
                    command.Parameters.AddWithValue("@Address", txtStudentAddress.Text);
                    command.Parameters.AddWithValue("@StudentImageFileName", txtFileName.Text);

                    command.Parameters.AddWithValue("@FaName", txtFatherName.Text);

                    SqlParameter imageDataParam = new SqlParameter("@StudentImage", SqlDbType.VarBinary);
                    imageDataParam.Value = imageData;
                    command.Parameters.Add(imageDataParam);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Student Update Successfully");
                        StudentPanelPage studentPanelPage = Application.OpenForms.OfType<StudentPanelPage>().FirstOrDefault();

                        // Update the DataGridView in the StudentPanelPage form
                        studentPanelPage?.txtSearch_TextChanged(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Student Update Not Successfull");
                    }
                }
                Close();
            }
            
        }
        private void importImageButton_Click(object sender, EventArgs e)
        {
            sd = new StudentDatabase();
            //TODO NOT YET FINISH
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png)|*.jpg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbPreview.Image = Image.FromFile(openFileDialog.FileName);
                txtFileName.Text = openFileDialog.FileName;
            }
        }

        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void numChecker(string num, Label lbl)
        {
            long nNum;
            if (!long.TryParse(num, out nNum))
            {

                lbl.Show();
            }
            else
            {

                lbl.Hide();
            }
        }

        private void txtStudentAge_TextChanged(object sender, EventArgs e)
        {
            numChecker(txtStudentAge.Text, lblAgeES);
        }

        private void txtStudentPhone_TextChanged(object sender, EventArgs e)
        {
            numChecker(txtStudentPhone.Text, lblPNES);
        }

        private void txtFatherAge_TextChanged(object sender, EventArgs e)
        {
            numChecker(txtFatherAge.Text, lblAgeEF);
        }

        private void txtFatherPhone_TextChanged(object sender, EventArgs e)
        {
            numChecker(txtFatherPhone.Text, lblPNEF);
        }

        private void txtMotherAge_TextChanged(object sender, EventArgs e)
        {
            numChecker(txtMotherAge.Text, lblAgeEM);
        }

        private void txtMotherPhone_TextChanged(object sender, EventArgs e)
        {
            numChecker(txtMotherPhone.Text, lblPNEM);
        }

        private void txtGuardianPhone_TextChanged(object sender, EventArgs e)
        {
            numChecker(txtGuardianPhone.Text, lblPNEG);
        }

        private void txtGuardianAge_TextChanged(object sender, EventArgs e)
        {
            numChecker(txtGuardianAge.Text, lblAgeEG);
        }

        private int CalculateAge(DateTime birthDate)
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - birthDate.Year;

            // Check if the birth date has not yet occurred this year
            if (birthDate > currentDate.AddYears(-age))
                age--;

            return age;
        }

        private void dtpStudentBirth_ValueChanged(object sender, EventArgs e)
        {
            DateTime studentBirthDate = dtpStudentBirth.Value;
            txtStudentAge.Text = CalculateAge(studentBirthDate).ToString();
        }

        private void dtpFatherBirth_ValueChanged(object sender, EventArgs e)
        {
            DateTime fatherBirthDate = dtpFatherBirth.Value;
            txtFatherAge.Text = CalculateAge(fatherBirthDate).ToString();
        }

        private void dtpMotherBirth_ValueChanged(object sender, EventArgs e)
        {
            DateTime motherBirthDate = dtpMotherBirth.Value;
            txtMotherAge.Text = CalculateAge(motherBirthDate).ToString();
        }

        private void dtpGuardianBirth_ValueChanged(object sender, EventArgs e)
        {
            DateTime guardianBirthDate = dtpGuardianBirth.Value;
            txtGuardianAge.Text = CalculateAge(guardianBirthDate).ToString();
        }
    }
}
