﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace StudentProfileManager
{
    class StudentDatabase
    {
        private SqlConnection connection;
        private SqlCommand cmd;
        public string addquery;
        private DataTable dT;
        private SqlDataAdapter dAdapter;

        public StudentDatabase()
        {
            OpenConnection();
        }

        private void OpenConnection()
        {
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\toxic\\source\\repos\\StudentProfileManager\\StudentProfileManager\\StudentProfileManagerDatabase.mdf; Integrated Security = True";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public int cud(string query)
        {
            /*cmd = new SqlCommand("INSERT INTO StudentInfo (StudentId, YearLvl, Course, Section, StudentType, FName, MName, LName, Suffix, " +
                "Religion, BirthDate, Age, PhoneNumber, EmailAdress, PlaceOfBirth, Address, " +
                "FaName, FaOccupation, FaAddress, FaBirthDate, FaAge, FaPhoneNumber, FaEmailAddress, MoName, " +
                "MoOccupation, MoAddress, MoBirthDate, MoAge, MoPhoneNumber, MoEmailAddress, GuName, GuRelation," +
                "GuOccupation, GuPhoneNumber, GuBirthDate, GuAge, GuAddress) VALUES ('MCC2022-0225')", connection);*/
            cmd = new SqlCommand(query, connection);
            return cmd.ExecuteNonQuery();
        }

        public DataTable GetStudentData(string query)
        {
            DataTable dTable = new DataTable();
            dTable.Columns.Add("StudentId", typeof(string));
            dTable.Columns.Add("StudentName", typeof(string));
            dTable.Columns.Add("Course", typeof(string));
            dTable.Columns.Add("YearSection", typeof(string));
            dTable.Columns.Add("StudentType", typeof(string));

            SqlDataAdapter dAdapter = new SqlDataAdapter(query, connection);
            DataTable origDTable = new DataTable();
            dAdapter.Fill(origDTable);

            foreach (DataRow row in origDTable.Rows)
            {
                string studentId = row["StudentId"].ToString();
                string fName = row["StudentFName"].ToString();
                string mName = row["StudentMName"].ToString();
                string lName = row["StudentLName"].ToString();
                string s = row["StudentSuffix"].ToString();
                string fullName = $"{lName}, {fName} {mName}";
                string course = row["Course"].ToString();
                string year = row["Year"].ToString();
                string section = row["Section"].ToString();
                string yearSection = $"{year.Trim()}-{section}";
                string typeOfStudent = row["StudentType"].ToString();

                dTable.Rows.Add(studentId, fullName, course, yearSection, typeOfStudent);
            }
            return dTable;
        }
    }
}
