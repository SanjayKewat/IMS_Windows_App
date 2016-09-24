namespace IMS.Category
{
    partial class frmCategory
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

         /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategory));
            this.add_cat_panel = new System.Windows.Forms.Panel();
            this.add_cat_lbl = new System.Windows.Forms.Label();
            this.add_cat_pic = new System.Windows.Forms.PictureBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.sett_pic = new System.Windows.Forms.PictureBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.logo_ims = new System.Windows.Forms.PictureBox();
            this.flpGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.add_cat_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_cat_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sett_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_ims)).BeginInit();
            this.SuspendLayout();
            // 
            // add_cat_panel
            // 
            this.add_cat_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_cat_panel.Controls.Add(this.add_cat_lbl);
            this.add_cat_panel.Controls.Add(this.add_cat_pic);
            this.add_cat_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_cat_panel.Location = new System.Drawing.Point(133, 164);
            this.add_cat_panel.Name = "add_cat_panel";
            this.add_cat_panel.Size = new System.Drawing.Size(113, 96);
            this.add_cat_panel.TabIndex = 9;
            this.add_cat_panel.Click += new System.EventHandler(this.add_cat_panel_Click);
            this.add_cat_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.add_cat_panel_Paint);
            this.add_cat_panel.MouseEnter += new System.EventHandler(this.add_cat_panel_MouseEnter);
            this.add_cat_panel.MouseLeave += new System.EventHandler(this.add_cat_panel_MouseLeave);
            // 
            // add_cat_lbl
            // 
            this.add_cat_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.add_cat_lbl.AutoSize = true;
            this.add_cat_lbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_cat_lbl.ForeColor = System.Drawing.Color.White;
            this.add_cat_lbl.Location = new System.Drawing.Point(0, 74);
            this.add_cat_lbl.Name = "add_cat_lbl";
            this.add_cat_lbl.Size = new System.Drawing.Size(114, 16);
            this.add_cat_lbl.TabIndex = 6;
            this.add_cat_lbl.Text = "Add New Category";
            this.add_cat_lbl.Click += new System.EventHandler(this.add_cat_lbl_Click);
            this.add_cat_lbl.MouseEnter += new System.EventHandler(this.add_cat_lbl_MouseEnter);
            this.add_cat_lbl.MouseLeave += new System.EventHandler(this.add_cat_lbl_MouseLeave);
            // 
            // add_cat_pic
            // 
            this.add_cat_pic.BackColor = System.Drawing.Color.Transparent;
            this.add_cat_pic.Image = global::IMS.Properties.Resources.Category;
            this.add_cat_pic.Location = new System.Drawing.Point(29, 19);
            this.add_cat_pic.Name = "add_cat_pic";
            this.add_cat_pic.Size = new System.Drawing.Size(52, 54);
            this.add_cat_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add_cat_pic.TabIndex = 5;
            this.add_cat_pic.TabStop = false;
            this.add_cat_pic.Click += new System.EventHandler(this.add_cat_pic_Click);
            this.add_cat_pic.MouseEnter += new System.EventHandler(this.add_cat_pic_MouseEnter);
            this.add_cat_pic.MouseLeave += new System.EventHandler(this.add_cat_pic_MouseLeave);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewImageColumn1.HeaderText = "EDIT";
            this.dataGridViewImageColumn1.Image = global::IMS.Properties.Resources.edit_row;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 60;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.HeaderText = "DELETE";
            this.dataGridViewImageColumn2.Image = global::IMS.Properties.Resources.delete_row;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.Width = 60;
            // 
            // sett_pic
            // 
            this.sett_pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sett_pic.Image = global::IMS.Properties.Resources.settings;
            this.sett_pic.Location = new System.Drawing.Point(1221, 49);
            this.sett_pic.Name = "sett_pic";
            this.sett_pic.Size = new System.Drawing.Size(45, 42);
            this.sett_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sett_pic.TabIndex = 8;
            this.sett_pic.TabStop = false;
            // 
            // back_btn
            // 
            this.back_btn.BackgroundImage = global::IMS.Properties.Resources.back;
            this.back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_btn.Location = new System.Drawing.Point(25, 151);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(50, 50);
            this.back_btn.TabIndex = 4;
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // logo_ims
            // 
            this.logo_ims.BackColor = System.Drawing.Color.Transparent;
            this.logo_ims.BackgroundImage = global::IMS.Properties.Resources.U_logo;
            this.logo_ims.Image = global::IMS.Properties.Resources.U_logo;
            this.logo_ims.Location = new System.Drawing.Point(25, 61);
            this.logo_ims.Name = "logo_ims";
            this.logo_ims.Size = new System.Drawing.Size(52, 54);
            this.logo_ims.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_ims.TabIndex = 3;
            this.logo_ims.TabStop = false;
            // 
            // flpGrid
            // 
            this.flpGrid.AutoScroll = true;
            this.flpGrid.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpGrid.Location = new System.Drawing.Point(133, 320);
            this.flpGrid.Name = "flpGrid";
            this.flpGrid.Size = new System.Drawing.Size(991, 272);
            this.flpGrid.TabIndex = 39;
            this.flpGrid.WrapContents = false;
            // 
            // pnlHead
            // 
            this.pnlHead.Location = new System.Drawing.Point(133, 273);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(991, 46);
            this.pnlHead.TabIndex = 40;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(28, 118);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(48, 13);
            this.lblLogo.TabIndex = 41;
            this.lblLogo.Text = "SB Sons";
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1360, 724);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.pnlHead);
            this.Controls.Add(this.flpGrid);
            this.Controls.Add(this.add_cat_panel);
            this.Controls.Add(this.sett_pic);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.logo_ims);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmCategory";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCategory_KeyDown);
            this.add_cat_panel.ResumeLayout(false);
            this.add_cat_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_cat_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sett_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_ims)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    

        private System.Windows.Forms.PictureBox logo_ims;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.PictureBox sett_pic;
        private System.Windows.Forms.Panel add_cat_panel;
        private System.Windows.Forms.Label add_cat_lbl;
        private System.Windows.Forms.PictureBox add_cat_pic;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.FlowLayoutPanel flpGrid;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Label lblLogo;
    }
}