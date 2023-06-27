
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoardPanelForm));
            this.studentCountPanel = new System.Windows.Forms.Panel();
            this.studentButtonPanel = new System.Windows.Forms.Panel();
            this.lnkStudentCountMoreInfo = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStudentCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.coursesButtonPanel = new System.Windows.Forms.Panel();
            this.lnkCollegeMoreInfo = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCourseCount = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dayContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMonth = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.studentCountPanel.SuspendLayout();
            this.studentButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.coursesButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentCountPanel
            // 
            this.studentCountPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(29)))));
            this.studentCountPanel.Controls.Add(this.studentButtonPanel);
            this.studentCountPanel.Controls.Add(this.pictureBox1);
            this.studentCountPanel.Controls.Add(this.label2);
            this.studentCountPanel.Controls.Add(this.lblStudentCount);
            this.studentCountPanel.Location = new System.Drawing.Point(49, 22);
            this.studentCountPanel.Name = "studentCountPanel";
            this.studentCountPanel.Size = new System.Drawing.Size(400, 115);
            this.studentCountPanel.TabIndex = 0;
            // 
            // studentButtonPanel
            // 
            this.studentButtonPanel.BackColor = System.Drawing.Color.Black;
            this.studentButtonPanel.Controls.Add(this.lnkStudentCountMoreInfo);
            this.studentButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.studentButtonPanel.Location = new System.Drawing.Point(0, 82);
            this.studentButtonPanel.Name = "studentButtonPanel";
            this.studentButtonPanel.Size = new System.Drawing.Size(400, 33);
            this.studentButtonPanel.TabIndex = 3;
            this.studentButtonPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.studentButtonPanel_Paint);
            // 
            // lnkStudentCountMoreInfo
            // 
            this.lnkStudentCountMoreInfo.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(86)))), ((int)(((byte)(28)))));
            this.lnkStudentCountMoreInfo.BackColor = System.Drawing.Color.Transparent;
            this.lnkStudentCountMoreInfo.ForeColor = System.Drawing.Color.White;
            this.lnkStudentCountMoreInfo.LinkColor = System.Drawing.Color.White;
            this.lnkStudentCountMoreInfo.Location = new System.Drawing.Point(0, 6);
            this.lnkStudentCountMoreInfo.Name = "lnkStudentCountMoreInfo";
            this.lnkStudentCountMoreInfo.Size = new System.Drawing.Size(394, 19);
            this.lnkStudentCountMoreInfo.TabIndex = 5;
            this.lnkStudentCountMoreInfo.TabStop = true;
            this.lnkStudentCountMoreInfo.Text = "More info";
            this.lnkStudentCountMoreInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkStudentCountMoreInfo.VisitedLinkColor = System.Drawing.Color.White;
            this.lnkStudentCountMoreInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkStudentCountMoreInfo_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentProfileManager.Properties.Resources.icons8_student_1003;
            this.pictureBox1.Location = new System.Drawing.Point(317, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(101)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.coursesButtonPanel);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblCourseCount);
            this.panel1.Location = new System.Drawing.Point(521, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 115);
            this.panel1.TabIndex = 4;
            // 
            // coursesButtonPanel
            // 
            this.coursesButtonPanel.BackColor = System.Drawing.Color.Black;
            this.coursesButtonPanel.Controls.Add(this.lnkCollegeMoreInfo);
            this.coursesButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.coursesButtonPanel.Location = new System.Drawing.Point(0, 82);
            this.coursesButtonPanel.Name = "coursesButtonPanel";
            this.coursesButtonPanel.Size = new System.Drawing.Size(400, 33);
            this.coursesButtonPanel.TabIndex = 3;
            // 
            // lnkCollegeMoreInfo
            // 
            this.lnkCollegeMoreInfo.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(29)))));
            this.lnkCollegeMoreInfo.BackColor = System.Drawing.Color.Transparent;
            this.lnkCollegeMoreInfo.ForeColor = System.Drawing.Color.White;
            this.lnkCollegeMoreInfo.LinkColor = System.Drawing.Color.White;
            this.lnkCollegeMoreInfo.Location = new System.Drawing.Point(0, 6);
            this.lnkCollegeMoreInfo.Name = "lnkCollegeMoreInfo";
            this.lnkCollegeMoreInfo.Size = new System.Drawing.Size(400, 19);
            this.lnkCollegeMoreInfo.TabIndex = 5;
            this.lnkCollegeMoreInfo.TabStop = true;
            this.lnkCollegeMoreInfo.Text = "More info";
            this.lnkCollegeMoreInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkCollegeMoreInfo.VisitedLinkColor = System.Drawing.Color.White;
            this.lnkCollegeMoreInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCollegeMoreInfo_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StudentProfileManager.Properties.Resources.icons8_graduation_cap_100;
            this.pictureBox2.Location = new System.Drawing.Point(327, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Colleges";
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
            this.lblCourseCount.Text = "5";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(29)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(778, 28);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(92, 27);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(101)))), ((int)(((byte)(48)))));
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(11, 28);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(92, 27);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sunday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Monday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tuesday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Wednesday";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(524, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Thursday";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(653, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Friday";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(765, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 19);
            this.label10.TabIndex = 14;
            this.label10.Text = "Saturday";
            // 
            // dayContainer
            // 
            this.dayContainer.Location = new System.Drawing.Point(11, 106);
            this.dayContainer.Name = "dayContainer";
            this.dayContainer.Size = new System.Drawing.Size(859, 335);
            this.dayContainer.TabIndex = 15;
            // 
            // lblMonth
            // 
            this.lblMonth.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(6, 25);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(868, 38);
            this.lblMonth.TabIndex = 16;
            this.lblMonth.Text = "July";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dayContainer);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnPrevious);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblMonth);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(49, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 447);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
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
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DashBoardPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashBoardPanelForm_Load);
            this.studentCountPanel.ResumeLayout(false);
            this.studentCountPanel.PerformLayout();
            this.studentButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.coursesButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.LinkLabel lnkCollegeMoreInfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCourseCount;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FlowLayoutPanel dayContainer;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}