
namespace StudentProfileManager
{
    partial class AdminForm
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
            this.lblStudentAddress = new System.Windows.Forms.Label();
            this.lblAdminUsername = new System.Windows.Forms.Label();
            this.txtAdminUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdminCurPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdminConPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdminNewPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnToggleCurPass = new System.Windows.Forms.Button();
            this.btnToggleNewPass = new System.Windows.Forms.Button();
            this.btnToggleConPass = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.lblInvalid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbAdmin = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentAddress
            // 
            this.lblStudentAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStudentAddress.AutoSize = true;
            this.lblStudentAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentAddress.ForeColor = System.Drawing.Color.White;
            this.lblStudentAddress.Location = new System.Drawing.Point(12, 9);
            this.lblStudentAddress.MaximumSize = new System.Drawing.Size(330, 0);
            this.lblStudentAddress.Name = "lblStudentAddress";
            this.lblStudentAddress.Size = new System.Drawing.Size(165, 19);
            this.lblStudentAddress.TabIndex = 24;
            this.lblStudentAddress.Text = "CHANGE PASSWORD";
            // 
            // lblAdminUsername
            // 
            this.lblAdminUsername.AutoSize = true;
            this.lblAdminUsername.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(86)))), ((int)(((byte)(28)))));
            this.lblAdminUsername.Location = new System.Drawing.Point(145, 94);
            this.lblAdminUsername.Name = "lblAdminUsername";
            this.lblAdminUsername.Size = new System.Drawing.Size(105, 32);
            this.lblAdminUsername.TabIndex = 25;
            this.lblAdminUsername.Text = "000000";
            // 
            // txtAdminUsername
            // 
            this.txtAdminUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.txtAdminUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdminUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.txtAdminUsername.Location = new System.Drawing.Point(45, 195);
            this.txtAdminUsername.Name = "txtAdminUsername";
            this.txtAdminUsername.Size = new System.Drawing.Size(283, 27);
            this.txtAdminUsername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.label1.Location = new System.Drawing.Point(17, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Username: ";
            // 
            // txtAdminCurPass
            // 
            this.txtAdminCurPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.txtAdminCurPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdminCurPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminCurPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.txtAdminCurPass.Location = new System.Drawing.Point(45, 256);
            this.txtAdminCurPass.Name = "txtAdminCurPass";
            this.txtAdminCurPass.Size = new System.Drawing.Size(283, 27);
            this.txtAdminCurPass.TabIndex = 1;
            this.txtAdminCurPass.UseSystemPasswordChar = true;
            this.txtAdminCurPass.TextChanged += new System.EventHandler(this.txtAdminCurPass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.label2.Location = new System.Drawing.Point(17, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Current Password:";
            // 
            // txtAdminConPass
            // 
            this.txtAdminConPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.txtAdminConPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdminConPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminConPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.txtAdminConPass.Location = new System.Drawing.Point(45, 380);
            this.txtAdminConPass.Name = "txtAdminConPass";
            this.txtAdminConPass.Size = new System.Drawing.Size(283, 27);
            this.txtAdminConPass.TabIndex = 3;
            this.txtAdminConPass.UseSystemPasswordChar = true;
            this.txtAdminConPass.TextChanged += new System.EventHandler(this.txtAdminConPass_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.label3.Location = new System.Drawing.Point(17, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "Confirm Password:";
            // 
            // txtAdminNewPass
            // 
            this.txtAdminNewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.txtAdminNewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdminNewPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.txtAdminNewPass.Location = new System.Drawing.Point(45, 319);
            this.txtAdminNewPass.Name = "txtAdminNewPass";
            this.txtAdminNewPass.Size = new System.Drawing.Size(283, 27);
            this.txtAdminNewPass.TabIndex = 2;
            this.txtAdminNewPass.UseSystemPasswordChar = true;
            this.txtAdminNewPass.TextChanged += new System.EventHandler(this.txtAdminNewPass_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.label4.Location = new System.Drawing.Point(17, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "New Password:";
            // 
            // btnToggleCurPass
            // 
            this.btnToggleCurPass.FlatAppearance.BorderSize = 0;
            this.btnToggleCurPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleCurPass.Location = new System.Drawing.Point(295, 259);
            this.btnToggleCurPass.Name = "btnToggleCurPass";
            this.btnToggleCurPass.Size = new System.Drawing.Size(32, 23);
            this.btnToggleCurPass.TabIndex = 34;
            this.btnToggleCurPass.UseVisualStyleBackColor = true;
            this.btnToggleCurPass.Click += new System.EventHandler(this.btnToggleCurPass_Click);
            // 
            // btnToggleNewPass
            // 
            this.btnToggleNewPass.FlatAppearance.BorderSize = 0;
            this.btnToggleNewPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleNewPass.Location = new System.Drawing.Point(295, 322);
            this.btnToggleNewPass.Name = "btnToggleNewPass";
            this.btnToggleNewPass.Size = new System.Drawing.Size(32, 23);
            this.btnToggleNewPass.TabIndex = 35;
            this.btnToggleNewPass.UseVisualStyleBackColor = true;
            this.btnToggleNewPass.Click += new System.EventHandler(this.btnToggleNewPass_Click);
            // 
            // btnToggleConPass
            // 
            this.btnToggleConPass.FlatAppearance.BorderSize = 0;
            this.btnToggleConPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleConPass.Location = new System.Drawing.Point(295, 383);
            this.btnToggleConPass.Name = "btnToggleConPass";
            this.btnToggleConPass.Size = new System.Drawing.Size(32, 23);
            this.btnToggleConPass.TabIndex = 36;
            this.btnToggleConPass.UseVisualStyleBackColor = true;
            this.btnToggleConPass.Click += new System.EventHandler(this.btnToggleConPass_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(29)))));
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.btnChangePass.Location = new System.Drawing.Point(59, 448);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(249, 40);
            this.btnChangePass.TabIndex = 4;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // lblInvalid
            // 
            this.lblInvalid.AutoSize = true;
            this.lblInvalid.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.lblInvalid.Location = new System.Drawing.Point(42, 421);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(0, 16);
            this.lblInvalid.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.label5.Location = new System.Drawing.Point(147, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "Welcome,";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(86)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblStudentAddress);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 34);
            this.panel1.TabIndex = 40;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::StudentProfileManager.Properties.Resources.icons8_close_24;
            this.btnExit.Location = new System.Drawing.Point(324, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 26);
            this.btnExit.TabIndex = 39;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbAdmin
            // 
            this.pbAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAdmin.Image = global::StudentProfileManager.Properties.Resources.icons8_admin_1001;
            this.pbAdmin.Location = new System.Drawing.Point(25, 50);
            this.pbAdmin.Name = "pbAdmin";
            this.pbAdmin.Size = new System.Drawing.Size(100, 100);
            this.pbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdmin.TabIndex = 7;
            this.pbAdmin.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(354, 514);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblInvalid);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.btnToggleConPass);
            this.Controls.Add(this.btnToggleNewPass);
            this.Controls.Add(this.btnToggleCurPass);
            this.Controls.Add(this.txtAdminConPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdminNewPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdminCurPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdminUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAdminUsername);
            this.Controls.Add(this.pbAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAdmin;
        private System.Windows.Forms.Label lblStudentAddress;
        private System.Windows.Forms.Label lblAdminUsername;
        private System.Windows.Forms.TextBox txtAdminUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdminCurPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdminConPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdminNewPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnToggleCurPass;
        private System.Windows.Forms.Button btnToggleNewPass;
        private System.Windows.Forms.Button btnToggleConPass;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Label lblInvalid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
    }
}