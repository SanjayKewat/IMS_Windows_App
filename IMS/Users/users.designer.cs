namespace IMS
{
    partial class users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(users));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.user_tip = new System.Windows.Forms.ToolTip(this.components);
            this.allusr_lbl = new System.Windows.Forms.Label();
            this.btnfilter = new System.Windows.Forms.Button();
            this.srch_btn = new System.Windows.Forms.Button();
            this.sett_pic = new System.Windows.Forms.PictureBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.add_usr_panel = new System.Windows.Forms.Panel();
            this.add_lbl = new System.Windows.Forms.Label();
            this.add_usr_pic = new System.Windows.Forms.PictureBox();
            this.usr_pnl = new System.Windows.Forms.Panel();
            this.usr_pic = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fname_txt = new System.Windows.Forms.TextBox();
            this.lname_lbl = new System.Windows.Forms.Label();
            this.role_lbl = new System.Windows.Forms.Label();
            this.lname_txt = new System.Windows.Forms.TextBox();
            this.role_drop = new System.Windows.Forms.ComboBox();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.usr_grd = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscPlywood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscHardware = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSUB_CATEGORY1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editBtn = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.logo_ims = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sett_pic)).BeginInit();
            this.add_usr_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_usr_pic)).BeginInit();
            this.usr_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usr_pic)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usr_grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_ims)).BeginInit();
            this.SuspendLayout();
            // 
            // user_tip
            // 
            this.user_tip.IsBalloon = true;
            // 
            // allusr_lbl
            // 
            this.allusr_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.allusr_lbl.AutoSize = true;
            this.allusr_lbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allusr_lbl.ForeColor = System.Drawing.Color.White;
            this.allusr_lbl.Location = new System.Drawing.Point(56, 116);
            this.allusr_lbl.Name = "allusr_lbl";
            this.allusr_lbl.Size = new System.Drawing.Size(85, 19);
            this.allusr_lbl.TabIndex = 7;
            this.allusr_lbl.Text = "All User\'s";
            this.user_tip.SetToolTip(this.allusr_lbl, "Click for Add New User...!");
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
            this.btnfilter.Location = new System.Drawing.Point(67, -4);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(49, 46);
            this.btnfilter.TabIndex = 5;
            this.user_tip.SetToolTip(this.btnfilter, "Click for clear filter..!");
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
            this.srch_btn.Location = new System.Drawing.Point(3, -3);
            this.srch_btn.Name = "srch_btn";
            this.srch_btn.Size = new System.Drawing.Size(49, 46);
            this.srch_btn.TabIndex = 4;
            this.user_tip.SetToolTip(this.srch_btn, "Click for Search User..!");
            this.srch_btn.UseVisualStyleBackColor = false;
            this.srch_btn.Click += new System.EventHandler(this.srch_btn_Click);
            // 
            // sett_pic
            // 
            this.sett_pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sett_pic.Image = global::IMS.Properties.Resources.settings;
            this.sett_pic.Location = new System.Drawing.Point(1221, 49);
            this.sett_pic.Name = "sett_pic";
            this.sett_pic.Size = new System.Drawing.Size(45, 42);
            this.sett_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sett_pic.TabIndex = 4;
            this.sett_pic.TabStop = false;
            this.user_tip.SetToolTip(this.sett_pic, "Click for Setting...!");
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
            this.back_btn.TabIndex = 0;
            this.user_tip.SetToolTip(this.back_btn, "Click for back..!");
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            this.back_btn.MouseHover += new System.EventHandler(this.back_btn_MouseHover);
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
            this.add_usr_panel.TabIndex = 6;
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
            this.add_lbl.Location = new System.Drawing.Point(25, 74);
            this.add_lbl.Name = "add_lbl";
            this.add_lbl.Size = new System.Drawing.Size(60, 16);
            this.add_lbl.TabIndex = 6;
            this.add_lbl.Text = "Add User";
            this.add_lbl.Click += new System.EventHandler(this.add_lbl_Click);
            this.add_lbl.MouseEnter += new System.EventHandler(this.add_lbl_MouseEnter);
            this.add_lbl.MouseLeave += new System.EventHandler(this.add_lbl_MouseLeave);
            // 
            // add_usr_pic
            // 
            this.add_usr_pic.BackColor = System.Drawing.Color.Transparent;
            this.add_usr_pic.Image = global::IMS.Properties.Resources.Add_User;
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
            // usr_pnl
            // 
            this.usr_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usr_pnl.Controls.Add(this.allusr_lbl);
            this.usr_pnl.Controls.Add(this.usr_pic);
            this.usr_pnl.Location = new System.Drawing.Point(1006, 100);
            this.usr_pnl.Name = "usr_pnl";
            this.usr_pnl.Size = new System.Drawing.Size(196, 138);
            this.usr_pnl.TabIndex = 7;
            // 
            // usr_pic
            // 
            this.usr_pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usr_pic.Image = global::IMS.Properties.Resources.Users;
            this.usr_pic.Location = new System.Drawing.Point(47, 13);
            this.usr_pic.Name = "usr_pic";
            this.usr_pic.Size = new System.Drawing.Size(100, 100);
            this.usr_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usr_pic.TabIndex = 3;
            this.usr_pic.TabStop = false;
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel1.Controls.Add(this.fname_txt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lname_lbl, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.role_lbl, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lname_txt, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.role_drop, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_fname, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 6, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(133, 290);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(1133, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1133, 52);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // fname_txt
            // 
            this.fname_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.fname_txt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.fname_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fname_txt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_txt.ForeColor = System.Drawing.Color.White;
            this.fname_txt.Location = new System.Drawing.Point(176, 22);
            this.fname_txt.Name = "fname_txt";
            this.fname_txt.Size = new System.Drawing.Size(171, 27);
            this.fname_txt.TabIndex = 1;
            // 
            // lname_lbl
            // 
            this.lname_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lname_lbl.AutoSize = true;
            this.lname_lbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_lbl.ForeColor = System.Drawing.Color.White;
            this.lname_lbl.Location = new System.Drawing.Point(379, 36);
            this.lname_lbl.Name = "lname_lbl";
            this.lname_lbl.Size = new System.Drawing.Size(111, 16);
            this.lname_lbl.TabIndex = 8;
            this.lname_lbl.Text = "Enter Last Name :";
            this.lname_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // role_lbl
            // 
            this.role_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.role_lbl.AutoSize = true;
            this.role_lbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role_lbl.ForeColor = System.Drawing.Color.White;
            this.role_lbl.Location = new System.Drawing.Point(724, 36);
            this.role_lbl.Name = "role_lbl";
            this.role_lbl.Size = new System.Drawing.Size(81, 16);
            this.role_lbl.TabIndex = 10;
            this.role_lbl.Text = "Select Role :";
            this.role_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lname_txt
            // 
            this.lname_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lname_txt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lname_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lname_txt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_txt.ForeColor = System.Drawing.Color.White;
            this.lname_txt.Location = new System.Drawing.Point(515, 22);
            this.lname_txt.Name = "lname_txt";
            this.lname_txt.Size = new System.Drawing.Size(171, 27);
            this.lname_txt.TabIndex = 2;
            // 
            // role_drop
            // 
            this.role_drop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.role_drop.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.role_drop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.role_drop.Font = new System.Drawing.Font("Tahoma", 12F);
            this.role_drop.ForeColor = System.Drawing.Color.White;
            this.role_drop.FormattingEnabled = true;
            this.role_drop.Location = new System.Drawing.Point(844, 22);
            this.role_drop.Name = "role_drop";
            this.role_drop.Size = new System.Drawing.Size(149, 27);
            this.role_drop.TabIndex = 3;
            // 
            // lbl_fname
            // 
            this.lbl_fname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fname.ForeColor = System.Drawing.Color.White;
            this.lbl_fname.Location = new System.Drawing.Point(3, 36);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(113, 16);
            this.lbl_fname.TabIndex = 7;
            this.lbl_fname.Text = "Enter First Name :";
            this.lbl_fname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnfilter);
            this.panel1.Controls.Add(this.srch_btn);
            this.panel1.Location = new System.Drawing.Point(999, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 45);
            this.panel1.TabIndex = 15;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewImageColumn1.FillWeight = 228.4264F;
            this.dataGridViewImageColumn1.HeaderText = "Edit";
            this.dataGridViewImageColumn1.MinimumWidth = 50;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 121;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usr_grd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.usr_grd.ColumnHeadersHeight = 50;
            this.usr_grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.usr_grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.colCustomerId,
            this.colFullName,
            this.colLName,
            this.colDiscPlywood,
            this.colDiscHardware,
            this.colMobile,
            this.colSUB_CATEGORY1,
            this.colEmailID,
            this.editBtn,
            this.btnDelete});
            this.usr_grd.GridColor = System.Drawing.Color.Silver;
            this.usr_grd.Location = new System.Drawing.Point(133, 377);
            this.usr_grd.MultiSelect = false;
            this.usr_grd.Name = "usr_grd";
            this.usr_grd.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usr_grd.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.usr_grd.RowHeadersVisible = false;
            this.usr_grd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            this.usr_grd.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.usr_grd.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.usr_grd.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usr_grd.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.usr_grd.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            this.usr_grd.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.usr_grd.RowTemplate.Height = 30;
            this.usr_grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usr_grd.Size = new System.Drawing.Size(1130, 309);
            this.usr_grd.TabIndex = 40;
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
            // colCustomerId
            // 
            this.colCustomerId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCustomerId.DataPropertyName = "user_id";
            this.colCustomerId.HeaderText = "User ID";
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.ReadOnly = true;
            this.colCustomerId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCustomerId.Width = 80;
            // 
            // colFullName
            // 
            this.colFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colFullName.DataPropertyName = "first_name";
            this.colFullName.HeaderText = "First Name";
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            this.colFullName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colFullName.Width = 150;
            // 
            // colLName
            // 
            this.colLName.DataPropertyName = "last_name";
            this.colLName.HeaderText = "Last Name";
            this.colLName.Name = "colLName";
            this.colLName.ReadOnly = true;
            // 
            // colDiscPlywood
            // 
            this.colDiscPlywood.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDiscPlywood.DataPropertyName = "usr_name";
            this.colDiscPlywood.FillWeight = 56.27266F;
            this.colDiscPlywood.HeaderText = "User Name";
            this.colDiscPlywood.Name = "colDiscPlywood";
            this.colDiscPlywood.ReadOnly = true;
            this.colDiscPlywood.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDiscPlywood.Width = 150;
            // 
            // colDiscHardware
            // 
            this.colDiscHardware.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDiscHardware.DataPropertyName = "role_name";
            this.colDiscHardware.HeaderText = "Role";
            this.colDiscHardware.MinimumWidth = 150;
            this.colDiscHardware.Name = "colDiscHardware";
            this.colDiscHardware.ReadOnly = true;
            this.colDiscHardware.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDiscHardware.Width = 150;
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
            this.colSUB_CATEGORY1.DataPropertyName = "usr_address";
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            this.editBtn.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.dataGridViewImageColumn2.Width = 60;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn3.HeaderText = "DELETE";
            this.dataGridViewImageColumn3.Image = global::IMS.Properties.Resources.delete_row;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn3.Width = 60;
            // 
            // logo_ims
            // 
            this.logo_ims.BackColor = System.Drawing.Color.Transparent;
            this.logo_ims.Image = global::IMS.Properties.Resources.U_logo;
            this.logo_ims.Location = new System.Drawing.Point(25, 61);
            this.logo_ims.Name = "logo_ims";
            this.logo_ims.Size = new System.Drawing.Size(52, 54);
            this.logo_ims.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_ims.TabIndex = 2;
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
            // users
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
            this.Name = "users";
            this.Text = "User\'s";
            this.Load += new System.EventHandler(this.users_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.users_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.sett_pic)).EndInit();
            this.add_usr_panel.ResumeLayout(false);
            this.add_usr_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_usr_pic)).EndInit();
            this.usr_pnl.ResumeLayout(false);
            this.usr_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usr_pic)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usr_grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_ims)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.PictureBox logo_ims;
        private System.Windows.Forms.PictureBox usr_pic;
        private System.Windows.Forms.ToolTip user_tip;
        private System.Windows.Forms.PictureBox sett_pic;
        private System.Windows.Forms.PictureBox add_usr_pic;
        private System.Windows.Forms.Panel add_usr_panel;
        private System.Windows.Forms.Label add_lbl;
        private System.Windows.Forms.Panel usr_pnl;
        private System.Windows.Forms.Label allusr_lbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Label lname_lbl;
        private System.Windows.Forms.Button srch_btn;
        private System.Windows.Forms.Label role_lbl;
        private System.Windows.Forms.ComboBox role_drop;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        internal System.Windows.Forms.DataGridView usr_grd;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscPlywood;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscHardware;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSUB_CATEGORY1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmailID;
        private System.Windows.Forms.DataGridViewImageColumn editBtn;
        private System.Windows.Forms.DataGridViewImageColumn btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.TextBox fname_txt;
        private System.Windows.Forms.TextBox lname_txt;
        private System.Windows.Forms.Label lblLogo;
    }
}