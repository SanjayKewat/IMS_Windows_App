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
    public partial class frmEditCustomer : Form
    {
        public frmEditCustomer()
        {
            InitializeComponent();
        }
      //  IMPFunctions impfunc = new IMPFunctions();
        
        DataTable dt; 
        public void clear_control()
        {
            txtCustId.Text = ""; txtFName.Text = ""; txtLName.Text = ""; txtAddress.Text = ""; txtCity.Text = ""; txtState.Text = "";
            txtMobileNo.Text = ""; txtStdCode.Text = ""; txtLandlineNo.Text = ""; txtCUSTTYPEFNAME.Text = ""; txtCUSTTYPELNAME.Text = ""; txtCUSTTYPEMOBILE.Text = "";
        txtDiscPlyWood.Text = ""; txtDiscHardware.Text = ""; txtEmailId.Text = "";
        }

        public void fill_combo()
        {
            
            dt = new DataTable();
              impfunc._Adapter = new SqlDataAdapter("SELECT * FROM CUSTOMER_TYPE_MASTER",   impfunc.cnn);
              impfunc._Adapter.Fill(dt);
            DataRow row = dt.NewRow();
            row["CUSTOMER_TYPE"] = "<--SELECT TYPE-->";
            dt.Rows.InsertAt(row, 0);
            drpdnType.DataSource = dt;

            drpdnType.DisplayMember = "CUSTOMER_TYPE";
            drpdnType.ValueMember = "CUSTOMER_TYPE_ID";
        }
        public void fill_form()
        {
         
            try
            {
                SqlCommand cmd = new SqlCommand("select * from CUSTOMER_DETAILS where custid=" + Convert.ToInt32(this.Tag), impfunc.cnn);
                  impfunc.cnn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        txtCustId.Text = rdr["CUSTOMERID"].ToString();
                        txtFName.Text = rdr["FIRST_NAME"].ToString();
                        txtLName.Text = rdr["LAST_NAME"].ToString();
                        txtAddress.Text = rdr["ADDRESS"].ToString();
                        txtCity.Text = rdr["CITY"].ToString();
                        txtState.Text = rdr["STATE"].ToString();
                        txtMobileNo.Text = rdr["MOBILE"].ToString();
                        txtStdCode.Text = rdr["STD_CODE"].ToString();
                        txtLandlineNo.Text = rdr["LAND_LINE_NO"].ToString();
                        txtCUSTTYPEFNAME.Text = rdr["REFFNAME"].ToString();
                        txtCUSTTYPELNAME.Text = rdr["REFLNAME"].ToString();
                        txtCUSTTYPEMOBILE.Text = rdr["REFMOBILE"].ToString();
                        drpdnType.SelectedValue = rdr["CUSTOMER_TYPE_ID"].ToString();
                        txtDiscPlyWood.Text = rdr["DISCOUNT_PLYWOOD"].ToString();
                        txtDiscHardware.Text = rdr["DISCOUNT_HARDWARE"].ToString();
                        txtEmailId.Text = rdr["EMAIL_ID"].ToString();
                    }
                }
                rdr.Close();
               
            }
            catch (Exception exception)
            {
                throw exception;
            }

              impfunc.cnn.Close();
          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditCustomer_KeyDown(object sender, KeyEventArgs e)
        {
       
            if (e.KeyCode == Keys.Enter)
            {
                impfunc.NEXTTAB(this, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnExit_Click(sender, e);
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
                errorMessage.SetError(drpdnType, "Please select Type..!");
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
            try
            {

                SqlCommand cmd = new SqlCommand("update  CUSTOMER set CUSTOMERID='" + txtCustId.Text + "',FIRST_NAME='" + txtFName.Text + "',LAST_NAME='" + txtLName.Text + "',ADDRESS='" + txtAddress.Text + "',CITY='" + txtCity.Text + "',STATE='" + txtState.Text + "',MOBILE='" + txtMobileNo.Text + "',STD_CODE='" + txtStdCode.Text + "',LAND_LINE_NO='" + txtLandlineNo.Text + "',CUST_TYPE_FNAME='" + txtCUSTTYPEFNAME.Text + "',CUST_TYPE_LNAME='" + txtCUSTTYPELNAME.Text + "',CUST_TYPE_MOBILE='" + txtCUSTTYPEMOBILE.Text + "',DISCOUNT_PLYWOOD='" + txtDiscPlyWood.Text + "',DISCOUNT_HARDWARE='" + txtDiscHardware.Text + "',EMAIL_ID='" + txtEmailId.Text + "',CUSTOMER_TYPE_ID='" + drpdnType.SelectedValue + "' where CUSTID=" + Convert.ToInt32(this.Tag),   impfunc.cnn);
         
              impfunc.cnn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                  impfunc.cnn.Close();
                MessageBox.Show(("ERROR: " + (ex.Message + ("\r\n" + "PLEASE CONTACT Mr. Amit Tiwari"))));
            }
            finally 
            {
                MessageBox.Show("Customer" + " " + txtFName.Text + " " + txtLName.Text + " updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void frmEditCustomer_Load(object sender, EventArgs e)
        {
         //   int a=impfunc.
            fill_combo();
            fill_form();
          
       txtCustId.Focus();
           
        }

        public int GENERATE_MAX(SqlConnection   Con, string Table, string Field)
        {
            int num = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(("select ISNULL(MAX(" + Field + "),0)+1 from " + Table), Con);
                Con.Open();
                num = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception exception)
            {
                throw exception;
            }

            Con.Close();
            return num;
        }

       
    
        }
    }

