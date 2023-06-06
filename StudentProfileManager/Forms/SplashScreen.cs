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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void loadTimer_Tick(object sender, EventArgs e)
        {
            loadPanel.Width += 3;
            if (loadPanel.Width >= 800)
            {
                loadTimer.Stop();
                LoginForm lf = new LoginForm();
                lf.Show();
                Hide();

            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            loadTimer.Interval = 8;
            loadTimer.Start();
        }
    }
}
