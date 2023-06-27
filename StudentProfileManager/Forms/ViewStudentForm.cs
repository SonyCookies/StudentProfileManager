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

        private void SetStudentData()
        {
            using (SqlConnection connection = new SqlConnection(sd.connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM StudentInfo WHERE Id = @ID";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ID", selectedIdentifier);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    lblStudentId.Text = reader["StudentId"].ToString();
                    lblStudentName.Text = $"{reader["StudentFName"]} {reader["StudentMName"]} {reader["StudentLName"]}";
                    lblStudentCourse.Text = reader["Course"].ToString();
                    lblStudentBirthDate.Text = ((DateTime) reader["BirthDate"]).ToString("MM/dd/yyyy");
                    lblStudentYearSection.Text = $"{reader["YearSection"]}";
                    lblStudentType.Text = reader["StudentType"].ToString();
                    lblStudentGender.Text = reader["Gender"].ToString();
                    lblStudentAge.Text = reader["Age"].ToString();
                    lblStudentPhoneNumber.Text = reader["PhoneNumber"].ToString();
                    lblStudentEmail.Text = reader["EmailAdress"].ToString();
                    lblStudentReligion.Text = reader["Religion"].ToString();
                    lblStudentBirth.Text = reader["PlaceOfBirth"].ToString();
                    lblStudentAddress.Text = reader["Address"].ToString();
                    pbStudentImage.Image = ConvertByteToArrayToImage((byte[])reader["StudentImage"]);


                    FatherNameLabel.Text = reader["FaName"].ToString();
                    FatherOccupationLabel.Text = reader["FaOccupation"].ToString();
                    FatherAddressLabel.Text = reader["FaAddress"].ToString();
                    FatherBirthDateLabel.Text = ((DateTime)reader["FaBirthDate"]).ToString("MM/dd/yyyy");
                    FatherAgeLabel.Text = reader["FaAge"].ToString();
                    FatherPhoneNumberLabel.Text = reader["FaPhoneNumber"].ToString();
                    FatherEmailAddressLabel.Text = reader["FaEmailAddress"].ToString();


                    MotherNameLabel.Text = reader["MoName"].ToString();
                    MotherOccupationLabel.Text = reader["MoOccupation"].ToString();
                    MotherAddressLabel.Text = reader["MoAddress"].ToString();
                    MotherBirthDateLabel.Text = ((DateTime)reader["MoBirthDate"]).ToString("MM/dd/yyyy");
                    MotherAgeLabel.Text = reader["MoAge"].ToString();
                    MotherPhoneNumberLabel.Text = reader["MoPhoneNumber"].ToString();
                    MotherEmailAddressLabel.Text = reader["MoEmailAddress"].ToString();

                    GuardianNameLabel.Text = reader["GuName"].ToString();
                    GuardianOccupationLabel.Text = reader["GuRelation"].ToString();
                    GuardianAddressLabel.Text = reader["GuAddress"].ToString();
                    GuardianBirthDateLabel.Text = ((DateTime)reader["GuBirthDate"]).ToString("MM/dd/yyyy");
                    GuardianAgeLabel.Text = reader["GuAge"].ToString();
                    GuardianPhoneNumberLabel.Text = reader["GuPhoneNumber"].ToString();
                    GuardianRelationLabel.Text = reader["GuRelation"].ToString();
                }

                reader.Close();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
