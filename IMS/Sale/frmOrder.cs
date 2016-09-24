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

namespace IMS.Sale
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        DataTable dtEdit = new DataTable();
        int MASTERID;
        int EXIST_COUNT = 0, COUNTER=0;
      
        DataTable dtSerial = new DataTable();
    SqlDataReader _dr1;
    bool flagDgSerialClick;
        bool flagDgClick;
//===================================================================Functions==============================================================================================================

        void fill_edit()
        {
            try
            {

                impfunc.FILL_RECORD(impfunc.cnn, "ORDERMASTER_VIEW", ("ORDERID=" + MASTERID), "ORDERNO", txtOrderNo, "ORDERDATE", dtpBillDate, "NAME", cboParty,  "TOTALAMOUNT", txtTotalAmount, "TOTALDISCOUNT", txtTotalDiscount, "TOTALVAT", txtTotalVat, "SUBTOTAL", txtSubTotal,  "ROUNDOFF", txtRoundOff, "GRANDTOTAL", txtGrandTotal);
                impfunc._Adapter = new SqlDataAdapter(("SELECT * FROM ORDERSLAVE_VIEW WHERE ORDERID=" + MASTERID), impfunc.cnn);
                dt.Rows.Clear();
                impfunc._Adapter.Fill(dt);



                impfunc._Adapter = new SqlDataAdapter(("SELECT * FROM ORDERSLAVE_VIEW WHERE ORDERID=" + MASTERID), impfunc.cnn);
                dtEdit.Rows.Clear();
                impfunc._Adapter.Fill(dtEdit);
                txtTotalQty.Text = dt.Rows.Count.ToString();
               
            }
            catch (Exception ex)
            {
              
            }
        }
        void FILL_LISTBOX()
        {
            txtRechargeNoSearch.Visible = false;
            CboPartySearch.Visible = false;
            dtpMonthSearch.Visible = false;
            try
            {
                if ((rdoRechargeNo.Checked == true))
                {
                    if ((txtRechargeNoSearch.Text.Trim() == ""))
                    {
                        impfunc.FILL_LISTBOX_DISTINCT(impfunc.cnn, lstBox, "ORDER_MASTER", "ORDERNO", "ORDERID", ("COMPANYID="
                                        + (impfunc._COMPANYID + (" AND FYEARID="
                                        + (impfunc._FYEARID + " AND ORDERSTATUS=0")))));
                    }
                    else
                    {
                        impfunc.FILL_LISTBOX_DISTINCT(impfunc.cnn, lstBox, "ORDER_MASTER", "ORDERNO", "ORDERID", ("COMPANYID="
                                        + (impfunc._COMPANYID + (" AND FYEARID="
                                        + (impfunc._FYEARID + (" AND ORDERSTATUS=0 AND ORDERNO LIKE \'%"
                                        + (txtRechargeNoSearch.Text + "%\'")))))));
                    }

                    txtRechargeNoSearch.Visible = true;
                }
                else if ((rdoDate.Checked == true))
                {
                    impfunc.FILL_LISTBOX_DISTINCT(impfunc.cnn, lstBox, "ORDER_MASTER", "ORDERNO", "ORDERID", ("COMPANYID="
                                    + (impfunc._COMPANYID + (" AND FYEARID="
                                    + (impfunc._FYEARID + (" AND ORDERSTATUS=0 AND MONTH(ORDERDATE)="
                                    + (dtpMonthSearch.Value.Month + (" AND YEAR(ORDERDATE)=" + dtpMonthSearch.Value.Year))))))));
                    dtpMonthSearch.Visible = true;
                }
                else if ((rdoParty.Checked == true))
                {
                    CboPartySearch.Visible = true;
                    if (impfunc.VALIDATION_BLANK(CboPartySearch))
                    {
                        lstBox.Items.Clear();
                        return;
                    }

                    impfunc.FILL_LISTBOX_DISTINCT(impfunc.cnn, lstBox, "ORDER_MASTER", "ORDERNO", "ORDERID", ("COMPANYID="
                                    + (impfunc._COMPANYID + (" AND FYEARID="
                                    + (impfunc._FYEARID + (" AND ORDERSTATUS=0 AND LEDGERID=" + CboPartySearch.SelectedValue))))));
                }

            }
            catch (Exception ex)
            {
                // MsgBox(ex.Message)
            }

        }


        void CALC_TOTAL()
        {
            try
            {
                if ((dt.Rows.Count > 0))
                {
                    txtTotalAmount.Text = dt.Compute("SUM(AMOUNT)", "").ToString();
                    txtTotalDiscount.Text = dt.Compute("SUM(DISCOUNT)", "").ToString();
                    txtTotalVat.Text = dt.Compute("SUM(VATAMOUNT)", "").ToString();
                    txtGrandTotal.Text = dt.Compute("SUM(NETAMOUNT)", "").ToString();
                    txtTotalQty.Text = dt.Rows.Count.ToString();
                }
                else
                {
                    txtTotalAmount.Text = "0";
                    txtTotalDiscount.Text = "0";
                    txtTotalVat.Text = "0";
                    txtTotalQty.Text = "0";
                }
                txtfinalamount.Text = Convert.ToDouble(txtGrandTotal.Text).ToString();
                     
            }
            catch (Exception ex)
            {
            }

        }
        void CLEAR_CONT()
        {
          txtOrderNo.Clear();

            txtSalePrice.Text = "0";
            txtQty.Text = "1";
            txtAmount.Text = "0";
            txtDisPer.Text = "0";
            txtDiscount.Text = "0";
            txtVatPer.Text = "0";
            txtVat.Text = "0";
            txtNetAmount.Text = "0";
         
            txtTotalAmount.Text = "0";
            txtTotalDiscount.Text = "0";
            txtTotalVat.Text = "0";
            txtSubTotal.Text = "0";
        
            txtRoundOff.Text = "0";
            txtGrandTotal.Text = "0";
            txtTotalQty.Text = "0";
            dt.Rows.Clear();
            dtEdit.Rows.Clear();
            MASTERID = 0;
            COUNTER = 0;
            grpSearch.Enabled = true;
            flagDgClick = false;
            flagDgSerialClick = false;
        }
        void FILL_ITEM_DATA()
        {
            try
            {
                int itemid = 0;
                txtSalePrice.Text = "";
                if (cboItem.SelectedValue != null)
                {
                    itemid = Convert.ToInt32(cboItem.SelectedValue);
                }

                impfunc.FILL_RECORD(impfunc.cnn, "ITEM_STOCK", "ITEMID=" + itemid, "CURRENTSTOCK", txtItemStock,  "SALEPRICE", txtSalePrice, "VATPER", txtVatPer, "DISCPER", txtDisPer);

            }
            catch (Exception ex)
            {

            }

        }
        void FILL_SUPPLIER()
        {
            try
            {
                impfunc.FILL_COMBO(impfunc.cnn, cboParty, "LEDGER", "NAME", "LEDGERID", ("COMPANYID="
                                + (impfunc._COMPANYID + " AND LEDGERSUBGROUPID=2")));
                impfunc.FILL_COMBO_DISTINCT(impfunc.cnn, CboPartySearch, "ORDERMASTER_VIEW", "NAME", "LEDGERID", ("COMPANYID="
                                + (impfunc._COMPANYID + "")));
            
            }
            catch (Exception ex)
            {
            }

        }

        private void fill_Cateogry()
        {

            impfunc._DTABLE = new DataTable();
            impfunc._Adapter = new SqlDataAdapter("SELECT CATEGORY_NAME,CATEGORY_ID FROM CATEGORY_MASTER order by CATEGORY_NAME ", impfunc.cnn);
            impfunc._Adapter.Fill(impfunc._DTABLE);

            cboCategory.DataSource = impfunc._DTABLE;

            cboCategory.DisplayMember = "CATEGORY_NAME";
            cboCategory.ValueMember = "CATEGORY_ID";


            impfunc._DTABLE = new DataTable();
            impfunc._Adapter = new SqlDataAdapter("SELECT SUBCATEGORY_VALUE,SUB_CATEGORY_ID FROM SUBCATEGORY_MASTER  where CATEGORY_ID=" + Convert.ToString(cboCategory.SelectedValue) + " order by SUBCATEGORY_VALUE ", impfunc.cnn);
            impfunc._Adapter.Fill(impfunc._DTABLE);
            if (impfunc._DTABLE.Rows.Count > 0)
            {
                //   lblSubCategory.Visible = true;
                cboSubCategory.Visible = true;
                cboSubCategory.DataSource = impfunc._DTABLE;

                cboSubCategory.DisplayMember = "SUBCATEGORY_VALUE";
                cboSubCategory.ValueMember = "SUB_CATEGORY_ID";
            }

            impfunc._DTABLE = new DataTable();
            impfunc._Adapter = new SqlDataAdapter("SELECT SSUBCATEGORY_VALUE,SSUB_CATEGORY_ID FROM SSUBCATEGORY_MASTER  where SUB_CATEGORY_ID=" + Convert.ToString(cboSubCategory.SelectedValue) + " order by SSUBCATEGORY_VALUE", impfunc.cnn);
            impfunc._Adapter.Fill(impfunc._DTABLE);
            if (impfunc._DTABLE.Rows.Count > 0)
            {
                //   lblssubcat.Visible = true;
                cboSSubCategory.Visible = true;
                cboSSubCategory.DataSource = impfunc._DTABLE;

                cboSSubCategory.DisplayMember = "SSUBCATEGORY_VALUE";
                cboSSubCategory.ValueMember = "SSUB_CATEGORY_ID";
            }

        }



        private void frmOrder_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            FILL_LISTBOX();
            FILL_SUPPLIER();
            cboParty_SelectionChangeCommitted(e, e);
            fill_Cateogry();
            cboCategory_SelectionChangeCommitted(e, e);
            impfunc._Adapter = new SqlDataAdapter("SELECT * FROM ORDERSLAVE_VIEW WHERE  ORDERSLAVEID=0", impfunc.cnn);
            impfunc._Adapter.Fill(dt);
            dg.AutoGenerateColumns = false;
            dg.DataSource = dt;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (impfunc.CHECK_IS_NOTHING(cboItem, true))
            {
                return;
            }

            foreach (DataRow dr in dt.Rows)
            {

                if (Convert.ToInt32(dr["ITEMID"]) == Convert.ToInt32(cboItem.SelectedValue))
                {
                    DialogResult dialogResult = MessageBox.Show("This Item is already in the list, Do you want to Overrite !", "Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int i = 0;
                        dt.Rows.Remove(dr);
                        break;
                    }
                    else
                    {
                        return;
                    }


                }

            }

            if (Convert.ToDouble(txtQty.Text) < 1)
            {
                MessageBox.Show("Please fill Qty!!", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtQty.Focus();
                return;
            }

            if (Convert.ToDouble(txtSalePrice.Text) < 0)
            {
                MessageBox.Show("Please fill Sale Price!!", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSalePrice.Focus();
                return;
            }
            int subcatid = 0;
            int ssubcatid = 0;
            if (cboSubCategory.SelectedValue != null)
            {
                subcatid = Convert.ToInt32(cboSubCategory.SelectedValue);
            }

            if (cboSSubCategory.SelectedValue != null)
            {
                ssubcatid = Convert.ToInt32(cboSSubCategory.SelectedValue);
            }
            DataRow DR = dt.NewRow();

            DR["ITEM_NAME"] = cboItem.Text;

            DR["SALEPRICE"] = Convert.ToDouble(txtSalePrice.Text);
            DR["QTY"] = Convert.ToDouble(txtQty.Text);
            DR["AMOUNT"] = Convert.ToDouble(txtAmount.Text);
            DR["DISCOUNTPER"] = Convert.ToDouble(txtDisPer.Text);
            DR["DISCOUNT"] = Convert.ToDouble(txtDiscount.Text);
            DR["VATPER"] = Convert.ToDouble(txtVatPer.Text);
            DR["VATAMOUNT"] = Convert.ToDouble(txtVat.Text);
            DR["NETAMOUNT"] = Convert.ToDouble(txtNetAmount.Text);
            DR["BRANDID"] = ssubcatid;
            DR["CATEGORY_ID"] = cboCategory.SelectedValue;
            DR["SUBCATEGORY_ID"] = subcatid;
            DR["ITEMID"] = cboItem.SelectedValue;

            dt.Rows.Add(DR);
            CALC_TOTAL();
            txtQty.Text = "1";
            DialogResult dialogResult1 = MessageBox.Show("DO YOU WANT TO CONTINUEE.......??", "Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult1 == DialogResult.Yes)
            {
                cboCategory.Focus();
            }
            else
            {
                btnAdd.Focus();
            }
        }
        private void cboParty_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ((cboParty.SelectedValue == null))
            {
                return;
            }
            else
            {
                try
                { 
                    double DR = double.Parse(impfunc.GET_ONEFIELD(impfunc.cnn, "JOURNAL", "SUM(DR)", ("LEDGERID=" + cboParty.SelectedValue)));
                    double CR = double.Parse(impfunc.GET_ONEFIELD(impfunc.cnn, "JOURNAL", "SUM(CR)", ("LEDGERID=" + cboParty.SelectedValue)));
                    if ((DR >= CR))
                    {
                        txtLedgerBalance.Text = (Math.Round((DR - CR), 2).ToString() + " DR");
                    }
                    else
                    {
                        txtLedgerBalance.Text = (Math.Round((CR - DR), 2).ToString() + " CR");
                    }
                    impfunc.FILL_RECORD(impfunc.cnn, "LEDGER", "LEDGERID=" + cboParty.SelectedValue, "NAME", txtParty, "MOBILE", txtMobileNo, "ADDRESS1", txtAddress);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(("Following error Occured :: " + ex.Message),Messa MsgBoxStyle.Critical, "Infotech Consultants");
                    //MsgBox(("Following error Occured :: " + ex.Message), MsgBoxStyle.Critical, "Infotech Consultants");
                }

            }
        }

        private void cboCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cboSubCategory.DataSource = null;
            //  lblSubCategory.Visible = false;
            cboSubCategory.Enabled = false;
            impfunc._DTABLE = new DataTable();
            impfunc._Adapter = new SqlDataAdapter("SELECT SUBCATEGORY_VALUE,SUB_CATEGORY_ID FROM SUBCATEGORY_MASTER  where CATEGORY_ID=" + Convert.ToString(cboCategory.SelectedValue) + " order by SUBCATEGORY_VALUE ", impfunc.cnn);
            impfunc._Adapter.Fill(impfunc._DTABLE);
            if (impfunc._DTABLE.Rows.Count > 0)
            {
                //  lblSubCategory.Visible = true;
                cboSubCategory.Enabled = true;
                cboSubCategory.DataSource = impfunc._DTABLE;

                cboSubCategory.DisplayMember = "SUBCATEGORY_VALUE";
                cboSubCategory.ValueMember = "SUB_CATEGORY_ID";
            }
            cboSubCategory_SelectionChangeCommitted(e, e);
        }

        private void cboSubCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int subcatid = 0;
            if (cboSubCategory.SelectedValue != null)
            {
                subcatid = Convert.ToInt32(cboSubCategory.SelectedValue);
            }

            //   lblssubcat.Visible = false;
            cboSSubCategory.Enabled = false;
            cboSSubCategory.DataSource = null;

            impfunc._DTABLE = new DataTable();
            impfunc._Adapter = new SqlDataAdapter("SELECT SSUBCATEGORY_VALUE,SSUB_CATEGORY_ID FROM SSUBCATEGORY_MASTER  where SUB_CATEGORY_ID=" + Convert.ToString(subcatid) + " order by SSUBCATEGORY_VALUE", impfunc.cnn);
            impfunc._Adapter.Fill(impfunc._DTABLE);
            if (impfunc._DTABLE.Rows.Count > 0)
            {
                // lblssubcat.Visible = true;
                cboSSubCategory.Enabled = true;
                cboSSubCategory.DataSource = impfunc._DTABLE;

                cboSSubCategory.DisplayMember = "SSUBCATEGORY_VALUE";
                cboSSubCategory.ValueMember = "SSUB_CATEGORY_ID";
            }
            cboSSubCategory_SelectionChangeCommitted(e, e);
        }

        private void cboSSubCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int catid = 0; int subcatid = 0; int ssubcatid = 0;
            if (cboCategory.SelectedValue != null)
            {
                catid = Convert.ToInt32(cboCategory.SelectedValue);
            }
            if (cboSubCategory.SelectedValue != null)
            {
                subcatid = Convert.ToInt32(cboSubCategory.SelectedValue);
            }
            if (cboSSubCategory.SelectedValue != null)
            {
                ssubcatid = Convert.ToInt32(cboSSubCategory.SelectedValue);
            }
            cboItem.Enabled = false;
            cboItem.DataSource = null;

            impfunc._DTABLE = new DataTable();
            impfunc._Adapter = new SqlDataAdapter("SELECT ITEM_NAME,ITEM_ID FROM ITEM_MASTER  where CATEGORY_ID=" + Convert.ToString(catid) + "and SUBCATEGORY_ID=" + Convert.ToString(subcatid) + " and SSUBCATEGORY_ID=" + Convert.ToString(ssubcatid) + "  order by ITEM_NAME", impfunc.cnn);
            impfunc._Adapter.Fill(impfunc._DTABLE);
            if (impfunc._DTABLE.Rows.Count > 0)
            {
                // lblssubcat.Visible = true;
                cboItem.Enabled = true;
                cboItem.DataSource = impfunc._DTABLE;

                cboItem.DisplayMember = "ITEM_NAME";
                cboItem.ValueMember = "ITEM_ID";
            }
            cboItem_SelectionChangeCommitted(e, e);
        }

        private void cboItem_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FILL_ITEM_DATA();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((btnAdd.Text == "Add(F3)"))
            {
             impfunc.ADD_EDIT_FUNCTION("ADD", btnAdd, btnEdit, btnDelete, grpMaster, grpAmount, grpItem);
             CLEAR_CONT();
                grpSearch.Enabled = false;
                txtOrderNo.Text = impfunc.GENERATE_MAX(impfunc.cnn, "ORDER_MASTER", "ORDERNO").ToString();
                FILL_ITEM_DATA();

                txtOrderNo.Focus();
            }
            else
            {
                if ((impfunc.VALIDATION_BLANK(txtOrderNo) == true))
                {
                    return;
                }

                if ((impfunc.VALIDATION_BLANK(cboParty) == true))
                {
                    return;
                }

                if ((dt.Rows.Count < 1))
                {
                    MessageBox.Show("There should be atleast one item to Order !! ?", "Info", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    cboCategory.Focus();
                    return;
                }

                if ((impfunc.EXISTS_RECORD(impfunc.cnn, "ORDER_MASTER", "ORDERNO", ("ORDERNO="
                                + (txtOrderNo.Text.Trim() + "")), false) == true))
                {
                    txtOrderNo.Text = impfunc.GENERATE_MAX(impfunc.cnn, "ORDER_MASTER", "ORDERNO").ToString();
                }

                try
                {
                    txtRoundOff.Text = Math.Round((Math.Round(double.Parse(txtfinalamount.Text)) - double.Parse(txtfinalamount.Text)), 2).ToString();
                    impfunc._Command = new SqlCommand();
                    impfunc._Command.Connection = impfunc.cnn;
                    impfunc.OPENCONNECTION();
                    impfunc._TR = impfunc.cnn.BeginTransaction(IsolationLevel.ReadCommitted);
                    impfunc._Command.Transaction = impfunc._TR;
                    impfunc.SAVE_RECORDS(impfunc.cnn, "ORDER_MASTER", impfunc._TR, "ORDERNO", "ORDERDATE", "LEDGERID", "FYEARID", "TOTALAMOUNT", "TOTALDISCOUNT", "TOTALVAT", "SUBTOTAL", "ROUNDOFF", "GRANDTOTAL", "COMPANYID", "CUSTNAME", "CUSTCONTACT", "CUSTADRESS", txtOrderNo.Text, dtpBillDate.Value.Date.ToString("dd/MMM/yyyy"), cboParty.SelectedValue.ToString(), impfunc._FYEARID.ToString(), txtTotalAmount.Text, txtTotalDiscount.Text, txtTotalVat.Text, txtSubTotal.Text, txtRoundOff.Text, txtGrandTotal.Text, impfunc._COMPANYID.ToString(),txtParty.Text,txtMobileNo.Text,txtAddress.Text);
                    MASTERID = Convert.ToInt32(impfunc.GET_ID_AFTER_SAVE(impfunc.cnn, "ORDER_MASTER", impfunc._TR));
                    foreach (DataRow DR in dt.Rows)
                    {
                        impfunc.SAVE_RECORDS(impfunc.cnn, "ORDERSLAVE", impfunc._TR, "ORDERID", "ITEMID", "BRANDID", "QTY", "SALEPRICE", "AMOUNT", "DISCOUNTPER", "DISCOUNT", "VATPER", "VATAMOUNT", "NETAMOUNT", MASTERID.ToString(), DR["ITEMID"].ToString(), DR["BRANDID"].ToString(), DR["QTY"].ToString(), DR["SALEPRICE"].ToString(), DR["AMOUNT"].ToString(), DR["DISCOUNTPER"].ToString(), DR["DISCOUNT"].ToString(), DR["VATPER"].ToString(), DR["VATAMOUNT"].ToString(), DR["NETAMOUNT"].ToString());
                      
                    }

                    impfunc._TR.Commit();
                    impfunc.CLOSECONNECTION();
                    MessageBox.Show("Data Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //if ((MsgBox(("SAVED SUCCESSFULLY !!" + ("\r\n" + " DO YOU WANT TO VIEW BILL ?")), MsgBoxStyle.YesNo, "Infotech Consultants") == MsgBoxResult.Yes))
                    //{
                    //    frmReportFullPage frm = new frmReportFullPage();
                    //    Check_ChildForm(Mainform);
                    //    Add_ChildAtTab(frm, Mainform);
                    //    ViewReport(frm.cr, "CHALLANBILL.rpt", "", false, frm, ("CHALLANMASTERID=" + MASTERID));
                    //}

                    btnReset_Click(e, e);
                }
                catch (Exception ex)
                {
                    impfunc._TR.Rollback();
                    impfunc.CLOSECONNECTION();
                  
                 //   MsgBox(("Following error Occured :: " + ex.Message), MsgBoxStyle.Critical, "Infotech Consultants");
                }

            }
        }

        private void frmOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                impfunc.NEXTTAB(this, e);
            }
            else if (((e.KeyCode == Keys.F3) || (e.KeyCode == Keys.F8)))
            {
                if ((btnAdd.Enabled == true))
                {
                    btnAdd_Click(e, e);
                }
            }
            else if (((e.KeyCode == Keys.F4) || (e.KeyCode == Keys.F6)))
            {
                if ((btnEdit.Enabled == true))
                {
                    btnEdit_Click(e, e);
                }
            }
            else if ((e.KeyCode == Keys.F7))
            {
                if ((btnDelete.Enabled == true))
                {
                    btnDelete_Click(e, e);
                }
            }
            else if ((e.KeyCode == Keys.F5))
            {
                btnReset_Click(e, e);
            }
            else if ((e.KeyCode == Keys.Escape))
            {
                impfunc.Remove_Child(this);
            }
            else if ((e.KeyCode == Keys.F1))
            {
                btnInsert_Click(null, null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            impfunc.Remove_Child(this);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            impfunc.ADD_EDIT_FUNCTION("RESET", btnAdd, btnEdit, btnDelete, grpMaster, grpItem, grpAmount);
            CLEAR_CONT();
            FILL_SUPPLIER();
            cboParty_SelectionChangeCommitted(e, e);
            fill_Cateogry();
            cboCategory_SelectionChangeCommitted(e, e);

            FILL_LISTBOX();
            btnAdd.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (impfunc.VALIDATION_BLANK(txtOrderNo) == true)
            {
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Sure, You want to delete Record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    EXIST_COUNT = Convert.ToInt32(impfunc.GET_ONEFIELD(impfunc.cnn, "ORDER_MASTER", "COUNT(ORDERID)", ("ORDERID=" + MASTERID)));
                    if ((EXIST_COUNT != 1))
                    {
                        MessageBox.Show("Please Select Proper Invoice !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    //    SHOW_PLEASE_WAIT(true);
                    impfunc._Command = new SqlCommand();
                    impfunc._Command.Connection = impfunc.cnn;
                    impfunc.OPENCONNECTION();
                    impfunc._TR = impfunc.cnn.BeginTransaction(IsolationLevel.ReadCommitted);
                    impfunc._Command.Transaction = impfunc._TR;


                    impfunc.DELETE_RECORDS(impfunc.cnn, "ORDER_MASTER", impfunc._TR, "ORDERID", MASTERID);
                    impfunc.DELETE_RECORDS(impfunc.cnn, "ORDERSLAVE", impfunc._TR, "ORDERID", MASTERID);
                  
                    impfunc._TR.Commit();
                    impfunc.CLOSECONNECTION();
                    // SHOW_PLEASE_WAIT(false);
                    MessageBox.Show("DELETED SUCCESSFULLY !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnReset_Click(e, e);
                }
                catch (Exception ex)
                {
                    impfunc._TR.Rollback();
                    impfunc.CLOSECONNECTION();
                    // SHOW_PLEASE_WAIT(false);
                    MessageBox.Show(("ERROR: " + (ex.Message + ("\r\n" + "PLEASE CONTACT Mr. Amit Tiwari"))));
                }
            }
            else
            {
                btnReset_Click(null, null);
                return;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (impfunc.VALIDATION_BLANK(txtOrderNo) == true)
            {
                return;
            }

            if ((btnEdit.Text == "Edit(F4)"))
            {
                impfunc.ADD_EDIT_FUNCTION("EDIT", btnAdd, btnEdit, btnDelete, grpMaster, grpItem, grpAmount);
                grpSearch.Enabled = false;
                txtOrderNo.Focus();
            }
            else
            {
                if (impfunc.VALIDATION_BLANK(txtOrderNo) == true)
                {
                    return;
                }

                if (impfunc.VALIDATION_BLANK(cboParty) == true)
                {
                    return;
                }

                if ((dt.Rows.Count < 1))
                {
                    // MsgBox("There should be atleast one item to purchase !! ?", MsgBoxStyle.Exclamation, "Infotech Consultants");
                    cboCategory.Focus();
                    return;
                }

                EXIST_COUNT = Convert.ToInt32(impfunc.GET_ONEFIELD(impfunc.cnn, "ORDER_MASTER", "COUNT(ORDERID)", ("ORDERID=" + MASTERID)));
                if ((EXIST_COUNT != 1))
                {
                    //     MsgBox("Please select invoice properly !", MsgBoxStyle.Critical, "Infotech Consultants");
                    return;
                }

                if ((impfunc.EXISTS_RECORD(impfunc.cnn, "ORDER_MASTER", ("COMPANYID="
                                + (impfunc._COMPANYID + " AND ORDERNO")), ("ORDERNO="
                                + (txtOrderNo.Text.Trim() + (" AND ORDERID<>" + MASTERID))), false) == true))
                {
                    txtOrderNo.Focus();
                    return;
                }

                try
                {
                    //    SHOW_PLEASE_WAIT(true);
                    txtRoundOff.Text = Math.Round((Math.Round(Convert.ToDouble(txtfinalamount.Text)) - Convert.ToDouble(txtfinalamount.Text)), 2).ToString();
                    impfunc._Command = new SqlCommand();
                    impfunc._Command.Connection = impfunc.cnn;
                    impfunc.OPENCONNECTION();
                    impfunc._TR = impfunc.cnn.BeginTransaction(IsolationLevel.ReadCommitted);
                    impfunc._Command.Transaction = impfunc._TR;


                    impfunc.UPDATE_RECORDS(impfunc.cnn, "ORDER_MASTER", impfunc._TR, "ORDERNO", "ORDERDATE", "LEDGERID", "FYEARID", "TOTALAMOUNT", "TOTALDISCOUNT", "TOTALVAT", "SUBTOTAL", "ROUNDOFF", "GRANDTOTAL", "COMPANYID", "CUSTNAME", "CUSTCONTACT", "CUSTADRESS", txtOrderNo.Text, dtpBillDate.Value.Date.ToString("dd/MMM/yyyy"), cboParty.SelectedValue.ToString(), impfunc._FYEARID.ToString(), txtTotalAmount.Text, txtTotalDiscount.Text, txtTotalVat.Text, txtSubTotal.Text, txtRoundOff.Text, txtGrandTotal.Text, impfunc._COMPANYID.ToString(), txtParty.Text, txtMobileNo.Text, txtAddress.Text, "ORDERID", MASTERID);

                    impfunc.DELETE_RECORDS(impfunc.cnn, "ORDERSLAVE", impfunc._TR, ("ORDERID=" + MASTERID));

                    foreach (DataRow DR in dt.Rows)
                    {

                        impfunc.SAVE_RECORDS(impfunc.cnn, "ORDERSLAVE", impfunc._TR, "ORDERID", "ITEMID", "BRANDID", "QTY", "SALEPRICE", "AMOUNT", "DISCOUNTPER", "DISCOUNT", "VATPER", "VATAMOUNT", "NETAMOUNT", MASTERID.ToString(), DR["ITEMID"].ToString(), DR["BRANDID"].ToString(), DR["QTY"].ToString(), DR["SALEPRICE"].ToString(), DR["AMOUNT"].ToString(), DR["DISCOUNTPER"].ToString(), DR["DISCOUNT"].ToString(), DR["VATPER"].ToString(), DR["VATAMOUNT"].ToString(), DR["NETAMOUNT"].ToString());
                    }

                
                  
                    impfunc._TR.Commit();
                    impfunc.CLOSECONNECTION();
                    // SHOW_PLEASE_WAIT(false);
                    MessageBox.Show("UPDATED SUCCESSFULLY !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnReset_Click(e, e);
                }
                catch (Exception ex)
                {
                    impfunc._TR.Rollback();
                    impfunc.CLOSECONNECTION();
                    // SHOW_PLEASE_WAIT(false);
                    MessageBox.Show(("ERROR: " + (ex.Message + ("\r\n" + "PLEASE CONTACT Mr. Amit Tiwari"))));
                }

            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            impfunc.Remove_Child(this);
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtAmount.Text = Math.Round((double.Parse(txtQty.Text) * double.Parse(txtSalePrice.Text))).ToString();
                if ((this.ActiveControl.Name == "txtDiscount"))
                {
                    txtDisPer.Text = Math.Round(((double.Parse(txtDiscount.Text) * 100)
                                    / double.Parse(txtAmount.Text)), 2).ToString();
                }
                else
                {
                    txtDiscount.Text = Math.Round((double.Parse(txtDisPer.Text)
                                    * (double.Parse(txtAmount.Text) / 100)), 2).ToString();
                }

                txtVat.Text = Math.Round((double.Parse(txtVatPer.Text)
                                * ((double.Parse(txtAmount.Text) - double.Parse(txtDiscount.Text))
                                / 100)), 2).ToString();
                txtNetAmount.Text = Math.Round(((double.Parse(txtAmount.Text) - double.Parse(txtDiscount.Text))
                                + double.Parse(txtVat.Text)), 2).ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void txtSalePrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtAmount.Text = Math.Round((double.Parse(txtQty.Text) * double.Parse(txtSalePrice.Text))).ToString();
                if ((this.ActiveControl.Name == "txtDiscount"))
                {
                    txtDisPer.Text = Math.Round(((double.Parse(txtDiscount.Text) * 100)
                                    / double.Parse(txtAmount.Text)), 2).ToString();
                }
                else
                {
                    txtDiscount.Text = Math.Round((double.Parse(txtDisPer.Text)
                                    * (double.Parse(txtAmount.Text) / 100)), 2).ToString();
                }

                txtVat.Text = Math.Round((double.Parse(txtVatPer.Text)
                                * ((double.Parse(txtAmount.Text) - double.Parse(txtDiscount.Text))
                                / 100)), 2).ToString();
                txtNetAmount.Text = Math.Round(((double.Parse(txtAmount.Text) - double.Parse(txtDiscount.Text))
                                + double.Parse(txtVat.Text)), 2).ToString();
            }
            catch (Exception ex)
            {
            }

        }

        private void txtDisPer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtAmount.Text = Math.Round((double.Parse(txtQty.Text) * double.Parse(txtSalePrice.Text))).ToString();
                if ((this.ActiveControl.Name == "txtDiscount"))
                {
                    txtDisPer.Text = Math.Round(((double.Parse(txtDiscount.Text) * 100)
                                    / double.Parse(txtAmount.Text)), 2).ToString();
                }
                else
                {
                    txtDiscount.Text = Math.Round((double.Parse(txtDisPer.Text)
                                    * (double.Parse(txtAmount.Text) / 100)), 2).ToString();
                }

                txtVat.Text = Math.Round((double.Parse(txtVatPer.Text)
                                * ((double.Parse(txtAmount.Text) - double.Parse(txtDiscount.Text))
                                / 100)), 2).ToString();
                txtNetAmount.Text = Math.Round(((double.Parse(txtAmount.Text) - double.Parse(txtDiscount.Text))
                                + double.Parse(txtVat.Text)), 2).ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtAmount.Text = Math.Round((double.Parse(txtQty.Text) * double.Parse(txtSalePrice.Text))).ToString();
                if ((this.ActiveControl.Name == "txtDiscount"))
                {
                    txtDisPer.Text = Math.Round(((double.Parse(txtDiscount.Text) * 100)
                                    / double.Parse(txtAmount.Text)), 2).ToString();
                }
                else
                {
                    txtDiscount.Text = Math.Round((double.Parse(txtDisPer.Text)
                                    * (double.Parse(txtAmount.Text) / 100)), 2).ToString();
                }

                txtVat.Text = Math.Round((double.Parse(txtVatPer.Text)
                                * ((double.Parse(txtAmount.Text) - double.Parse(txtDiscount.Text))
                                / 100)), 2).ToString();
                txtNetAmount.Text = Math.Round(((double.Parse(txtAmount.Text) - double.Parse(txtDiscount.Text))
                                + double.Parse(txtVat.Text)), 2).ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void txtVatPer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtAmount.Text = Math.Round((double.Parse(txtQty.Text) * double.Parse(txtSalePrice.Text))).ToString();
                if ((this.ActiveControl.Name == "txtDiscount"))
                {
                    txtDisPer.Text = Math.Round(((double.Parse(txtDiscount.Text) * 100)
                                    / double.Parse(txtAmount.Text)), 2).ToString();
                }
                else
                {
                    txtDiscount.Text = Math.Round((double.Parse(txtDisPer.Text)
                                    * (double.Parse(txtAmount.Text) / 100)), 2).ToString();
                }

                txtVat.Text = Math.Round((double.Parse(txtVatPer.Text)
                                * ((double.Parse(txtAmount.Text) - double.Parse(txtDiscount.Text))
                                / 100)), 2).ToString();
                txtNetAmount.Text = Math.Round(((double.Parse(txtAmount.Text) - double.Parse(txtDiscount.Text))
                                + double.Parse(txtVat.Text)), 2).ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void txtVat_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdoRechargeNo_CheckedChanged(object sender, EventArgs e)
        {
            FILL_LISTBOX();
        }

        private void rdoDate_CheckedChanged(object sender, EventArgs e)
        {
            FILL_LISTBOX();
        }

        private void rdoParty_CheckedChanged(object sender, EventArgs e)
        {
            FILL_LISTBOX();
        }

        private void dtpMonthSearch_ValueChanged(object sender, EventArgs e)
        {
            FILL_LISTBOX();
        }

        private void txtRechargeNoSearch_TextChanged(object sender, EventArgs e)
        {
            FILL_LISTBOX();
        }

        private void CboPartySearch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FILL_LISTBOX();
        }

        private void lstBox_Click(object sender, EventArgs e)
        {
            MASTERID = Convert.ToInt32(lstBox.SelectedValue);
            fill_edit();
            CALC_TOTAL();
        }

        private void dg_Click(object sender, EventArgs e)
        {
            if ((dg.SelectedRows.Count > 0))
            {
                try
                {
                    cboCategory.SelectedValue = dg.CurrentRow.Cells["colItemGroupId"].Value;
                    cboCategory_SelectionChangeCommitted(e, e);
                    cboSubCategory.SelectedValue = dg.CurrentRow.Cells["colItemSubGroupId"].Value;
                    cboSubCategory_SelectionChangeCommitted(e, e);
                    cboSSubCategory.SelectedValue = dg.CurrentRow.Cells["colBrandId"].Value;
                    cboSSubCategory_SelectionChangeCommitted(e, e);
                    cboItem.SelectedValue = dg.CurrentRow.Cells["colItemId"].Value;
                    txtSalePrice.Text = dg.CurrentRow.Cells["colSalePrice"].Value.ToString();
                    txtQty.Text = dg.CurrentRow.Cells["colQty"].Value.ToString();

                    txtAmount.Text = dg.CurrentRow.Cells["colAmount"].Value.ToString();
                    txtDisPer.Text = dg.CurrentRow.Cells["colDisPer"].Value.ToString();
                    txtDiscount.Text = dg.CurrentRow.Cells["colDiscount"].Value.ToString();
                    txtVatPer.Text = dg.CurrentRow.Cells["colVatPer"].Value.ToString();
                    txtVat.Text = dg.CurrentRow.Cells["colVat"].Value.ToString();
                    txtNetAmount.Text = dg.CurrentRow.Cells["colNetAmount"].Value.ToString();
                    // For Each OBJ As ItemSerialNo In ARRSERIALLIST
                    //     If OBJ.ItemId = dg.CurrentRow.Cells("colItemId").Value Then
                    //         Dim LI As ListViewItem = lvSerialNo.Items.Add(OBJ.serialno)
                    //         If OBJ.tag = True Then
                    //             LI.ForeColor = Color.Red
                    //             LI.Tag = True
                    //         Else
                    //             LI.Tag = False
                    //         End If
                    //     End If
                    // Next
                }
                catch (Exception ex)
                {
                    MessageBox.Show(("ERROR: " + (ex.Message + ("\r\n" + "PLEASE CONTACT Mr. Amit Tiwari"))));
                }
            }
        }
        private void dg_DoubleClick(object sender, EventArgs e)
         {
            if ((dg.SelectedRows.Count > 0))
            {
                dt.Rows.RemoveAt(dg.CurrentRow.Index);
                dg.DataSource = dt;
              //  CLEAR_CONT();
                CALC_TOTAL();
            }
        }
    }
}
