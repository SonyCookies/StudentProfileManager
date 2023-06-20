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
    public partial class CoursesForm : Form
    {
        public CoursesForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CoursesForm_Load(object sender, EventArgs e)
        {
            bsitPanel.BackColor = Color.FromArgb(100, Color.Black);
            bsedPanel.BackColor = Color.FromArgb(100, Color.Black);
            btvtedPanel.BackColor = Color.FromArgb(100, Color.Black);
            bscrimPanel.BackColor = Color.FromArgb(100, Color.Black);
            bstmPanel.BackColor = Color.FromArgb(100, Color.Black);
            bshmPanel.BackColor = Color.FromArgb(100, Color.Black);
            abpsychPanel.BackColor = Color.FromArgb(100, Color.Black);
            abengPanel.BackColor = Color.FromArgb(100, Color.Black);
        }
    }
}
