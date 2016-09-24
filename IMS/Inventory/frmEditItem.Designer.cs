namespace IMS.Inventory
{
    partial class frmEditItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditItem));
            this.pnlMain = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.txtdisc = new System.Windows.Forms.TextBox();
            this.lblDiscPer = new System.Windows.Forms.Label();
            this.txtVatPer = new System.Windows.Forms.TextBox();
            this.lblVat = new System.Windows.Forms.Label();
            this.txtSale = new System.Windows.Forms.TextBox();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.txtOpgQty = new System.Windows.Forms.TextBox();
            this.lblOpgqty = new System.Windows.Forms.Label();
            this.txtPurchase = new System.Windows.Forms.TextBox();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.drpdnssubcat = new System.Windows.Forms.ComboBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemcode = new System.Windows.Forms.TextBox();
            this.lblssubcat = new System.Windows.Forms.Label();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.drpdnsubcat = new System.Windows.Forms.ComboBox();
            this.lblSubCategory = new System.Windows.Forms.Label();
            this.drpdnCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pnlCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSubMain3 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlHead.SuspendLayout();
            this.pnlSubMain3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSize = true;
            this.pnlMain.Controls.Add(this.pnlHead);
            this.pnlMain.Controls.Add(this.pnlCategory);
            this.pnlMain.Controls.Add(this.pnlSubMain3);
            this.pnlMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlMain.Location = new System.Drawing.Point(11, 13);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(833, 622);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlHead
            // 
            this.pnlHead.Controls.Add(this.txtdisc);
            this.pnlHead.Controls.Add(this.lblDiscPer);
            this.pnlHead.Controls.Add(this.txtVatPer);
            this.pnlHead.Controls.Add(this.lblVat);
            this.pnlHead.Controls.Add(this.txtSale);
            this.pnlHead.Controls.Add(this.lblSalePrice);
            this.pnlHead.Controls.Add(this.txtOpgQty);
            this.pnlHead.Controls.Add(this.lblOpgqty);
            this.pnlHead.Controls.Add(this.txtPurchase);
            this.pnlHead.Controls.Add(this.lblPurchasePrice);
            this.pnlHead.Controls.Add(this.txtItemName);
            this.pnlHead.Controls.Add(this.drpdnssubcat);
            this.pnlHead.Controls.Add(this.lblItemName);
            this.pnlHead.Controls.Add(this.txtItemcode);
            this.pnlHead.Controls.Add(this.lblssubcat);
            this.pnlHead.Controls.Add(this.lblItemCode);
            this.pnlHead.Controls.Add(this.drpdnsubcat);
            this.pnlHead.Controls.Add(this.lblSubCategory);
            this.pnlHead.Controls.Add(this.drpdnCategory);
            this.pnlHead.Controls.Add(this.lblCategory);
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(827, 128);
            this.pnlHead.TabIndex = 1;
            // 
            // txtdisc
            // 
            this.txtdisc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtdisc.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtdisc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdisc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdisc.ForeColor = System.Drawing.Color.White;
            this.txtdisc.Location = new System.Drawing.Point(751, 90);
            this.txtdisc.Name = "txtdisc";
            this.txtdisc.Size = new System.Drawing.Size(71, 27);
            this.txtdisc.TabIndex = 46;
            this.txtdisc.Text = "0";
            // 
            // lblDiscPer
            // 
            this.lblDiscPer.AutoSize = true;
            this.lblDiscPer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscPer.ForeColor = System.Drawing.Color.White;
            this.lblDiscPer.Location = new System.Drawing.Point(682, 95);
            this.lblDiscPer.Name = "lblDiscPer";
            this.lblDiscPer.Size = new System.Drawing.Size(63, 16);
            this.lblDiscPer.TabIndex = 51;
            this.lblDiscPer.Text = "Disc Per :";
            this.lblDiscPer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtVatPer
            // 
            this.txtVatPer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVatPer.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtVatPer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVatPer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVatPer.ForeColor = System.Drawing.Color.White;
            this.txtVatPer.Location = new System.Drawing.Point(605, 90);
            this.txtVatPer.Name = "txtVatPer";
            this.txtVatPer.Size = new System.Drawing.Size(71, 27);
            this.txtVatPer.TabIndex = 45;
            this.txtVatPer.Text = "0";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.ForeColor = System.Drawing.Color.White;
            this.lblVat.Location = new System.Drawing.Point(550, 95);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(59, 16);
            this.lblVat.TabIndex = 50;
            this.lblVat.Text = "Vat Per :";
            this.lblVat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSale
            // 
            this.txtSale.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSale.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSale.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSale.ForeColor = System.Drawing.Color.White;
            this.txtSale.Location = new System.Drawing.Point(277, 90);
            this.txtSale.Name = "txtSale";
            this.txtSale.Size = new System.Drawing.Size(123, 27);
            this.txtSale.TabIndex = 43;
            this.txtSale.Text = "0";
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalePrice.ForeColor = System.Drawing.Color.White;
            this.lblSalePrice.Location = new System.Drawing.Point(199, 95);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(74, 16);
            this.lblSalePrice.TabIndex = 48;
            this.lblSalePrice.Text = "Sale Price :";
            this.lblSalePrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtOpgQty
            // 
            this.txtOpgQty.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtOpgQty.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtOpgQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpgQty.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpgQty.ForeColor = System.Drawing.Color.White;
            this.txtOpgQty.Location = new System.Drawing.Point(470, 90);
            this.txtOpgQty.Name = "txtOpgQty";
            this.txtOpgQty.Size = new System.Drawing.Size(74, 27);
            this.txtOpgQty.TabIndex = 44;
            this.txtOpgQty.Text = "0";
            // 
            // lblOpgqty
            // 
            this.lblOpgqty.AutoSize = true;
            this.lblOpgqty.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpgqty.ForeColor = System.Drawing.Color.White;
            this.lblOpgqty.Location = new System.Drawing.Point(403, 95);
            this.lblOpgqty.Name = "lblOpgqty";
            this.lblOpgqty.Size = new System.Drawing.Size(63, 16);
            this.lblOpgqty.TabIndex = 49;
            this.lblOpgqty.Text = "Opg Qty :";
            this.lblOpgqty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPurchase
            // 
            this.txtPurchase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPurchase.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPurchase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPurchase.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchase.ForeColor = System.Drawing.Color.White;
            this.txtPurchase.Location = new System.Drawing.Point(95, 90);
            this.txtPurchase.Name = "txtPurchase";
            this.txtPurchase.Size = new System.Drawing.Size(98, 27);
            this.txtPurchase.TabIndex = 42;
            this.txtPurchase.Text = "0";
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchasePrice.ForeColor = System.Drawing.Color.White;
            this.lblPurchasePrice.Location = new System.Drawing.Point(4, 95);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(94, 16);
            this.lblPurchasePrice.TabIndex = 47;
            this.lblPurchasePrice.Text = "Purcase Price :";
            this.lblPurchasePrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtItemName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.ForeColor = System.Drawing.Color.White;
            this.txtItemName.Location = new System.Drawing.Point(366, 10);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(456, 27);
            this.txtItemName.TabIndex = 27;
            // 
            // drpdnssubcat
            // 
            this.drpdnssubcat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.drpdnssubcat.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.drpdnssubcat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpdnssubcat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drpdnssubcat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpdnssubcat.ForeColor = System.Drawing.Color.White;
            this.drpdnssubcat.FormattingEnabled = true;
            this.drpdnssubcat.Location = new System.Drawing.Point(646, 50);
            this.drpdnssubcat.Name = "drpdnssubcat";
            this.drpdnssubcat.Size = new System.Drawing.Size(176, 27);
            this.drpdnssubcat.TabIndex = 33;
            this.drpdnssubcat.Visible = false;
            this.drpdnssubcat.SelectionChangeCommitted += new System.EventHandler(this.drpdnssubcat_SelectionChangeCommitted);
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.White;
            this.lblItemName.Location = new System.Drawing.Point(278, 17);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(80, 16);
            this.lblItemName.TabIndex = 26;
            this.lblItemName.Text = "Item Name :";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtItemcode
            // 
            this.txtItemcode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtItemcode.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtItemcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemcode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemcode.ForeColor = System.Drawing.Color.White;
            this.txtItemcode.Location = new System.Drawing.Point(83, 9);
            this.txtItemcode.Name = "txtItemcode";
            this.txtItemcode.Size = new System.Drawing.Size(183, 27);
            this.txtItemcode.TabIndex = 20;
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
            // lblItemCode
            // 
            this.lblItemCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            // drpdnsubcat
            // 
            this.drpdnsubcat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.drpdnsubcat.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.drpdnsubcat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpdnsubcat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drpdnsubcat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpdnsubcat.ForeColor = System.Drawing.Color.White;
            this.drpdnsubcat.FormattingEnabled = true;
            this.drpdnsubcat.Location = new System.Drawing.Point(366, 50);
            this.drpdnsubcat.Name = "drpdnsubcat";
            this.drpdnsubcat.Size = new System.Drawing.Size(172, 27);
            this.drpdnsubcat.TabIndex = 31;
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
            // drpdnCategory
            // 
            this.drpdnCategory.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.drpdnCategory.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.drpdnCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpdnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drpdnCategory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpdnCategory.ForeColor = System.Drawing.Color.White;
            this.drpdnCategory.FormattingEnabled = true;
            this.drpdnCategory.Location = new System.Drawing.Point(82, 51);
            this.drpdnCategory.Name = "drpdnCategory";
            this.drpdnCategory.Size = new System.Drawing.Size(184, 27);
            this.drpdnCategory.TabIndex = 28;
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
            this.pnlCategory.Location = new System.Drawing.Point(3, 131);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(0, 0);
            this.pnlCategory.TabIndex = 0;
            // 
            // pnlSubMain3
            // 
            this.pnlSubMain3.Controls.Add(this.btnSave);
            this.pnlSubMain3.Controls.Add(this.btnExit);
            this.pnlSubMain3.Location = new System.Drawing.Point(3, 137);
            this.pnlSubMain3.Name = "pnlSubMain3";
            this.pnlSubMain3.Size = new System.Drawing.Size(824, 67);
            this.pnlSubMain3.TabIndex = 4;
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
            this.btnSave.TabIndex = 24;
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
            this.btnExit.Location = new System.Drawing.Point(389, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 49);
            this.btnExit.TabIndex = 24;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmEditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(854, 648);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(870, 700);
            this.MinimizeBox = false;
            this.Name = "frmEditItem";
            this.Text = "frmEditItem";
            this.Load += new System.EventHandler(this.frmEditItem_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEditItem_KeyDown);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            this.pnlSubMain3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlMain;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.ComboBox drpdnssubcat;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemcode;
        private System.Windows.Forms.Label lblssubcat;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.ComboBox drpdnsubcat;
        private System.Windows.Forms.Label lblSubCategory;
        private System.Windows.Forms.ComboBox drpdnCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.FlowLayoutPanel pnlCategory;
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
        private System.Windows.Forms.TextBox txtPurchase;
        private System.Windows.Forms.Label lblPurchasePrice;
    }
}