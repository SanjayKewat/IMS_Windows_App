namespace IMS.Category
{
    partial class frmEditCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditCategory));
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.txtCATCODE = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lbl_Customer = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSubMain1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSubMain3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnAddSUBCategory = new System.Windows.Forms.Button();
            this.btnDeleteSubCAt = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlSubMain3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.ForeColor = System.Drawing.Color.White;
            this.lblCategoryName.Location = new System.Drawing.Point(79, 85);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(105, 16);
            this.lblCategoryName.TabIndex = 17;
            this.lblCategoryName.Text = "Category Name :";
            this.lblCategoryName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCATCODE
            // 
            this.txtCATCODE.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCATCODE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCATCODE.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCATCODE.ForeColor = System.Drawing.Color.White;
            this.txtCATCODE.Location = new System.Drawing.Point(193, 47);
            this.txtCATCODE.Name = "txtCATCODE";
            this.txtCATCODE.Size = new System.Drawing.Size(388, 27);
            this.txtCATCODE.TabIndex = 16;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoryName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.ForeColor = System.Drawing.Color.White;
            this.txtCategoryName.Location = new System.Drawing.Point(193, 80);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(388, 27);
            this.txtCategoryName.TabIndex = 18;
            // 
            // lbl_Customer
            // 
            this.lbl_Customer.AutoSize = true;
            this.lbl_Customer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer.ForeColor = System.Drawing.Color.White;
            this.lbl_Customer.Location = new System.Drawing.Point(42, 56);
            this.lbl_Customer.Name = "lbl_Customer";
            this.lbl_Customer.Size = new System.Drawing.Size(142, 16);
            this.lbl_Customer.TabIndex = 15;
            this.lbl_Customer.Text = "Category Code Initials :";
            this.lbl_Customer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSize = true;
            this.pnlMain.Controls.Add(this.pnlSubMain1);
            this.pnlMain.Controls.Add(this.pnlSubMain3);
            this.pnlMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlMain.Location = new System.Drawing.Point(2, 130);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(782, 202);
            this.pnlMain.TabIndex = 20;
            this.pnlMain.WrapContents = false;
            // 
            // pnlSubMain1
            // 
            this.pnlSubMain1.AutoSize = true;
            this.pnlSubMain1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlSubMain1.Location = new System.Drawing.Point(3, 3);
            this.pnlSubMain1.Name = "pnlSubMain1";
            this.pnlSubMain1.Size = new System.Drawing.Size(0, 0);
            this.pnlSubMain1.TabIndex = 0;
            // 
            // pnlSubMain3
            // 
            this.pnlSubMain3.Controls.Add(this.btnExit);
            this.pnlSubMain3.Controls.Add(this.btnLogin);
            this.pnlSubMain3.Location = new System.Drawing.Point(3, 9);
            this.pnlSubMain3.Name = "pnlSubMain3";
            this.pnlSubMain3.Size = new System.Drawing.Size(776, 67);
            this.pnlSubMain3.TabIndex = 2;
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
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.btnLogin.BackgroundImage = global::IMS.Properties.Resources.save;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(330, 9);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(53, 49);
            this.btnLogin.TabIndex = 23;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnAddSUBCategory
            // 
            this.btnAddSUBCategory.BackgroundImage = global::IMS.Properties.Resources.Add;
            this.btnAddSUBCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSUBCategory.FlatAppearance.BorderSize = 0;
            this.btnAddSUBCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddSUBCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddSUBCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSUBCategory.Location = new System.Drawing.Point(616, 77);
            this.btnAddSUBCategory.Name = "btnAddSUBCategory";
            this.btnAddSUBCategory.Size = new System.Drawing.Size(43, 37);
            this.btnAddSUBCategory.TabIndex = 19;
            this.btnAddSUBCategory.UseVisualStyleBackColor = true;
            this.btnAddSUBCategory.Click += new System.EventHandler(this.btnAddSUBCategory_Click);
            // 
            // btnDeleteSubCAt
            // 
            this.btnDeleteSubCAt.BackgroundImage = global::IMS.Properties.Resources.Minus;
            this.btnDeleteSubCAt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteSubCAt.FlatAppearance.BorderSize = 0;
            this.btnDeleteSubCAt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteSubCAt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteSubCAt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSubCAt.Location = new System.Drawing.Point(665, 77);
            this.btnDeleteSubCAt.Name = "btnDeleteSubCAt";
            this.btnDeleteSubCAt.Size = new System.Drawing.Size(43, 37);
            this.btnDeleteSubCAt.TabIndex = 30;
            this.btnDeleteSubCAt.UseVisualStyleBackColor = true;
            this.btnDeleteSubCAt.Click += new System.EventHandler(this.btnDeleteSubCAt_Click);
            // 
            // frmEditCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(787, 462);
            this.Controls.Add(this.btnDeleteSubCAt);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.btnAddSUBCategory);
            this.Controls.Add(this.txtCATCODE);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.lbl_Customer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(803, 800);
            this.MinimizeBox = false;
            this.Name = "frmEditCategory";
            this.Text = "Edit Category";
            this.Load += new System.EventHandler(this.frmEditCategory_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlSubMain3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Button btnAddSUBCategory;
        private System.Windows.Forms.TextBox txtCATCODE;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lbl_Customer;
        private System.Windows.Forms.FlowLayoutPanel pnlMain;
        private System.Windows.Forms.FlowLayoutPanel pnlSubMain1;
        private System.Windows.Forms.Panel pnlSubMain3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnDeleteSubCAt;


    }
}