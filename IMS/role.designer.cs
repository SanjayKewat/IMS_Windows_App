namespace IMS
{
    partial class role
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(role));
            this.main_flow_tab = new System.Windows.Forms.FlowLayoutPanel();
            this.logo_ims = new System.Windows.Forms.PictureBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.allusr_lbl = new System.Windows.Forms.Label();
            this.usr_pic = new System.Windows.Forms.PictureBox();
            this.sett_pic = new System.Windows.Forms.PictureBox();
            this.user_tip = new System.Windows.Forms.ToolTip(this.components);
            this.usr_pnl = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo_ims)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usr_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sett_pic)).BeginInit();
            this.usr_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_flow_tab
            // 
            this.main_flow_tab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.main_flow_tab.AutoSize = true;
            this.main_flow_tab.Location = new System.Drawing.Point(243, 201);
            this.main_flow_tab.Name = "main_flow_tab";
            this.main_flow_tab.Size = new System.Drawing.Size(0, 0);
            this.main_flow_tab.TabIndex = 0;
            // 
            // logo_ims
            // 
            this.logo_ims.BackColor = System.Drawing.Color.Transparent;
            this.logo_ims.Image = global::IMS.Properties.Resources.U_logo;
            this.logo_ims.Location = new System.Drawing.Point(25, 61);
            this.logo_ims.Name = "logo_ims";
            this.logo_ims.Size = new System.Drawing.Size(52, 54);
            this.logo_ims.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_ims.TabIndex = 14;
            this.logo_ims.TabStop = false;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.back_btn.BackgroundImage = global::IMS.Properties.Resources.back;
            this.back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Location = new System.Drawing.Point(25, 151);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(50, 50);
            this.back_btn.TabIndex = 13;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // allusr_lbl
            // 
            this.allusr_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.allusr_lbl.AutoSize = true;
            this.allusr_lbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allusr_lbl.ForeColor = System.Drawing.Color.White;
            this.allusr_lbl.Location = new System.Drawing.Point(190, 119);
            this.allusr_lbl.Name = "allusr_lbl";
            this.allusr_lbl.Size = new System.Drawing.Size(175, 19);
            this.allusr_lbl.TabIndex = 7;
            this.allusr_lbl.Text = "Role and Permission";
            // 
            // usr_pic
            // 
            this.usr_pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usr_pic.Image = global::IMS.Properties.Resources.role_permiss;
            this.usr_pic.Location = new System.Drawing.Point(228, 20);
            this.usr_pic.Name = "usr_pic";
            this.usr_pic.Size = new System.Drawing.Size(100, 96);
            this.usr_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usr_pic.TabIndex = 3;
            this.usr_pic.TabStop = false;
            // 
            // sett_pic
            // 
            this.sett_pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sett_pic.Image = global::IMS.Properties.Resources.settings;
            this.sett_pic.Location = new System.Drawing.Point(1221, 49);
            this.sett_pic.Name = "sett_pic";
            this.sett_pic.Size = new System.Drawing.Size(45, 42);
            this.sett_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sett_pic.TabIndex = 16;
            this.sett_pic.TabStop = false;
            // 
            // user_tip
            // 
            this.user_tip.IsBalloon = true;
            // 
            // usr_pnl
            // 
            this.usr_pnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usr_pnl.Controls.Add(this.allusr_lbl);
            this.usr_pnl.Controls.Add(this.usr_pic);
            this.usr_pnl.Location = new System.Drawing.Point(387, 12);
            this.usr_pnl.Name = "usr_pnl";
            this.usr_pnl.Size = new System.Drawing.Size(532, 138);
            this.usr_pnl.TabIndex = 15;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(27, 118);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(48, 13);
            this.lblLogo.TabIndex = 42;
            this.lblLogo.Text = "SB Sons";
            // 
            // role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1280, 717);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.sett_pic);
            this.Controls.Add(this.usr_pnl);
            this.Controls.Add(this.logo_ims);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.main_flow_tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "role";
            this.Text = "Role & Permissions";
            this.Load += new System.EventHandler(this.role_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.role_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.logo_ims)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usr_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sett_pic)).EndInit();
            this.usr_pnl.ResumeLayout(false);
            this.usr_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel main_flow_tab;
        private System.Windows.Forms.PictureBox logo_ims;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label allusr_lbl;
        private System.Windows.Forms.PictureBox usr_pic;
        private System.Windows.Forms.PictureBox sett_pic;
        private System.Windows.Forms.ToolTip user_tip;
        private System.Windows.Forms.Panel usr_pnl;
        private System.Windows.Forms.Label lblLogo;
    }
}