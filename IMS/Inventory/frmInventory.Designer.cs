namespace IMS.Inventory
{
    partial class frmInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlAddItem = new System.Windows.Forms.Panel();
            this.lblAddItem = new System.Windows.Forms.Label();
            this.add_item_pic = new System.Windows.Forms.PictureBox();
            this.add_cat_panel = new System.Windows.Forms.Panel();
            this.add_cat_lbl = new System.Windows.Forms.Label();
            this.add_cat_pic = new System.Windows.Forms.PictureBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.colItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsubcat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSSubcat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOPGQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurcase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editBtn = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.back_btn = new System.Windows.Forms.Button();
            this.sett_pic = new System.Windows.Forms.PictureBox();
            this.logo_ims = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlAddItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_item_pic)).BeginInit();
            this.add_cat_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_cat_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sett_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_ims)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAddItem
            // 
            this.pnlAddItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddItem.Controls.Add(this.lblAddItem);
            this.pnlAddItem.Controls.Add(this.add_item_pic);
            this.pnlAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlAddItem.Location = new System.Drawing.Point(133, 131);
            this.pnlAddItem.Name = "pnlAddItem";
            this.pnlAddItem.Size = new System.Drawing.Size(113, 96);
            this.pnlAddItem.TabIndex = 12;
            this.pnlAddItem.Click += new System.EventHandler(this.pnlAddItem_Click);
            this.pnlAddItem.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddItem_Paint);
            this.pnlAddItem.MouseEnter += new System.EventHandler(this.pnlAddItem_MouseEnter);
            this.pnlAddItem.MouseLeave += new System.EventHandler(this.pnlAddItem_MouseLeave);
            // 
            // lblAddItem
            // 
            this.lblAddItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddItem.AutoSize = true;
            this.lblAddItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddItem.ForeColor = System.Drawing.Color.White;
            this.lblAddItem.Location = new System.Drawing.Point(26, 76);
            this.lblAddItem.Name = "lblAddItem";
            this.lblAddItem.Size = new System.Drawing.Size(60, 16);
            this.lblAddItem.TabIndex = 6;
            this.lblAddItem.Text = "Add Item";
            this.lblAddItem.Click += new System.EventHandler(this.lblAddItem_Click);
            this.lblAddItem.MouseEnter += new System.EventHandler(this.lblAddItem_MouseEnter);
            this.lblAddItem.MouseLeave += new System.EventHandler(this.lblAddItem_MouseLeave);
            // 
            // add_item_pic
            // 
            this.add_item_pic.BackColor = System.Drawing.Color.Transparent;
            this.add_item_pic.Image = global::IMS.Properties.Resources.invtry;
            this.add_item_pic.Location = new System.Drawing.Point(29, 19);
            this.add_item_pic.Name = "add_item_pic";
            this.add_item_pic.Size = new System.Drawing.Size(52, 54);
            this.add_item_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add_item_pic.TabIndex = 5;
            this.add_item_pic.TabStop = false;
            this.add_item_pic.Click += new System.EventHandler(this.add_item_pic_Click);
            this.add_item_pic.MouseEnter += new System.EventHandler(this.add_item_pic_MouseEnter);
            this.add_item_pic.MouseLeave += new System.EventHandler(this.add_item_pic_MouseLeave);
            // 
            // add_cat_panel
            // 
            this.add_cat_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_cat_panel.Controls.Add(this.add_cat_lbl);
            this.add_cat_panel.Controls.Add(this.add_cat_pic);
            this.add_cat_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_cat_panel.Location = new System.Drawing.Point(273, 131);
            this.add_cat_panel.Name = "add_cat_panel";
            this.add_cat_panel.Size = new System.Drawing.Size(113, 96);
            this.add_cat_panel.TabIndex = 13;
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
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.AllowUserToResizeColumns = false;
            this.dg.AllowUserToResizeRows = false;
            this.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg.ColumnHeadersHeight = 50;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemId,
            this.colItemcode,
            this.colItemName,
            this.colCatName,
            this.colsubcat,
            this.colSSubcat,
            this.colOPGQTY,
            this.colPurcase,
            this.colSale,
            this.editBtn,
            this.btnDelete});
            this.dg.GridColor = System.Drawing.Color.Silver;
            this.dg.Location = new System.Drawing.Point(133, 234);
            this.dg.MultiSelect = false;
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg.RowHeadersVisible = false;
            this.dg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            this.dg.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dg.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dg.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dg.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            this.dg.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dg.RowTemplate.Height = 30;
            this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(972, 280);
            this.dg.TabIndex = 40;
            this.dg.TabStop = false;
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
            // 
            // colItemId
            // 
            this.colItemId.DataPropertyName = "ITEM_ID";
            this.colItemId.HeaderText = "ItemId";
            this.colItemId.Name = "colItemId";
            this.colItemId.ReadOnly = true;
            this.colItemId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colItemId.Visible = false;
            // 
            // colItemcode
            // 
            this.colItemcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colItemcode.DataPropertyName = "ITEM_CODE";
            this.colItemcode.HeaderText = "Item Code";
            this.colItemcode.Name = "colItemcode";
            this.colItemcode.ReadOnly = true;
            this.colItemcode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colItemcode.Width = 80;
            // 
            // colItemName
            // 
            this.colItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colItemName.DataPropertyName = "ITEM_NAME";
            this.colItemName.HeaderText = "Item Name";
            this.colItemName.Name = "colItemName";
            this.colItemName.ReadOnly = true;
            this.colItemName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colItemName.Width = 120;
            // 
            // colCatName
            // 
            this.colCatName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCatName.DataPropertyName = "CATEGORY_NAME";
            this.colCatName.HeaderText = "Category Name";
            this.colCatName.Name = "colCatName";
            this.colCatName.ReadOnly = true;
            this.colCatName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCatName.Width = 120;
            // 
            // colsubcat
            // 
            this.colsubcat.DataPropertyName = "SUBCATEGORY_VALUE";
            this.colsubcat.HeaderText = "Sub-Category";
            this.colsubcat.Name = "colsubcat";
            this.colsubcat.ReadOnly = true;
            // 
            // colSSubcat
            // 
            this.colSSubcat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSSubcat.DataPropertyName = "SSUBCATEGORY_VALUE";
            this.colSSubcat.HeaderText = "SSub-Category";
            this.colSSubcat.Name = "colSSubcat";
            this.colSSubcat.ReadOnly = true;
            this.colSSubcat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colSSubcat.Width = 120;
            // 
            // colOPGQTY
            // 
            this.colOPGQTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colOPGQTY.DataPropertyName = "OPGQTY";
            this.colOPGQTY.HeaderText = "Opening Qty";
            this.colOPGQTY.Name = "colOPGQTY";
            this.colOPGQTY.ReadOnly = true;
            this.colOPGQTY.Width = 80;
            // 
            // colPurcase
            // 
            this.colPurcase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPurcase.DataPropertyName = "PURCHASEPRICE";
            this.colPurcase.HeaderText = "Purchase Price";
            this.colPurcase.Name = "colPurcase";
            this.colPurcase.ReadOnly = true;
            this.colPurcase.Width = 80;
            // 
            // colSale
            // 
            this.colSale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSale.DataPropertyName = "SALEPRICE";
            this.colSale.HeaderText = "Sale Price";
            this.colSale.Name = "colSale";
            this.colSale.ReadOnly = true;
            this.colSale.Width = 80;
            // 
            // editBtn
            // 
            this.editBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            this.editBtn.DefaultCellStyle = dataGridViewCellStyle2;
            this.editBtn.HeaderText = "EDIT";
            this.editBtn.Image = global::IMS.Properties.Resources.edit_row;
            this.editBtn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.editBtn.Name = "editBtn";
            this.editBtn.ReadOnly = true;
            this.editBtn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.editBtn.Width = 60;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btnDelete.HeaderText = "DELETE";
            this.btnDelete.Image = global::IMS.Properties.Resources.delete_row;
            this.btnDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnDelete.Width = 60;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle5.NullValue")));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle5;
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
            // back_btn
            // 
            this.back_btn.BackgroundImage = global::IMS.Properties.Resources.back;
            this.back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Location = new System.Drawing.Point(25, 151);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(50, 50);
            this.back_btn.TabIndex = 11;
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // sett_pic
            // 
            this.sett_pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sett_pic.Image = global::IMS.Properties.Resources.settings;
            this.sett_pic.Location = new System.Drawing.Point(1221, 49);
            this.sett_pic.Name = "sett_pic";
            this.sett_pic.Size = new System.Drawing.Size(45, 42);
            this.sett_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sett_pic.TabIndex = 10;
            this.sett_pic.TabStop = false;
            // 
            // logo_ims
            // 
            this.logo_ims.BackColor = System.Drawing.Color.Transparent;
            this.logo_ims.Image = global::IMS.Properties.Resources.U_logo;
            this.logo_ims.Location = new System.Drawing.Point(25, 61);
            this.logo_ims.Name = "logo_ims";
            this.logo_ims.Size = new System.Drawing.Size(52, 54);
            this.logo_ims.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_ims.TabIndex = 5;
            this.logo_ims.TabStop = false;
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
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1344, 686);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.add_cat_panel);
            this.Controls.Add(this.pnlAddItem);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.sett_pic);
            this.Controls.Add(this.logo_ims);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "frmInventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmInventory_KeyDown);
            this.pnlAddItem.ResumeLayout(false);
            this.pnlAddItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_item_pic)).EndInit();
            this.add_cat_panel.ResumeLayout(false);
            this.add_cat_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_cat_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sett_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_ims)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo_ims;
        private System.Windows.Forms.PictureBox sett_pic;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Panel pnlAddItem;
        private System.Windows.Forms.Label lblAddItem;
        private System.Windows.Forms.PictureBox add_item_pic;
        private System.Windows.Forms.Panel add_cat_panel;
        private System.Windows.Forms.Label add_cat_lbl;
        private System.Windows.Forms.PictureBox add_cat_pic;
        internal System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCatName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsubcat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSSubcat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOPGQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurcase;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSale;
        private System.Windows.Forms.DataGridViewImageColumn editBtn;
        private System.Windows.Forms.DataGridViewImageColumn btnDelete;
        private System.Windows.Forms.Label lblLogo;
    }
}