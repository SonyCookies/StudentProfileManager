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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {
                AdminDatabase db = new AdminDatabase();

                if (db.CheckLoginCredentials(username, password))
                {
                    DashBoardForm dbForm = new DashBoardForm();
                    dbForm.Show();
                    Close();
                }
                else
                {
                    if (txtUsername.Text == "")
                    {
                        if (txtPassword.Text == "")
                        {
                            lblInvalid.Text = "*Please enter username and password.";
                        }
                        else
                        {
                            lblInvalid.Text = "*Please enter username.";
                        }
                    }
                    else
                    {
                        if (txtPassword.Text == "")
                        {
                            lblInvalid.Text = "*Please enter password.";
                        }
                        else
                        {
                            lblInvalid.Text = "*Invalid username or password.";

                            txtPassword.Text = string.Empty;
                            txtUsername.Text = string.Empty;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }    

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitForm ext = new ExitForm();
            ext.Show();
        }

        private void btnTogglePass_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                // Password is currently hidden, so show it
                txtPassword.UseSystemPasswordChar = false;
                btnTogglePass.Image = Properties.Resources.visibility_off_FILL0_wght400_GRAD0_opsz20;
            }
            else
            {
                // Password is currently shown, so hide it
                txtPassword.UseSystemPasswordChar = true;
                btnTogglePass.Image = Properties.Resources.visibility_FILL0_wght400_GRAD0_opsz20;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                btnTogglePass.Show();
                btnTogglePass.Image = Properties.Resources.visibility_off_FILL0_wght400_GRAD0_opsz20;
            }
            if (txtPassword.Text == "")
            {
                btnTogglePass.Hide();
            }
        }
    }
}
