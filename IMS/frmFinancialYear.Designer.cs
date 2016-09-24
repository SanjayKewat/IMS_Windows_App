namespace IMS
{
    partial class frmFinancialYear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinancialYear));
            this.lbl_info = new System.Windows.Forms.Label();
            this.logo_ims = new System.Windows.Forms.PictureBox();
            this.cboFinancialYear = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo_ims)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.BackColor = System.Drawing.Color.Transparent;
            this.lbl_info.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.ForeColor = System.Drawing.Color.White;
            this.lbl_info.Location = new System.Drawing.Point(146, 24);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(272, 25);
            this.lbl_info.TabIndex = 4;
            this.lbl_info.Text = "Please Select Finanical Year";
            // 
            // logo_ims
            // 
            this.logo_ims.BackColor = System.Drawing.Color.Transparent;
            this.logo_ims.Image = global::IMS.Properties.Resources.U_logo;
            this.logo_ims.Location = new System.Drawing.Point(12, 12);
            this.logo_ims.Name = "logo_ims";
            this.logo_ims.Size = new System.Drawing.Size(52, 54);
            this.logo_ims.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_ims.TabIndex = 3;
            this.logo_ims.TabStop = false;
            // 
            // cboFinancialYear
            // 
            this.cboFinancialYear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cboFinancialYear.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cboFinancialYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFinancialYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFinancialYear.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cboFinancialYear.ForeColor = System.Drawing.Color.White;
            this.cboFinancialYear.FormattingEnabled = true;
            this.cboFinancialYear.Location = new System.Drawing.Point(151, 84);
            this.cboFinancialYear.Name = "cboFinancialYear";
            this.cboFinancialYear.Size = new System.Drawing.Size(267, 27);
            this.cboFinancialYear.TabIndex = 1;
            this.cboFinancialYear.SelectionChangeCommitted += new System.EventHandler(this.cboFinancialYear_SelectionChangeCommitted);
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(1, 91);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(118, 16);
            this.Label2.TabIndex = 18;
            this.Label2.Text = "Financial Year :";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.btnExit.BackgroundImage = global::IMS.Properties.Resources.Cancel;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(269, 118);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 49);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.btnLogin.BackgroundImage = global::IMS.Properties.Resources.Login;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(210, 118);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(53, 49);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(12, 69);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(48, 13);
            this.lblLogo.TabIndex = 42;
            this.lblLogo.Text = "SB Sons";
            // 
            // frmFinancialYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(458, 181);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.cboFinancialYear);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.logo_ims);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmFinancialYear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFinancialYear";
            this.Load += new System.EventHandler(this.frmFinancialYear_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFinancialYear_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.logo_ims)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.PictureBox logo_ims;
        private System.Windows.Forms.ComboBox cboFinancialYear;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLogo;
    }
}