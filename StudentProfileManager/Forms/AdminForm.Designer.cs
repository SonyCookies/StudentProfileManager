
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
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
            this.btnToggleConPass = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.lblInvalid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnToggleNewPass = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdminUsername
            // 
            this.lblAdminUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdminUsername.AutoSize = true;
            this.lblAdminUsername.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(86)))), ((int)(((byte)(28)))));
            this.lblAdminUsername.Location = new System.Drawing.Point(459, 14);
            this.lblAdminUsername.Name = "lblAdminUsername";
            this.lblAdminUsername.Size = new System.Drawing.Size(84, 25);
            this.lblAdminUsername.TabIndex = 25;
            this.lblAdminUsername.Text = "000000";
            // 
            // txtAdminUsername
            // 
            this.txtAdminUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.txtAdminUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdminUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.txtAdminUsername.Location = new System.Drawing.Point(441, 97);
            this.txtAdminUsername.Name = "txtAdminUsername";
            this.txtAdminUsername.Size = new System.Drawing.Size(283, 27);
            this.txtAdminUsername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.label1.Location = new System.Drawing.Point(413, 70);
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
            this.txtAdminCurPass.Location = new System.Drawing.Point(441, 158);
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
            this.label2.Location = new System.Drawing.Point(413, 131);
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
            this.txtAdminConPass.Location = new System.Drawing.Point(441, 282);
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
            this.label3.Location = new System.Drawing.Point(413, 255);
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
            this.txtAdminNewPass.Location = new System.Drawing.Point(441, 221);
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
            this.label4.Location = new System.Drawing.Point(413, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "New Password:";
            // 
            // btnToggleCurPass
            // 
            this.btnToggleCurPass.FlatAppearance.BorderSize = 0;
            this.btnToggleCurPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleCurPass.Location = new System.Drawing.Point(690, 160);
            this.btnToggleCurPass.Name = "btnToggleCurPass";
            this.btnToggleCurPass.Size = new System.Drawing.Size(32, 23);
            this.btnToggleCurPass.TabIndex = 34;
            this.btnToggleCurPass.UseVisualStyleBackColor = true;
            this.btnToggleCurPass.Click += new System.EventHandler(this.btnToggleCurPass_Click);
            // 
            // btnToggleConPass
            // 
            this.btnToggleConPass.FlatAppearance.BorderSize = 0;
            this.btnToggleConPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleConPass.Location = new System.Drawing.Point(690, 284);
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
            this.btnChangePass.Location = new System.Drawing.Point(441, 376);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(283, 40);
            this.btnChangePass.TabIndex = 4;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // lblInvalid
            // 
            this.lblInvalid.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.lblInvalid.Location = new System.Drawing.Point(441, 320);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(283, 16);
            this.lblInvalid.TabIndex = 37;
            this.lblInvalid.Text = "asdfasdf";
            this.lblInvalid.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.label5.Location = new System.Drawing.Point(349, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Welcome,";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::StudentProfileManager.Properties.Resources.icons8_close_20__1_;
            this.btnExit.Location = new System.Drawing.Point(769, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 27);
            this.btnExit.TabIndex = 39;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 448);
            this.panel2.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::StudentProfileManager.Properties.Resources.login5__2_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 448);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnToggleNewPass
            // 
            this.btnToggleNewPass.FlatAppearance.BorderSize = 0;
            this.btnToggleNewPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleNewPass.Location = new System.Drawing.Point(690, 223);
            this.btnToggleNewPass.Name = "btnToggleNewPass";
            this.btnToggleNewPass.Size = new System.Drawing.Size(32, 23);
            this.btnToggleNewPass.TabIndex = 35;
            this.btnToggleNewPass.UseVisualStyleBackColor = true;
            this.btnToggleNewPass.Click += new System.EventHandler(this.btnToggleNewPass_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel2);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button btnToggleConPass;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Label lblInvalid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnToggleNewPass;
    }
}