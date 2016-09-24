namespace IMS
{
    partial class frmBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackup));
            this.lblPath = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.savefile = new System.Windows.Forms.SaveFileDialog();
            this.openfile = new System.Windows.Forms.OpenFileDialog();
            this.iconTips = new System.Windows.Forms.ToolTip(this.components);
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.ForeColor = System.Drawing.Color.White;
            this.lblPath.Location = new System.Drawing.Point(12, 43);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(37, 18);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "Path";
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(16, 153);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(611, 23);
            this.pb.TabIndex = 5;
            this.pb.Visible = false;
            // 
            // iconTips
            // 
            this.iconTips.IsBalloon = true;
            // 
            // btnBackup
            // 
            this.btnBackup.BackgroundImage = global::IMS.Properties.Resources.Backup;
            this.btnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Location = new System.Drawing.Point(277, 81);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(58, 49);
            this.btnBackup.TabIndex = 3;
            this.iconTips.SetToolTip(this.btnBackup, "click for backup");
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::IMS.Properties.Resources.Cancel;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(360, 81);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(58, 49);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPath
            // 
            this.btnPath.BackColor = System.Drawing.Color.Transparent;
            this.btnPath.BackgroundImage = global::IMS.Properties.Resources.path;
            this.btnPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPath.FlatAppearance.BorderSize = 0;
            this.btnPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPath.Location = new System.Drawing.Point(584, 29);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(58, 49);
            this.btnPath.TabIndex = 2;
            this.btnPath.UseVisualStyleBackColor = false;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.txtPath);
            this.pnlMain.Controls.Add(this.lblPath);
            this.pnlMain.Controls.Add(this.pb);
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Controls.Add(this.btnPath);
            this.pnlMain.Controls.Add(this.btnBackup);
            this.pnlMain.Location = new System.Drawing.Point(52, 151);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(661, 219);
            this.pnlMain.TabIndex = 6;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPath.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.ForeColor = System.Drawing.Color.White;
            this.txtPath.Location = new System.Drawing.Point(60, 40);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(518, 27);
            this.txtPath.TabIndex = 6;
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(774, 542);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmBackup";
            this.Text = "Data BackUp";
            this.Load += new System.EventHandler(this.frmBackup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBackup_KeyDown);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.SaveFileDialog savefile;
        public System.Windows.Forms.OpenFileDialog openfile;
        private System.Windows.Forms.ToolTip iconTips;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtPath;
    }
}