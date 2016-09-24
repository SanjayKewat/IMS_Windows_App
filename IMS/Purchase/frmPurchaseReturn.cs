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
using IMS.Suppliers;

namespace IMS.Purchase
{
    public partial class frmPurchaseReturn : Form
    {
        public frmPurchaseReturn()
        {
            InitializeComponent();
        }
           int MASTERID;
    DataTable dt =new DataTable();
    DataTable DTEDIT=new DataTable();

    double PURCHASE_RETURN_0=0, PURCHASE_RETURN_0_4_5=0, PURCHASE_RETURN_4_5=0, PURCHASE_RETURN_13_5=0, PURCHASE_RETURN_5=0, PURCHASE_RETURN_OTHER=0, vat_0_4_5=0, VAT_4_5=0, VAT_5=0, VAT_13_5=0, VAT_OTHER=0;
    int EXIST_COUNT = 0;
  //==========================================================Functions Declaration====================================================================================================
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
                        impfunc.FILL_LISTBOX_DISTINCT(impfunc.cnn, lstBox, "PURCHASE_RETURN_MASTER", "INVOICENO", "PURCHASE_RETURNMASTERID", ("COMPANYID="
                                        + (impfunc._COMPANYID + (" AND FYEARID=" + impfunc._FYEARID))));
                    }
                    else
                    {
                        impfunc.FILL_LISTBOX_DISTINCT(impfunc.cnn, lstBox, "PURCHASE_RETURN_MASTER", "INVOICENO", "PURCHASE_RETURNMASTERID", ("COMPANYID="
                                        + (impfunc._COMPANYID + (" AND FYEARID="
                                        + (impfunc._FYEARID + (" AND INVOICENO LIKE \'%"
                                        + (txtRechargeNoSearch.Text + "%\'")))))));
                    }

                    txtRechargeNoSearch.Visible = true;
                }
                else if ((rdoDate.Checked == true))
                {
                    impfunc.FILL_LISTBOX_DISTINCT(impfunc.cnn, lstBox, "PURCHASE_RETURN_MASTER", "INVOICENO", "PURCHASE_RETURNMASTERID", ("COMPANYID="
                                    + (impfunc._COMPANYID + (" AND FYEARID="
                                    + (impfunc._FYEARID + (" AND MONTH(INVOICEDATE)="
                                    + (dtpMonthSearch.Value.Month + (" AND YEAR(INVOICEDATE)=" + dtpMonthSearch.Value.Year))))))));
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

                    impfunc.FILL_LISTBOX_DISTINCT(impfunc.cnn, lstBox, "PURCHASE_RETURN_MASTER", "INVOICENO", "PURCHASE_RETURNMASTERID", ("COMPANYID="
                                    + (impfunc._COMPANYID + (" AND FYEARID="
                                    + (impfunc._FYEARID + (" AND LEDGERID=" + CboPartySearch.SelectedValue))))));
                }

            }
            catch (Exception ex)
            {
                // MsgBox(ex.Message)
            }

        }

        void FILL_SUPPLIER()
        {
            try
            {
                impfunc.FILL_COMBO(impfunc.cnn, cboSupplier, "LEDGER", "NAME", "LEDGERID", ("COMPANYID="
                                + (impfunc._COMPANYID + " AND  LEDGERSUBGROUPID=14")), "NAME");
                impfunc.FILL_COMBO_DISTINCT(impfunc.cnn, CboPartySearch, "PURCHASE_RETURN_MASTER_VIEW", "NAME", "LEDGERID");
                cboSupplier_SelectionChangeCommitted(null, null);
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

       

        void FILL_ITEM_DATA()
        {
            try
            {
                int itemid = 0;
               txtPURCHASE_RETURNPrice.Text = "";
                if (cboItem.SelectedValue != null)
                {
                    itemid = Convert.ToInt32(cboItem.SelectedValue);
                }

                impfunc.FILL_RECORD(impfunc.cnn, "ITEM_STOCK", "ITEMID=" + itemid, "CURRENTSTOCK", txtItemStock, "PURCHASEPRICE", txtPURCHASE_RETURNPrice, "SALEPRICE", txtSalePrice, "VATPER", txtVatPer, "DISCPER", txtDisPer);

            }
            catch (Exception ex)
            {

            }

        }

        void CLEAR_CONTROL()
        {
            txtPURCHASE_RETURNPrice.Text = "0";
            txtSalePrice.Text = "0";
            txtQty.Text = "1";
            txtAmount.Text = "0";
            txtDisPer.Text = "0";
            txtDiscount.Text = "0";
            txtVatPer.Text = "0";
            txtVat.Text = "0";
            txtNetAmount.Text = "0";
        }

        void CLEAR_CONT()
        {
            CLEAR_CONTROL();
            txtInvoiceNo.Clear();
            txtTotalAmount.Text = "0";
            txtTotalDiscount.Text = "0";
            txtTotalVat.Text = "0";
            txtSubTotal.Text = "0";
            txtFreight.Text = "0";
            txtRoundOff.Text = "0";
            txtGrandTotal.Text = "0";
            txtTotalQty.Text = "0";
       
            txtcst.Text="0";
            txtcstper.Text="0";
          
            txtfinalamount.Text="0";
            txtlabourcharges.Text="0";
       
            dt.Rows.Clear();
            MASTERID = 0;
            grpSearch.Enabled = true;
        }

        void fill_edit()
        {
            try
            {
              //  SHOW_PLEASE_WAIT(true);
                impfunc.FILL_RECORD(impfunc.cnn, "PURCHASE_RETURN_MASTER_VIEW", ("PURCHASE_RETURNMASTERID=" + MASTERID), "INVOICENO", txtInvoiceNo, "INVOICEDATE", dtpInvoiceDate, "PURCHASE_RETURNDATE", dtpPURCHASE_RETURNDate, "NAME", cboSupplier, "TOTALAMOUNT", txtTotalAmount, "TOTALDISCOUNT", txtTotalDiscount, "TOTALVAT", txtTotalVat, "SUBTOTAL", txtSubTotal, "FREIGHT", txtFreight, "ROUNDOFF", txtRoundOff, "GRANDTOTAL", txtGrandTotal, "FINALAMOUNT", txtfinalamount, "CTSAMOUNT", txtcst, "CTSPERCENT", txtcstper, "LABOUR", txtlabourcharges);
                impfunc._Adapter = new SqlDataAdapter(("SELECT * FROM PURCHASE_RETURN_SLAVE_VIEW WHERE PURCHASE_RETURNMASTERID=" + MASTERID), impfunc.cnn);
                dt.Rows.Clear();
                impfunc._Adapter.Fill(dt);
                txtTotalQty.Text = dt.Rows.Count.ToString();
                impfunc._Adapter = new SqlDataAdapter(("SELECT * FROM PURCHASE_RETURN_SLAVE_VIEW WHERE PURCHASE_RETURNMASTERID=" + MASTERID), impfunc.cnn);
                DTEDIT.Rows.Clear();
                impfunc._Adapter.Fill(DTEDIT);
                dg.DataSource = DTEDIT;
               // SHOW_PLEASE_WAIT(false);
            }
            catch (Exception ex)
            {
              //  SHOW_PLEASE_WAIT(false);
              //  MsgBox(("Following error Occured :: " + ex.Message), MsgBoxStyle.Critical, "Infotech Consultants");
            }

        }

        void JOURNAL()
        {
            try
            {
                int VNO = impfunc.GENERATE_MAX(impfunc.cnn, impfunc._TR, "JOURNAL", "VNO", "VTYPE=\'PURCHASE_RETURN\'");
                // _COMPANYID = 1
                int S = 4;
                impfunc.SAVE_IN_JOURNAL(impfunc.cnn, impfunc._TR, impfunc._COMPANYID, Convert.ToInt32(cboSupplier.SelectedValue), 1, dtpInvoiceDate.Value.Date.ToString("dd/MMM/yyyy"), VNO, ("PURCHASE_RETURN AGAINST INVOICENO " + txtInvoiceNo.Text), "PURCHASE_RETURN", "PURCHASE_RETURN", Math.Round(Convert.ToDouble(txtfinalamount.Text)).ToString(), "0", MASTERID, VNO, impfunc._FYEARID, 0, "1/1/1990");
                impfunc.SAVE_IN_JOURNAL(impfunc.cnn, impfunc._TR, impfunc._COMPANYID, 2, 2, dtpInvoiceDate.Value.Date.ToString("dd/MMM/yyyy"), VNO, ("PURCHASE_RETURN AGAINST INVOICENO " + txtInvoiceNo.Text), "PURCHASE_RETURN", "PURCHASE_RETURN", "0", double.Parse(txtTotalAmount.Text).ToString(), MASTERID, VNO, impfunc._FYEARID, 0, "1/1/1990");
                if ((double.Parse(txtTotalDiscount.Text) > 0))
                {
                    S = (S + 1);
                    impfunc.SAVE_IN_JOURNAL(impfunc.cnn, impfunc._TR, impfunc._COMPANYID, 11, S,dtpInvoiceDate.Value.Date.ToString("dd/MMM/yyyy"), VNO, ("PURCHASE_RETURN AGAINST INVOICENO " + txtInvoiceNo.Text), "PURCHASE_RETURN", "PURCHASE_RETURN", double.Parse(txtTotalDiscount.Text).ToString(), "0", MASTERID, VNO, impfunc._FYEARID, 0, "1/1/1990");
                }


                if ((double.Parse(txtcst.Text) > 0))
                {
                    S = (S + 1);
                    impfunc.SAVE_IN_JOURNAL(impfunc.cnn, impfunc._TR, impfunc._COMPANYID, 22, S, dtpInvoiceDate.Value.Date.ToString("dd/MMM/yyyy"), VNO, ("PURCHASE_RETURN AGAINST INVOICENO " + txtInvoiceNo.Text), "PURCHASE_RETURN", "PURCHASE_RETURN", "0", double.Parse(txtcst.Text).ToString(), MASTERID, VNO, impfunc._FYEARID, 0, "1/1/1990");
                }

                if ((double.Parse(txtlabourcharges.Text) > 0))
                {
                    S = (S + 1);
                    impfunc.SAVE_IN_JOURNAL(impfunc.cnn, impfunc._TR, impfunc._COMPANYID, 59, S, dtpInvoiceDate.Value.Date.ToString("dd/MMM/yyyy"), VNO, ("PURCHASE_RETURN AGAINST INVOICENO " + txtInvoiceNo.Text), "PURCHASE_RETURN", "PURCHASE_RETURN", "0", double.Parse(txtlabourcharges.Text).ToString(), MASTERID, VNO, impfunc._FYEARID, 0, "1/1/1990");
                }

                if ((VAT_4_5 > 0))
                {
                    S = (S + 1);
                    impfunc.SAVE_IN_JOURNAL(impfunc.cnn, impfunc._TR, impfunc._COMPANYID, 39, S, dtpInvoiceDate.Value.Date.ToString("dd/MMM/yyyy"), VNO, ("PURCHASE_RETURN AGAINST INVOICENO " + txtInvoiceNo.Text), "PURCHASE_RETURN", "PURCHASE_RETURN", "0", VAT_4_5.ToString(), MASTERID, VNO, impfunc._FYEARID, 0, "1/1/1990");
                }

                if ((VAT_13_5 > 0))
                {
                    S = (S + 1);
                    impfunc.SAVE_IN_JOURNAL(impfunc.cnn, impfunc._TR, impfunc._COMPANYID, 40, S, dtpInvoiceDate.Value.Date.ToString("dd/MMM/yyyy"), VNO, ("PURCHASE_RETURN AGAINST INVOICENO " + txtInvoiceNo.Text), "PURCHASE_RETURN", "PURCHASE_RETURN", "0", VAT_13_5.ToString(), MASTERID, VNO, impfunc._FYEARID, 0, "1/1/1990");
                }

                if ((VAT_5 > 0))
                {
                    S = (S + 1);
                    impfunc.SAVE_IN_JOURNAL(impfunc.cnn, impfunc._TR, impfunc._COMPANYID, 53, S, dtpInvoiceDate.Value.Date.ToString("dd/MMM/yyyy"), VNO, ("PURCHASE_RETURN AGAINST INVOICENO " + txtInvoiceNo.Text), "PURCHASE_RETURN", "PURCHASE_RETURN", "0", VAT_5.ToString(), MASTERID, VNO, impfunc._FYEARID, 0, "1/1/1990");
                }

                if ((VAT_OTHER > 0))
                {
                    S = (S + 1);
                    impfunc.SAVE_IN_JOURNAL(impfunc.cnn, impfunc._TR, impfunc._COMPANYID, 38, S, dtpInvoiceDate.Value.Date.ToString("dd/MMM/yyyy"), VNO, ("PURCHASE_RETURN AGAINST INVOICENO " + txtInvoiceNo.Text), "PURCHASE_RETURN", "PURCHASE_RETURN", "0", VAT_OTHER.ToString(), MASTERID, VNO, impfunc._FYEARID, 0, "1/1/1990");
                }

                if ((double.Parse(txtFreight.Text) > 0))
                {
                    S = (S + 1);
                    impfunc.SAVE_IN_JOURNAL(impfunc.cnn, impfunc._TR, impfunc._COMPANYID, 14, S, dtpInvoiceDate.Value.Date.ToString("dd/MMM/yyyy"), VNO, ("PURCHASE_RETURN AGAINST INVOICENO " + txtInvoiceNo.Text), "PURCHASE_RETURN", "PURCHASE_RETURN", "0", double.Parse(txtFreight.Text).ToString(), MASTERID, VNO, impfunc._FYEARID, 0, "1/1/1990");
                }

                if ((double.Parse(txtFreight.Text) > 0))
                {
                    S = (S + 1);
                    impfunc.SAVE_IN_JOURNAL(impfunc.cnn, impfunc._TR, impfunc._COMPANYID, 14, S, dtpInvoiceDate.Value.Date.ToString("dd/MMM/yyyy"), VNO, ("PURCHASE_RETURN AGAINST INVOICENO " + txtInvoiceNo.Text), "PURCHASE_RETURN", "PURCHASE_RETURN", "0", double.Parse(txtFreight.Text).ToString(), MASTERID, VNO, impfunc._FYEARID, 0, "1/1/1990");
                }

                if ((double.Parse(txtRoundOff.Text) != 0))
                {
                    S = (S + 1);
                    impfunc.SAVE_IN_JOURNAL(impfunc.cnn, impfunc._TR, impfunc._COMPANYID, 9, S,dtpInvoiceDate.Value.Date.ToString("dd/MMM/yyyy"), VNO, ("PURCHASE_RETURN AGAINST INVOICENO " + txtInvoiceNo.Text), "PURCHASE_RETURN", "PURCHASE_RETURN", ((double.Parse(txtRoundOff.Text) < 0) ? Math.Abs(double.Parse(txtRoundOff.Text)) : 0).ToString(), ((double.Parse(txtRoundOff.Text) < 0) ? 0 : Math.Abs(double.Parse(txtRoundOff.Text))).ToString(), MASTERID, VNO, impfunc._FYEARID, 0, "1/1/1990");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        void CALC_TOTAL()
        {
            try
            {
                if (dt.Rows.Count > 0)
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

                txtfinalamount.Text = (Convert.ToDouble(txtFreight.Text)
                               + Convert.ToDouble(txtGrandTotal.Text)
                               + Convert.ToDouble(txtlabourcharges.Text)
                               + Convert.ToDouble(txtcst.Text)).ToString();
            }
            catch (Exception ex)
            {
            }

        }

        void calc_vat()
        {
            PURCHASE_RETURN_0 = 0;
            PURCHASE_RETURN_4_5 = 0;
            PURCHASE_RETURN_5 = 0;
            PURCHASE_RETURN_13_5 = 0;
            PURCHASE_RETURN_OTHER = 0;
            VAT_4_5 = 0;
            VAT_5 = 0;
            VAT_13_5 = 0;
            VAT_OTHER = 0;
            double AMOUNT;
            foreach (DataRow DR in dt.Rows)
            {
                AMOUNT = (Convert.ToDouble(DR["AMOUNT"]) - Convert.ToDouble(DR["DISCOUNT"]));
                if ((Convert.ToDouble(DR["VATPER"]) == 0))
                {
                    PURCHASE_RETURN_0 = (PURCHASE_RETURN_0 + AMOUNT);
                }
                else if ((Convert.ToDouble(DR["VATPER"]) == 4.5))
                {
                    PURCHASE_RETURN_4_5 = (PURCHASE_RETURN_4_5 + AMOUNT);
                    VAT_4_5 = (VAT_4_5 + Convert.ToDouble(DR["VATAMOUNT"]));
                }
                else if ((Convert.ToDouble(DR["VATPER"]) == 13.5))
                {
                    PURCHASE_RETURN_13_5 = (PURCHASE_RETURN_13_5 + AMOUNT);
                    VAT_13_5 = (VAT_13_5 + Convert.ToDouble(DR["VATAMOUNT"]));
                }
                else if ((Convert.ToDouble(DR["VATPER"]) == 5))
                {
                    PURCHASE_RETURN_5 = (PURCHASE_RETURN_5 + AMOUNT);
                    VAT_5 = (VAT_5 + Convert.ToDouble(DR["VATAMOUNT"]));
                }
                else
                {
                    PURCHASE_RETURN_OTHER = (PURCHASE_RETURN_OTHER + AMOUNT);
                    VAT_OTHER = (VAT_OTHER + Convert.ToDouble(DR["VATAMOUNT"]));
                }

            }

        }

        //public bool enabledStatus(string type)
        //{
        //    if ((type == "ADD"))
        //    {
        //        enabledStatus = btnAdd.Enabled;
        //    }
        //    else
        //    {
        //        enabledStatus = btnEdit.Enabled;
        //    }

        //}
//=========================================================================================================End=================================================================================================================

        private void frmPurchaseReturn_KeyDown(object sender, KeyEventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add(F3)")
            {
                impfunc.ADD_EDIT_FUNCTION("ADD", btnAdd, btnEdit, btnDelete, grpMaster, grpItem, grpAmount);
                CLEAR_CONT();
                cboCategory_SelectionChangeCommitted(e, e);
                grpSearch.Enabled = false;

                txtInvoiceNo.Text = impfunc.GENERATE_MAX(impfunc.cnn, "PURCHASE_RETURN_MASTER", "INVOICENO", ("COMPANYID="
                                + (impfunc._COMPANYID + ""))).ToString();
                txtInvoiceNo.Focus();
                return;
            }
            else
            {
                if (impfunc.VALIDATION_BLANK(txtInvoiceNo) == true)
                {
                    return;
                }

                if (impfunc.VALIDATION_BLANK(cboSupplier) == true)
                {
                    return;
                }

                if (dt.Rows.Count < 1)
                {
                  //  MsgBox("There should be atleast one item to PURCHASE_RETURN !! ?", MsgBoxStyle.Exclamation, "Infotech Consultants");
                   cboCategory.Focus();
                    return;
                }

                if ((impfunc.EXISTS_RECORD(impfunc.cnn, "PURCHASE_RETURN_MASTER", "INVOICENO", ("COMPANYID="
                                + (impfunc._COMPANYID + (" AND INVOICENO="
                                + (txtInvoiceNo.Text.Trim() + "")))), false) == true))
                {
                    txtInvoiceNo.Text = impfunc.GENERATE_MAX(impfunc.cnn, "PURCHASE_RETURN_MASTER", "INVOICENO", ("COMPANYID="
                                    + (impfunc._COMPANYID + ""))).ToString();
                }

                try
                {
                    txtRoundOff.Text = Math.Round((Math.Round(double.Parse(txtfinalamount.Text)) - double.Parse(txtfinalamount.Text)), 2).ToString();
                   // SHOW_PLEASE_WAIT(true);
                    impfunc._Command = new SqlCommand();
                    impfunc._Command.Connection = impfunc.cnn;
                    impfunc.OPENCONNECTION();
                    impfunc._TR = impfunc.cnn.BeginTransaction(IsolationLevel.ReadCommitted);
                    impfunc._Command.Transaction = impfunc._TR;
                    calc_vat();
                    impfunc.SAVE_RECORDS(impfunc.cnn, "PURCHASE_RETURN_MASTER", impfunc._TR, "INVOICENO", "INVOICEDATE", "PURCHASE_RETURNDATE", "LEDGERID", "COMPANYID", "FYEARID", "LOGINID", "TOTALAMOUNT", "TOTALDISCOUNT", "TOTALVAT", "SUBTOTAL", "FREIGHT", "ROUNDOFF", "GRANDTOTAL", "PURCHASE_RETURN_0", "PURCHASE_RETURN_4_5", "PURCHASE_RETURN_13_5", "PURCHASE_RETURN_OTHER", "VAT_4_5", "VAT_13_5", "VAT_OTHER", "LABOUR",  "CTSPERCENT", "CTSAMOUNT", "FINALAMOUNT", txtInvoiceNo.Text, dtpInvoiceDate.Value.Date.ToString("dd/MMM/yyyy"), dtpPURCHASE_RETURNDate.Value.Date.ToString("dd/MMM/yyyy"), cboSupplier.SelectedValue.ToString(), impfunc._COMPANYID.ToString(), impfunc._FYEARID.ToString(), impfunc._LOGINID.ToString(), txtTotalAmount.Text, txtTotalDiscount.Text, txtTotalVat.Text, txtSubTotal.Text, txtFreight.Text, txtRoundOff.Text, txtGrandTotal.Text, PURCHASE_RETURN_0.ToString(), PURCHASE_RETURN_4_5.ToString(), PURCHASE_RETURN_13_5.ToString(), PURCHASE_RETURN_OTHER.ToString(), VAT_4_5.ToString(), VAT_13_5.ToString(), VAT_OTHER.ToString(), txtlabourcharges.Text,txtcstper.Text, txtcst.Text, Math.Round(Convert.ToDouble(txtfinalamount.Text)).ToString());
                    MASTERID = Convert.ToInt32(impfunc.GET_ID_AFTER_SAVE(impfunc.cnn, "PURCHASE_RETURN_MASTER", impfunc._TR));
                    foreach (DataRow DR in dt.Rows)
                    {
                        impfunc.UPDATE_RECORDS(impfunc.cnn, "ITEM_STOCK", impfunc._TR, ("SET STOCKIN=STOCKIN-"
                                        + (DR["QTY"] + (",CURRENTSTOCK=CURRENTSTOCK-"
                                        + (DR["QTY"] + (",SALEPRICE="
                                        + (DR["SALEPRICE"] + (",PURCHASEPRICE="
                                        + (DR["PURCHASE_RETURNPRICE"] + (" WHERE ITEMID="
                                        + (DR["ITEMID"] )))))))))));
                        impfunc.SAVE_RECORDS(impfunc.cnn, "PURCHASE_RETURN_SLAVE", impfunc._TR, "PURCHASE_RETURNMASTERID", "ITEMID", "BRANDID", "EXPIRYDATE", "SALEPRICE", "QTY", "PURCHASE_RETURNPRICE", "AMOUNT", "DISCOUNTPER", "DISCOUNT", "VATPER", "VATAMOUNT", "NETAMOUNT", MASTERID.ToString(), DR["ITEMID"].ToString(), DR["BRANDID"].ToString(), DR["EXPIRYDATE"].ToString(), DR["SALEPRICE"].ToString(), DR["QTY"].ToString(), DR["PURCHASE_RETURNPRICE"].ToString(), DR["AMOUNT"].ToString(), DR["DISCOUNTPER"].ToString(), DR["DISCOUNT"].ToString(), DR["VATPER"].ToString(), DR["VATAMOUNT"].ToString(), DR["NETAMOUNT"].ToString());
                        impfunc._ID = impfunc.GET_ID_AFTER_SAVE(impfunc.cnn, "PURCHASE_RETURN_SLAVE", impfunc._TR);
                    }

                    JOURNAL();
                    impfunc._TR.Commit();
                    impfunc.CLOSECONNECTION();
                //    SHOW_PLEASE_WAIT(false);
                    //if ((MsgBox(("SAVED SUCCESSFULLY !!" + ("\r\n" + " DO YOU WANT TO VIEW BILL ?")), MsgBoxStyle.YesNo, "Infotech Consultants") == MsgBoxResult.Yes))
                    //{
                    //    frmReportFullPage frm = new frmReportFullPage();
                    //    Check_ChildForm(Mainform);
                    //    Add_ChildAtTab(frm, Mainform);
                    //    ViewReport(frm.cr, "PURCHASERETURNINVOICE.rpt", "", false, frm, ("PURCHASERETURNMASTERID=" + MASTERID));
                    //}

                    btnReset_Click(e, e);
                }
                catch (Exception ex)
                {
                    impfunc._TR.Rollback();
                    impfunc.CLOSECONNECTION();
                //    SHOW_PLEASE_WAIT(false);
                    MessageBox.Show(("ERROR: " + (ex.Message + ("\r\n" + "PLEASE CONTACT Mr. Amit Tiwari"))));
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if ((impfunc.VALIDATION_BLANK(txtInvoiceNo) == true))
            {
                return;
            }

            if ((btnEdit.Text == "Edit(F4)"))
            {
                impfunc.ADD_EDIT_FUNCTION("EDIT", btnAdd, btnEdit, btnDelete, grpMaster, grpItem, grpAmount);
                grpSearch.Enabled = false;
                txtInvoiceNo.Focus();
            }
            else
            {
                if ((impfunc.VALIDATION_BLANK(txtInvoiceNo) == true))
                {
                    return;
                }

                if ((impfunc.VALIDATION_BLANK(cboSupplier) == true))
                {
                    return;
                }

                if ((dt.Rows.Count < 1))
                {
                    MessageBox.Show("There should be atleast one item to PURCHASE_RETURN !! ?", "Info", MessageBoxButtons.OK, MessageBoxIcon.Question);
            
                    cboCategory.Focus();
                    return;
                }

                EXIST_COUNT = Convert.ToInt32(impfunc.GET_ONEFIELD(impfunc.cnn, "PURCHASE_RETURN_MASTER", "COUNT(PURCHASE_RETURNMASTERID)", ("PURCHASE_RETURNMASTERID=" + MASTERID)));
                if ((EXIST_COUNT != 1))
                {
                  
                    MessageBox.Show("Please select invoice properly !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if ((impfunc.EXISTS_RECORD(impfunc.cnn, "PURCHASE_RETURN_MASTER", ("COMPANYID="
                                + (impfunc._COMPANYID + " AND INVOICENO")), ("INVOICENO="
                                + (txtInvoiceNo.Text.Trim() + (" AND PURCHASE_RETURNMASTERID<>" + MASTERID))), false) == true))
                {
                    txtInvoiceNo.Focus();
                    return;
                }

                try
                {
                  //  SHOW_PLEASE_WAIT(true);
                    txtRoundOff.Text = Math.Round((Math.Round(double.Parse(txtfinalamount.Text)) - double.Parse(txtfinalamount.Text)), 2).ToString();
                    impfunc._Command = new SqlCommand();
                    impfunc._Command.Connection = impfunc.cnn;
                    impfunc.OPENCONNECTION();
                    impfunc._TR = impfunc.cnn.BeginTransaction(IsolationLevel.ReadCommitted);
                    impfunc._Command.Transaction = impfunc._TR;
                    foreach (DataRow DR in DTEDIT.Rows)
                    {
                        impfunc.UPDATE_RECORDS(impfunc.cnn, "ITEM_STOCK", impfunc._TR, ("SET STOCKIN=STOCKIN+"
                                        + (DR["QTY"] + (",CURRENTSTOCK=CURRENTSTOCK+"
                                        + (DR["QTY"] + (" WHERE ITEMID="
                                        + (DR["ITEMID"] )))))));
                    }

                    calc_vat();
                    impfunc.UPDATE_RECORDS(impfunc.cnn, "PURCHASE_RETURN_MASTER", impfunc._TR, "INVOICENO", "INVOICEDATE", "PURCHASE_RETURNDATE", "LEDGERID", "COMPANYID", "FYEARID", "TOTALAMOUNT", "TOTALDISCOUNT", "TOTALVAT", "SUBTOTAL", "FREIGHT", txtInvoiceNo.Text, dtpInvoiceDate.Value.Date.ToString("dd/MMM/yyyy"), dtpPURCHASE_RETURNDate.Value.Date.ToString("dd/MMM/yyyy"), cboSupplier.SelectedValue.ToString(), impfunc._COMPANYID.ToString(), impfunc._FYEARID.ToString(), txtTotalAmount.Text, txtTotalDiscount.Text, txtTotalVat.Text, txtSubTotal.Text, txtFreight.Text,  "PURCHASE_RETURNMASTERID", MASTERID);

                    impfunc.UPDATE_RECORDS(impfunc.cnn, "PURCHASE_RETURN_MASTER", impfunc._TR, "ROUNDOFF", "GRANDTOTAL", "PURCHASE_RETURN_0", "PURCHASE_RETURN_4_5", "PURCHASE_RETURN_13_5", "PURCHASE_RETURN_OTHER", "VAT_4_5", "VAT_13_5", "VAT_OTHER", "LABOUR", "CTSPERCENT", "CTSAMOUNT", "FINALAMOUNT", txtRoundOff.Text, txtGrandTotal.Text, PURCHASE_RETURN_0.ToString(), PURCHASE_RETURN_4_5.ToString(), PURCHASE_RETURN_13_5.ToString(), PURCHASE_RETURN_OTHER.ToString(), VAT_4_5.ToString(), VAT_13_5.ToString(), VAT_OTHER.ToString(), txtlabourcharges.Text, txtcstper.Text, txtcst.Text, Math.Round(Convert.ToDouble(txtfinalamount.Text)).ToString(), "PURCHASE_RETURNMASTERID", MASTERID);
                    impfunc.DELETE_RECORDS(impfunc.cnn, "PURCHASE_RETURN_SLAVE", impfunc._TR, ("PURCHASE_RETURNMASTERID=" + MASTERID));
                    foreach (DataRow DR in dt.Rows)
                    {
                        impfunc.UPDATE_RECORDS(impfunc.cnn, "ITEM_STOCK", impfunc._TR, ("SET STOCKIN=STOCKIN-"
                                        + (DR["QTY"] + (",CURRENTSTOCK=CURRENTSTOCK-"
                                        + (DR["QTY"] + (",SALEPRICE="
                                        + (DR["SALEPRICE"] + (",PURCHASEPRICE="
                                        + (DR["PURCHASE_RETURNPRICE"] + (" WHERE ITEMID="
                                        + (DR["ITEMID"] )))))))))));
                        impfunc.SAVE_RECORDS(impfunc.cnn, "PURCHASE_RETURN_SLAVE", impfunc._TR, "PURCHASE_RETURNMASTERID", "ITEMID", "BRANDID", "EXPIRYDATE", "SALEPRICE", "QTY", "PURCHASE_RETURNPRICE", "AMOUNT", "DISCOUNTPER", "DISCOUNT", "VATPER", "VATAMOUNT", "NETAMOUNT", MASTERID.ToString(), DR["ITEMID"].ToString(), DR["BRANDID"].ToString(), DR["EXPIRYDATE"].ToString(), DR["SALEPRICE"].ToString(), DR["QTY"].ToString(), DR["PURCHASE_RETURNPRICE"].ToString(), DR["AMOUNT"].ToString(), DR["DISCOUNTPER"].ToString(), DR["DISCOUNT"].ToString(), DR["VATPER"].ToString(), DR["VATAMOUNT"].ToString(), DR["NETAMOUNT"].ToString());
                    }

                    impfunc.DELETE_FROM_JOURNAL(impfunc.cnn, impfunc._TR, ("VTYPE=\'PURCHASE_RETURN\' AND TRANSACTIONID=" + MASTERID));
                    JOURNAL();
                    impfunc._TR.Commit();
                    impfunc.CLOSECONNECTION();
                   // SHOW_PLEASE_WAIT(false);
                    //if ((MsgBox(("SAVED SUCCESSFULLY !!" + ("\r\n" + " DO YOU WANT TO VIEW BILL ?")), MsgBoxStyle.YesNo, "Infotech Consultants") == MsgBoxResult.Yes))
                    //{
                    //    frmReportFullPage frm = new frmReportFullPage();
                    //    Check_ChildForm(Mainform);
                    //    Add_ChildAtTab(frm, Mainform);
                    //    ViewReport(frm.cr, "PURCHASERETURNINVOICE.rpt", "", false, frm, ("PURCHASERETURNMASTERID=" + MASTERID));
                    //}

                    btnReset_Click(e, e);
                }
                catch (Exception ex)
                {
                    impfunc._TR.Rollback();
                    impfunc.CLOSECONNECTION();
                    //SHOW_PLEASE_WAIT(false);
                    MessageBox.Show(("ERROR: " + (ex.Message + ("\r\n" + "PLEASE CONTACT Mr. Amit Tiwari"))));
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((impfunc.VALIDATION_BLANK(txtInvoiceNo) == true))
            {
                return;
            }
               DialogResult dialogResult = MessageBox.Show("Sure, You want to delete Record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               if (dialogResult == DialogResult.Yes)
               {
                   try
                   {
                       EXIST_COUNT = Convert.ToInt32(impfunc.GET_ONEFIELD(impfunc.cnn, "PURCHASE_RETURN_MASTER", "COUNT(PURCHASE_RETURNMASTERID)", ("PURCHASE_RETURNMASTERID=" + MASTERID)));
                       if ((EXIST_COUNT != 1))
                       {

                           MessageBox.Show("Please select invoice properly !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                           return;
                       }

                       // SHOW_PLEASE_WAIT(true);
                       impfunc._Command = new SqlCommand();
                       impfunc._Command.Connection = impfunc.cnn;
                       impfunc.OPENCONNECTION();
                       impfunc._TR = impfunc.cnn.BeginTransaction(IsolationLevel.ReadCommitted);
                       impfunc._Command.Transaction = impfunc._TR;
                       foreach (DataRow DR in DTEDIT.Rows)
                       {
                           impfunc.UPDATE_RECORDS(impfunc.cnn, "ITEM_STOCK", impfunc._TR, ("SET STOCKIN=STOCKIN+"
                                           + (DR["QTY"] + (",CURRENTSTOCK=CURRENTSTOCK+"
                                           + (DR["QTY"] + (" WHERE ITEMID="
                                           + (DR["ITEMID"])))))));
                       }

                       impfunc.DELETE_RECORDS(impfunc.cnn, "PURCHASE_RETURN_MASTER", impfunc._TR, "PURCHASE_RETURNMASTERID", MASTERID);
                       impfunc.DELETE_RECORDS(impfunc.cnn, "PURCHASE_RETURN_SLAVE", impfunc._TR, "PURCHASE_RETURNMASTERID", MASTERID);
                       impfunc.DELETE_FROM_JOURNAL(impfunc.cnn, impfunc._TR, ("VTYPE=\'PURCHASE_RETURN\' AND TRANSACTIONID=" + MASTERID));
                       impfunc._TR.Commit();
                       impfunc.CLOSECONNECTION();
                       // SHOW_PLEASE_WAIT(false);
                       MessageBox.Show("DELETED SUCCESSFULLY !!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                       btnReset_Click(e, e);
                   }
                   catch (Exception ex)
                   {
                       impfunc._TR.Rollback();
                       impfunc.CLOSECONNECTION();
                       // impfunc.SHOW_PLEASE_WAIT(false);
                       MessageBox.Show(("ERROR: " + (ex.Message + ("\r\n" + "PLEASE CONTACT Mr. Amit Tiwari"))));
                   }
               }
               else
               {
                   btnReset_Click(null, null);
                   return;
               }
          

         
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            impfunc.ADD_EDIT_FUNCTION("RESET", btnAdd, btnEdit, btnDelete, grpMaster, grpItem, grpAmount);
            CLEAR_CONT();
            FILL_SUPPLIER();
            cboSupplier_SelectionChangeCommitted(e, e);
            fill_Cateogry();
            cboCategory_SelectionChangeCommitted(e, e);

            FILL_LISTBOX();
            btnAdd.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            impfunc.Remove_Child(this);
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

            if (Convert.ToDouble(txtPURCHASE_RETURNPrice.Text) < 0)
            {
                MessageBox.Show("Please fill Purchase Price!!", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPURCHASE_RETURNPrice.Focus();
                return;
            }

            try
            {
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
                DR["CATEGORY_NAME"] = cboCategory.Text;
                DR["SUBCATEGORY_VALUE"] = cboSubCategory.Text;
                DR["ITEM_NAME"] = cboItem.Text;
                DR["SSUBCATEGORY_VALUE"] = cboSSubCategory.Text;
                DR["EXPIRYDATE"] = dtpExpiryDate.Value;
                DR["SALEPRICE"] = Convert.ToDouble(txtSalePrice.Text);
                DR["QTY"] = Convert.ToDouble(txtQty.Text);
                DR["PURCHASE_RETURNPRICE"] = Convert.ToDouble(txtPURCHASE_RETURNPrice.Text);
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
                DR["PURCHASE_RETURNSLAVEID"] = 0;
                dt.Rows.Add(DR);
                CALC_TOTAL();
                CLEAR_CONTROL();
                cboItem_SelectionChangeCommitted(null, null);
                DialogResult dialogResult = MessageBox.Show("DO YOU WANT TO CONTINUEE.......??", "Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    cboCategory.Focus();
                }
                else
                {
                    txtlabourcharges.Focus();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(("ERROR: " + (ex.Message + ("\r\n" + "PLEASE CONTACT Mr. Amit Tiwari"))));
            }

        }

        private void cboSupplier_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ((cboSupplier.SelectedValue == null))
            {
                return;
            }
            else
            {
                try
                {
                    double DR = double.Parse(impfunc.GET_ONEFIELD(impfunc.cnn, "JOURNAL", "SUM(DR)", ("LEDGERID=" + cboSupplier.SelectedValue)));
                    double CR = double.Parse(impfunc.GET_ONEFIELD(impfunc.cnn, "JOURNAL", "SUM(CR)", ("LEDGERID=" + cboSupplier.SelectedValue)));
                    if ((DR >= CR))
                    {
                        txtLedgerBalance.Text = (Math.Round((DR - CR), 2).ToString() + " DR");
                    }
                    else
                    {
                        txtLedgerBalance.Text = (Math.Round((CR - DR), 2).ToString() + " CR");
                    }

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

        private void frmPurchaseReturn_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            btnAdd.Focus();
            FILL_LISTBOX();
            FILL_SUPPLIER();
            cboSupplier_SelectionChangeCommitted(e, e);
            fill_Cateogry();
            cboCategory_SelectionChangeCommitted(e, e);
            impfunc._Adapter = new SqlDataAdapter("SELECT * FROM PURCHASE_RETURN_SLAVE_VIEW WHERE  PURCHASE_RETURNSLAVEID=0", impfunc.cnn);
            impfunc._Adapter.Fill(dt);
            dg.AutoGenerateColumns = false;
            dg.DataSource = dt;
        }

        private void lstBox_Click(object sender, EventArgs e)
        {
            MASTERID = Convert.ToInt32(lstBox.SelectedValue);
            fill_edit();
            CALC_TOTAL();
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

        private void txtRechargeNoSearch_TextChanged(object sender, EventArgs e)
        {
            FILL_LISTBOX();
        }

        private void CboPartySearch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FILL_LISTBOX();
        }

        private void CboPartySearch_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            FILL_LISTBOX();
        }

        private void dtpMonthSearch_ValueChanged(object sender, EventArgs e)
        {
            FILL_LISTBOX();
        }

        private void dg_Click(object sender, EventArgs e)
        {
            if ((dg.SelectedRows.Count > 0)) {
    try {
        cboCategory.SelectedValue = dg.CurrentRow.Cells["colCategoryId"].Value;
        cboCategory_SelectionChangeCommitted(null, null);
        cboSubCategory.SelectedValue = dg.CurrentRow.Cells["colSubcategoryid"].Value;
        cboSubCategory_SelectionChangeCommitted(null, null);
        cboItem.SelectedValue = dg.CurrentRow.Cells["colItemId"].Value;
        cboSSubCategory.SelectedValue = dg.CurrentRow.Cells["colSusubcategoryId"].Value;
        cboSSubCategory_SelectionChangeCommitted(null, null);
        dtpExpiryDate.Text = dg.CurrentRow.Cells["colExpiryDate"].Value.ToString();
        txtSalePrice.Text = dg.CurrentRow.Cells["colSalePrice"].Value.ToString();
        txtQty.Text = dg.CurrentRow.Cells["colQty"].Value.ToString();
        txtPURCHASE_RETURNPrice.Text = dg.CurrentRow.Cells["colPURCHASE_RETURNPrice"].Value.ToString();
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
    catch (Exception ex) {
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
                CLEAR_CONTROL();
                CALC_TOTAL();
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtAmount.Text = Math.Round(Convert.ToDouble(txtQty.Text) * Convert.ToDouble(txtPURCHASE_RETURNPrice.Text)).ToString();
                if ((this.ActiveControl.Name == "txtDiscount"))
                {
                    txtDisPer.Text = Math.Round(((Convert.ToDouble(txtDiscount.Text) * 100)
                                    / Convert.ToDouble(txtAmount.Text)), 2).ToString();
                }
                else
                {
                    txtDiscount.Text = Math.Round((Convert.ToDouble(txtDisPer.Text)
                                    * (Convert.ToDouble(txtAmount.Text) / 100)), 2).ToString();
                }

                txtVat.Text = Math.Round((double.Parse(txtVatPer.Text)
                                * ((Convert.ToDouble(txtAmount.Text) - Convert.ToDouble(txtDiscount.Text))
                                / 100)), 2).ToString();
                txtNetAmount.Text = Math.Round(((Convert.ToDouble(txtAmount.Text) - Convert.ToDouble(txtDiscount.Text))
                                + Convert.ToDouble(txtVat.Text)), 2).ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void txtPURCHASE_RETURNPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtAmount.Text = Math.Round(Convert.ToDouble(txtQty.Text) * Convert.ToDouble(txtPURCHASE_RETURNPrice.Text)).ToString();
                if ((this.ActiveControl.Name == "txtDiscount"))
                {
                    txtDisPer.Text = Math.Round(((Convert.ToDouble(txtDiscount.Text) * 100)
                                    / Convert.ToDouble(txtAmount.Text)), 2).ToString();
                }
                else
                {
                    txtDiscount.Text = Math.Round((Convert.ToDouble(txtDisPer.Text)
                                    * (Convert.ToDouble(txtAmount.Text) / 100)), 2).ToString();
                }

                txtVat.Text = Math.Round((Convert.ToDouble(txtVatPer.Text)
                                * ((Convert.ToDouble(txtAmount.Text) - Convert.ToDouble(txtDiscount.Text))
                                / 100)), 2).ToString();
                txtNetAmount.Text = Math.Round(((Convert.ToDouble(txtAmount.Text) - Convert.ToDouble(txtDiscount.Text))
                                + Convert.ToDouble(txtVat.Text)), 2).ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void txtDisPer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtAmount.Text = Math.Round(Convert.ToDouble(txtQty.Text) * Convert.ToDouble(txtPURCHASE_RETURNPrice.Text)).ToString();
                if ((this.ActiveControl.Name == "txtDiscount"))
                {
                    txtDisPer.Text = Math.Round(((Convert.ToDouble(txtDiscount.Text) * 100)
                                    / Convert.ToDouble(txtAmount.Text)), 2).ToString();
                }
                else
                {
                    txtDiscount.Text = Math.Round((Convert.ToDouble(txtDisPer.Text)
                                    * (Convert.ToDouble(txtAmount.Text) / 100)), 2).ToString();
                }

                txtVat.Text = Math.Round((double.Parse(txtVatPer.Text)
                                * ((Convert.ToDouble(txtAmount.Text) - Convert.ToDouble(txtDiscount.Text))
                                / 100)), 2).ToString();
                txtNetAmount.Text = Math.Round(((Convert.ToDouble(txtAmount.Text) - Convert.ToDouble(txtDiscount.Text))
                                + Convert.ToDouble(txtVat.Text)), 2).ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtAmount.Text = Math.Round(Convert.ToDouble(txtQty.Text) * Convert.ToDouble(txtPURCHASE_RETURNPrice.Text)).ToString();
                if ((this.ActiveControl.Name == "txtDiscount"))
                {
                    txtDisPer.Text = Math.Round(((Convert.ToDouble(txtDiscount.Text) * 100)
                                    / Convert.ToDouble(txtAmount.Text)), 2).ToString();
                }
                else
                {
                    txtDiscount.Text = Math.Round((Convert.ToDouble(txtDisPer.Text)
                                    * (Convert.ToDouble(txtAmount.Text) / 100)), 2).ToString();
                }

                txtVat.Text = Math.Round((Convert.ToDouble(txtVatPer.Text)
                                * ((Convert.ToDouble(txtAmount.Text) - Convert.ToDouble(txtDiscount.Text))
                                / 100)), 2).ToString();
                txtNetAmount.Text = Math.Round(((Convert.ToDouble(txtAmount.Text) - Convert.ToDouble(txtDiscount.Text))
                                + Convert.ToDouble(txtVat.Text)), 2).ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void txtVatPer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtAmount.Text = Math.Round(Convert.ToDouble(txtQty.Text) * Convert.ToDouble(txtPURCHASE_RETURNPrice.Text)).ToString();
                if ((this.ActiveControl.Name == "txtDiscount"))
                {
                    txtDisPer.Text = Math.Round(((Convert.ToDouble(txtDiscount.Text) * 100)
                                    / Convert.ToDouble(txtAmount.Text)), 2).ToString();
                }
                else
                {
                    txtDiscount.Text = Math.Round((Convert.ToDouble(txtDisPer.Text)
                                    * (Convert.ToDouble(txtAmount.Text) / 100)), 2).ToString();
                }

                txtVat.Text = Math.Round((Convert.ToDouble(txtVatPer.Text)
                                * ((Convert.ToDouble(txtAmount.Text) - Convert.ToDouble(txtDiscount.Text))
                                / 100)), 2).ToString();
                txtNetAmount.Text = Math.Round(((Convert.ToDouble(txtAmount.Text) - Convert.ToDouble(txtDiscount.Text))
                                + Convert.ToDouble(txtVat.Text)), 2).ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void txtVat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtAmount.Text = Math.Round(Convert.ToDouble(txtQty.Text) * Convert.ToDouble(txtPURCHASE_RETURNPrice.Text)).ToString();
                if ((this.ActiveControl.Name == "txtDiscount"))
                {
                    txtDisPer.Text = Math.Round(((Convert.ToDouble(txtDiscount.Text) * 100)
                                    / Convert.ToDouble(txtAmount.Text)), 2).ToString();
                }
                else
                {
                    txtDiscount.Text = Math.Round((Convert.ToDouble(txtDisPer.Text)
                                    * (Convert.ToDouble(txtAmount.Text) / 100)), 2).ToString();
                }

                txtVat.Text = Math.Round((Convert.ToDouble(txtVatPer.Text)
                                * ((Convert.ToDouble(txtAmount.Text) - Convert.ToDouble(txtDiscount.Text))
                                / 100)), 2).ToString();
                txtNetAmount.Text = Math.Round(((Convert.ToDouble(txtAmount.Text) - Convert.ToDouble(txtDiscount.Text))
                                + Convert.ToDouble(txtVat.Text)), 2).ToString();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
