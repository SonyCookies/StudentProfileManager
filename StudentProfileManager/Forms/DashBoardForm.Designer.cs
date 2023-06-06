
namespace StudentProfileManager
{
    partial class DashBoardForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoardForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnDashBoardPage = new System.Windows.Forms.Button();
            this.btnStudentPage = new System.Windows.Forms.Button();
            this.btnAddStudentPage = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentProfileManagerDatabaseDataSet = new StudentProfileManager.StudentProfileManagerDatabaseDataSet();
            this.studentProfileManagerDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAdminProfile = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentProfileManagerDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentProfileManagerDatabaseDataSetBindingSource)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(86)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.pnlMenu);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 650);
            this.panel1.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnDashBoardPage);
            this.pnlMenu.Controls.Add(this.btnStudentPage);
            this.pnlMenu.Controls.Add(this.btnAddStudentPage);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 151);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(230, 452);
            this.pnlMenu.TabIndex = 11;
            // 
            // btnDashBoardPage
            // 
            this.btnDashBoardPage.FlatAppearance.BorderSize = 0;
            this.btnDashBoardPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoardPage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoardPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.btnDashBoardPage.Image = global::StudentProfileManager.Properties.Resources.icons8_dashboard_25;
            this.btnDashBoardPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoardPage.Location = new System.Drawing.Point(0, 0);
            this.btnDashBoardPage.Name = "btnDashBoardPage";
            this.btnDashBoardPage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashBoardPage.Size = new System.Drawing.Size(230, 50);
            this.btnDashBoardPage.TabIndex = 8;
            this.btnDashBoardPage.Text = "          Dashboard";
            this.btnDashBoardPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoardPage.UseVisualStyleBackColor = true;
            this.btnDashBoardPage.Click += new System.EventHandler(this.btnDashBoardPage_Click);
            // 
            // btnStudentPage
            // 
            this.btnStudentPage.FlatAppearance.BorderSize = 0;
            this.btnStudentPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentPage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.btnStudentPage.Image = global::StudentProfileManager.Properties.Resources.icons8_student_25;
            this.btnStudentPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentPage.Location = new System.Drawing.Point(0, 48);
            this.btnStudentPage.Name = "btnStudentPage";
            this.btnStudentPage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStudentPage.Size = new System.Drawing.Size(230, 50);
            this.btnStudentPage.TabIndex = 3;
            this.btnStudentPage.Text = "          Manage Student";
            this.btnStudentPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentPage.UseVisualStyleBackColor = true;
            this.btnStudentPage.Click += new System.EventHandler(this.btnStudentPage_Click);
            // 
            // btnAddStudentPage
            // 
            this.btnAddStudentPage.FlatAppearance.BorderSize = 0;
            this.btnAddStudentPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudentPage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudentPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.btnAddStudentPage.Image = global::StudentProfileManager.Properties.Resources.icons8_add_male_user_25;
            this.btnAddStudentPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStudentPage.Location = new System.Drawing.Point(0, 97);
            this.btnAddStudentPage.Name = "btnAddStudentPage";
            this.btnAddStudentPage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddStudentPage.Size = new System.Drawing.Size(230, 50);
            this.btnAddStudentPage.TabIndex = 4;
            this.btnAddStudentPage.Text = "          Add Student";
            this.btnAddStudentPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStudentPage.UseVisualStyleBackColor = true;
            this.btnAddStudentPage.Click += new System.EventHandler(this.btnAddStudentPage_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 51);
            this.panel3.TabIndex = 10;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(29)))));
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.btnLogOut.Location = new System.Drawing.Point(0, 603);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(230, 47);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbLogo);
            this.panel2.Controls.Add(this.lblLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 100);
            this.panel2.TabIndex = 10;
            // 
            // pbLogo
            // 
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo.Image = global::StudentProfileManager.Properties.Resources.logo__2_;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(84, 73);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogo.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(102, 15);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(104, 66);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "MINDORO\r\nSTATE\r\nUNIVERSITY\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(29)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label3.Location = new System.Drawing.Point(869, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "|";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(441, 8);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(88, 19);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(29)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Location = new System.Drawing.Point(-11, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "|";
            // 
            // studentProfileManagerDatabaseDataSet
            // 
            this.studentProfileManagerDatabaseDataSet.DataSetName = "StudentProfileManagerDatabaseDataSet";
            this.studentProfileManagerDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentProfileManagerDatabaseDataSetBindingSource
            // 
            this.studentProfileManagerDatabaseDataSetBindingSource.DataSource = this.studentProfileManagerDatabaseDataSet;
            this.studentProfileManagerDatabaseDataSetBindingSource.Position = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(86)))), ((int)(((byte)(28)))));
            this.panel6.Controls.Add(this.lblHeader);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.btnAdminProfile);
            this.panel6.Controls.Add(this.btnClose);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.btnMinimize);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(230, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(970, 38);
            this.panel6.TabIndex = 2;
            // 
            // btnAdminProfile
            // 
            this.btnAdminProfile.FlatAppearance.BorderSize = 0;
            this.btnAdminProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminProfile.Image = global::StudentProfileManager.Properties.Resources.icons8_person_24;
            this.btnAdminProfile.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdminProfile.Location = new System.Drawing.Point(832, 5);
            this.btnAdminProfile.Name = "btnAdminProfile";
            this.btnAdminProfile.Size = new System.Drawing.Size(29, 28);
            this.btnAdminProfile.TabIndex = 5;
            this.btnAdminProfile.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::StudentProfileManager.Properties.Resources.icons8_close_20;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(936, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::StudentProfileManager.Properties.Resources.icons8_minimize_20;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.Location = new System.Drawing.Point(899, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 30);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.pnlContainer.Location = new System.Drawing.Point(230, 38);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(970, 612);
            this.pnlContainer.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::StudentProfileManager.Properties.Resources.logofaded;
            this.pictureBox1.Location = new System.Drawing.Point(230, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(970, 612);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DashBoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MinSU Student\'s Profile Manager";
            this.Load += new System.EventHandler(this.DashBoardForm_Load);
            this.panel1.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentProfileManagerDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentProfileManagerDatabaseDataSetBindingSource)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnStudentPage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdminProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource studentProfileManagerDatabaseDataSetBindingSource;
        private StudentProfileManagerDatabaseDataSet studentProfileManagerDatabaseDataSet;
        private System.Windows.Forms.Button btnDashBoardPage;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblLogo;
        public System.Windows.Forms.Button btnAddStudentPage;
    }
}