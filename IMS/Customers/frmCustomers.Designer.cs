namespace IMS.Customers
{
    partial class frmCustomers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.add_cust_panel = new System.Windows.Forms.Panel();
            this.add_cust_lbl = new System.Windows.Forms.Label();
            this.add_cust_pic = new System.Windows.Forms.PictureBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.colCustId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSUB_CATEGORY1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscPlywood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscHardware = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editBtn = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAccount = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlLayout = new System.Windows.Forms.TableLayoutPanel();
            this.drpdnState = new System.Windows.Forms.ComboBox();
            this.drpdnCity = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lbl_Customer = new System.Windows.Forms.Label();
            this.drpdnCustomer = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.drpdnType = new System.Windows.Forms.ComboBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.srch_btn = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.sett_pic = new System.Windows.Forms.PictureBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.logo_ims = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.add_cust_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_cust_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.pnlLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sett_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_ims)).BeginInit();
            this.SuspendLayout();
            // 
            // add_cust_panel
            // 
            this.add_cust_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_cust_panel.Controls.Add(this.add_cust_lbl);
            this.add_cust_panel.Controls.Add(this.add_cust_pic);
            this.add_cust_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_cust_panel.Location = new System.Drawing.Point(133, 164);
            this.add_cust_panel.Name = "add_cust_panel";
            this.add_cust_panel.Size = new System.Drawing.Size(113, 96);
            this.add_cust_panel.TabIndex = 10;
            this.add_cust_panel.Click += new System.EventHandler(this.add_cust_panel_Click);
            this.add_cust_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.add_cust_panel_Paint);
            this.add_cust_panel.MouseEnter += new System.EventHandler(this.add_cust_panel_MouseEnter);
            this.add_cust_panel.MouseLeave += new System.EventHandler(this.add_cust_panel_MouseLeave);
            // 
            // add_cust_lbl
            // 
            this.add_cust_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.add_cust_lbl.AutoSize = true;
            this.add_cust_lbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_cust_lbl.ForeColor = System.Drawing.Color.White;
            this.add_cust_lbl.Location = new System.Drawing.Point(9, 76);
            this.add_cust_lbl.Name = "add_cust_lbl";
            this.add_cust_lbl.Size = new System.Drawing.Size(89, 16);
            this.add_cust_lbl.TabIndex = 6;
            this.add_cust_lbl.Text = "Add Customer";
            this.add_cust_lbl.Click += new System.EventHandler(this.add_cust_lbl_Click);
            this.add_cust_lbl.MouseEnter += new System.EventHandler(this.add_cust_lbl_MouseEnter);
            this.add_cust_lbl.MouseLeave += new System.EventHandler(this.add_cust_lbl_MouseLeave);
            // 
            // add_cust_pic
            // 
            this.add_cust_pic.BackColor = System.Drawing.Color.Transparent;
            this.add_cust_pic.Image = global::IMS.Properties.Resources.Add_Customer;
            this.add_cust_pic.Location = new System.Drawing.Point(29, 19);
            this.add_cust_pic.Name = "add_cust_pic";
            this.add_cust_pic.Size = new System.Drawing.Size(52, 54);
            this.add_cust_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add_cust_pic.TabIndex = 5;
            this.add_cust_pic.TabStop = false;
            this.add_cust_pic.Click += new System.EventHandler(this.add_cust_pic_Click);
            this.add_cust_pic.MouseEnter += new System.EventHandler(this.add_cust_pic_MouseEnter);
            this.add_cust_pic.MouseLeave += new System.EventHandler(this.add_cust_pic_MouseLeave);
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.AllowUserToResizeColumns = false;
            this.dg.AllowUserToResizeRows = false;
            this.dg.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.colCustId,
            this.colCustomerId,
            this.colFullName,
            this.colFName,
            this.colLName,
            this.colMobile,
            this.colSUB_CATEGORY1,
            this.colEmailID,
            this.colDiscPlywood,
            this.colDiscHardware,
            this.editBtn,
            this.btnDelete,
            this.btnAccount});
            this.dg.GridColor = System.Drawing.Color.Silver;
            this.dg.Location = new System.Drawing.Point(52, 352);
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
            this.dg.Size = new System.Drawing.Size(1251, 254);
            this.dg.TabIndex = 39;
            this.dg.TabStop = false;
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
            // 
            // colCustId
            // 
            this.colCustId.DataPropertyName = "CUSTID";
            this.colCustId.HeaderText = "custid";
            this.colCustId.Name = "colCustId";
            this.colCustId.ReadOnly = true;
            this.colCustId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCustId.Visible = false;
            // 
            // colCustomerId
            // 
            this.colCustomerId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCustomerId.DataPropertyName = "CUSTOMERID";
            this.colCustomerId.HeaderText = "Customer Id";
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.ReadOnly = true;
            this.colCustomerId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCustomerId.Width = 80;
            // 
            // colFullName
            // 
            this.colFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colFullName.DataPropertyName = "FuLL_NAME";
            this.colFullName.HeaderText = "Customer Name";
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            this.colFullName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colFullName.Width = 150;
            // 
            // colFName
            // 
            this.colFName.DataPropertyName = "FIRST_NAME";
            this.colFName.HeaderText = "First Name";
            this.colFName.Name = "colFName";
            this.colFName.ReadOnly = true;
            this.colFName.Visible = false;
            // 
            // colLName
            // 
            this.colLName.DataPropertyName = "LAST_NAME";
            this.colLName.HeaderText = "Last Name";
            this.colLName.Name = "colLName";
            this.colLName.ReadOnly = true;
            this.colLName.Visible = false;
            // 
            // colMobile
            // 
            this.colMobile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colMobile.DataPropertyName = "MOBILE";
            this.colMobile.FillWeight = 56.27266F;
            this.colMobile.HeaderText = "Contact No.";
            this.colMobile.Name = "colMobile";
            this.colMobile.ReadOnly = true;
            this.colMobile.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colSUB_CATEGORY1
            // 
            this.colSUB_CATEGORY1.DataPropertyName = "ADDRESS";
            this.colSUB_CATEGORY1.HeaderText = "Address";
            this.colSUB_CATEGORY1.Name = "colSUB_CATEGORY1";
            this.colSUB_CATEGORY1.ReadOnly = true;
            // 
            // colEmailID
            // 
            this.colEmailID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEmailID.DataPropertyName = "EMAIL_ID";
            this.colEmailID.FillWeight = 56.27266F;
            this.colEmailID.HeaderText = "Email Id";
            this.colEmailID.Name = "colEmailID";
            this.colEmailID.ReadOnly = true;
            this.colEmailID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colEmailID.Width = 150;
            // 
            // colDiscPlywood
            // 
            this.colDiscPlywood.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDiscPlywood.DataPropertyName = "DISCOUNT_PLYWOOD";
            this.colDiscPlywood.FillWeight = 56.27266F;
            this.colDiscPlywood.HeaderText = "Discount On Plywood";
            this.colDiscPlywood.Name = "colDiscPlywood";
            this.colDiscPlywood.ReadOnly = true;
            this.colDiscPlywood.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDiscPlywood.Width = 150;
            // 
            // colDiscHardware
            // 
            this.colDiscHardware.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDiscHardware.DataPropertyName = "DISCOUNT_HARDWARE";
            this.colDiscHardware.HeaderText = "Discount On Hardware";
            this.colDiscHardware.MinimumWidth = 150;
            this.colDiscHardware.Name = "colDiscHardware";
            this.colDiscHardware.ReadOnly = true;
            this.colDiscHardware.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDiscHardware.Width = 150;
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
            this.btnAccount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnAccount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnAccount.Width = 70;
            // 
            // pnlLayout
            // 
            this.pnlLayout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlLayout.ColumnCount = 9;
            this.pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.88773F));
            this.pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.11227F));
            this.pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.pnlLayout.Controls.Add(this.drpdnState, 5, 0);
            this.pnlLayout.Controls.Add(this.drpdnCity, 3, 0);
            this.pnlLayout.Controls.Add(this.lblState, 4, 0);
            this.pnlLayout.Controls.Add(this.lbl_Customer, 0, 0);
            this.pnlLayout.Controls.Add(this.drpdnCustomer, 1, 0);
            this.pnlLayout.Controls.Add(this.lblType, 6, 0);
            this.pnlLayout.Controls.Add(this.drpdnType, 7, 0);
            this.pnlLayout.Controls.Add(this.lblCity, 2, 0);
            this.pnlLayout.Controls.Add(this.srch_btn, 8, 0);
            this.pnlLayout.Location = new System.Drawing.Point(52, 294);
            this.pnlLayout.MinimumSize = new System.Drawing.Size(1133, 52);
            this.pnlLayout.Name = "pnlLayout";
            this.pnlLayout.RowCount = 1;
            this.pnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlLayout.Size = new System.Drawing.Size(1251, 52);
            this.pnlLayout.TabIndex = 40;
            // 
            // drpdnState
            // 
            this.drpdnState.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.drpdnState.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.drpdnState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpdnState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drpdnState.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpdnState.ForeColor = System.Drawing.Color.White;
            this.drpdnState.FormattingEnabled = true;
            this.drpdnState.Location = new System.Drawing.Point(759, 22);
            this.drpdnState.Name = "drpdnState";
            this.drpdnState.Size = new System.Drawing.Size(168, 27);
            this.drpdnState.TabIndex = 16;
            // 
            // drpdnCity
            // 
            this.drpdnCity.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.drpdnCity.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.drpdnCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpdnCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drpdnCity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpdnCity.ForeColor = System.Drawing.Color.White;
            this.drpdnCity.FormattingEnabled = true;
            this.drpdnCity.Location = new System.Drawing.Point(505, 22);
            this.drpdnCity.Name = "drpdnCity";
            this.drpdnCity.Size = new System.Drawing.Size(175, 27);
            this.drpdnCity.TabIndex = 15;
            // 
            // lblState
            // 
            this.lblState.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.White;
            this.lblState.Location = new System.Drawing.Point(696, 36);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(47, 16);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "State :";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Customer
            // 
            this.lbl_Customer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Customer.AutoSize = true;
            this.lbl_Customer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer.ForeColor = System.Drawing.Color.White;
            this.lbl_Customer.Location = new System.Drawing.Point(11, 36);
            this.lbl_Customer.Name = "lbl_Customer";
            this.lbl_Customer.Size = new System.Drawing.Size(72, 16);
            this.lbl_Customer.TabIndex = 7;
            this.lbl_Customer.Text = "Customer :";
            this.lbl_Customer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // drpdnCustomer
            // 
            this.drpdnCustomer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.drpdnCustomer.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.drpdnCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpdnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drpdnCustomer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpdnCustomer.ForeColor = System.Drawing.Color.White;
            this.drpdnCustomer.FormattingEnabled = true;
            this.drpdnCustomer.Location = new System.Drawing.Point(120, 22);
            this.drpdnCustomer.Name = "drpdnCustomer";
            this.drpdnCustomer.Size = new System.Drawing.Size(304, 27);
            this.drpdnCustomer.TabIndex = 14;
            // 
            // lblType
            // 
            this.lblType.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(942, 36);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(45, 16);
            this.lblType.TabIndex = 17;
            this.lblType.Text = "Type :";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // drpdnType
            // 
            this.drpdnType.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.drpdnType.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.drpdnType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpdnType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drpdnType.Font = new System.Drawing.Font("Tahoma", 12F);
            this.drpdnType.ForeColor = System.Drawing.Color.White;
            this.drpdnType.FormattingEnabled = true;
            this.drpdnType.Location = new System.Drawing.Point(1005, 22);
            this.drpdnType.Name = "drpdnType";
            this.drpdnType.Size = new System.Drawing.Size(149, 27);
            this.drpdnType.TabIndex = 18;
            // 
            // lblCity
            // 
            this.lblCity.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.White;
            this.lblCity.Location = new System.Drawing.Point(454, 36);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(38, 16);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City :";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // srch_btn
            // 
            this.srch_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.srch_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.srch_btn.BackgroundImage = global::IMS.Properties.Resources.find_user;
            this.srch_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.srch_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.srch_btn.FlatAppearance.BorderSize = 0;
            this.srch_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.srch_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.srch_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.srch_btn.Location = new System.Drawing.Point(1190, 3);
            this.srch_btn.Name = "srch_btn";
            this.srch_btn.Size = new System.Drawing.Size(58, 46);
            this.srch_btn.TabIndex = 19;
            this.srch_btn.UseVisualStyleBackColor = false;
            this.srch_btn.Click += new System.EventHandler(this.srch_btn_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
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
            this.dataGridViewImageColumn1.HeaderText = "DELETE";
            this.dataGridViewImageColumn1.Image = global::IMS.Properties.Resources.delete_row;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 149;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewImageColumn2.HeaderText = "EDIT";
            this.dataGridViewImageColumn2.Image = global::IMS.Properties.Resources.edit_row;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.Width = 80;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn3.HeaderText = "Account";
            this.dataGridViewImageColumn3.Image = global::IMS.Properties.Resources.view_detail;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn3.Width = 5;
            // 
            // sett_pic
            // 
            this.sett_pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sett_pic.Image = global::IMS.Properties.Resources.settings;
            this.sett_pic.Location = new System.Drawing.Point(1221, 49);
            this.sett_pic.Name = "sett_pic";
            this.sett_pic.Size = new System.Drawing.Size(45, 42);
            this.sett_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sett_pic.TabIndex = 9;
            this.sett_pic.TabStop = false;
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
            this.back_btn.TabIndex = 5;
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
            this.logo_ims.TabIndex = 4;
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
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1360, 724);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.pnlLayout);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.add_cust_panel);
            this.Controls.Add(this.sett_pic);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.logo_ims);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmCustomers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCustomers_KeyDown);
            this.add_cust_panel.ResumeLayout(false);
            this.add_cust_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_cust_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.pnlLayout.ResumeLayout(false);
            this.pnlLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sett_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_ims)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo_ims;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.PictureBox sett_pic;
        private System.Windows.Forms.Panel add_cust_panel;
        private System.Windows.Forms.Label add_cust_lbl;
        private System.Windows.Forms.PictureBox add_cust_pic;
        internal System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.TableLayoutPanel pnlLayout;
        private System.Windows.Forms.ComboBox drpdnState;
        private System.Windows.Forms.ComboBox drpdnCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lbl_Customer;
        private System.Windows.Forms.ComboBox drpdnCustomer;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox drpdnType;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button srch_btn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSUB_CATEGORY1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscPlywood;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscHardware;
        private System.Windows.Forms.DataGridViewImageColumn editBtn;
        private System.Windows.Forms.DataGridViewImageColumn btnDelete;
        private System.Windows.Forms.DataGridViewImageColumn btnAccount;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Label lblLogo;

    }
}