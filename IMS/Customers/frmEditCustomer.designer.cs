namespace IMS.Customers
{
    partial class frmEditCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditCustomer));
            this.usr_pnl = new System.Windows.Forms.Panel();
            this.usr_pic = new System.Windows.Forms.PictureBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCustId = new System.Windows.Forms.Label();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.drpdnType = new System.Windows.Forms.ComboBox();
            this.txtStdCode = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtDiscHardware = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiscPlyWood = new System.Windows.Forms.TextBox();
            this.lblDiscPly = new System.Windows.Forms.Label();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.txtCUSTTYPEMOBILE = new System.Windows.Forms.TextBox();
            this.lblCustMobileNO = new System.Windows.Forms.Label();
            this.txtCUSTTYPELNAME = new System.Windows.Forms.TextBox();
            this.lblCutLName = new System.Windows.Forms.Label();
            this.txtCUSTTYPEFNAME = new System.Windows.Forms.TextBox();
            this.lblCustFName = new System.Windows.Forms.Label();
            this.txtEmailId = new System.Windows.Forms.TextBox();
            this.lblConFName = new System.Windows.Forms.Label();
            this.txtLandlineNo = new System.Windows.Forms.TextBox();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.lblLandline = new System.Windows.Forms.Label();
            this.lblMobileNo = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.errorMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblType = new System.Windows.Forms.Label();
            this.usr_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usr_pic)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // usr_pnl
            // 
            this.usr_pnl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usr_pnl.Controls.Add(this.usr_pic);
            this.usr_pnl.Location = new System.Drawing.Point(424, 15);
            this.usr_pnl.Name = "usr_pnl";
            this.usr_pnl.Size = new System.Drawing.Size(196, 127);
            this.usr_pnl.TabIndex = 11;
            // 
            // usr_pic
            // 
            this.usr_pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usr_pic.Image = global::IMS.Properties.Resources.Add_User;
            this.usr_pic.Location = new System.Drawing.Point(47, 13);
            this.usr_pic.Name = "usr_pic";
            this.usr_pic.Size = new System.Drawing.Size(100, 100);
            this.usr_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usr_pic.TabIndex = 3;
            this.usr_pic.TabStop = false;
            // 
            // txtFName
            // 
            this.txtFName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.ForeColor = System.Drawing.Color.White;
            this.txtFName.Location = new System.Drawing.Point(91, 50);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(341, 27);
            this.txtFName.TabIndex = 2;
            // 
            // lbl_fname
            // 
            this.lbl_fname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fname.ForeColor = System.Drawing.Color.White;
            this.lbl_fname.Location = new System.Drawing.Point(6, 55);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(79, 16);
            this.lbl_fname.TabIndex = 8;
            this.lbl_fname.Text = "First Name :";
            this.lbl_fname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_lname
            // 
            this.lbl_lname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lname.ForeColor = System.Drawing.Color.White;
            this.lbl_lname.Location = new System.Drawing.Point(447, 55);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(77, 16);
            this.lbl_lname.TabIndex = 15;
            this.lbl_lname.Text = "Last Name :";
            this.lbl_lname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtLName
            // 
            this.txtLName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.ForeColor = System.Drawing.Color.White;
            this.txtLName.Location = new System.Drawing.Point(530, 51);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(382, 27);
            this.txtLName.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(22, 92);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(63, 16);
            this.lblAddress.TabIndex = 21;
            this.lblAddress.Text = "Address :";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.White;
            this.txtAddress.Location = new System.Drawing.Point(91, 87);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(821, 59);
            this.txtAddress.TabIndex = 4;
            // 
            // lblCity
            // 
            this.lblCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.White;
            this.lblCity.Location = new System.Drawing.Point(47, 159);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(38, 16);
            this.lblCity.TabIndex = 23;
            this.lblCity.Text = "City :";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCustId
            // 
            this.lblCustId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustId.AutoSize = true;
            this.lblCustId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustId.ForeColor = System.Drawing.Color.White;
            this.lblCustId.Location = new System.Drawing.Point(3, 20);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.Size = new System.Drawing.Size(87, 16);
            this.lblCustId.TabIndex = 24;
            this.lblCustId.Text = "Customer Id :";
            this.lblCustId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCustId
            // 
            this.txtCustId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustId.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCustId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustId.ForeColor = System.Drawing.Color.White;
            this.txtCustId.Location = new System.Drawing.Point(91, 15);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(821, 27);
            this.txtCustId.TabIndex = 1;
            // 
            // txtCity
            // 
            this.txtCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCity.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.ForeColor = System.Drawing.Color.White;
            this.txtCity.Location = new System.Drawing.Point(91, 154);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(341, 27);
            this.txtCity.TabIndex = 5;
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.drpdnType);
            this.pnlDetail.Controls.Add(this.txtStdCode);
            this.pnlDetail.Controls.Add(this.btnExit);
            this.pnlDetail.Controls.Add(this.btnLogin);
            this.pnlDetail.Controls.Add(this.txtDiscHardware);
            this.pnlDetail.Controls.Add(this.label1);
            this.pnlDetail.Controls.Add(this.txtDiscPlyWood);
            this.pnlDetail.Controls.Add(this.lblDiscPly);
            this.pnlDetail.Controls.Add(this.grpCustomer);
            this.pnlDetail.Controls.Add(this.txtEmailId);
            this.pnlDetail.Controls.Add(this.lblConFName);
            this.pnlDetail.Controls.Add(this.txtLandlineNo);
            this.pnlDetail.Controls.Add(this.txtMobileNo);
            this.pnlDetail.Controls.Add(this.lblLandline);
            this.pnlDetail.Controls.Add(this.lblMobileNo);
            this.pnlDetail.Controls.Add(this.lblState);
            this.pnlDetail.Controls.Add(this.txtState);
            this.pnlDetail.Controls.Add(this.txtCity);
            this.pnlDetail.Controls.Add(this.lblCity);
            this.pnlDetail.Controls.Add(this.lblCustId);
            this.pnlDetail.Controls.Add(this.txtAddress);
            this.pnlDetail.Controls.Add(this.lblAddress);
            this.pnlDetail.Controls.Add(this.txtCustId);
            this.pnlDetail.Controls.Add(this.txtFName);
            this.pnlDetail.Controls.Add(this.lbl_fname);
            this.pnlDetail.Controls.Add(this.lbl_lname);
            this.pnlDetail.Controls.Add(this.txtLName);
            this.pnlDetail.Location = new System.Drawing.Point(55, 148);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(929, 517);
            this.pnlDetail.TabIndex = 13;
            // 
            // drpdnType
            // 
            this.drpdnType.AllowDrop = true;
            this.drpdnType.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.drpdnType.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.drpdnType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpdnType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drpdnType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpdnType.ForeColor = System.Drawing.Color.White;
            this.drpdnType.FormattingEnabled = true;
            this.drpdnType.Location = new System.Drawing.Point(91, 257);
            this.drpdnType.Name = "drpdnType";
            this.drpdnType.Size = new System.Drawing.Size(821, 27);
            this.drpdnType.TabIndex = 43;
            // 
            // txtStdCode
            // 
            this.txtStdCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStdCode.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtStdCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStdCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStdCode.ForeColor = System.Drawing.Color.White;
            this.txtStdCode.Location = new System.Drawing.Point(530, 187);
            this.txtStdCode.MaxLength = 4;
            this.txtStdCode.Name = "txtStdCode";
            this.txtStdCode.Size = new System.Drawing.Size(97, 27);
            this.txtStdCode.TabIndex = 8;
            this.txtStdCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStdCode_KeyPress);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.btnExit.BackgroundImage = global::IMS.Properties.Resources.Cancel;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(467, 460);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 49);
            this.btnExit.TabIndex = 22;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.btnLogin.BackgroundImage = global::IMS.Properties.Resources.save;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(407, 460);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(53, 49);
            this.btnLogin.TabIndex = 21;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtDiscHardware
            // 
            this.txtDiscHardware.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscHardware.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDiscHardware.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscHardware.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscHardware.ForeColor = System.Drawing.Color.White;
            this.txtDiscHardware.Location = new System.Drawing.Point(578, 400);
            this.txtDiscHardware.Name = "txtDiscHardware";
            this.txtDiscHardware.Size = new System.Drawing.Size(334, 27);
            this.txtDiscHardware.TabIndex = 20;
            this.txtDiscHardware.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscHardware_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(440, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Discount on Hardware";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDiscPlyWood
            // 
            this.txtDiscPlyWood.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscPlyWood.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDiscPlyWood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscPlyWood.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscPlyWood.ForeColor = System.Drawing.Color.White;
            this.txtDiscPlyWood.Location = new System.Drawing.Point(143, 400);
            this.txtDiscPlyWood.Name = "txtDiscPlyWood";
            this.txtDiscPlyWood.Size = new System.Drawing.Size(292, 27);
            this.txtDiscPlyWood.TabIndex = 19;
            this.txtDiscPlyWood.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscPlyWood_KeyPress);
            // 
            // lblDiscPly
            // 
            this.lblDiscPly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscPly.AutoSize = true;
            this.lblDiscPly.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscPly.ForeColor = System.Drawing.Color.White;
            this.lblDiscPly.Location = new System.Drawing.Point(10, 405);
            this.lblDiscPly.Name = "lblDiscPly";
            this.lblDiscPly.Size = new System.Drawing.Size(134, 16);
            this.lblDiscPly.TabIndex = 37;
            this.lblDiscPly.Text = "Discount on Plywood :";
            this.lblDiscPly.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.txtCUSTTYPEMOBILE);
            this.grpCustomer.Controls.Add(this.lblCustMobileNO);
            this.grpCustomer.Controls.Add(this.txtCUSTTYPELNAME);
            this.grpCustomer.Controls.Add(this.lblCutLName);
            this.grpCustomer.Controls.Add(this.txtCUSTTYPEFNAME);
            this.grpCustomer.Controls.Add(this.lblCustFName);
            this.grpCustomer.Location = new System.Drawing.Point(6, 290);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(912, 100);
            this.grpCustomer.TabIndex = 11;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Contractor Detail";
            // 
            // txtCUSTTYPEMOBILE
            // 
            this.txtCUSTTYPEMOBILE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCUSTTYPEMOBILE.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCUSTTYPEMOBILE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCUSTTYPEMOBILE.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCUSTTYPEMOBILE.ForeColor = System.Drawing.Color.White;
            this.txtCUSTTYPEMOBILE.Location = new System.Drawing.Point(88, 62);
            this.txtCUSTTYPEMOBILE.MaxLength = 10;
            this.txtCUSTTYPEMOBILE.Name = "txtCUSTTYPEMOBILE";
            this.txtCUSTTYPEMOBILE.Size = new System.Drawing.Size(818, 27);
            this.txtCUSTTYPEMOBILE.TabIndex = 14;
            this.txtCUSTTYPEMOBILE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustMobileNo_KeyPress);
            // 
            // lblCustMobileNO
            // 
            this.lblCustMobileNO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustMobileNO.AutoSize = true;
            this.lblCustMobileNO.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustMobileNO.ForeColor = System.Drawing.Color.White;
            this.lblCustMobileNO.Location = new System.Drawing.Point(6, 67);
            this.lblCustMobileNO.Name = "lblCustMobileNO";
            this.lblCustMobileNO.Size = new System.Drawing.Size(77, 16);
            this.lblCustMobileNO.TabIndex = 38;
            this.lblCustMobileNO.Text = "Mobile No. :";
            this.lblCustMobileNO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCUSTTYPELNAME
            // 
            this.txtCUSTTYPELNAME.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCUSTTYPELNAME.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCUSTTYPELNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCUSTTYPELNAME.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCUSTTYPELNAME.ForeColor = System.Drawing.Color.White;
            this.txtCUSTTYPELNAME.Location = new System.Drawing.Point(524, 25);
            this.txtCUSTTYPELNAME.Name = "txtCUSTTYPELNAME";
            this.txtCUSTTYPELNAME.Size = new System.Drawing.Size(382, 27);
            this.txtCUSTTYPELNAME.TabIndex = 13;
            // 
            // lblCutLName
            // 
            this.lblCutLName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCutLName.AutoSize = true;
            this.lblCutLName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCutLName.ForeColor = System.Drawing.Color.White;
            this.lblCutLName.Location = new System.Drawing.Point(444, 30);
            this.lblCutLName.Name = "lblCutLName";
            this.lblCutLName.Size = new System.Drawing.Size(77, 16);
            this.lblCutLName.TabIndex = 36;
            this.lblCutLName.Text = "Last Name :";
            this.lblCutLName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCUSTTYPEFNAME
            // 
            this.txtCUSTTYPEFNAME.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCUSTTYPEFNAME.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCUSTTYPEFNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCUSTTYPEFNAME.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCUSTTYPEFNAME.ForeColor = System.Drawing.Color.White;
            this.txtCUSTTYPEFNAME.Location = new System.Drawing.Point(88, 25);
            this.txtCUSTTYPEFNAME.Name = "txtCUSTTYPEFNAME";
            this.txtCUSTTYPEFNAME.Size = new System.Drawing.Size(341, 27);
            this.txtCUSTTYPEFNAME.TabIndex = 12;
            // 
            // lblCustFName
            // 
            this.lblCustFName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustFName.AutoSize = true;
            this.lblCustFName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustFName.ForeColor = System.Drawing.Color.White;
            this.lblCustFName.Location = new System.Drawing.Point(4, 30);
            this.lblCustFName.Name = "lblCustFName";
            this.lblCustFName.Size = new System.Drawing.Size(79, 16);
            this.lblCustFName.TabIndex = 34;
            this.lblCustFName.Text = "First Name :";
            this.lblCustFName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEmailId
            // 
            this.txtEmailId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailId.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEmailId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailId.ForeColor = System.Drawing.Color.White;
            this.txtEmailId.Location = new System.Drawing.Point(91, 221);
            this.txtEmailId.Name = "txtEmailId";
            this.txtEmailId.Size = new System.Drawing.Size(821, 27);
            this.txtEmailId.TabIndex = 10;
            // 
            // lblConFName
            // 
            this.lblConFName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConFName.AutoSize = true;
            this.lblConFName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConFName.ForeColor = System.Drawing.Color.White;
            this.lblConFName.Location = new System.Drawing.Point(24, 226);
            this.lblConFName.Name = "lblConFName";
            this.lblConFName.Size = new System.Drawing.Size(63, 16);
            this.lblConFName.TabIndex = 33;
            this.lblConFName.Text = "Email Id :";
            this.lblConFName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtLandlineNo
            // 
            this.txtLandlineNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLandlineNo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtLandlineNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLandlineNo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLandlineNo.ForeColor = System.Drawing.Color.White;
            this.txtLandlineNo.Location = new System.Drawing.Point(633, 187);
            this.txtLandlineNo.MaxLength = 10;
            this.txtLandlineNo.Name = "txtLandlineNo";
            this.txtLandlineNo.Size = new System.Drawing.Size(279, 27);
            this.txtLandlineNo.TabIndex = 9;
            this.txtLandlineNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLandlineNo_KeyPress);
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMobileNo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMobileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMobileNo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNo.ForeColor = System.Drawing.Color.White;
            this.txtMobileNo.Location = new System.Drawing.Point(91, 188);
            this.txtMobileNo.MaxLength = 10;
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(341, 27);
            this.txtMobileNo.TabIndex = 7;
            this.txtMobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobileNo_KeyPress);
            // 
            // lblLandline
            // 
            this.lblLandline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLandline.AutoSize = true;
            this.lblLandline.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLandline.ForeColor = System.Drawing.Color.White;
            this.lblLandline.Location = new System.Drawing.Point(438, 193);
            this.lblLandline.Name = "lblLandline";
            this.lblLandline.Size = new System.Drawing.Size(87, 16);
            this.lblLandline.TabIndex = 30;
            this.lblLandline.Text = "Landline No. :";
            this.lblLandline.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMobileNo
            // 
            this.lblMobileNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMobileNo.AutoSize = true;
            this.lblMobileNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobileNo.ForeColor = System.Drawing.Color.White;
            this.lblMobileNo.Location = new System.Drawing.Point(8, 193);
            this.lblMobileNo.Name = "lblMobileNo";
            this.lblMobileNo.Size = new System.Drawing.Size(77, 16);
            this.lblMobileNo.TabIndex = 29;
            this.lblMobileNo.Text = "Mobile No. :";
            this.lblMobileNo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblState
            // 
            this.lblState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.White;
            this.lblState.Location = new System.Drawing.Point(477, 159);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(47, 16);
            this.lblState.TabIndex = 28;
            this.lblState.Text = "State :";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtState
            // 
            this.txtState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtState.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtState.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.ForeColor = System.Drawing.Color.White;
            this.txtState.Location = new System.Drawing.Point(530, 154);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(382, 27);
            this.txtState.TabIndex = 6;
            // 
            // errorMessage
            // 
            this.errorMessage.ContainerControl = this;
            // 
            // lblType
            // 
            this.lblType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(67, 408);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(75, 16);
            this.lblType.TabIndex = 42;
            this.lblType.Text = "Reference :";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1040, 703);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.usr_pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditCustomer";
            this.Text = "Edit Customer";
            this.Load += new System.EventHandler(this.frmEditCustomer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEditCustomer_KeyDown);
            this.usr_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usr_pic)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel usr_pnl;
        private System.Windows.Forms.PictureBox usr_pic;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCustId;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtEmailId;
        private System.Windows.Forms.Label lblConFName;
        private System.Windows.Forms.TextBox txtLandlineNo;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Label lblLandline;
        private System.Windows.Forms.Label lblMobileNo;
        private System.Windows.Forms.TextBox txtDiscHardware;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiscPlyWood;
        private System.Windows.Forms.Label lblDiscPly;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.TextBox txtCUSTTYPEMOBILE;
        private System.Windows.Forms.Label lblCustMobileNO;
        private System.Windows.Forms.TextBox txtCUSTTYPELNAME;
        private System.Windows.Forms.Label lblCutLName;
        private System.Windows.Forms.TextBox txtCUSTTYPEFNAME;
        private System.Windows.Forms.Label lblCustFName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtStdCode;
        private System.Windows.Forms.ErrorProvider errorMessage;
        private System.Windows.Forms.ComboBox drpdnType;
        private System.Windows.Forms.Label lblType;
    }
}