namespace IMS.Inventory
{
    partial class frmAddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddItem));
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemcode = new System.Windows.Forms.TextBox();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cboUnit = new System.Windows.Forms.ComboBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtMinQty = new System.Windows.Forms.TextBox();
            this.lblminqty = new System.Windows.Forms.Label();
            this.cboQuality = new System.Windows.Forms.ComboBox();
            this.lblQuality = new System.Windows.Forms.Label();
            this.cboplytype = new System.Windows.Forms.ComboBox();
            this.lblplyType = new System.Windows.Forms.Label();
            this.cboThick = new System.Windows.Forms.ComboBox();
            this.lblThick = new System.Windows.Forms.Label();
            this.cbowidth = new System.Windows.Forms.ComboBox();
            this.lblwidth = new System.Windows.Forms.Label();
            this.cboLength = new System.Windows.Forms.ComboBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtdisc = new System.Windows.Forms.TextBox();
            this.lblDiscPer = new System.Windows.Forms.Label();
            this.txtVatPer = new System.Windows.Forms.TextBox();
            this.lblVat = new System.Windows.Forms.Label();
            this.txtSale = new System.Windows.Forms.TextBox();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.drpdnssubcat = new System.Windows.Forms.ComboBox();
            this.txtOpgQty = new System.Windows.Forms.TextBox();
            this.lblOpgqty = new System.Windows.Forms.Label();
            this.lblssubcat = new System.Windows.Forms.Label();
            this.drpdnsubcat = new System.Windows.Forms.ComboBox();
            this.lblSubCategory = new System.Windows.Forms.Label();
            this.txtPurchase = new System.Windows.Forms.TextBox();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.drpdnCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pnlCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSubMain3 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlHead.SuspendLayout();
            this.pnlSubMain3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.ForeColor = System.Drawing.Color.White;
            this.txtItemName.Location = new System.Drawing.Point(237, 10);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(208, 27);
            this.txtItemName.TabIndex = 2;
            // 
            // txtItemcode
            // 
            this.txtItemcode.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtItemcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemcode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemcode.ForeColor = System.Drawing.Color.White;
            this.txtItemcode.Location = new System.Drawing.Point(83, 9);
            this.txtItemcode.Name = "txtItemcode";
            this.txtItemcode.Size = new System.Drawing.Size(68, 27);
            this.txtItemcode.TabIndex = 1;
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCode.ForeColor = System.Drawing.Color.White;
            this.lblItemCode.Location = new System.Drawing.Point(3, 14);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(76, 16);
            this.lblItemCode.TabIndex = 25;
            this.lblItemCode.Text = "Item Code :";
            this.lblItemCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.White;
            this.lblItemName.Location = new System.Drawing.Point(155, 17);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(80, 16);
            this.lblItemName.TabIndex = 26;
            this.lblItemName.Text = "Item Name :";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSize = true;
            this.pnlMain.Controls.Add(this.pnlHead);
            this.pnlMain.Controls.Add(this.pnlCategory);
            this.pnlMain.Controls.Add(this.pnlSubMain3);
            this.pnlMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlMain.Location = new System.Drawing.Point(9, 33);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(833, 304);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlHead
            // 
            this.pnlHead.Controls.Add(this.txtSize);
            this.pnlHead.Controls.Add(this.lblSize);
            this.pnlHead.Controls.Add(this.txtBrand);
            this.pnlHead.Controls.Add(this.button1);
            this.pnlHead.Controls.Add(this.cboUnit);
            this.pnlHead.Controls.Add(this.lblUnit);
            this.pnlHead.Controls.Add(this.cboBrand);
            this.pnlHead.Controls.Add(this.lblBrand);
            this.pnlHead.Controls.Add(this.txtMinQty);
            this.pnlHead.Controls.Add(this.lblminqty);
            this.pnlHead.Controls.Add(this.cboQuality);
            this.pnlHead.Controls.Add(this.lblQuality);
            this.pnlHead.Controls.Add(this.cboplytype);
            this.pnlHead.Controls.Add(this.lblplyType);
            this.pnlHead.Controls.Add(this.cboThick);
            this.pnlHead.Controls.Add(this.lblThick);
            this.pnlHead.Controls.Add(this.cbowidth);
            this.pnlHead.Controls.Add(this.lblwidth);
            this.pnlHead.Controls.Add(this.cboLength);
            this.pnlHead.Controls.Add(this.lblLength);
            this.pnlHead.Controls.Add(this.txtdisc);
            this.pnlHead.Controls.Add(this.lblDiscPer);
            this.pnlHead.Controls.Add(this.txtVatPer);
            this.pnlHead.Controls.Add(this.lblVat);
            this.pnlHead.Controls.Add(this.txtSale);
            this.pnlHead.Controls.Add(this.lblSalePrice);
            this.pnlHead.Controls.Add(this.txtItemName);
            this.pnlHead.Controls.Add(this.drpdnssubcat);
            this.pnlHead.Controls.Add(this.txtOpgQty);
            this.pnlHead.Controls.Add(this.lblOpgqty);
            this.pnlHead.Controls.Add(this.lblItemName);
            this.pnlHead.Controls.Add(this.txtItemcode);
            this.pnlHead.Controls.Add(this.lblssubcat);
            this.pnlHead.Controls.Add(this.lblItemCode);
            this.pnlHead.Controls.Add(this.drpdnsubcat);
            this.pnlHead.Controls.Add(this.lblSubCategory);
            this.pnlHead.Controls.Add(this.txtPurchase);
            this.pnlHead.Controls.Add(this.lblPurchasePrice);
            this.pnlHead.Controls.Add(this.drpdnCategory);
            this.pnlHead.Controls.Add(this.lblCategory);
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(827, 214);
            this.pnlHead.TabIndex = 1;
            // 
            // txtSize
            // 
            this.txtSize.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSize.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.ForeColor = System.Drawing.Color.White;
            this.txtSize.Location = new System.Drawing.Point(72, 170);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(126, 27);
            this.txtSize.TabIndex = 17;
            this.txtSize.Text = "0";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.White;
            this.lblSize.Location = new System.Drawing.Point(20, 179);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(41, 16);
            this.lblSize.TabIndex = 62;
            this.lblSize.Text = "Size :";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBrand
            // 
            this.txtBrand.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrand.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.ForeColor = System.Drawing.Color.White;
            this.txtBrand.Location = new System.Drawing.Point(504, 9);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(137, 27);
            this.txtBrand.TabIndex = 3;
            this.txtBrand.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::IMS.Properties.Resources.settings;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(650, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 59;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboUnit
            // 
            this.cboUnit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboUnit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.ForeColor = System.Drawing.Color.White;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(726, 10);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(95, 27);
            this.cboUnit.TabIndex = 4;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.ForeColor = System.Drawing.Color.White;
            this.lblUnit.Location = new System.Drawing.Point(681, 16);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(39, 16);
            this.lblUnit.TabIndex = 57;
            this.lblUnit.Text = "Unit :";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboBrand
            // 
            this.cboBrand.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBrand.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBrand.ForeColor = System.Drawing.Color.White;
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.Location = new System.Drawing.Point(503, 9);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(138, 27);
            this.cboBrand.TabIndex = 3;
            this.cboBrand.SelectionChangeCommitted += new System.EventHandler(this.cboBrand_SelectionChangeCommitted);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(451, 15);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(50, 16);
            this.lblBrand.TabIndex = 55;
            this.lblBrand.Text = "Brand :";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtMinQty
            // 
            this.txtMinQty.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMinQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinQty.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinQty.ForeColor = System.Drawing.Color.White;
            this.txtMinQty.Location = new System.Drawing.Point(531, 90);
            this.txtMinQty.Name = "txtMinQty";
            this.txtMinQty.Size = new System.Drawing.Size(48, 27);
            this.txtMinQty.TabIndex = 11;
            this.txtMinQty.Text = "0";
            this.txtMinQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinQty_KeyPress);
            // 
            // lblminqty
            // 
            this.lblminqty.AutoSize = true;
            this.lblminqty.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblminqty.ForeColor = System.Drawing.Color.White;
            this.lblminqty.Location = new System.Drawing.Point(468, 95);
            this.lblminqty.Name = "lblminqty";
            this.lblminqty.Size = new System.Drawing.Size(60, 16);
            this.lblminqty.TabIndex = 54;
            this.lblminqty.Text = "Min Qty :";
            this.lblminqty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboQuality
            // 
            this.cboQuality.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cboQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuality.Enabled = false;
            this.cboQuality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboQuality.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQuality.ForeColor = System.Drawing.Color.White;
            this.cboQuality.FormattingEnabled = true;
            this.cboQuality.Location = new System.Drawing.Point(650, 170);
            this.cboQuality.Name = "cboQuality";
            this.cboQuality.Size = new System.Drawing.Size(172, 27);
            this.cboQuality.TabIndex = 19;
            // 
            // lblQuality
            // 
            this.lblQuality.AutoSize = true;
            this.lblQuality.Enabled = false;
            this.lblQuality.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuality.ForeColor = System.Drawing.Color.White;
            this.lblQuality.Location = new System.Drawing.Point(582, 174);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(56, 16);
            this.lblQuality.TabIndex = 51;
            this.lblQuality.Text = "Quality :";
            this.lblQuality.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboplytype
            // 
            this.cboplytype.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cboplytype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboplytype.Enabled = false;
            this.cboplytype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboplytype.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboplytype.ForeColor = System.Drawing.Color.White;
            this.cboplytype.FormattingEnabled = true;
            this.cboplytype.Location = new System.Drawing.Point(304, 168);
            this.cboplytype.Name = "cboplytype";
            this.cboplytype.Size = new System.Drawing.Size(247, 27);
            this.cboplytype.TabIndex = 18;
            // 
            // lblplyType
            // 
            this.lblplyType.AutoSize = true;
            this.lblplyType.Enabled = false;
            this.lblplyType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplyType.ForeColor = System.Drawing.Color.White;
            this.lblplyType.Location = new System.Drawing.Point(216, 175);
            this.lblplyType.Name = "lblplyType";
            this.lblplyType.Size = new System.Drawing.Size(82, 16);
            this.lblplyType.TabIndex = 49;
            this.lblplyType.Text = "Type Of Ply :";
            this.lblplyType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboThick
            // 
            this.cboThick.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cboThick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThick.Enabled = false;
            this.cboThick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboThick.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThick.ForeColor = System.Drawing.Color.White;
            this.cboThick.FormattingEnabled = true;
            this.cboThick.Location = new System.Drawing.Point(650, 127);
            this.cboThick.Name = "cboThick";
            this.cboThick.Size = new System.Drawing.Size(171, 27);
            this.cboThick.TabIndex = 16;
            this.cboThick.SelectionChangeCommitted += new System.EventHandler(this.cboThick_SelectionChangeCommitted);
            // 
            // lblThick
            // 
            this.lblThick.AutoSize = true;
            this.lblThick.Enabled = false;
            this.lblThick.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThick.ForeColor = System.Drawing.Color.White;
            this.lblThick.Location = new System.Drawing.Point(568, 133);
            this.lblThick.Name = "lblThick";
            this.lblThick.Size = new System.Drawing.Size(73, 16);
            this.lblThick.TabIndex = 47;
            this.lblThick.Text = "Thickness :";
            this.lblThick.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbowidth
            // 
            this.cbowidth.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbowidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbowidth.Enabled = false;
            this.cbowidth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbowidth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbowidth.ForeColor = System.Drawing.Color.White;
            this.cbowidth.FormattingEnabled = true;
            this.cbowidth.Location = new System.Drawing.Point(385, 126);
            this.cbowidth.Name = "cbowidth";
            this.cbowidth.Size = new System.Drawing.Size(167, 27);
            this.cbowidth.TabIndex = 15;
            this.cbowidth.SelectionChangeCommitted += new System.EventHandler(this.cbowidth_SelectionChangeCommitted);
            // 
            // lblwidth
            // 
            this.lblwidth.AutoSize = true;
            this.lblwidth.Enabled = false;
            this.lblwidth.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwidth.ForeColor = System.Drawing.Color.White;
            this.lblwidth.Location = new System.Drawing.Point(329, 132);
            this.lblwidth.Name = "lblwidth";
            this.lblwidth.Size = new System.Drawing.Size(50, 16);
            this.lblwidth.TabIndex = 45;
            this.lblwidth.Text = "Width :";
            this.lblwidth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboLength
            // 
            this.cboLength.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cboLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLength.Enabled = false;
            this.cboLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboLength.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLength.ForeColor = System.Drawing.Color.White;
            this.cboLength.FormattingEnabled = true;
            this.cboLength.Location = new System.Drawing.Point(72, 126);
            this.cboLength.Name = "cboLength";
            this.cboLength.Size = new System.Drawing.Size(245, 27);
            this.cboLength.TabIndex = 14;
            this.cboLength.SelectionChangeCommitted += new System.EventHandler(this.cboLength_SelectionChangeCommitted);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Enabled = false;
            this.lblLength.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.ForeColor = System.Drawing.Color.White;
            this.lblLength.Location = new System.Drawing.Point(20, 132);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(55, 16);
            this.lblLength.TabIndex = 43;
            this.lblLength.Text = "Length :";
            this.lblLength.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtdisc
            // 
            this.txtdisc.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtdisc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdisc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdisc.ForeColor = System.Drawing.Color.White;
            this.txtdisc.Location = new System.Drawing.Point(767, 90);
            this.txtdisc.Name = "txtdisc";
            this.txtdisc.Size = new System.Drawing.Size(54, 27);
            this.txtdisc.TabIndex = 13;
            this.txtdisc.Text = "0";
            this.txtdisc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdisc_KeyPress);
            // 
            // lblDiscPer
            // 
            this.lblDiscPer.AutoSize = true;
            this.lblDiscPer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscPer.ForeColor = System.Drawing.Color.White;
            this.lblDiscPer.Location = new System.Drawing.Point(701, 95);
            this.lblDiscPer.Name = "lblDiscPer";
            this.lblDiscPer.Size = new System.Drawing.Size(63, 16);
            this.lblDiscPer.TabIndex = 41;
            this.lblDiscPer.Text = "Disc Per :";
            this.lblDiscPer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtVatPer
            // 
            this.txtVatPer.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtVatPer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVatPer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVatPer.ForeColor = System.Drawing.Color.White;
            this.txtVatPer.Location = new System.Drawing.Point(650, 90);
            this.txtVatPer.Name = "txtVatPer";
            this.txtVatPer.Size = new System.Drawing.Size(48, 27);
            this.txtVatPer.TabIndex = 12;
            this.txtVatPer.Text = "0";
            this.txtVatPer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVatPer_KeyPress);
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.ForeColor = System.Drawing.Color.White;
            this.lblVat.Location = new System.Drawing.Point(587, 95);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(59, 16);
            this.lblVat.TabIndex = 39;
            this.lblVat.Text = "Vat Per :";
            this.lblVat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSale
            // 
            this.txtSale.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSale.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSale.ForeColor = System.Drawing.Color.White;
            this.txtSale.Location = new System.Drawing.Point(237, 90);
            this.txtSale.Name = "txtSale";
            this.txtSale.Size = new System.Drawing.Size(80, 27);
            this.txtSale.TabIndex = 9;
            this.txtSale.Text = "0";
            this.txtSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSale_KeyPress);
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalePrice.ForeColor = System.Drawing.Color.White;
            this.lblSalePrice.Location = new System.Drawing.Point(162, 95);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(74, 16);
            this.lblSalePrice.TabIndex = 35;
            this.lblSalePrice.Text = "Sale Price :";
            this.lblSalePrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // drpdnssubcat
            // 
            this.drpdnssubcat.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.drpdnssubcat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpdnssubcat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drpdnssubcat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpdnssubcat.ForeColor = System.Drawing.Color.White;
            this.drpdnssubcat.FormattingEnabled = true;
            this.drpdnssubcat.Location = new System.Drawing.Point(646, 50);
            this.drpdnssubcat.Name = "drpdnssubcat";
            this.drpdnssubcat.Size = new System.Drawing.Size(176, 27);
            this.drpdnssubcat.TabIndex = 7;
            this.drpdnssubcat.Visible = false;
            this.drpdnssubcat.SelectionChangeCommitted += new System.EventHandler(this.drpdnssubcat_SelectionChangeCommitted);
            // 
            // txtOpgQty
            // 
            this.txtOpgQty.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtOpgQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpgQty.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpgQty.ForeColor = System.Drawing.Color.White;
            this.txtOpgQty.Location = new System.Drawing.Point(385, 92);
            this.txtOpgQty.Name = "txtOpgQty";
            this.txtOpgQty.Size = new System.Drawing.Size(74, 27);
            this.txtOpgQty.TabIndex = 10;
            this.txtOpgQty.Text = "0";
            this.txtOpgQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOpgQty_KeyPress);
            // 
            // lblOpgqty
            // 
            this.lblOpgqty.AutoSize = true;
            this.lblOpgqty.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpgqty.ForeColor = System.Drawing.Color.White;
            this.lblOpgqty.Location = new System.Drawing.Point(321, 95);
            this.lblOpgqty.Name = "lblOpgqty";
            this.lblOpgqty.Size = new System.Drawing.Size(63, 16);
            this.lblOpgqty.TabIndex = 37;
            this.lblOpgqty.Text = "Opg Qty :";
            this.lblOpgqty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblssubcat
            // 
            this.lblssubcat.AutoSize = true;
            this.lblssubcat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblssubcat.ForeColor = System.Drawing.Color.White;
            this.lblssubcat.Location = new System.Drawing.Point(542, 56);
            this.lblssubcat.Name = "lblssubcat";
            this.lblssubcat.Size = new System.Drawing.Size(103, 16);
            this.lblssubcat.TabIndex = 32;
            this.lblssubcat.Text = "SSub-Category :";
            this.lblssubcat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblssubcat.Visible = false;
            // 
            // drpdnsubcat
            // 
            this.drpdnsubcat.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.drpdnsubcat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpdnsubcat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drpdnsubcat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpdnsubcat.ForeColor = System.Drawing.Color.White;
            this.drpdnsubcat.FormattingEnabled = true;
            this.drpdnsubcat.Location = new System.Drawing.Point(366, 50);
            this.drpdnsubcat.Name = "drpdnsubcat";
            this.drpdnsubcat.Size = new System.Drawing.Size(172, 27);
            this.drpdnsubcat.TabIndex = 6;
            this.drpdnsubcat.Visible = false;
            this.drpdnsubcat.SelectionChangeCommitted += new System.EventHandler(this.drpdnsubcat_SelectionChangeCommitted);
            // 
            // lblSubCategory
            // 
            this.lblSubCategory.AutoSize = true;
            this.lblSubCategory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCategory.ForeColor = System.Drawing.Color.White;
            this.lblSubCategory.Location = new System.Drawing.Point(270, 56);
            this.lblSubCategory.Name = "lblSubCategory";
            this.lblSubCategory.Size = new System.Drawing.Size(95, 16);
            this.lblSubCategory.TabIndex = 30;
            this.lblSubCategory.Text = "Sub-Category :";
            this.lblSubCategory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSubCategory.Visible = false;
            // 
            // txtPurchase
            // 
            this.txtPurchase.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPurchase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPurchase.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchase.ForeColor = System.Drawing.Color.White;
            this.txtPurchase.Location = new System.Drawing.Point(94, 90);
            this.txtPurchase.Name = "txtPurchase";
            this.txtPurchase.Size = new System.Drawing.Size(65, 27);
            this.txtPurchase.TabIndex = 8;
            this.txtPurchase.Text = "0";
            this.txtPurchase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchasePrice.ForeColor = System.Drawing.Color.White;
            this.lblPurchasePrice.Location = new System.Drawing.Point(3, 95);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(94, 16);
            this.lblPurchasePrice.TabIndex = 29;
            this.lblPurchasePrice.Text = "Purcase Price :";
            this.lblPurchasePrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // drpdnCategory
            // 
            this.drpdnCategory.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.drpdnCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpdnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drpdnCategory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpdnCategory.ForeColor = System.Drawing.Color.White;
            this.drpdnCategory.FormattingEnabled = true;
            this.drpdnCategory.Location = new System.Drawing.Point(82, 51);
            this.drpdnCategory.Name = "drpdnCategory";
            this.drpdnCategory.Size = new System.Drawing.Size(184, 27);
            this.drpdnCategory.TabIndex = 5;
            this.drpdnCategory.SelectionChangeCommitted += new System.EventHandler(this.drpdnCategory_SelectionChangeCommitted);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(10, 56);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(68, 16);
            this.lblCategory.TabIndex = 27;
            this.lblCategory.Text = "Category :";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlCategory
            // 
            this.pnlCategory.AutoSize = true;
            this.pnlCategory.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlCategory.Location = new System.Drawing.Point(3, 217);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(0, 0);
            this.pnlCategory.TabIndex = 0;
            // 
            // pnlSubMain3
            // 
            this.pnlSubMain3.Controls.Add(this.btnReset);
            this.pnlSubMain3.Controls.Add(this.btnSave);
            this.pnlSubMain3.Controls.Add(this.btnExit);
            this.pnlSubMain3.Location = new System.Drawing.Point(3, 223);
            this.pnlSubMain3.Name = "pnlSubMain3";
            this.pnlSubMain3.Size = new System.Drawing.Size(824, 67);
            this.pnlSubMain3.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::IMS.Properties.Resources.clear;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(390, 9);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(53, 49);
            this.btnReset.TabIndex = 21;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.btnSave.BackgroundImage = global::IMS.Properties.Resources.save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(330, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(53, 49);
            this.btnSave.TabIndex = 20;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.btnExit.BackgroundImage = global::IMS.Properties.Resources.Cancel;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(501, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 49);
            this.btnExit.TabIndex = 22;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(854, 381);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(870, 700);
            this.MinimizeBox = false;
            this.Name = "frmAddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.frmAddItem_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddItem_KeyDown);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            this.pnlSubMain3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.FlowLayoutPanel pnlMain;
        private System.Windows.Forms.FlowLayoutPanel pnlCategory;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemcode;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.ComboBox drpdnCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtPurchase;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.ComboBox drpdnssubcat;
        private System.Windows.Forms.Label lblssubcat;
        private System.Windows.Forms.ComboBox drpdnsubcat;
        private System.Windows.Forms.Label lblSubCategory;
        private System.Windows.Forms.Panel pnlSubMain3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtdisc;
        private System.Windows.Forms.Label lblDiscPer;
        private System.Windows.Forms.TextBox txtVatPer;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.TextBox txtSale;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.TextBox txtOpgQty;
        private System.Windows.Forms.Label lblOpgqty;
        private System.Windows.Forms.ComboBox cboLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.ComboBox cboThick;
        private System.Windows.Forms.Label lblThick;
        private System.Windows.Forms.ComboBox cbowidth;
        private System.Windows.Forms.Label lblwidth;
        private System.Windows.Forms.ComboBox cboplytype;
        private System.Windows.Forms.Label lblplyType;
        private System.Windows.Forms.TextBox txtMinQty;
        private System.Windows.Forms.Label lblminqty;
        private System.Windows.Forms.ComboBox cboQuality;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Button btnReset;
    }
}