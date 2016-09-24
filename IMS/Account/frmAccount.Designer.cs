namespace IMS.Account
{
    partial class frmAccount
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
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlArch = new System.Windows.Forms.Panel();
            this.lblArch = new System.Windows.Forms.Label();
            this.picArch = new System.Windows.Forms.PictureBox();
            this.pnlSupplier = new System.Windows.Forms.Panel();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.picSupplier = new System.Windows.Forms.PictureBox();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.picCustomer = new System.Windows.Forms.PictureBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.logo_ims = new System.Windows.Forms.PictureBox();
            this.pnlMain.SuspendLayout();
            this.pnlArch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArch)).BeginInit();
            this.pnlSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSupplier)).BeginInit();
            this.pnlCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_ims)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(27, 118);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(48, 13);
            this.lblLogo.TabIndex = 48;
            this.lblLogo.Text = "SB Sons";
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.Controls.Add(this.pnlArch);
            this.pnlMain.Controls.Add(this.pnlSupplier);
            this.pnlMain.Controls.Add(this.pnlCustomer);
            this.pnlMain.Location = new System.Drawing.Point(318, 225);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(686, 268);
            this.pnlMain.TabIndex = 49;
            // 
            // pnlArch
            // 
            this.pnlArch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlArch.Controls.Add(this.lblArch);
            this.pnlArch.Controls.Add(this.picArch);
            this.pnlArch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlArch.Location = new System.Drawing.Point(253, 35);
            this.pnlArch.Name = "pnlArch";
            this.pnlArch.Size = new System.Drawing.Size(184, 192);
            this.pnlArch.TabIndex = 12;
            this.pnlArch.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlArch_Paint);
            this.pnlArch.MouseEnter += new System.EventHandler(this.pnlArch_MouseEnter);
            this.pnlArch.MouseLeave += new System.EventHandler(this.pnlArch_MouseLeave);
            // 
            // lblArch
            // 
            this.lblArch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblArch.AutoSize = true;
            this.lblArch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArch.ForeColor = System.Drawing.Color.White;
            this.lblArch.Location = new System.Drawing.Point(11, 170);
            this.lblArch.Name = "lblArch";
            this.lblArch.Size = new System.Drawing.Size(161, 16);
            this.lblArch.TabIndex = 6;
            this.lblArch.Text = "View Contractors/Architect";
            this.lblArch.MouseEnter += new System.EventHandler(this.lblArch_MouseEnter);
            this.lblArch.MouseLeave += new System.EventHandler(this.lblArch_MouseLeave);
            // 
            // picArch
            // 
            this.picArch.BackColor = System.Drawing.Color.Transparent;
            this.picArch.Image = global::IMS.Properties.Resources.view_detail;
            this.picArch.Location = new System.Drawing.Point(31, 39);
            this.picArch.Name = "picArch";
            this.picArch.Size = new System.Drawing.Size(119, 100);
            this.picArch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArch.TabIndex = 5;
            this.picArch.TabStop = false;
            this.picArch.MouseEnter += new System.EventHandler(this.picArch_MouseEnter);
            this.picArch.MouseLeave += new System.EventHandler(this.picArch_MouseLeave);
            // 
            // pnlSupplier
            // 
            this.pnlSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSupplier.Controls.Add(this.lblSupplier);
            this.pnlSupplier.Controls.Add(this.picSupplier);
            this.pnlSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlSupplier.Location = new System.Drawing.Point(456, 37);
            this.pnlSupplier.Name = "pnlSupplier";
            this.pnlSupplier.Size = new System.Drawing.Size(184, 192);
            this.pnlSupplier.TabIndex = 12;
            this.pnlSupplier.Click += new System.EventHandler(this.pnlSupplier_Click);
            this.pnlSupplier.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSupplier_Paint);
            this.pnlSupplier.MouseEnter += new System.EventHandler(this.pnlSupplier_MouseEnter);
            this.pnlSupplier.MouseLeave += new System.EventHandler(this.pnlSupplier_MouseLeave);
            // 
            // lblSupplier
            // 
            this.lblSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.ForeColor = System.Drawing.Color.White;
            this.lblSupplier.Location = new System.Drawing.Point(20, 168);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(142, 16);
            this.lblSupplier.TabIndex = 6;
            this.lblSupplier.Text = "View Suppliers Account";
            this.lblSupplier.Click += new System.EventHandler(this.lblSupplier_Click);
            this.lblSupplier.MouseEnter += new System.EventHandler(this.lblSupplier_MouseEnter);
            this.lblSupplier.MouseLeave += new System.EventHandler(this.lblSupplier_MouseLeave);
            // 
            // picSupplier
            // 
            this.picSupplier.BackColor = System.Drawing.Color.Transparent;
            this.picSupplier.Image = global::IMS.Properties.Resources.supplier;
            this.picSupplier.Location = new System.Drawing.Point(27, 37);
            this.picSupplier.Name = "picSupplier";
            this.picSupplier.Size = new System.Drawing.Size(119, 100);
            this.picSupplier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSupplier.TabIndex = 5;
            this.picSupplier.TabStop = false;
            this.picSupplier.Click += new System.EventHandler(this.picSupplier_Click);
            this.picSupplier.MouseEnter += new System.EventHandler(this.picSupplier_MouseEnter);
            this.picSupplier.MouseLeave += new System.EventHandler(this.picSupplier_MouseLeave);
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCustomer.Controls.Add(this.lblCustomer);
            this.pnlCustomer.Controls.Add(this.picCustomer);
            this.pnlCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCustomer.Location = new System.Drawing.Point(29, 37);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(184, 192);
            this.pnlCustomer.TabIndex = 11;
            this.pnlCustomer.Click += new System.EventHandler(this.pnlCustomer_Click);
            this.pnlCustomer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCustomer_Paint);
            this.pnlCustomer.MouseEnter += new System.EventHandler(this.pnlCustomer_MouseEnter);
            this.pnlCustomer.MouseLeave += new System.EventHandler(this.pnlCustomer_MouseLeave);
            // 
            // lblCustomer
            // 
            this.lblCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.White;
            this.lblCustomer.Location = new System.Drawing.Point(17, 170);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(150, 16);
            this.lblCustomer.TabIndex = 6;
            this.lblCustomer.Text = "View Customers Account";
            this.lblCustomer.Click += new System.EventHandler(this.lblCustomer_Click);
            this.lblCustomer.MouseEnter += new System.EventHandler(this.lblCustomer_MouseEnter);
            this.lblCustomer.MouseLeave += new System.EventHandler(this.lblCustomer_MouseLeave);
            // 
            // picCustomer
            // 
            this.picCustomer.BackColor = System.Drawing.Color.Transparent;
            this.picCustomer.Image = global::IMS.Properties.Resources.customer;
            this.picCustomer.Location = new System.Drawing.Point(32, 37);
            this.picCustomer.Name = "picCustomer";
            this.picCustomer.Size = new System.Drawing.Size(119, 100);
            this.picCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCustomer.TabIndex = 5;
            this.picCustomer.TabStop = false;
            this.picCustomer.Click += new System.EventHandler(this.picCustomer_Click);
            this.picCustomer.MouseEnter += new System.EventHandler(this.picCustomer_MouseEnter);
            this.picCustomer.MouseLeave += new System.EventHandler(this.picCustomer_MouseLeave);
            // 
            // back_btn
            // 
            this.back_btn.BackgroundImage = global::IMS.Properties.Resources.back;
            this.back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Location = new System.Drawing.Point(25, 151);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(50, 50);
            this.back_btn.TabIndex = 47;
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // logo_ims
            // 
            this.logo_ims.BackColor = System.Drawing.Color.Transparent;
            this.logo_ims.Image = global::IMS.Properties.Resources.U_logo;
            this.logo_ims.Location = new System.Drawing.Point(25, 61);
            this.logo_ims.Name = "logo_ims";
            this.logo_ims.Size = new System.Drawing.Size(52, 54);
            this.logo_ims.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_ims.TabIndex = 46;
            this.logo_ims.TabStop = false;
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1320, 678);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.logo_ims);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmAccount";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAccount_KeyDown);
            this.pnlMain.ResumeLayout(false);
            this.pnlArch.ResumeLayout(false);
            this.pnlArch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArch)).EndInit();
            this.pnlSupplier.ResumeLayout(false);
            this.pnlSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSupplier)).EndInit();
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_ims)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.PictureBox logo_ims;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlArch;
        private System.Windows.Forms.Label lblArch;
        private System.Windows.Forms.PictureBox picArch;
        private System.Windows.Forms.Panel pnlSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.PictureBox picSupplier;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.PictureBox picCustomer;
    }
}