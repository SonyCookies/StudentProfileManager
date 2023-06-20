
namespace StudentProfileManager
{
    partial class DashBoardPanelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentCountPanel = new System.Windows.Forms.Panel();
            this.lblStudentCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentButtonPanel = new System.Windows.Forms.Panel();
            this.lnkStudentCountMoreInfo = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.coursesButtonPanel = new System.Windows.Forms.Panel();
            this.lnkCourseMoreInfo = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCourseCount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sectionButtonPanel = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSectionCount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.studentCountPanel.SuspendLayout();
            this.studentButtonPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.coursesButtonPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.sectionButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // studentCountPanel
            // 
            this.studentCountPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(29)))));
            this.studentCountPanel.Controls.Add(this.studentButtonPanel);
            this.studentCountPanel.Controls.Add(this.pictureBox1);
            this.studentCountPanel.Controls.Add(this.label2);
            this.studentCountPanel.Controls.Add(this.lblStudentCount);
            this.studentCountPanel.Location = new System.Drawing.Point(49, 63);
            this.studentCountPanel.Name = "studentCountPanel";
            this.studentCountPanel.Size = new System.Drawing.Size(250, 170);
            this.studentCountPanel.TabIndex = 0;
            // 
            // lblStudentCount
            // 
            this.lblStudentCount.AutoSize = true;
            this.lblStudentCount.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentCount.Location = new System.Drawing.Point(12, 12);
            this.lblStudentCount.Name = "lblStudentCount";
            this.lblStudentCount.Size = new System.Drawing.Size(71, 38);
            this.lblStudentCount.TabIndex = 3;
            this.lblStudentCount.Text = "200";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Students";
            // 
            // studentButtonPanel
            // 
            this.studentButtonPanel.BackColor = System.Drawing.Color.Black;
            this.studentButtonPanel.Controls.Add(this.lnkStudentCountMoreInfo);
            this.studentButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.studentButtonPanel.Location = new System.Drawing.Point(0, 137);
            this.studentButtonPanel.Name = "studentButtonPanel";
            this.studentButtonPanel.Size = new System.Drawing.Size(250, 33);
            this.studentButtonPanel.TabIndex = 3;
            // 
            // lnkStudentCountMoreInfo
            // 
            this.lnkStudentCountMoreInfo.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(86)))), ((int)(((byte)(28)))));
            this.lnkStudentCountMoreInfo.AutoSize = true;
            this.lnkStudentCountMoreInfo.BackColor = System.Drawing.Color.Transparent;
            this.lnkStudentCountMoreInfo.ForeColor = System.Drawing.Color.White;
            this.lnkStudentCountMoreInfo.LinkColor = System.Drawing.Color.White;
            this.lnkStudentCountMoreInfo.Location = new System.Drawing.Point(90, 6);
            this.lnkStudentCountMoreInfo.Name = "lnkStudentCountMoreInfo";
            this.lnkStudentCountMoreInfo.Size = new System.Drawing.Size(73, 19);
            this.lnkStudentCountMoreInfo.TabIndex = 5;
            this.lnkStudentCountMoreInfo.TabStop = true;
            this.lnkStudentCountMoreInfo.Text = "More Info";
            this.lnkStudentCountMoreInfo.VisitedLinkColor = System.Drawing.Color.White;
            this.lnkStudentCountMoreInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkStudentCountMoreInfo_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(101)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.coursesButtonPanel);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblCourseCount);
            this.panel1.Location = new System.Drawing.Point(360, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 170);
            this.panel1.TabIndex = 4;
            // 
            // coursesButtonPanel
            // 
            this.coursesButtonPanel.BackColor = System.Drawing.Color.Black;
            this.coursesButtonPanel.Controls.Add(this.lnkCourseMoreInfo);
            this.coursesButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.coursesButtonPanel.Location = new System.Drawing.Point(0, 137);
            this.coursesButtonPanel.Name = "coursesButtonPanel";
            this.coursesButtonPanel.Size = new System.Drawing.Size(250, 33);
            this.coursesButtonPanel.TabIndex = 3;
            // 
            // lnkCourseMoreInfo
            // 
            this.lnkCourseMoreInfo.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(29)))));
            this.lnkCourseMoreInfo.AutoSize = true;
            this.lnkCourseMoreInfo.BackColor = System.Drawing.Color.Transparent;
            this.lnkCourseMoreInfo.ForeColor = System.Drawing.Color.White;
            this.lnkCourseMoreInfo.LinkColor = System.Drawing.Color.White;
            this.lnkCourseMoreInfo.Location = new System.Drawing.Point(90, 6);
            this.lnkCourseMoreInfo.Name = "lnkCourseMoreInfo";
            this.lnkCourseMoreInfo.Size = new System.Drawing.Size(73, 19);
            this.lnkCourseMoreInfo.TabIndex = 5;
            this.lnkCourseMoreInfo.TabStop = true;
            this.lnkCourseMoreInfo.Text = "More Info";
            this.lnkCourseMoreInfo.VisitedLinkColor = System.Drawing.Color.White;
            this.lnkCourseMoreInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCourseMoreInfo_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Courses";
            // 
            // lblCourseCount
            // 
            this.lblCourseCount.AutoSize = true;
            this.lblCourseCount.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseCount.ForeColor = System.Drawing.Color.White;
            this.lblCourseCount.Location = new System.Drawing.Point(12, 12);
            this.lblCourseCount.Name = "lblCourseCount";
            this.lblCourseCount.Size = new System.Drawing.Size(35, 38);
            this.lblCourseCount.TabIndex = 3;
            this.lblCourseCount.Text = "8";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(29)))));
            this.panel2.Controls.Add(this.sectionButtonPanel);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblSectionCount);
            this.panel2.Location = new System.Drawing.Point(671, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 170);
            this.panel2.TabIndex = 1;
            // 
            // sectionButtonPanel
            // 
            this.sectionButtonPanel.BackColor = System.Drawing.Color.Black;
            this.sectionButtonPanel.Controls.Add(this.linkLabel2);
            this.sectionButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sectionButtonPanel.Location = new System.Drawing.Point(0, 137);
            this.sectionButtonPanel.Name = "sectionButtonPanel";
            this.sectionButtonPanel.Size = new System.Drawing.Size(250, 33);
            this.sectionButtonPanel.TabIndex = 3;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(86)))), ((int)(((byte)(28)))));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.ForeColor = System.Drawing.Color.White;
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(90, 6);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(93, 19);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Find Section";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sections";
            // 
            // lblSectionCount
            // 
            this.lblSectionCount.AutoSize = true;
            this.lblSectionCount.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectionCount.Location = new System.Drawing.Point(12, 12);
            this.lblSectionCount.Name = "lblSectionCount";
            this.lblSectionCount.Size = new System.Drawing.Size(53, 38);
            this.lblSectionCount.TabIndex = 3;
            this.lblSectionCount.Text = "23";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentProfileManager.Properties.Resources.icons8_students_100;
            this.pictureBox1.Location = new System.Drawing.Point(134, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StudentProfileManager.Properties.Resources.icons8_graduation_cap_100;
            this.pictureBox2.Location = new System.Drawing.Point(134, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::StudentProfileManager.Properties.Resources.icons8_class_100;
            this.pictureBox3.Location = new System.Drawing.Point(134, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // DashBoardPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(970, 612);
            this.ControlBox = false;
            this.Controls.Add(this.studentCountPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DashBoardPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashBoardPanelForm_Load);
            this.studentCountPanel.ResumeLayout(false);
            this.studentCountPanel.PerformLayout();
            this.studentButtonPanel.ResumeLayout(false);
            this.studentButtonPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.coursesButtonPanel.ResumeLayout(false);
            this.coursesButtonPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.sectionButtonPanel.ResumeLayout(false);
            this.sectionButtonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel studentCountPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStudentCount;
        private System.Windows.Forms.Panel studentButtonPanel;
        private System.Windows.Forms.LinkLabel lnkStudentCountMoreInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel coursesButtonPanel;
        private System.Windows.Forms.LinkLabel lnkCourseMoreInfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCourseCount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sectionButtonPanel;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSectionCount;
    }
}