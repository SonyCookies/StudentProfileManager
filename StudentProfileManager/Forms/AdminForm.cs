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
    public partial class AdminForm : Form
    {
        private string adminEntered;
        public AdminForm(string username)
        {
            InitializeComponent();
            adminEntered = username;
        }

        private void txtAdminCurPass_TextChanged(object sender, EventArgs e)
        {
            
            if (txtAdminCurPass.UseSystemPasswordChar)
            {
                if (txtAdminCurPass.Text != "")
                {
                    btnToggleCurPass.Show();
                }
                if (txtAdminCurPass.Text == "")
                {
                    btnToggleCurPass.Hide();
                }
                btnToggleCurPass.Image = Properties.Resources.visibility_off_FILL0_wght400_GRAD0_opsz20;
            }
            else
            {
                if (txtAdminCurPass.Text == "")
                {
                    btnToggleCurPass.Hide();
                }
                if (txtAdminCurPass.Text != "")
                {
                    btnToggleCurPass.Show();
                }
                btnToggleCurPass.Image = Properties.Resources.visibility_FILL0_wght400_GRAD0_opsz20;
            }
            
        }

        private void btnToggleCurPass_Click(object sender, EventArgs e)
        {
            if (txtAdminCurPass.UseSystemPasswordChar)
            {
                // Password is currently hidden, so show it
                txtAdminCurPass.UseSystemPasswordChar = false;
                btnToggleCurPass.Image = Properties.Resources.visibility_FILL0_wght400_GRAD0_opsz20;
            }
            else
            {
                // Password is currently shown, so hide it
                txtAdminCurPass.UseSystemPasswordChar = true;
                btnToggleCurPass.Image = Properties.Resources.visibility_off_FILL0_wght400_GRAD0_opsz20;
                
            }
        }

        private void txtAdminNewPass_TextChanged(object sender, EventArgs e)
        {
            if (txtAdminNewPass.TextLength < 8 && txtAdminNewPass.TextLength > 0)
            {
                lblInvalid.Text = "*New password must be at least 8 characters long!";
                btnChangePass.Enabled = false;
            }
            else
            {
                lblInvalid.Text = "";
                btnChangePass.Enabled = true;
            }
            if (txtAdminNewPass.UseSystemPasswordChar)
            {
                if (txtAdminNewPass.Text != "")
                {
                    btnToggleNewPass.Show();
                }
                if (txtAdminNewPass.Text == "")
                {
                    btnToggleNewPass.Hide();
                }
                btnToggleNewPass.Image = Properties.Resources.visibility_off_FILL0_wght400_GRAD0_opsz20;
            }
            else
            {
                if (txtAdminNewPass.Text == "")
                {
                    btnToggleNewPass.Hide();
                }
                if (txtAdminNewPass.Text != "")
                {
                    btnToggleNewPass.Show();
                }
                btnToggleNewPass.Image = Properties.Resources.visibility_FILL0_wght400_GRAD0_opsz20;
            }
        }

        private void btnToggleNewPass_Click(object sender, EventArgs e)
        {
            if (txtAdminNewPass.UseSystemPasswordChar)
            {
                // Password is currently hidden, so show it
                txtAdminNewPass.UseSystemPasswordChar = false;
                btnToggleNewPass.Image = Properties.Resources.visibility_FILL0_wght400_GRAD0_opsz20;
            }
            else
            {
                // Password is currently shown, so hide it
                txtAdminNewPass.UseSystemPasswordChar = true;
                btnToggleNewPass.Image = Properties.Resources.visibility_off_FILL0_wght400_GRAD0_opsz20;

            }
        }

        private void txtAdminConPass_TextChanged(object sender, EventArgs e)
        {
            if (txtAdminConPass.TextLength < 8 && txtAdminConPass.TextLength > 0)
            {
                lblInvalid.Text = "*Password must be at least 8 characters long!";
                btnChangePass.Enabled = false;
            }
            else
            {
                lblInvalid.Text = "";
                btnChangePass.Enabled = true;
            }
            if (txtAdminConPass.UseSystemPasswordChar)
            {
                if (txtAdminConPass.Text != "")
                {
                    btnToggleConPass.Show();
                }
                if (txtAdminConPass.Text == "")
                {
                    btnToggleConPass.Hide();
                }
                btnToggleConPass.Image = Properties.Resources.visibility_off_FILL0_wght400_GRAD0_opsz20;
            }
            else
            {
                if (txtAdminConPass.Text == "")
                {
                    btnToggleConPass.Hide();
                }
                if (txtAdminConPass.Text != "")
                {
                    btnToggleConPass.Show();
                }
                btnToggleConPass.Image = Properties.Resources.visibility_FILL0_wght400_GRAD0_opsz20;
            }
        }

        private void btnToggleConPass_Click(object sender, EventArgs e)
        {
            if (txtAdminConPass.UseSystemPasswordChar)
            {
                // Password is currently hidden, so show it
                txtAdminConPass.UseSystemPasswordChar = false;
                btnToggleConPass.Image = Properties.Resources.visibility_FILL0_wght400_GRAD0_opsz20;
            }
            else
            {
                // Password is currently shown, so hide it
                txtAdminConPass.UseSystemPasswordChar = true;
                btnToggleConPass.Image = Properties.Resources.visibility_off_FILL0_wght400_GRAD0_opsz20;

            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            string username = txtAdminUsername.Text;
            string password = txtAdminCurPass.Text;
            string newPass = txtAdminNewPass.Text;
            string conPass = txtAdminConPass.Text;

            try
            {
                AdminDatabase db = new AdminDatabase();

                if (db.CheckLoginCredentials(username, password) && newPass == conPass)
                {
                    db.ChangePassword(txtAdminConPass, lblAdminUsername);
                    MessageBox.Show("Password Changed Successfully.");
                    Close();
                }
                else
                {
                    if (username == "")
                    {
                        if (password == "")
                        {
                            lblInvalid.Text = "*Please enter username and password.";
                        }
                        else
                        {
                            lblInvalid.Text = "*Please enter username.";
                        }
                    }
                    else if(newPass == "")
                    {
                        lblInvalid.Text = "*New password is empty!";
                    }
                    else if (conPass == "")
                    {
                        lblInvalid.Text = "*Confirm password is empty!";
                    }
                    else if (newPass != conPass)
                    {
                        lblInvalid.Text = "*Password don't match!";
                    }
                    else
                    {
                        if (password == "")
                        {
                            lblInvalid.Text = "*Please enter password.";
                        }
                        else
                        {
                            txtAdminCurPass.Text = string.Empty;
                            txtAdminUsername.Text = string.Empty;
                            txtAdminConPass.Text = string.Empty;
                            txtAdminNewPass.Text = string.Empty;

                            lblInvalid.Text = "*Password incorrect.";
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            lblAdminUsername.Text = adminEntered;
            btnChangePass.Enabled = false;
            txtAdminUsername.Text = lblAdminUsername.Text;
            txtAdminUsername.ReadOnly = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
