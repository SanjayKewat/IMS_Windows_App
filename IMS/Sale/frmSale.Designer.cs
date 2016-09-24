namespace IMS.Sale
{
    partial class frmSale
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
            this.lblLogo = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.logo_ims = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlPaymentRec = new System.Windows.Forms.Panel();
            this.lblPaymentRec = new System.Windows.Forms.Label();
            this.picPaymentRec = new System.Windows.Forms.PictureBox();
            this.pnlGoodReturn = new System.Windows.Forms.Panel();
            this.lblGoodReturns = new System.Windows.Forms.Label();
            this.picGoodReturn = new System.Windows.Forms.PictureBox();
            this.pnlFinalOrder = new System.Windows.Forms.Panel();
            this.lblFinalOrder = new System.Windows.Forms.Label();
            this.picFinalOrder = new System.Windows.Forms.PictureBox();
            this.pnlGenOrder = new System.Windows.Forms.Panel();
            this.lbl_GenOrder = new System.Windows.Forms.Label();
            this.picGenOrder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo_ims)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlPaymentRec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPaymentRec)).BeginInit();
            this.pnlGoodReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGoodReturn)).BeginInit();
            this.pnlFinalOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFinalOrder)).BeginInit();
            this.pnlGenOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGenOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(27, 118);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(48, 13);
            this.lblLogo.TabIndex = 45;
            this.lblLogo.Text = "SB Sons";
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
            this.back_btn.TabIndex = 44;
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
            this.logo_ims.TabIndex = 43;
            this.logo_ims.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.Controls.Add(this.pnlPaymentRec);
            this.pnlMain.Controls.Add(this.pnlGoodReturn);
            this.pnlMain.Controls.Add(this.pnlFinalOrder);
            this.pnlMain.Controls.Add(this.pnlGenOrder);
            this.pnlMain.Location = new System.Drawing.Point(373, 190);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(550, 397);
            this.pnlMain.TabIndex = 46;
            // 
            // pnlPaymentRec
            // 
            this.pnlPaymentRec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPaymentRec.Controls.Add(this.lblPaymentRec);
            this.pnlPaymentRec.Controls.Add(this.picPaymentRec);
            this.pnlPaymentRec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlPaymentRec.Location = new System.Drawing.Point(339, 213);
            this.pnlPaymentRec.Name = "pnlPaymentRec";
            this.pnlPaymentRec.Size = new System.Drawing.Size(150, 144);
            this.pnlPaymentRec.TabIndex = 12;
            this.pnlPaymentRec.Click += new System.EventHandler(this.pnlPaymentRec_Click);
            this.pnlPaymentRec.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPaymentRec_Paint);
            this.pnlPaymentRec.MouseEnter += new System.EventHandler(this.pnlPaymentRec_MouseEnter);
            this.pnlPaymentRec.MouseLeave += new System.EventHandler(this.pnlPaymentRec_MouseLeave);
            // 
            // lblPaymentRec
            // 
            this.lblPaymentRec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPaymentRec.AutoSize = true;
            this.lblPaymentRec.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentRec.ForeColor = System.Drawing.Color.White;
            this.lblPaymentRec.Location = new System.Drawing.Point(26, 122);
            this.lblPaymentRec.Name = "lblPaymentRec";
            this.lblPaymentRec.Size = new System.Drawing.Size(112, 16);
            this.lblPaymentRec.TabIndex = 6;
            this.lblPaymentRec.Text = "Payment Received";
            this.lblPaymentRec.Click += new System.EventHandler(this.lblPaymentRec_Click);
            this.lblPaymentRec.MouseEnter += new System.EventHandler(this.lblPaymentRec_MouseEnter);
            this.lblPaymentRec.MouseLeave += new System.EventHandler(this.lblPaymentRec_MouseLeave);
            // 
            // picPaymentRec
            // 
            this.picPaymentRec.BackColor = System.Drawing.Color.Transparent;
            this.picPaymentRec.Image = global::IMS.Properties.Resources.Sale;
            this.picPaymentRec.Location = new System.Drawing.Point(16, 19);
            this.picPaymentRec.Name = "picPaymentRec";
            this.picPaymentRec.Size = new System.Drawing.Size(119, 100);
            this.picPaymentRec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPaymentRec.TabIndex = 5;
            this.picPaymentRec.TabStop = false;
            this.picPaymentRec.Click += new System.EventHandler(this.picPaymentRec_Click);
            this.picPaymentRec.MouseEnter += new System.EventHandler(this.picPaymentRec_MouseEnter);
            this.picPaymentRec.MouseLeave += new System.EventHandler(this.picPaymentRec_MouseLeave);
            // 
            // pnlGoodReturn
            // 
            this.pnlGoodReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGoodReturn.Controls.Add(this.lblGoodReturns);
            this.pnlGoodReturn.Controls.Add(this.picGoodReturn);
            this.pnlGoodReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlGoodReturn.Location = new System.Drawing.Point(63, 213);
            this.pnlGoodReturn.Name = "pnlGoodReturn";
            this.pnlGoodReturn.Size = new System.Drawing.Size(150, 144);
            this.pnlGoodReturn.TabIndex = 12;
            this.pnlGoodReturn.Click += new System.EventHandler(this.pnlGoodReturn_Click);
            this.pnlGoodReturn.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGoodReturn_Paint);
            this.pnlGoodReturn.MouseEnter += new System.EventHandler(this.pnlGoodReturn_MouseEnter);
            this.pnlGoodReturn.MouseLeave += new System.EventHandler(this.pnlGoodReturn_MouseLeave);
            // 
            // lblGoodReturns
            // 
            this.lblGoodReturns.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGoodReturns.AutoSize = true;
            this.lblGoodReturns.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodReturns.ForeColor = System.Drawing.Color.White;
            this.lblGoodReturns.Location = new System.Drawing.Point(26, 122);
            this.lblGoodReturns.Name = "lblGoodReturns";
            this.lblGoodReturns.Size = new System.Drawing.Size(85, 16);
            this.lblGoodReturns.TabIndex = 6;
            this.lblGoodReturns.Text = "Good Returns";
            this.lblGoodReturns.Click += new System.EventHandler(this.lblGoodReturns_Click);
            this.lblGoodReturns.MouseEnter += new System.EventHandler(this.lblGoodReturns_MouseEnter);
            this.lblGoodReturns.MouseLeave += new System.EventHandler(this.lblGoodReturns_MouseLeave);
            // 
            // picGoodReturn
            // 
            this.picGoodReturn.BackColor = System.Drawing.Color.Transparent;
            this.picGoodReturn.Image = global::IMS.Properties.Resources.Sale;
            this.picGoodReturn.Location = new System.Drawing.Point(16, 19);
            this.picGoodReturn.Name = "picGoodReturn";
            this.picGoodReturn.Size = new System.Drawing.Size(119, 100);
            this.picGoodReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGoodReturn.TabIndex = 5;
            this.picGoodReturn.TabStop = false;
            this.picGoodReturn.Click += new System.EventHandler(this.picGoodReturn_Click);
            this.picGoodReturn.MouseEnter += new System.EventHandler(this.picGoodReturn_MouseEnter);
            this.picGoodReturn.MouseLeave += new System.EventHandler(this.picGoodReturn_MouseLeave);
            // 
            // pnlFinalOrder
            // 
            this.pnlFinalOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFinalOrder.Controls.Add(this.lblFinalOrder);
            this.pnlFinalOrder.Controls.Add(this.picFinalOrder);
            this.pnlFinalOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlFinalOrder.Location = new System.Drawing.Point(339, 37);
            this.pnlFinalOrder.Name = "pnlFinalOrder";
            this.pnlFinalOrder.Size = new System.Drawing.Size(150, 144);
            this.pnlFinalOrder.TabIndex = 12;
            this.pnlFinalOrder.Click += new System.EventHandler(this.pnlFinalOrder_Click);
            this.pnlFinalOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFinalOrder_Paint);
            this.pnlFinalOrder.MouseEnter += new System.EventHandler(this.pnlFinalOrder_MouseEnter);
            this.pnlFinalOrder.MouseLeave += new System.EventHandler(this.pnlFinalOrder_MouseLeave);
            // 
            // lblFinalOrder
            // 
            this.lblFinalOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFinalOrder.AutoSize = true;
            this.lblFinalOrder.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalOrder.ForeColor = System.Drawing.Color.White;
            this.lblFinalOrder.Location = new System.Drawing.Point(44, 122);
            this.lblFinalOrder.Name = "lblFinalOrder";
            this.lblFinalOrder.Size = new System.Drawing.Size(72, 16);
            this.lblFinalOrder.TabIndex = 6;
            this.lblFinalOrder.Text = "Final Order";
            this.lblFinalOrder.Click += new System.EventHandler(this.lblFinalOrder_Click);
            this.lblFinalOrder.MouseEnter += new System.EventHandler(this.lblFinalOrder_MouseEnter);
            this.lblFinalOrder.MouseLeave += new System.EventHandler(this.lblFinalOrder_MouseLeave);
            // 
            // picFinalOrder
            // 
            this.picFinalOrder.BackColor = System.Drawing.Color.Transparent;
            this.picFinalOrder.Image = global::IMS.Properties.Resources.Sale;
            this.picFinalOrder.Location = new System.Drawing.Point(16, 19);
            this.picFinalOrder.Name = "picFinalOrder";
            this.picFinalOrder.Size = new System.Drawing.Size(119, 100);
            this.picFinalOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFinalOrder.TabIndex = 5;
            this.picFinalOrder.TabStop = false;
            this.picFinalOrder.Click += new System.EventHandler(this.picFinalOrder_Click);
            this.picFinalOrder.MouseEnter += new System.EventHandler(this.picFinalOrder_MouseEnter);
            this.picFinalOrder.MouseLeave += new System.EventHandler(this.picFinalOrder_MouseLeave);
            // 
            // pnlGenOrder
            // 
            this.pnlGenOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGenOrder.Controls.Add(this.lbl_GenOrder);
            this.pnlGenOrder.Controls.Add(this.picGenOrder);
            this.pnlGenOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlGenOrder.Location = new System.Drawing.Point(63, 37);
            this.pnlGenOrder.Name = "pnlGenOrder";
            this.pnlGenOrder.Size = new System.Drawing.Size(150, 144);
            this.pnlGenOrder.TabIndex = 11;
            this.pnlGenOrder.Click += new System.EventHandler(this.pnlGenOrder_Click);
            this.pnlGenOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGenOrder_Paint);
            this.pnlGenOrder.MouseEnter += new System.EventHandler(this.pnlGenOrder_MouseEnter);
            this.pnlGenOrder.MouseLeave += new System.EventHandler(this.pnlGenOrder_MouseLeave);
            // 
            // lbl_GenOrder
            // 
            this.lbl_GenOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_GenOrder.AutoSize = true;
            this.lbl_GenOrder.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GenOrder.ForeColor = System.Drawing.Color.White;
            this.lbl_GenOrder.Location = new System.Drawing.Point(26, 122);
            this.lbl_GenOrder.Name = "lbl_GenOrder";
            this.lbl_GenOrder.Size = new System.Drawing.Size(97, 16);
            this.lbl_GenOrder.TabIndex = 6;
            this.lbl_GenOrder.Text = "Generate Order";
            this.lbl_GenOrder.Click += new System.EventHandler(this.lbl_GenOrder_Click);
            this.lbl_GenOrder.MouseEnter += new System.EventHandler(this.lbl_GenOrder_MouseEnter);
            this.lbl_GenOrder.MouseLeave += new System.EventHandler(this.lbl_GenOrder_MouseLeave);
            // 
            // picGenOrder
            // 
            this.picGenOrder.BackColor = System.Drawing.Color.Transparent;
            this.picGenOrder.Image = global::IMS.Properties.Resources.Sale;
            this.picGenOrder.Location = new System.Drawing.Point(16, 19);
            this.picGenOrder.Name = "picGenOrder";
            this.picGenOrder.Size = new System.Drawing.Size(119, 100);
            this.picGenOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGenOrder.TabIndex = 5;
            this.picGenOrder.TabStop = false;
            this.picGenOrder.Click += new System.EventHandler(this.picGenOrder_Click);
            this.picGenOrder.MouseEnter += new System.EventHandler(this.picGenOrder_MouseEnter);
            this.picGenOrder.MouseLeave += new System.EventHandler(this.picGenOrder_MouseLeave);
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1336, 716);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.logo_ims);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmSale";
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.frmSale_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSale_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.logo_ims)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlPaymentRec.ResumeLayout(false);
            this.pnlPaymentRec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPaymentRec)).EndInit();
            this.pnlGoodReturn.ResumeLayout(false);
            this.pnlGoodReturn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGoodReturn)).EndInit();
            this.pnlFinalOrder.ResumeLayout(false);
            this.pnlFinalOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFinalOrder)).EndInit();
            this.pnlGenOrder.ResumeLayout(false);
            this.pnlGenOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGenOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.PictureBox logo_ims;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlPaymentRec;
        private System.Windows.Forms.Label lblPaymentRec;
        private System.Windows.Forms.PictureBox picPaymentRec;
        private System.Windows.Forms.Panel pnlGoodReturn;
        private System.Windows.Forms.Label lblGoodReturns;
        private System.Windows.Forms.PictureBox picGoodReturn;
        private System.Windows.Forms.Panel pnlFinalOrder;
        private System.Windows.Forms.Label lblFinalOrder;
        private System.Windows.Forms.PictureBox picFinalOrder;
        private System.Windows.Forms.Panel pnlGenOrder;
        private System.Windows.Forms.Label lbl_GenOrder;
        private System.Windows.Forms.PictureBox picGenOrder;
    }
}