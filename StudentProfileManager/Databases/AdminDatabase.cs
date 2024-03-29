﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentProfileManager
{
    class AdminDatabase
    {
        private SqlConnection connection;
        public AdminDatabase()
        {
            OpenConnection();
            // Open the connection once an instance of AdminDatabase was created.
        }
        private void OpenConnection()
        {
            // Establish the database connection
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\toxic\\source\\repos\\StudentProfileManager\\StudentProfileManager\\StudentProfileManagerDatabase.mdf; Integrated Security = True";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        //TO UNDERSTAND 
        public bool CheckLoginCredentials(string username, string password)
        {
            string sqlQuery = "SELECT COUNT(*) FROM Admin WHERE username = @username AND password = @password";
            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        public int ChangePassword(TextBox txtPassword, Label lblUsername)
        {
            string query = "UPDATE Admin SET password = @password WHERE username = @username";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@password", txtPassword.Text);
            command.Parameters.AddWithValue("@username", lblUsername.Text);

            return command.ExecuteNonQuery();


        }

    }
}
