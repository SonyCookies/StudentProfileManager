using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;



namespace StudentProfileManager
{
    public partial class AddStudentPanelPage : Form
    {

        StudentDatabase sd;
        public AddStudentPanelPage()
        {
            
            InitializeComponent();
            lblInvSPN.Hide();
            lblInvFPN.Hide();
            lblInvMPN.Hide();
            lblInvGPN.Hide();

            lblAgeS.Hide();
            lblAgeF.Hide();
            lblAgeM.Hide();
            lblAgeG.Hide();

            txtSection.Mask = "0-L0";
        }


        private void Clear()
        {
            txtStudentId.Clear();
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

        private void AddStudentPanelPage_Load(object sender, EventArgs e)
        {
            sd = new StudentDatabase();
        }


        private void btnAddStud_Click(object sender, EventArgs e)
        {

            byte[] imageData;
           
            if (string.IsNullOrEmpty(txtStudentId.Text) ||
                string.IsNullOrEmpty(txtSection.Text) || string.IsNullOrEmpty(cmbCourse.Text) ||
                string.IsNullOrEmpty(cmbStudentType.Text) || string.IsNullOrEmpty(txtFName.Text) ||
                string.IsNullOrEmpty(txtMName.Text) || string.IsNullOrEmpty(txtLName.Text) ||
                string.IsNullOrEmpty(txtStudentReligion.Text) || string.IsNullOrEmpty(txtStudentAge.Text) ||
                string.IsNullOrEmpty(txtStudentPhone.Text) || string.IsNullOrEmpty(txtStudentEmail.Text) ||
                string.IsNullOrEmpty(txtStudentPoB.Text) || string.IsNullOrEmpty(txtStudentAddress.Text) ||
                string.IsNullOrEmpty(txtFileName.Text) || string.IsNullOrEmpty(txtFatherName.Text) ||
                string.IsNullOrEmpty(txtFatherAddress.Text) || string.IsNullOrEmpty(txtFatherPhone.Text) ||
                string.IsNullOrEmpty(txtMotherName.Text) || string.IsNullOrEmpty(txtMotherAddress.Text) ||
                string.IsNullOrEmpty(txtMotherPhone.Text) || string.IsNullOrEmpty(txtGuardianName.Text) ||
                string.IsNullOrEmpty(txtGuardianRS.Text) || string.IsNullOrEmpty(txtGuardianAddress.Text) ||
                string.IsNullOrEmpty(txtGuardianPhone.Text))
            {
                MessageBox.Show("Please fill in all required fields."); //
                return;
            }
            imageData = ConvertImageToBytes(pbPreview.Image);

            string query = "INSERT INTO StudentInfo (StudentId, YearSection, Course, StudentType, " +
                "StudentFName, StudentMName, StudentLName, StudentSuffix, Religion, BirthDate, Age, Gender, " +
                "PhoneNumber, EmailAdress, PlaceOfBirth, Address, StudentImage, StudentImageFileName, FaName, FaOccupation, FaAddress, FaAge, " +
                "FaBirthDate, FaPhoneNumber, FaEmailAddress, MoName, MoOccupation, MoAddress, MoBirthDate, MoAge, " +
                "MoPhoneNumber, MoEmailAddress, GuName, GuRelation, GuOccupation, GuPhoneNumber, " +
                "GuBirthDate, GuAge, GuAddress) VALUES (@StudentId, @YearSection, @Course, @StudentType, " +
                "@StudentFName, @StudentMName, @StudentLName, @StudentSuffix, @Religion, @BirthDate, @Age, @Gender, " +
                "@PhoneNumber, @EmailAdress, @PlaceOfBirth, @Address, @StudentImage, @StudentImageFileName, @FaName, @FaOccupation, @FaAddress, @FaAge, " +
                "@FaBirthDate, @FaPhoneNumber, @FaEmailAddress, @MoName, @MoOccupation, @MoAddress, @MoBirthDate, @MoAge, " +
                "@MoPhoneNumber, @MoEmailAddress, @GuName, @GuRelation, @GuOccupation, @GuPhoneNumber, " +
                "@GuBirthDate, @GuAge, @GuAddress)";

            DialogResult finallize = MessageBox.Show("Are you sure you want to proceed with the entered data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (finallize == DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand(query, sd.connection);
                command.Parameters.AddWithValue("@StudentId", txtStudentId.Text);
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
                command.Parameters.AddWithValue("@FaOccupation", txtFatherOcc.Text);
                command.Parameters.AddWithValue("@FaAddress", txtFatherAddress.Text);
                command.Parameters.AddWithValue("@FaAge", txtFatherAge.Text);
                command.Parameters.AddWithValue("@FaBirthDate", dtpFatherBirth.Value);
                command.Parameters.AddWithValue("@FaPhoneNumber", txtFatherPhone.Text);
                command.Parameters.AddWithValue("@FaEmailAddress", txtFatherEmail.Text);
                command.Parameters.AddWithValue("@MoName", txtMotherName.Text);
                command.Parameters.AddWithValue("@MoOccupation", txtMotherOcc.Text);
                command.Parameters.AddWithValue("@MoAddress", txtMotherAddress.Text);
                command.Parameters.AddWithValue("@MoBirthDate", dtpMotherBirth.Value);
                command.Parameters.AddWithValue("@MoAge", txtMotherAge.Text);
                command.Parameters.AddWithValue("@MoPhoneNumber", txtMotherPhone.Text);
                command.Parameters.AddWithValue("@MoEmailAddress", txtMotherEmail.Text);
                command.Parameters.AddWithValue("@GuName", txtGuardianName.Text);
                command.Parameters.AddWithValue("@GuRelation", txtGuardianRS.Text);
                command.Parameters.AddWithValue("@GuOccupation", txtGuardianOcc.Text);
                command.Parameters.AddWithValue("@GuPhoneNumber", txtGuardianPhone.Text);
                command.Parameters.AddWithValue("@GuBirthDate", dtpGuardianBirth.Value);
                command.Parameters.AddWithValue("@GuAge", txtGuardianAge.Text);
                command.Parameters.AddWithValue("@GuAddress", txtGuardianAddress.Text);

                SqlParameter imageDataParam = new SqlParameter("@StudentImage", SqlDbType.VarBinary);
                imageDataParam.Value = imageData;
                command.Parameters.Add(imageDataParam);

                if (command.ExecuteNonQuery() > 0)  
                {
                    Clear();
                    MessageBox.Show("Student Added Successfully");
                }
                else
                {
                    MessageBox.Show("Adding of Student is Unsuccessful");
                }

                if (ParentForm is DashBoardForm dashboardForm)
                {
                    dashboardForm.OpenChildForm(new StudentPanelPage(), dashboardForm.btnStudentPage);
                }
            }
            else
            {

            }
        }

        byte[] ConvertImageToBytes(Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
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

        private void txtMotherPhone_TextChanged(object sender, EventArgs e)
        {
            numChecker(txtMotherPhone.Text, lblInvMPN);
        }

        private void txtStudentPhone_TextChanged(object sender, EventArgs e)
        {
            numChecker(txtStudentPhone.Text, lblInvSPN);
        }

        private void txtFatherPhone_TextChanged(object sender, EventArgs e)
        {
            numChecker(txtFatherPhone.Text, lblInvFPN);
        }

        private void txtGuardianPhone_TextChanged(object sender, EventArgs e)
        {
            numChecker(txtGuardianPhone.Text, lblInvGPN);
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentAge_TextChanged(object sender, EventArgs e)
        {
            numChecker(txtStudentAge.Text, lblAgeS);
        }

        private void txtFatherAge_TextChanged(object sender, EventArgs e)
        {
            numChecker(txtFatherAge.Text, lblAgeF);
        }

        private void txtMotherAge_TextChanged(object sender, EventArgs e)
        {
            numChecker(txtMotherAge.Text, lblAgeM);
        }

        private void txtGuardianAge_TextChanged(object sender, EventArgs e)
        {
            numChecker(txtGuardianAge.Text, lblAgeG);
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



        private int CalculateAge(DateTime birthDate)
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - birthDate.Year;

            // Check if the birth date has not yet occurred this year
            if (birthDate > currentDate.AddYears(-age))
                age--;

            return age;
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
