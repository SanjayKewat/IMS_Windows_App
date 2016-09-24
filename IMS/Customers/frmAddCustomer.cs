using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AMIT_FUNCTIONS;

namespace IMS.Customers
{
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }
      //  IMPFunctions impfunc = new IMPFunctions();
     //   SqlConnection con = new SqlConnection(DBconnection.cnString);
        int LedgerID;

        public void clear_control()
        {
            txtCustId.Text = ""; txtFName.Text = ""; txtLName.Text = ""; txtAddress.Text = ""; txtCity.Text = ""; txtState.Text = "";
            txtMobileNo.Text = ""; txtStdCode.Text = ""; txtLandlineNo.Text = ""; 
            txtCUSTTYPEFNAME.Text = ""; txtCUSTTYPELNAME.Text = ""; txtCUSTTYPEMOBILE.Text = ""; txtDiscPlyWood.Text = ""; txtDiscHardware.Text = ""; txtEmailId.Text = "";
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            impfunc.Remove_Child(this);
        }

        private void frmAddCustomer_KeyDown(object sender, KeyEventArgs e)
        {
       
            if (e.KeyCode == Keys.Enter)
            {
                impfunc.NEXTTAB(this, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                impfunc.Remove_Child(this);
            }
        //ElseIf e.KeyCode = Keys.F3 Then
        //    If btnAdd.Enabled = True Then btnAdd_Click(e, e)
        //ElseIf e.KeyCode = Keys.F8 Then
        //    If btnAdd.Enabled = True Then btnAdd_Click(e, e)
        //ElseIf e.KeyCode = Keys.F4 Then
        //    If btnEdit.Enabled = True Then btnEdit_Click(e, e)
        //ElseIf e.KeyCode = Keys.F6 Then
        //    If btnEdit.Enabled = True Then btnEdit_Click(e, e)
        //ElseIf e.KeyCode = Keys.F7 Then
        //    If btnDelete.Enabled = True Then btnDelete_Click(e, e)
        //ElseIf e.KeyCode = Keys.F5 Then
        //    btnReset_Click(e, e)
        //ElseIf e.KeyCode = Keys.Escape Then

        //    btnClose_Click(e, e)
        //ElseIf e.KeyCode = Keys.F2 Then
        //    'txtSearch.Focus()
        //ElseIf e.KeyCode = Keys.F11 Then
        //    chkHideLedger.Checked = True
        //    btnEdit_Click(e, e)
        //    btnEdit_Click(e, e)
        //ElseIf e.KeyCode = Keys.F9 Then
        //    btnLedgerSubGroup_Click(e, e)
        //End If
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtCustId.Text.Length == 0)
            {
                errorMessage.SetError(txtCustId, "Customer Id cannot be blank..!");
                return;
            }
            if (txtFName.Text.Length == 0)
            {
                errorMessage.SetError(txtFName, "FirstName cannot be blank..!");
                return;
            }
            if (txtLName.Text.Length == 0)
            {
                errorMessage.SetError(txtLName, "Last Name cannot be blank..!");
                return;
            }
            if (txtCity.Text.Length == 0)
            {
                errorMessage.SetError(txtCity, "City cannot be blank..!");
                return;
            }

            if (txtState.Text.Length == 0)
            {
                errorMessage.SetError(txtState, "City cannot be blank..!");
                return;
            }

            if (drpdnType.SelectedIndex == 0)
            {
                errorMessage.SetError(drpdnType, "Please select Reference Type..!");
                return;
            }

            if (txtMobileNo.Text == "")
            {
                txtMobileNo.Text = "0";
            }
            if (txtStdCode.Text == "")
            {
                txtStdCode.Text = "0";
            }
            if (txtLandlineNo.Text == "")
            {
                txtLandlineNo.Text = "0";
            }
           
            if (txtCUSTTYPEMOBILE.Text == "")
            {
                txtCUSTTYPEMOBILE.Text = "0";
            }
            if (txtDiscPlyWood.Text == "")
            {
                txtDiscPlyWood.Text = "0";
            }
            if (txtDiscHardware.Text == "")
            {
                txtDiscPlyWood.Text = "0";
            }

            string name = txtFName.Text + " " +txtLName.Text;
            if (impfunc.EXISTS_RECORD(impfunc.cnn, "Ledger", "NAME", "NAME='" + name + "' and ADDRESS1 ='" + txtAddress.Text + "' and MOBILE ='" + txtMobileNo.Text + "' and COMPANYID=" + impfunc._COMPANYID + "", true) == true)
            {
                txtFName.Focus();
                return;
            }
            LedgerID = impfunc.GENERATE_MAX(impfunc.cnn, "LEDGER", "LEDGERID", "LEDGERID>299");
            if (LedgerID == 1)
            {
                LedgerID = 300;
            }

            try
            {
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = impfunc.cnn;
                impfunc.cnn.Open();
                impfunc._TR = impfunc.cnn.BeginTransaction(IsolationLevel.ReadCommitted);
                impfunc._Command.Transaction = impfunc._TR; 
                impfunc.SAVE_RECORDS(impfunc.cnn, "LEDGER", impfunc._TR, "LEDGERID", "CompanyId", "LEDGERSUBGROUPID", "NAME", "OPENINGBALANCEDR",
                   "OPENINGBALANCECR", "ADDRESS1", "ADDRESS2", "PARTY_DL_NO", "PHONE2", "MOBILE", "FAX", "CITY", "STATE",
                   "COUNTRY", "TINNO", "STNO", "CSTNO", "CONT_PERSON", "DESIG", "EditAllowed", "PANNO", "LEDGERCODE",
                   LedgerID.ToString(), impfunc._COMPANYID.ToString(), "2",
                   name, "0", "0", txtAddress.Text, txtAddress.Text,
                  "", "phn_txt.Text", txtMobileNo.Text, "",txtCity.Text,
                  txtState.Text, "India", "", "", "",
                  "", "", "Y", "", "0");
                impfunc.SAVE_RECORDS(impfunc.cnn, "CUSTOMER", impfunc._TR, "CUSTOMERID", "FIRST_NAME", "LAST_NAME", "ADDRESS", "CITY", "STATE", "MOBILE", "STD_CODE", "LAND_LINE_NO", "DISCOUNT_PLYWOOD", "DISCOUNT_HARDWARE", "EMAIL_ID", "LedgerId", txtCustId.Text, txtFName.Text, txtLName.Text, txtAddress.Text, txtCity.Text, txtState.Text, txtMobileNo.Text, txtStdCode.Text, txtLandlineNo.Text, txtDiscPlyWood.Text, txtDiscHardware.Text, txtEmailId.Text, LedgerID.ToString());
                int custid=   Convert.ToInt32(impfunc.GET_ID_AFTER_SAVE(impfunc.cnn, "CUSTOMER", impfunc._TR));
                if (impfunc.EXISTS_RECORD(impfunc.cnn, impfunc._TR, "CUSTOMER_REF_MASTER", "REFFULLNAME", "REFFNAME='" + txtCUSTTYPEFNAME.Text + "' and REFLNAME ='" + txtCUSTTYPELNAME.Text + "' and REFMOBILE ='" + txtCUSTTYPEMOBILE.Text + "'", true) == true)
                {
                    impfunc.UPDATE_RECORDS(impfunc.cnn, "CUSTOMER_REF_MASTER", impfunc._TR, "SET REFPOINT=REFPOINT+1 WHERE REFFNAME='" + txtCUSTTYPEFNAME.Text + "' and REFLNAME ='" + txtCUSTTYPELNAME.Text + "' and REFMOBILE ='" + txtCUSTTYPEMOBILE.Text + "'");
                }
                else
                {
                    impfunc.SAVE_RECORDS(impfunc.cnn, "CUSTOMER_REF_MASTER", impfunc._TR, "REFFNAME", "REFLNAME", "REFMOBILE", "CUSTID", "CUSTOMER_TYPE_ID", txtCUSTTYPEFNAME.Text, txtCUSTTYPELNAME.Text, txtCUSTTYPEMOBILE.Text, custid.ToString(), drpdnType.SelectedValue.ToString());
                }
                //if ((EXIST_COUNT < 1))
                //{
                //    impfunc.SAVE_RECORDS(impfunc.cnn, "ITEM_STOCK", impfunc._TR, "ITEMID", "PURCHASEPRICE", "SALEPRICE", "VATPER", "STOCKIN", "CURRENTSTOCK", "COMPANYID", DR["ITEMID"].ToString(), DR["PURCHASEPRICE"].ToString(), DR["SALEPRICE"].ToString(), DR["VATPER"].ToString(), DR["QTY"].ToString(), DR["QTY"].ToString(), impfunc._COMPANYID.ToString());
                //}
                //else
                //{
                //    impfunc.UPDATE_RECORDS(impfunc.cnn, "ITEM_STOCK", impfunc._TR, ("SET STOCKIN=STOCKIN+"
                //                    + (DR["QTY"].ToString() + (",CURRENTSTOCK=CURRENTSTOCK+"
                //                    + (DR["QTY"].ToString() + (",SALEPRICE="
                //                    + (DR["SALEPRICE"].ToString() + (",PURCHASEPRICE="
                //                    + (DR["PURCHASEPRICE"].ToString() + (" WHERE ITEMID="
                //                    + (DR["ITEMID"].ToString())))))))))));
                //}
                
              
                DateTime dt;
                if ((DateTime.Now.Month == 1) || (DateTime.Now.Month == 2) || (DateTime.Now.Month == 3))
                {
                    dt = DateTime.Parse(("1/Apr/" + (DateTime.Now.Year - 1)));
                } 
                else
                {
                    dt = DateTime.Parse(("1/Apr/" + DateTime.Now.Year));
                }

                impfunc.SAVE_IN_JOURNAL(impfunc.cnn, impfunc._TR, Convert.ToInt32(impfunc._COMPANYID), Convert.ToInt32(LedgerID), 0, dt.ToString("dd-MMM-yyyy"), 0, "Opening_Balance", "Opening_Balance", "Opening_Balance", "0", "0", 0, 0, Convert.ToInt32(impfunc._FYEARID), 0, "1/1/1990");
                impfunc._TR.Commit();
                impfunc.cnn.Close();

           
                MessageBox.Show("Data Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                impfunc.cnn.Close();
                MessageBox.Show(("ERROR: " + (ex.Message + ("\r\n" + "PLEASE CONTACT Mr. Amit Tiwari"))));
            }
            finally 
            {

                clear_control();

                impfunc.cnn.Close();
            }
          
        
        }

        private void txtDiscPlyWood_KeyPress(object sender, KeyPressEventArgs e)
        {
            impfunc.CHECK_NUMERIC_WITH_DOT(txtDiscPlyWood, e);
        }

        private void txtDiscHardware_KeyPress(object sender, KeyPressEventArgs e)
        {
            impfunc.CHECK_NUMERIC_WITH_DOT(txtDiscHardware, e);
        }

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            impfunc.CHECK_NUMERIC_VALUE(txtMobileNo, e);
        }

        private void txtStdCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            impfunc.CHECK_NUMERIC_VALUE(txtMobileNo, e);
        }

        private void txtLandlineNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            impfunc.CHECK_NUMERIC_VALUE(txtMobileNo, e);
        }

        private void txtCustMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            impfunc.CHECK_NUMERIC_VALUE(txtMobileNo, e);
        }

        private void txtArchMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            impfunc.CHECK_NUMERIC_VALUE(txtMobileNo, e);
        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
         //   int a=impfunc.
            fill_combo();
            clear_control();
       txtCustId.Text= Convert.ToString(GENERATE_MAX(impfunc.cnn, "CUSTOMER", "CUSTID")+1000);
       txtCustId.Focus();
           
        }

        public int GENERATE_MAX(SqlConnection Con, string Table, string Field)
        {
            int num = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(("select ISNULL(MAX(" + Field + "),0)+1 from " + Table), impfunc.cnn);
                impfunc.cnn.Open();
                num = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception exception)
            {
                throw exception;
            }

            impfunc.cnn.Close();
            return num;
        }
public void fill_combo(){

   impfunc._DTABLE = new DataTable();
   impfunc._Adapter = new SqlDataAdapter("SELECT * FROM CUSTOMER_TYPE_MASTER", impfunc.cnn);
   impfunc._Adapter.Fill(impfunc._DTABLE);
    DataRow row = impfunc._DTABLE.NewRow();
    row["CUSTOMER_TYPE"] = "<--SELECT TYPE-->";
    impfunc._DTABLE.Rows.InsertAt(row, 0);
    drpdnType.DataSource = impfunc._DTABLE;

    drpdnType.DisplayMember = "CUSTOMER_TYPE";
    drpdnType.ValueMember = "CUSTOMER_TYPE_ID";
}

private void drpdnType_SelectedIndexChanged(object sender, EventArgs e)
{
    grpAcrhitect.Text = drpdnType.Text;
}

private void drpdnType_SelectionChangeCommitted(object sender, EventArgs e)
{

}
        }
    }

