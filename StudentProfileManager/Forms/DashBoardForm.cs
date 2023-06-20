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
    public partial class DashBoardForm : Form
    {

        public Button currentButton;
        private Form activeForm;
        private string adminEntered;

        public DashBoardForm(string username)
        {
            InitializeComponent();
            adminEntered = username;
        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
            
            lblLogo.Click += new EventHandler(Label_Click);
            pbLogo.Click += new EventHandler(Label_Click);

            StudentDatabase sDb = new StudentDatabase();
        }

        // TO MADE SOME SPECIFICATION WHEN A CURRENT BUTTON IS ACTIVATED OR CLICKED
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null && btnSender is Button)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(46, 103, 33);
                    currentButton.ForeColor = Color.FromArgb(255, 204, 29);
                    currentButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        // DISABLE THE BUTTON THAT HAVE BEEN CLICKED BEFORE THUS RETURNING THE ORIGINAL COLOR AND FONT OF THE TEXT
        private void DisableButton()
        {
            foreach(Control previousBtn in pnlMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.ForeColor = Color.White;
                    previousBtn.BackColor = Color.FromArgb(39, 86, 28);
                    previousBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        // TO OPEN THE FORM IN THE PANEL
        public void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.FormClosed -= ActiveForm_FormClosed;
                activeForm.Close();
            }

            ActivateButton(btnSender as Button);
            activeForm = childForm;
            activeForm.FormClosed -= ActiveForm_FormClosed;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlContainer.Controls.Add(childForm);
            pnlContainer.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();

            lblHeader.Text = childForm.Text;

            pictureBox1.Hide();
            
        }
        private void ActiveForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            activeForm = null;
        }

        private void btnStudentPage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudentPanelPage(), sender);
        }

        private void btnAddStudentPage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddStudentPanelPage(), sender);
        }

        private void btnDashBoardPage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DashBoardPanelForm(), sender);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ExitForm exForm = new ExitForm();
            exForm.Show();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
            Close();

        }

        private void Label_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();   
        }

        private void Reset()
        {
            DisableButton();
            lblHeader.Text = "Welcome";
            currentButton = null;
            pictureBox1.Show();
        }

        private void btnAdminProfile_Click(object sender, EventArgs e)
        {
            AdminForm amForm = new AdminForm(adminEntered);
            amForm.Show();
        }
    }
}
