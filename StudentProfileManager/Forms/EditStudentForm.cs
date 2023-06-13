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

            string query = "UPDATE StudentInfo SET StudentId = @StudentId, Year = @Year, Section = @Section, Course = @Course, " +
               "StudentType = @StudentType, StudentFName = @StudentFName, StudentMName = @StudentMName, " +
               "StudentLName = @StudentLName, StudentSuffix = @StudentSuffix, Religion = @Religion, " +
               "BirthDate = @BirthDate, Age = @Age, Gender = @Gender, PhoneNumber = @PhoneNumber, " +
               "EmailAdress = @EmailAdress, PlaceOfBirth = @PlaceOfBirth, Address = @Address, " +
               "StudentImage = @StudentImage, StudentImageFileName = @StudentImageFileName WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(sd.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@StudentId", txtStudentId.Text);
                command.Parameters.AddWithValue("@Id", txtNum.Text);
                command.Parameters.AddWithValue("@Year", txtYear.Text);
                command.Parameters.AddWithValue("@Section", txtSection.Text);
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
                    studentPanelPage?.RefreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Student Update Not Successfull");
                }
            }
            Close();
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
    }
}
