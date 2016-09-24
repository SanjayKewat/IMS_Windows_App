namespace IMS
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.logo_ims = new System.Windows.Forms.PictureBox();
            this.lbl_info = new System.Windows.Forms.Label();
            this.usr_icon = new System.Windows.Forms.PictureBox();
            this.pwd_icon = new System.Windows.Forms.PictureBox();
            this.txt_usr = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.ims_tip = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_error = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo_ims)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usr_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pwd_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // logo_ims
            // 
            this.logo_ims.BackColor = System.Drawing.Color.Transparent;
            this.logo_ims.Image = global::IMS.Properties.Resources.U_logo;
            this.logo_ims.Location = new System.Drawing.Point(31, 25);
            this.logo_ims.Name = "logo_ims";
            this.logo_ims.Size = new System.Drawing.Size(52, 54);
            this.logo_ims.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_ims.TabIndex = 1;
            this.logo_ims.TabStop = false;
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.BackColor = System.Drawing.Color.Transparent;
            this.lbl_info.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.ForeColor = System.Drawing.Color.White;
            this.lbl_info.Location = new System.Drawing.Point(104, 43);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(292, 25);
            this.lbl_info.TabIndex = 2;
            this.lbl_info.Text = "Inventry Management System";
            // 
            // usr_icon
            // 
            this.usr_icon.BackColor = System.Drawing.Color.Transparent;
            this.usr_icon.Image = global::IMS.Properties.Resources.usr;
            this.usr_icon.Location = new System.Drawing.Point(31, 103);
            this.usr_icon.Name = "usr_icon";
            this.usr_icon.Size = new System.Drawing.Size(52, 47);
            this.usr_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usr_icon.TabIndex = 3;
            this.usr_icon.TabStop = false;
            // 
            // pwd_icon
            // 
            this.pwd_icon.BackColor = System.Drawing.Color.Transparent;
            this.pwd_icon.Image = global::IMS.Properties.Resources.pwd;
            this.pwd_icon.Location = new System.Drawing.Point(31, 166);
            this.pwd_icon.Name = "pwd_icon";
            this.pwd_icon.Size = new System.Drawing.Size(52, 47);
            this.pwd_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pwd_icon.TabIndex = 4;
            this.pwd_icon.TabStop = false;
            // 
            // txt_usr
            // 
            this.txt_usr.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_usr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_usr.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usr.ForeColor = System.Drawing.Color.White;
            this.txt_usr.Location = new System.Drawing.Point(107, 114);
            this.txt_usr.Name = "txt_usr";
            this.txt_usr.Size = new System.Drawing.Size(275, 27);
            this.txt_usr.TabIndex = 1;
            this.ims_tip.SetToolTip(this.txt_usr, "Enter Username Here...?");
            // 
            // txt_pwd
            // 
            this.txt_pwd.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pwd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pwd.ForeColor = System.Drawing.Color.White;
            this.txt_pwd.Location = new System.Drawing.Point(107, 177);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.Size = new System.Drawing.Size(275, 27);
            this.txt_pwd.TabIndex = 2;
            this.ims_tip.SetToolTip(this.txt_pwd, "Enter Password Here...?");
            // 
            // ims_tip
            // 
            this.ims_tip.BackColor = System.Drawing.Color.Transparent;
            this.ims_tip.ForeColor = System.Drawing.Color.White;
            this.ims_tip.IsBalloon = true;
            this.ims_tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ims_tip.ToolTipTitle = "Tips";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.BackColor = System.Drawing.Color.Transparent;
            this.lbl_error.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.White;
            this.lbl_error.Location = new System.Drawing.Point(99, 289);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(59, 13);
            this.lbl_error.TabIndex = 9;
            this.lbl_error.Text = "login_error";
            this.lbl_error.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.btnLogin.BackgroundImage = global::IMS.Properties.Resources.Login;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(169, 225);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(53, 49);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.btnExit.BackgroundImage = global::IMS.Properties.Resources.Cancel;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(228, 225);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 49);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(35, 82);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(48, 13);
            this.lblLogo.TabIndex = 42;
            this.lblLogo.Text = "SB Sons";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IMS.Properties.Resources.invtry_back;
            this.ClientSize = new System.Drawing.Size(423, 332);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_usr);
            this.Controls.Add(this.pwd_icon);
            this.Controls.Add(this.usr_icon);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.logo_ims);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.logo_ims)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usr_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pwd_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo_ims;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.PictureBox usr_icon;
        private System.Windows.Forms.PictureBox pwd_icon;
        private System.Windows.Forms.TextBox txt_usr;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.ToolTip ims_tip;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLogo;
    }
}