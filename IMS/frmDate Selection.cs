using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMS.Account;
using AMIT_FUNCTIONS;

namespace IMS
{
    public partial class frmDate_Selection : Form
    {
        public frmDate_Selection()
        {
            InitializeComponent();
        }
        ReportFunc rptfunc = new ReportFunc();
        void FILL_SUPPLIER()
        {
            try
            {
                impfunc.FILL_COMBO_DISTINCT(impfunc.cnn, cboSupplier, "LEDGER", "NAME", "LEDGERId", ("COMPANYID="
                                + (impfunc._COMPANYID + " AND LEDGERSUBGROUPID=14")));
            }
            catch (Exception ex)
            {
            }

        }
        void FILL_CUSTOMER()
        {
            try
            {
                impfunc.FILL_COMBO_DISTINCT(impfunc.cnn, cboSupplier, "LEDGER", "NAME", "LEDGERId", ("COMPANYID="
                                + (impfunc._COMPANYID + " AND LEDGERSUBGROUPID=2")));
            }
            catch (Exception ex)
            {
            }

        }

        private void frmDate_Selection_Load(object sender, EventArgs e)
        {
            dtpfromdate.Value = DateTime.Now;
            dtptodate.Value = DateTime.Now;

            //frm.Location = new System.Drawing.Point(((this.Parent.Width - this.Width)
            //                / 2), this.Height);
            //grpcontainer.Location = new System.Drawing.Point(((this.Parent.Width - grpcontainer.Width)
            //                / 2), -4);
            if ( frmAccount.rpttag== "SUPPLIER ACCOUNT")
            {
                FILL_SUPPLIER();
                lblSupplier.Text = "Supplier";
            }
            else if (frmAccount.rpttag == "CUSTOMER ACCOUNT")
            {
                FILL_CUSTOMER();
                lblSupplier.Text = "Customer";
            }


            dtpfromdate.Focus();
        }

        private void frmDate_Selection_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                impfunc.NEXTTAB(this, e);
            }
            else if ((e.KeyCode == Keys.F10))
            {
               btnview_Click(e, e);
            }
            else if ((e.KeyCode == Keys.Escape))
            {
                impfunc.Remove_Child(this);
            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            if (dtpfromdate.Value > dtptodate.Value)
            {
                MessageBox.Show("From date must be greater than to date !!");
                dtpfromdate.Focus();
                return;
            }
           
                rptfunc.ViewReport(cr, "LedgerStatement.rpt", "", "CompanyId", "LedgerID", "OpeningBalance", "FromDate", "TillDate", impfunc._COMPANYID.ToString(), cboSupplier.SelectedValue.ToString(), "0", dtpfromdate.Value.Date.ToString("dd/MMM/yyyy"), dtptodate.Value.Date.ToString("dd/MMM/yyyy"), 0, this);
      

        }
    }
}
