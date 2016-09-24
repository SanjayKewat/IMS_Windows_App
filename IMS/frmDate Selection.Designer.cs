namespace IMS
{
    partial class frmDate_Selection
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
            this.grpcontainer = new System.Windows.Forms.GroupBox();
            this.dtptodate = new System.Windows.Forms.DateTimePicker();
            this.dtpfromdate = new System.Windows.Forms.DateTimePicker();
            this.lbltodate = new System.Windows.Forms.Label();
            this.lblfromdate = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cboSupplier = new System.Windows.Forms.ComboBox();
            this.btnview = new System.Windows.Forms.Button();
            this.cr = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.grpcontainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpcontainer
            // 
            this.grpcontainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpcontainer.Controls.Add(this.dtptodate);
            this.grpcontainer.Controls.Add(this.btnview);
            this.grpcontainer.Controls.Add(this.dtpfromdate);
            this.grpcontainer.Controls.Add(this.lbltodate);
            this.grpcontainer.Controls.Add(this.lblfromdate);
            this.grpcontainer.Controls.Add(this.lblSupplier);
            this.grpcontainer.Controls.Add(this.cboSupplier);
            this.grpcontainer.Location = new System.Drawing.Point(4, 49);
            this.grpcontainer.Name = "grpcontainer";
            this.grpcontainer.Size = new System.Drawing.Size(1005, 44);
            this.grpcontainer.TabIndex = 1;
            this.grpcontainer.TabStop = false;
            // 
            // dtptodate
            // 
            this.dtptodate.CustomFormat = "dd-MMM-yyyy";
            this.dtptodate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtptodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtptodate.Location = new System.Drawing.Point(250, 17);
            this.dtptodate.Name = "dtptodate";
            this.dtptodate.Size = new System.Drawing.Size(130, 21);
            this.dtptodate.TabIndex = 2;
            this.dtptodate.Value = new System.DateTime(2011, 7, 9, 0, 0, 0, 0);
            // 
            // dtpfromdate
            // 
            this.dtpfromdate.CustomFormat = "dd-MMM-yyyy";
            this.dtpfromdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfromdate.Location = new System.Drawing.Point(76, 17);
            this.dtpfromdate.Name = "dtpfromdate";
            this.dtpfromdate.Size = new System.Drawing.Size(114, 21);
            this.dtpfromdate.TabIndex = 1;
            this.dtpfromdate.Value = new System.DateTime(2011, 7, 9, 0, 0, 0, 0);
            // 
            // lbltodate
            // 
            this.lbltodate.AutoSize = true;
            this.lbltodate.BackColor = System.Drawing.Color.Transparent;
            this.lbltodate.ForeColor = System.Drawing.Color.White;
            this.lbltodate.Location = new System.Drawing.Point(197, 20);
            this.lbltodate.Name = "lbltodate";
            this.lbltodate.Size = new System.Drawing.Size(46, 13);
            this.lbltodate.TabIndex = 1;
            this.lbltodate.Text = "To Date";
            // 
            // lblfromdate
            // 
            this.lblfromdate.AutoSize = true;
            this.lblfromdate.BackColor = System.Drawing.Color.Transparent;
            this.lblfromdate.ForeColor = System.Drawing.Color.White;
            this.lblfromdate.Location = new System.Drawing.Point(14, 21);
            this.lblfromdate.Name = "lblfromdate";
            this.lblfromdate.Size = new System.Drawing.Size(56, 13);
            this.lblfromdate.TabIndex = 1;
            this.lblfromdate.Text = "From Date";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.BackColor = System.Drawing.Color.Transparent;
            this.lblSupplier.ForeColor = System.Drawing.Color.White;
            this.lblSupplier.Location = new System.Drawing.Point(406, 21);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(45, 13);
            this.lblSupplier.TabIndex = 1;
            this.lblSupplier.Text = "Supplier";
            // 
            // cboSupplier
            // 
            this.cboSupplier.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSupplier.FormattingEnabled = true;
            this.cboSupplier.Location = new System.Drawing.Point(465, 17);
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.Size = new System.Drawing.Size(342, 21);
            this.cboSupplier.TabIndex = 3;
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.Gray;
            this.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnview.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnview.Location = new System.Drawing.Point(836, 15);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(86, 23);
            this.btnview.TabIndex = 4;
            this.btnview.Tag = "";
            this.btnview.Text = "View (F10)";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // cr
            // 
            this.cr.ActiveViewIndex = -1;
            this.cr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cr.Cursor = System.Windows.Forms.Cursors.Default;
            this.cr.Location = new System.Drawing.Point(-3, 93);
            this.cr.Name = "cr";
            this.cr.ShowCloseButton = false;
            this.cr.ShowCopyButton = false;
            this.cr.ShowGotoPageButton = false;
            this.cr.ShowGroupTreeButton = false;
            this.cr.ShowLogo = false;
            this.cr.ShowParameterPanelButton = false;
            this.cr.ShowZoomButton = false;
            this.cr.Size = new System.Drawing.Size(1012, 750);
            this.cr.TabIndex = 2;
            this.cr.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmDate_Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1012, 845);
            this.Controls.Add(this.cr);
            this.Controls.Add(this.grpcontainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmDate_Selection";
            this.Text = "View Account";
            this.Load += new System.EventHandler(this.frmDate_Selection_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDate_Selection_KeyDown);
            this.grpcontainer.ResumeLayout(false);
            this.grpcontainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grpcontainer;
        internal System.Windows.Forms.DateTimePicker dtptodate;
        internal System.Windows.Forms.Button btnview;
        internal System.Windows.Forms.DateTimePicker dtpfromdate;
        internal System.Windows.Forms.Label lbltodate;
        internal System.Windows.Forms.Label lblfromdate;
        internal System.Windows.Forms.Label lblSupplier;
        internal System.Windows.Forms.ComboBox cboSupplier;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer cr;
    }
}