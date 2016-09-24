﻿namespace IMS.Users
{
    partial class Edituser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edituser));
            this.usr_pnl = new System.Windows.Forms.Panel();
            this.usr_pic = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_role = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.fname_txt = new System.Windows.Forms.TextBox();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.lname_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usr_txt = new System.Windows.Forms.TextBox();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.pwd_txt = new System.Windows.Forms.TextBox();
            this.lbl_lnd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.std_txt = new System.Windows.Forms.TextBox();
            this.phn_txt = new System.Windows.Forms.TextBox();
            this.mob_txt = new System.Windows.Forms.TextBox();
            this.lbl_mob = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.city_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usr_addrs = new System.Windows.Forms.TextBox();
            this.role_drop = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.usr_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usr_pic)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // usr_pnl
            // 
            this.usr_pnl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usr_pnl.Controls.Add(this.usr_pic);
            this.usr_pnl.Location = new System.Drawing.Point(487, 37);
            this.usr_pnl.Name = "usr_pnl";
            this.usr_pnl.Size = new System.Drawing.Size(196, 127);
            this.usr_pnl.TabIndex = 12;
            // 
            // usr_pic
            // 
            this.usr_pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usr_pic.Image = global::IMS.Properties.Resources.edit_usr;
            this.usr_pic.Location = new System.Drawing.Point(47, 13);
            this.usr_pic.Name = "usr_pic";
            this.usr_pic.Size = new System.Drawing.Size(100, 100);
            this.usr_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usr_pic.TabIndex = 3;
            this.usr_pic.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.90909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.09091F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_role, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txt_email, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_email, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.fname_txt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_fname, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_lname, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lname_txt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.usr_txt, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_pwd, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pwd_txt, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_lnd, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.mob_txt, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbl_mob, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.city_txt, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.usr_addrs, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.role_drop, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 10);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(356, 184);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.42857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 542);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // lbl_role
            // 
            this.lbl_role.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_role.AutoSize = true;
            this.lbl_role.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.ForeColor = System.Drawing.Color.White;
            this.lbl_role.Location = new System.Drawing.Point(3, 421);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(191, 16);
            this.lbl_role.TabIndex = 33;
            this.lbl_role.Text = "Role :";
            this.lbl_role.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_email
            // 
            this.txt_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_email.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.White;
            this.txt_email.Location = new System.Drawing.Point(200, 180);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(225, 27);
            this.txt_email.TabIndex = 5;
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.White;
            this.lbl_email.Location = new System.Drawing.Point(3, 194);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(191, 16);
            this.lbl_email.TabIndex = 31;
            this.lbl_email.Text = "Email ID :";
            this.lbl_email.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fname_txt
            // 
            this.fname_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fname_txt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.fname_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fname_txt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_txt.ForeColor = System.Drawing.Color.White;
            this.fname_txt.Location = new System.Drawing.Point(200, 14);
            this.fname_txt.Name = "fname_txt";
            this.fname_txt.Size = new System.Drawing.Size(225, 27);
            this.fname_txt.TabIndex = 1;
            // 
            // lbl_fname
            // 
            this.lbl_fname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fname.ForeColor = System.Drawing.Color.White;
            this.lbl_fname.Location = new System.Drawing.Point(3, 28);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(191, 16);
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
            this.lbl_lname.Location = new System.Drawing.Point(3, 72);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(191, 16);
            this.lbl_lname.TabIndex = 15;
            this.lbl_lname.Text = "Last Name :";
            this.lbl_lname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lname_txt
            // 
            this.lname_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lname_txt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lname_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lname_txt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_txt.ForeColor = System.Drawing.Color.White;
            this.lname_txt.Location = new System.Drawing.Point(200, 58);
            this.lname_txt.Name = "lname_txt";
            this.lname_txt.Size = new System.Drawing.Size(225, 27);
            this.lname_txt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "User Name :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // usr_txt
            // 
            this.usr_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.usr_txt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.usr_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usr_txt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usr_txt.ForeColor = System.Drawing.Color.White;
            this.usr_txt.Location = new System.Drawing.Point(200, 99);
            this.usr_txt.Name = "usr_txt";
            this.usr_txt.ReadOnly = true;
            this.usr_txt.Size = new System.Drawing.Size(225, 27);
            this.usr_txt.TabIndex = 3;
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pwd.ForeColor = System.Drawing.Color.White;
            this.lbl_pwd.Location = new System.Drawing.Point(3, 153);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(191, 16);
            this.lbl_pwd.TabIndex = 19;
            this.lbl_pwd.Text = "Password :";
            this.lbl_pwd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pwd_txt
            // 
            this.pwd_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pwd_txt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pwd_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pwd_txt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd_txt.ForeColor = System.Drawing.Color.White;
            this.pwd_txt.Location = new System.Drawing.Point(200, 139);
            this.pwd_txt.Name = "pwd_txt";
            this.pwd_txt.PasswordChar = '*';
            this.pwd_txt.Size = new System.Drawing.Size(225, 27);
            this.pwd_txt.TabIndex = 4;
            // 
            // lbl_lnd
            // 
            this.lbl_lnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_lnd.AutoSize = true;
            this.lbl_lnd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lnd.ForeColor = System.Drawing.Color.White;
            this.lbl_lnd.Location = new System.Drawing.Point(3, 374);
            this.lbl_lnd.Name = "lbl_lnd";
            this.lbl_lnd.Size = new System.Drawing.Size(191, 16);
            this.lbl_lnd.TabIndex = 27;
            this.lbl_lnd.Text = "Landline No. :";
            this.lbl_lnd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.std_txt);
            this.panel1.Controls.Add(this.phn_txt);
            this.panel1.Location = new System.Drawing.Point(200, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 39);
            this.panel1.TabIndex = 30;
            // 
            // std_txt
            // 
            this.std_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.std_txt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.std_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.std_txt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_txt.ForeColor = System.Drawing.Color.White;
            this.std_txt.Location = new System.Drawing.Point(3, 9);
            this.std_txt.Name = "std_txt";
            this.std_txt.Size = new System.Drawing.Size(71, 27);
            this.std_txt.TabIndex = 9;
            this.std_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phn_txt
            // 
            this.phn_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phn_txt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.phn_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phn_txt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phn_txt.ForeColor = System.Drawing.Color.White;
            this.phn_txt.Location = new System.Drawing.Point(80, 9);
            this.phn_txt.Name = "phn_txt";
            this.phn_txt.Size = new System.Drawing.Size(142, 27);
            this.phn_txt.TabIndex = 10;
            this.phn_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mob_txt
            // 
            this.mob_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mob_txt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.mob_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mob_txt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mob_txt.ForeColor = System.Drawing.Color.White;
            this.mob_txt.Location = new System.Drawing.Point(200, 315);
            this.mob_txt.Name = "mob_txt";
            this.mob_txt.Size = new System.Drawing.Size(225, 27);
            this.mob_txt.TabIndex = 8;
            // 
            // lbl_mob
            // 
            this.lbl_mob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_mob.AutoSize = true;
            this.lbl_mob.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mob.ForeColor = System.Drawing.Color.White;
            this.lbl_mob.Location = new System.Drawing.Point(3, 329);
            this.lbl_mob.Name = "lbl_mob";
            this.lbl_mob.Size = new System.Drawing.Size(191, 16);
            this.lbl_mob.TabIndex = 25;
            this.lbl_mob.Text = "Mobile :";
            this.lbl_mob.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "City :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // city_txt
            // 
            this.city_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.city_txt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.city_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.city_txt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_txt.ForeColor = System.Drawing.Color.White;
            this.city_txt.Location = new System.Drawing.Point(200, 277);
            this.city_txt.Name = "city_txt";
            this.city_txt.Size = new System.Drawing.Size(225, 27);
            this.city_txt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Address :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // usr_addrs
            // 
            this.usr_addrs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.usr_addrs.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.usr_addrs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usr_addrs.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usr_addrs.ForeColor = System.Drawing.Color.White;
            this.usr_addrs.Location = new System.Drawing.Point(200, 217);
            this.usr_addrs.Multiline = true;
            this.usr_addrs.Name = "usr_addrs";
            this.usr_addrs.Size = new System.Drawing.Size(225, 48);
            this.usr_addrs.TabIndex = 6;
            // 
            // role_drop
            // 
            this.role_drop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.role_drop.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.role_drop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.role_drop.Font = new System.Drawing.Font("Tahoma", 12F);
            this.role_drop.ForeColor = System.Drawing.Color.White;
            this.role_drop.FormattingEnabled = true;
            this.role_drop.Location = new System.Drawing.Point(200, 407);
            this.role_drop.Name = "role_drop";
            this.role_drop.Size = new System.Drawing.Size(225, 27);
            this.role_drop.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_cancel);
            this.panel2.Controls.Add(this.update_btn);
            this.panel2.Location = new System.Drawing.Point(200, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 87);
            this.panel2.TabIndex = 36;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.btn_cancel.BackgroundImage = global::IMS.Properties.Resources.Cancel;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(98, 24);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(53, 49);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // update_btn
            // 
            this.update_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.update_btn.BackgroundImage = global::IMS.Properties.Resources.save;
            this.update_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_btn.FlatAppearance.BorderSize = 0;
            this.update_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.update_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Location = new System.Drawing.Point(30, 24);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(53, 49);
            this.update_btn.TabIndex = 12;
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Edituser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1196, 737);
            this.Controls.Add(this.usr_pnl);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Edituser";
            this.Text = "Edit User";
            this.Load += new System.EventHandler(this.Edituser_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Edituser_KeyDown);
            this.usr_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usr_pic)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel usr_pnl;
        private System.Windows.Forms.PictureBox usr_pic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox fname_txt;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.TextBox lname_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usr_txt;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.TextBox pwd_txt;
        private System.Windows.Forms.Label lbl_lnd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox std_txt;
        private System.Windows.Forms.TextBox phn_txt;
        private System.Windows.Forms.TextBox mob_txt;
        private System.Windows.Forms.Label lbl_mob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox city_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usr_addrs;
        private System.Windows.Forms.ComboBox role_drop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.ErrorProvider error;
    }
}