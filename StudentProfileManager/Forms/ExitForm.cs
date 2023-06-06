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
    public partial class ExitForm : Form
    {
        public ExitForm()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            LoginForm lgn = new LoginForm();
            lgn.Close();
            Application.Exit();

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
