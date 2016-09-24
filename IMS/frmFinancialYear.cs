using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMIT_FUNCTIONS;
using System.Data.SqlClient;

namespace IMS
{
    public partial class frmFinancialYear : Form
    {
        public frmFinancialYear()
        {
            InitializeComponent();
        }

        private void frmFinancialYear_Load(object sender, EventArgs e)
        {
            try
            {
                impfunc.FILL_COMBO(impfunc.cnn, cboFinancialYear, "FINANCIALYEAR_VIEW", "FYEAR", "FYEARID");
            }
            catch (Exception ex)
            {
            }

            DateTime dt = DateTime.Now;
            string f;
            if ((DateTime.Now.Date > DateTime.Parse(("31/Mar/" + DateTime.Now.Year))))
            {
                f = (DateTime.Now.Year + ("-"
                            + (DateTime.Now.Year + 1)));
            }
            else
            {
                f = ((DateTime.Now.Year - 1) + ("-" + DateTime.Now.Year));
            }

            cboFinancialYear.SelectedIndex = cboFinancialYear.FindStringExact(f);
            cboFinancialYear_SelectionChangeCommitted(e, e);
        }

        private void cboFinancialYear_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                impfunc._FYEARFROMDATE = DateTime.Parse(impfunc.GET_ONEFIELD(impfunc.cnn, "FINANCIALYEAR", "BookStartDate", ("FYEARID="
                                    + (cboFinancialYear.SelectedValue + ""))));
                impfunc._FYEARTODATE = DateTime.Parse(impfunc.GET_ONEFIELD(impfunc.cnn, "FINANCIALYEAR", "BookEndDate", ("FYEARID="
                                    + (cboFinancialYear.SelectedValue + ""))));
            }
            catch (Exception ex)
            {
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            impfunc._FYEARID = Convert.ToInt32(cboFinancialYear.SelectedValue);
            impfunc._FYEAR = cboFinancialYear.Text;
            frmMain frm = new frmMain();
            frm.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmFinancialYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                impfunc.NEXTTAB(this, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
    }
}
