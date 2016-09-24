namespace IMS.Suppliers
{
    partial class suppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(suppliers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.usr_grd = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLEDGERID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSUB_CATEGORY1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editBtn = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAccount = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.drp_sup = new System.Windows.Forms.ComboBox();
            this.lname_lbl = new System.Windows.Forms.Label();
            this.role_lbl = new System.Windows.Forms.Label();
            this.drp_state = new System.Windows.Forms.ComboBox();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnfilter = new System.Windows.Forms.Button();
            this.srch_btn = new System.Windows.Forms.Button();
            this.drp_city = new System.Windows.Forms.ComboBox();
            this.usr_pnl = new System.Windows.Forms.Panel();
            this.allusr_lbl = new System.Windows.Forms.Label();
            this.usr_pic = new System.Windows.Forms.PictureBox();
            this.add_usr_panel = new System.Windows.Forms.Panel();
            this.add_lbl = new System.Windows.Forms.Label();
            this.add_usr_pic = new System.Windows.Forms.PictureBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.sett_pic = new System.Windows.Forms.PictureBox();
            this.logo_ims = new System.Windows.Forms.PictureBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usr_grd)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.usr_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usr_pic)).BeginInit();
            this.add_usr_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_usr_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sett_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_ims)).BeginInit();
            this.SuspendLayout();
            // 
            // usr_grd
            // 
            this.usr_grd.AllowUserToAddRows = false;
            this.usr_grd.AllowUserToDeleteRows = false;
            this.usr_grd.AllowUserToResizeColumns = false;
            this.usr_grd.AllowUserToResizeRows = false;
            this.usr_grd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.usr_grd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usr_grd.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usr_grd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.usr_grd.ColumnHeadersHeight = 50;
            this.usr_grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.usr_grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.colLEDGERID,
            this.colCustomerId,
            this.colFullName,
            this.colMobile,
            this.colSUB_CATEGORY1,
            this.colEmailID,
            this.editBtn,
            this.btnDelete,
            this.btnAccount});
            this.usr_grd.GridColor = System.Drawing.Color.Silver;
            this.usr_grd.Location = new System.Drawing.Point(141, 377);
            this.usr_grd.MultiSelect = false;
            this.usr_grd.Name = "usr_grd";
            this.usr_grd.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usr_grd.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.usr_grd.RowHeadersVisible = false;
            this.usr_grd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            this.usr_grd.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.usr_grd.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.usr_grd.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usr_grd.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.usr_grd.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            this.usr_grd.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.usr_grd.RowTemplate.Height = 30;
            this.usr_grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usr_grd.Size = new System.Drawing.Size(1130, 347);
            this.usr_grd.TabIndex = 47;
            this.usr_grd.TabStop = false;
            this.usr_grd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usr_grd_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Visible = false;
            // 
            // colLEDGERID
            // 
            this.colLEDGERID.DataPropertyName = "LedgerId";
            this.colLEDGERID.HeaderText = "ledgerid";
            this.colLEDGERID.Name = "colLEDGERID";
            this.colLEDGERID.ReadOnly = true;
            this.colLEDGERID.Visible = false;
            // 
            // colCustomerId
            // 
            this.colCustomerId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCustomerId.DataPropertyName = "supplier_id";
            this.colCustomerId.HeaderText = "Supplier ID";
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.ReadOnly = true;
            this.colCustomerId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCustomerId.Width = 80;
            // 
            // colFullName
            // 
            this.colFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colFullName.DataPropertyName = "SUP_FULLNAME";
            this.colFullName.HeaderText = "Supplier Name";
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            this.colFullName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colFullName.Width = 150;
            // 
            // colMobile
            // 
            this.colMobile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colMobile.DataPropertyName = "mob_no";
            this.colMobile.FillWeight = 56.27266F;
            this.colMobile.HeaderText = "Contact No.";
            this.colMobile.Name = "colMobile";
            this.colMobile.ReadOnly = true;
            this.colMobile.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colSUB_CATEGORY1
            // 
            this.colSUB_CATEGORY1.DataPropertyName = "sup_address";
            this.colSUB_CATEGORY1.HeaderText = "Address";
            this.colSUB_CATEGORY1.Name = "colSUB_CATEGORY1";
            this.colSUB_CATEGORY1.ReadOnly = true;
            // 
            // colEmailID
            // 
            this.colEmailID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEmailID.DataPropertyName = "email_id";
            this.colEmailID.FillWeight = 56.27266F;
            this.colEmailID.HeaderText = "Email Id";
            this.colEmailID.Name = "colEmailID";
            this.colEmailID.ReadOnly = true;
            this.colEmailID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colEmailID.Width = 150;
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
            // btnAccount
            // 
            this.btnAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btnAccount.HeaderText = "ACCOUNT";
            this.btnAccount.Image = global::IMS.Properties.Resources.view_detail;
            this.btnAccount.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.ReadOnly = true;
            this.btnAccount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnAccount.ToolTipText = "Click to View Details";
            this.btnAccount.Width = 70;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.6899F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.3101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.Controls.Add(this.drp_sup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lname_lbl, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.role_lbl, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.drp_state, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_fname, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.drp_city, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(141, 290);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(1133, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1133, 52);
            this.tableLayoutPanel1.TabIndex = 46;
            // 
            // drp_sup
            // 
            this.drp_sup.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.drp_sup.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.drp_sup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drp_sup.Font = new System.Drawing.Font("Tahoma", 12F);
            this.drp_sup.ForeColor = System.Drawing.Color.White;
            this.drp_sup.FormattingEnabled = true;
            this.drp_sup.Location = new System.Drawing.Point(184, 22);
            this.drp_sup.Name = "drp_sup";
            this.drp_sup.Size = new System.Drawing.Size(149, 27);
            this.drp_sup.TabIndex = 16;
            // 
            // lname_lbl
            // 
            this.lname_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lname_lbl.AutoSize = true;
            this.lname_lbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_lbl.ForeColor = System.Drawing.Color.White;
            this.lname_lbl.Location = new System.Drawing.Point(411, 36);
            this.lname_lbl.Name = "lname_lbl";
            this.lname_lbl.Size = new System.Drawing.Size(38, 16);
            this.lname_lbl.TabIndex = 8;
            this.lname_lbl.Text = "City :";
            this.lname_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // role_lbl
            // 
            this.role_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.role_lbl.AutoSize = true;
            this.role_lbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role_lbl.ForeColor = System.Drawing.Color.White;
            this.role_lbl.Location = new System.Drawing.Point(737, 36);
            this.role_lbl.Name = "role_lbl";
            this.role_lbl.Size = new System.Drawing.Size(47, 16);
            this.role_lbl.TabIndex = 10;
            this.role_lbl.Text = "State :";
            this.role_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // drp_state
            // 
            this.drp_state.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.drp_state.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.drp_state.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drp_state.Font = new System.Drawing.Font("Tahoma", 12F);
            this.drp_state.ForeColor = System.Drawing.Color.White;
            this.drp_state.FormattingEnabled = true;
            this.drp_state.Location = new System.Drawing.Point(840, 22);
            this.drp_state.Name = "drp_state";
            this.drp_state.Size = new System.Drawing.Size(149, 27);
            this.drp_state.TabIndex = 3;
            // 
            // lbl_fname
            // 
            this.lbl_fname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fname.ForeColor = System.Drawing.Color.White;
            this.lbl_fname.Location = new System.Drawing.Point(3, 36);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(64, 16);
            this.lbl_fname.TabIndex = 7;
            this.lbl_fname.Text = "Supplier :";
            this.lbl_fname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnfilter);
            this.panel1.Controls.Add(this.srch_btn);
            this.panel1.Location = new System.Drawing.Point(995, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 45);
            this.panel1.TabIndex = 15;
            // 
            // btnfilter
            // 
            this.btnfilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnfilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.btnfilter.BackgroundImage = global::IMS.Properties.Resources.clear;
            this.btnfilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnfilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfilter.FlatAppearance.BorderSize = 0;
            this.btnfilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnfilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnfilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfilter.Location = new System.Drawing.Point(67, 0);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(49, 46);
            this.btnfilter.TabIndex = 5;
            this.btnfilter.UseVisualStyleBackColor = false;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // srch_btn
            // 
            this.srch_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.srch_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.srch_btn.BackgroundImage = global::IMS.Properties.Resources.find_user;
            this.srch_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.srch_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.srch_btn.FlatAppearance.BorderSize = 0;
            this.srch_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.srch_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.srch_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.srch_btn.Location = new System.Drawing.Point(3, 3);
            this.srch_btn.Name = "srch_btn";
            this.srch_btn.Size = new System.Drawing.Size(49, 46);
            this.srch_btn.TabIndex = 4;
            this.srch_btn.UseVisualStyleBackColor = false;
            this.srch_btn.Click += new System.EventHandler(this.srch_btn_Click);
            // 
            // drp_city
            // 
            this.drp_city.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.drp_city.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.drp_city.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drp_city.Font = new System.Drawing.Font("Tahoma", 12F);
            this.drp_city.ForeColor = System.Drawing.Color.White;
            this.drp_city.FormattingEnabled = true;
            this.drp_city.Location = new System.Drawing.Point(522, 22);
            this.drp_city.Name = "drp_city";
            this.drp_city.Size = new System.Drawing.Size(149, 27);
            this.drp_city.TabIndex = 17;
            // 
            // usr_pnl
            // 
            this.usr_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usr_pnl.Controls.Add(this.allusr_lbl);
            this.usr_pnl.Controls.Add(this.usr_pic);
            this.usr_pnl.Location = new System.Drawing.Point(1022, 100);
            this.usr_pnl.Name = "usr_pnl";
            this.usr_pnl.Size = new System.Drawing.Size(196, 138);
            this.usr_pnl.TabIndex = 45;
            // 
            // allusr_lbl
            // 
            this.allusr_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.allusr_lbl.AutoSize = true;
            this.allusr_lbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allusr_lbl.ForeColor = System.Drawing.Color.White;
            this.allusr_lbl.Location = new System.Drawing.Point(41, 116);
            this.allusr_lbl.Name = "allusr_lbl";
            this.allusr_lbl.Size = new System.Drawing.Size(115, 19);
            this.allusr_lbl.TabIndex = 7;
            this.allusr_lbl.Text = "All Supplier\'s";
            // 
            // usr_pic
            // 
            this.usr_pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usr_pic.Image = global::IMS.Properties.Resources.supplier;
            this.usr_pic.Location = new System.Drawing.Point(47, 13);
            this.usr_pic.Name = "usr_pic";
            this.usr_pic.Size = new System.Drawing.Size(100, 100);
            this.usr_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usr_pic.TabIndex = 3;
            this.usr_pic.TabStop = false;
            // 
            // add_usr_panel
            // 
            this.add_usr_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_usr_panel.Controls.Add(this.add_lbl);
            this.add_usr_panel.Controls.Add(this.add_usr_pic);
            this.add_usr_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_usr_panel.Location = new System.Drawing.Point(133, 164);
            this.add_usr_panel.Name = "add_usr_panel";
            this.add_usr_panel.Size = new System.Drawing.Size(113, 96);
            this.add_usr_panel.TabIndex = 44;
            this.add_usr_panel.Click += new System.EventHandler(this.add_usr_panel_Click);
            this.add_usr_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.add_usr_panel_Paint);
            this.add_usr_panel.MouseEnter += new System.EventHandler(this.add_usr_panel_MouseEnter);
            this.add_usr_panel.MouseLeave += new System.EventHandler(this.add_usr_panel_MouseLeave);
            // 
            // add_lbl
            // 
            this.add_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.add_lbl.AutoSize = true;
            this.add_lbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_lbl.ForeColor = System.Drawing.Color.White;
            this.add_lbl.Location = new System.Drawing.Point(17, 74);
            this.add_lbl.Name = "add_lbl";
            this.add_lbl.Size = new System.Drawing.Size(81, 16);
            this.add_lbl.TabIndex = 6;
            this.add_lbl.Text = "Add Supplier";
            this.add_lbl.Click += new System.EventHandler(this.add_lbl_Click);
            this.add_lbl.MouseEnter += new System.EventHandler(this.add_lbl_MouseEnter);
            this.add_lbl.MouseLeave += new System.EventHandler(this.add_lbl_MouseLeave);
            // 
            // add_usr_pic
            // 
            this.add_usr_pic.BackColor = System.Drawing.Color.Transparent;
            this.add_usr_pic.Image = global::IMS.Properties.Resources.add_supplier;
            this.add_usr_pic.Location = new System.Drawing.Point(29, 19);
            this.add_usr_pic.Name = "add_usr_pic";
            this.add_usr_pic.Size = new System.Drawing.Size(52, 54);
            this.add_usr_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add_usr_pic.TabIndex = 5;
            this.add_usr_pic.TabStop = false;
            this.add_usr_pic.Click += new System.EventHandler(this.add_usr_pic_Click);
            this.add_usr_pic.MouseEnter += new System.EventHandler(this.add_usr_pic_MouseEnter);
            this.add_usr_pic.MouseLeave += new System.EventHandler(this.add_usr_pic_MouseLeave);
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
            this.dataGridViewImageColumn1.ReadOnly = true;
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
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.Width = 60;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn3.HeaderText = "ACCOUNT";
            this.dataGridViewImageColumn3.Image = global::IMS.Properties.Resources.view_detail;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn3.ToolTipText = "Click to View Details";
            this.dataGridViewImageColumn3.Width = 70;
            // 
            // sett_pic
            // 
            this.sett_pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sett_pic.Image = global::IMS.Properties.Resources.settings;
            this.sett_pic.Location = new System.Drawing.Point(1237, 49);
            this.sett_pic.Name = "sett_pic";
            this.sett_pic.Size = new System.Drawing.Size(45, 42);
            this.sett_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sett_pic.TabIndex = 43;
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
            this.logo_ims.TabIndex = 42;
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
            this.back_btn.TabIndex = 41;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
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
            // suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1300, 759);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.usr_grd);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.usr_pnl);
            this.Controls.Add(this.add_usr_panel);
            this.Controls.Add(this.sett_pic);
            this.Controls.Add(this.logo_ims);
            this.Controls.Add(this.back_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "suppliers";
            this.Text = "suppliers";
            this.Load += new System.EventHandler(this.suppliers_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.suppliers_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.usr_grd)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.usr_pnl.ResumeLayout(false);
            this.usr_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usr_pic)).EndInit();
            this.add_usr_panel.ResumeLayout(false);
            this.add_usr_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_usr_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sett_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_ims)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView usr_grd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lname_lbl;
        private System.Windows.Forms.Label role_lbl;
        private System.Windows.Forms.ComboBox drp_state;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.Button srch_btn;
        private System.Windows.Forms.Panel usr_pnl;
        private System.Windows.Forms.Label allusr_lbl;
        private System.Windows.Forms.PictureBox usr_pic;
        private System.Windows.Forms.Panel add_usr_panel;
        private System.Windows.Forms.Label add_lbl;
        private System.Windows.Forms.PictureBox add_usr_pic;
        private System.Windows.Forms.PictureBox sett_pic;
        private System.Windows.Forms.PictureBox logo_ims;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.ComboBox drp_sup;
        private System.Windows.Forms.ComboBox drp_city;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLEDGERID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSUB_CATEGORY1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmailID;
        private System.Windows.Forms.DataGridViewImageColumn editBtn;
        private System.Windows.Forms.DataGridViewImageColumn btnDelete;
        private System.Windows.Forms.DataGridViewImageColumn btnAccount;
        private System.Windows.Forms.Label lblLogo;
    }
}