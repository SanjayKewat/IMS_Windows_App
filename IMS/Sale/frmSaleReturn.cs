﻿using System;
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
    public partial class frmSaleReturn : Form
    {
        public frmSaleReturn()
        {
            InitializeComponent();
        }
       public int  MASTERID=0, CHALLANMASTERID=0, BILLMASTERID=0, SHOWBILLDATE=0;
    int EXIST_COUNT=0;
    DataTable  dt = new DataTable();
    DataTable dtrev = new DataTable();
    DataTable dtEdit = new DataTable();
    DataTable dtRevEdit = new DataTable();
    DataTable dtSerial = new DataTable();
    SqlDataReader _dr1;
    Boolean flagDgClick;
    double SALE_RETURN_0=0, SALE_RETURN_0_4_5=0, SALE_RETURN_4_5=0, SALE_RETURN_5=0, SALE_RETURN_13_5=0, SALE_RETURN_OTHER=0, vat_0_4_5=0, VAT_4_5=0, VAT_5=0, VAT_13_5=0, VAT_OTHER=0;
//==============================================================================================functions=============================================================================================
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
                    impfunc.FILL_LISTBOX_DISTINCT(impfunc.cnn, lstBox, "SALE_RETURN_MASTER", "BILLNO", "SALE_RETURNMASTERID", ("COMPANYID="
                                      + (impfunc._COMPANYID + (" AND FYEARID=" + impfunc._FYEARID))));
                }
                else
                {
                    impfunc.FILL_LISTBOX_DISTINCT(impfunc.cnn, lstBox, "SALE_RETURN_MASTER", "BILLNO", "SALE_RETURNMASTERID", ("COMPANYID="
                                   + (impfunc._COMPANYID + (" AND FYEARID="
                                   + (impfunc._FYEARID + (" AND BILLNO LIKE \'%"
                                   + (txtRechargeNoSearch.Text + "%\'")))))));
                }

                txtRechargeNoSearch.Visible = true;
            }
            else if ((rdoDate.Checked == true))
            {
                impfunc.FILL_LISTBOX_DISTINCT(impfunc.cnn, lstBox, "SALE_RETURN_MASTER", "BILLNO", "SALE_RETURNMASTERID", ("COMPANYID="
                               + (impfunc._COMPANYID + (" AND FYEARID="
                               + (impfunc._FYEARID + (" AND MONTH(BILLDATE)="
                               + (dtpMonthSearch.Value.Month + (" AND YEAR(BILLDATE)=" + dtpMonthSearch.Value.Year))))))));
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

                impfunc.FILL_LISTBOX_DISTINCT(impfunc.cnn, lstBox, "SALE_RETURN_MASTER", "BILLNO", "SALE_RETURNMASTERID", ("COMPANYID="
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
            impfunc.FILL_COMBO(impfunc.cnn, cboParty, "LEDGER", "NAME", "LEDGERID", ("COMPANYID="
                            + (impfunc._COMPANYID + " AND LEDGERSUBGROUPID=2 ")));
            impfunc.FILL_COMBO_DISTINCT(impfunc.cnn, CboPartySearch, "SALE_RETURN_MASTER_VIEW", "NAME", "LEDGERID", ("COMPANYID="
                            + (impfunc._COMPANYID + " ")));
            //   cboPartyName_SelectionChangeCommitted(null, null);
        }
        catch (Exception ex)
        {
        }

    }


    void CLEAR_CONTROL()
    {

        txtQty.Text = "1";
        txtAmount.Text = "0";
        txtDisPer.Text = "0";
        txtDiscount.Text = "0";
        txtVatPer.Text = "0";
        txtVat.Text = "0";
        txtNetAmount.Text = "0";
        dt.Rows.Clear();

        dtEdit.Rows.Clear();

        MASTERID = 0;
   
        grpSearch.Enabled = true;
        flagDgClick = false;
        cboType.SelectedIndex = 0;
    

    }

    void CLEAR_CONT()
    {
        CLEAR_CONTROL();
        txtBillNo.Clear();
        txtSalePrice.Text = "0";
        txtTotalAmount.Text = "0";
        txtTotalDiscount.Text = "0";
        txtTotalVat.Text = "0";
        txttotalpacking.Text = "0";
        txtSubTotal.Text = "0";

        txtRoundOff.Text = "0";
        txtGrandTotal.Text = "0";
        txtTotalQty.Text = "0";

        txtrevnetamount.Clear();
        txtrevqty.Text = "1";
        txttotalrevqty.Clear();
        txtrevtotalamount.Clear();

        txtfinalamount.Text = "0";
        dtpGraceDate.ResetText();
        dtpBillDate.ResetText();
        chkShowBillDate.Checked = true;
    }

    void fill_edit()
    {
        try
        {

            impfunc.FILL_RECORD(impfunc.cnn, "SALE_RETURN_MASTER_VIEW", ("SALE_RETURNMASTERID=" + MASTERID), "BILLNO", txtBillNo, "BILLDATE", dtpBillDate, "NAME", cboParty,  "TOTALAMOUNT", txtTotalAmount, "TOTALDISCOUNT", txtTotalDiscount, "TOTALVAT", txtTotalVat, "SUBTOTAL", txtSubTotal,  "ROUNDOFF", txtRoundOff, "GRANDTOTAL", txtGrandTotal);
            impfunc._Adapter = new SqlDataAdapter(("SELECT * FROM SALE_RETURN_SLAVE_VIEW WHERE SALE_RETURNMASTERID=" + MASTERID), impfunc.cnn);
            dt.Rows.Clear();
            impfunc._Adapter.Fill(dt);
            impfunc._Adapter = new SqlDataAdapter(("SELECT * FROM SALE_RETURN_SLAVE_VIEW WHERE SALE_RETURNMASTERID=" + MASTERID), impfunc.cnn);
            dtEdit = new DataTable();
            dtEdit.Rows.Clear();
            impfunc._Adapter.Fill(dtEdit);
            string g = impfunc.GET_ONEFIELD(impfunc.cnn, "SALE_RETURN_MASTER_VIEW", "SHOWBILLDATE", ("SALE_RETURNMASTERID=" + MASTERID));
            if ((g == "0"))
            {
                chkShowBillDate.Checked = false;
            }
            else
            {
                chkShowBillDate.Checked = true;
            }

         
        }
        catch (Exception ex)
        {
          
          //  MsgBox(ex.Message);
        }
    }

    void JOURNAL()
    {
        try
        {
            int VNO = impfunc.GENERATE_MAX(impfunc.cnn, impfunc._TR, "JOURNAL", "VNO", "VTYPE=\'SALE_RETURN\'");
            // _COMPANYID = 1
            int S = 4;
            impfunc.SAVE_IN_JOURNAL(impfunc.cnn, impfunc._TR, impfunc._COMPANYID, Convert.ToInt32(cboParty.SelectedValue), 1, dtpBillDate.Value.Date.ToString("dd/MMM/yyyy"), VNO, ("SALE_RETURN AGAINST BILLNO " + txtBillNo.Text), "SALE_RETURN", "SALE_RETURN", "0", Math.Round(double.Parse(txtfinalamount.Text), 0).ToString(), MASTERID, VNO, impfunc._FYEARID, 0, "1/1/1990");
            impfunc.SAVE_IN_JOURNAL(impfunc.cnn, impfunc._TR, impfunc._COMPANYID, 1, 2, dtpBillDate.Value.Date.ToString("dd/MMM/yyyy"), VNO, ("SALE_RETURN AGAINST BILLNO " + txtBillNo.Text), "SALE_RETURN", "SALE_RETURN", txtTotalAmount.Text, "0", MASTERID, VNO, impfunc._FYEARID, 0, "1/1/1990");
            //if ((Convert.ToDouble(txtrevtotalamount.Text) > 0))
            //{
            //    // SAVE_IN_JOURNAL(cnn, _TR, _COMPANYID, cboParty.SelectedValue, 45, Format(dtpBillDate.Value, "dd/MMM/yyyy"), VNO, "REBATE AGAINST BILLNO " & txtBillNo.Text, "REBATE", "REBATE", 0, Val(txtrevtotalamount.Text), MASTERID, VNO, _FYEARID, 0, "1/1/1990")
            //    impfunc.SAVE_IN_JOURNAL(cnn, _TR, _COMPANYID, 45, 2, Format(dtpBillDate.Value.Date, "dd/MMM/yyyy"), VNO, ("REBATE AGAINST BILLNO " + txtBillNo.Text), "REBATE", "REBATE", double.Parse(txtrevtotalamount.Text), 0, MASTERID, VNO, _FYEARID, 0, "1/1/1990");
            //}

            if ((Convert.ToDouble(txtTotalDiscount.Text) > 0))
            {
                S = (S + 1);
                impfunc.SAVE_IN_JOURNAL(impfunc.cnn, impfunc._TR, impfunc._COMPANYID, 12, S, dtpBillDate.Value.Date.ToString("dd/MMM/yyyy"), VNO, ("SALE_RETURN AGAINST BILLNO " + txtBillNo.Text), "SALE_RETURN", "SALE_RETURN", "0", txtTotalDiscount.Text, MASTERID, VNO, impfunc._FYEARID, 0, "1/1/1990");
            }

            if ((VAT_4_5 > 0))
            {
                S = (S + 1);
                impfunc.SAVE_IN_JOURNAL(impfunc.cnn, impfunc._TR, impfunc._COMPANYID, 5, S, dtpBillDate.Value.Date.ToString("dd/MMM/yyyy"), VNO, ("SALE_RETURN AGAINST BILLNO " + txtBillNo.Text), "SALE_RETURN", "SALE_RETURN", VAT_4_5.ToString(), "0", MASTERID, VNO, impfunc._FYEARID, 0, "1/1/1990");
            }

            if ((VAT_5 > 0))
            {
                S = (S + 1);
                impfunc.SAVE_IN_JOURNAL(impfunc.cnn, impfunc._TR, impfunc._COMPANYID, 54, S, dtpBillDate.Value.Date.ToString("dd/MMM/yyyy"), VNO, ("SALE_RETURN AGAINST BILLNO " + txtBillNo.Text), "SALE_RETURN", "SALE_RETURN", VAT_5.ToString(), "0", MASTERID, VNO, impfunc._FYEARID, 0, "1/1/1990");
            }

            if ((VAT_13_5 > 0))
            {
                S = (S + 1);
                impfunc.SAVE_IN_JOURNAL(impfunc.cnn, impfunc._TR, impfunc._COMPANYID, 6, S, dtpBillDate.Value.Date.ToString("dd/MMM/yyyy"), VNO, ("SALE_RETURN AGAINST BILLNO " + txtBillNo.Text), "SALE_RETURN", "SALE_RETURN", VAT_13_5.ToString(), "0", MASTERID, VNO, impfunc._FYEARID, 0, "1/1/1990");
            }

            if ((VAT_OTHER > 0))
            {
                S = (S + 1);
                impfunc.SAVE_IN_JOURNAL(impfunc.cnn, impfunc._TR, impfunc._COMPANYID, 7, S, dtpBillDate.Value.Date.ToString("dd/MMM/yyyy"), VNO, ("SALE_RETURN AGAINST BILLNO " + txtBillNo.Text), "SALE_RETURN", "SALE_RETURN", VAT_OTHER.ToString(), "0", MASTERID, VNO, impfunc._FYEARID, 0, "1/1/1990");
            }

            //if ((double.Parse(txtFreight.Text) > 0))
            //{
            //    S = (S + 1);
            //    SAVE_IN_JOURNAL(cnn, _TR, _COMPANYID, 13, S, Format(dtpBillDate.Value.Date, "dd/MMM/yyyy"), VNO, ("SALE_RETURN AGAINST BILLNO " + txtBillNo.Text), "SALE_RETURN", "SALE_RETURN", double.Parse(txtFreight.Text), 0, MASTERID, VNO, _FYEARID, 0, "1/1/1990");
            //}

            if ((double.Parse(txtRoundOff.Text) != 0))
            {
                S = (S + 1);
                impfunc.SAVE_IN_JOURNAL(impfunc.cnn, impfunc._TR, impfunc._COMPANYID, 10, S, dtpBillDate.Value.Date.ToString("dd/MMM/yyyy"), VNO, ("SALE_RETURN AGAINST BILLNO " + txtBillNo.Text), "SALE_RETURN", "SALE_RETURN", ((double.Parse(txtRoundOff.Text) < 0) ? 0 : Math.Abs(double.Parse(txtRoundOff.Text))).ToString(), ((double.Parse(txtRoundOff.Text) < 0) ? Math.Abs(double.Parse(txtRoundOff.Text)) : 0).ToString(), MASTERID, VNO, impfunc._FYEARID, 0, "1/1/1990");
            }

            //if ((double.Parse(txttotalpacking.Text) > 0))
            //{
            //    S = (S + 1);
            //    SAVE_IN_JOURNAL(cnn, _TR, _COMPANYID, 48, S, Format(dtpBillDate.Value.Date, "dd/MMM/yyyy"), VNO, ("SALE_RETURN AGAINST BILLNO " + txtBillNo.Text), "SALE_RETURN", "SALE_RETURN", double.Parse(txttotalpacking.Text), 0, MASTERID, VNO, _FYEARID, 0, "1/1/1990");
            //}

            //if ((double.Parse(txtinstallationchrgs.Text) > 0))
            //{
            //    S = (S + 1);
            //    SAVE_IN_JOURNAL(cnn, _TR, _COMPANYID, 49, S, Format(dtpBillDate.Value.Date, "dd/MMM/yyyy"), VNO, ("SALE_RETURN AGAINST BILLNO " + txtBillNo.Text), "SALE_RETURN", "SALE_RETURN", double.Parse(txtinstallationchrgs.Text), 0, MASTERID, VNO, _FYEARID, 0, "1/1/1990");
            //}

            //if ((double.Parse(txtservicechrgs.Text) > 0))
            //{
            //    S = (S + 1);
            //    SAVE_IN_JOURNAL(cnn, _TR, _COMPANYID, 50, S, Format(dtpBillDate.Value.Date, "dd/MMM/yyyy"), VNO, ("SALE_RETURN AGAINST BILLNO " + txtBillNo.Text), "SALE_RETURN", "SALE_RETURN", double.Parse(txtservicechrgs.Text), 0, MASTERID, VNO, _FYEARID, 0, "1/1/1990");
            //}

            //if ((double.Parse(txtlabourchrgs.Text) > 0))
            //{
            //    S = (S + 1);
            //    SAVE_IN_JOURNAL(cnn, _TR, _COMPANYID, 51, S, Format(dtpBillDate.Value.Date, "dd/MMM/yyyy"), VNO, ("SALE_RETURN AGAINST BILLNO " + txtBillNo.Text), "SALE_RETURN", "SALE_RETURN", double.Parse(txtlabourchrgs.Text), 0, MASTERID, VNO, _FYEARID, 0, "1/1/1990");
            //}

            //if ((double.Parse(txtCtsAmt.Text) > 0))
            //{
            //    S = (S + 1);
            //    SAVE_IN_JOURNAL(cnn, _TR, _COMPANYID, 23, S, Format(dtpBillDate.Value.Date, "dd/MMM/yyyy"), VNO, ("SALE_RETURN AGAINST BILLNO " + txtBillNo.Text), "SALE_RETURN", "SALE_RETURN", double.Parse(txtCtsAmt.Text), 0, MASTERID, VNO, _FYEARID, 0, "1/1/1990");
            //}

            //if ((double.Parse(txtSpDiscount.Text) > 0))
            //{
            //    S = (S + 1);
            //    SAVE_IN_JOURNAL(cnn, _TR, _COMPANYID, 55, S, Format(dtpBillDate.Value.Date, "dd/MMM/yyyy"), VNO, ("SALE_RETURN AGAINST BILLNO " + txtBillNo.Text), "SALE_RETURN", "SALE_RETURN", 0, double.Parse(txtSpDiscount.Text), MASTERID, VNO, _FYEARID, 0, "1/1/1990");
            //}

        }
        catch (Exception ex)
        {
            throw ex;
        }

    }
    void calc_vat()
    {
        SALE_RETURN_0 = 0;
        SALE_RETURN_4_5 = 0;
        SALE_RETURN_5 = 0;
        SALE_RETURN_13_5 = 0;
        SALE_RETURN_OTHER = 0;
        VAT_4_5 = 0;
        VAT_5 = 0;
        VAT_13_5 = 0;
        VAT_OTHER = 0;
        double AMOUNT;
        foreach (DataRow DR in dt.Rows)
        {
            AMOUNT = ((Convert.ToDouble(DR["AMOUNT"]) - Convert.ToDouble(DR["DISCOUNT"])));
            if ((Convert.ToDouble(DR["VATPER"]) == 0))
            {
                SALE_RETURN_0 = (SALE_RETURN_0 + AMOUNT);
            }
            else if ((Convert.ToDouble(DR["VATPER"]) == 4.5))
            {
                SALE_RETURN_4_5 = (SALE_RETURN_4_5 + AMOUNT);
                VAT_4_5 = (VAT_4_5 + Convert.ToDouble(DR["VATAMOUNT"]));
            }
            else if ((Convert.ToDouble(DR["VATPER"]) == 13.5))
            {
                SALE_RETURN_13_5 = (SALE_RETURN_13_5 + AMOUNT);
                VAT_13_5 = (VAT_13_5 + Convert.ToDouble(DR["VATAMOUNT"]));
            }
            else if ((Convert.ToDouble(DR["VATPER"]) == 5))
            {
                SALE_RETURN_5 = (SALE_RETURN_5 + AMOUNT);
                VAT_5 = (VAT_5 + Convert.ToDouble(DR["VATAMOUNT"]));
            }
            else
            {
                SALE_RETURN_OTHER = (SALE_RETURN_OTHER + AMOUNT);
                VAT_OTHER = (VAT_OTHER + Convert.ToDouble(DR["VATAMOUNT"]));
            }
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
                txtTotalQty.Text = dt.Compute("SUM(QTY)", "").ToString();

                txtGrandTotal.Text = dt.Compute("SUM(NETAMOUNT)", "").ToString();
            }
            else
            {
                txtTotalAmount.Text = "0";
                txtTotalDiscount.Text = "0";
                txtTotalVat.Text = "0";
                txtTotalQty.Text = "0";
                txttotalpacking.Text = "0";
            }

            txtrevtotalamount.Text = "0";
            txttotalrevqty.Text = "0";


            // txtCtsAmt.Text = Math.Round(Val(txtGrandTotal.Text) - (Val(txtGrandTotal.Text) * (Val(txtCtsPerct.Text)) / 100), 2)
            txtfinalamount.Text = Math.Round(((Convert.ToDouble(txtGrandTotal.Text) - Convert.ToDouble(txtrevtotalamount.Text))), 2).ToString();
        }
        catch (Exception ex)
        {
        }

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

            impfunc.FILL_RECORD(impfunc.cnn, "ITEM_STOCK", "ITEMID=" + itemid, "CURRENTSTOCK", txtItemStock, "SALEPRICE", txtSalePrice, "VATPER", txtVatPer, "DISCPER", txtDisPer);

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


        private void frmSaleReturn_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            FILL_LISTBOX();
            FILL_SUPPLIER();
            cboParty_SelectionChangeCommitted(e, e);
            fill_Cateogry();
            cboCategory_SelectionChangeCommitted(e, e);
            impfunc._Adapter = new SqlDataAdapter("SELECT * FROM SALE_RETURN_SLAVE_VIEW WHERE SALE_RETURNSLAVEID=0", impfunc.cnn);
            impfunc._Adapter.Fill(dt);
            impfunc._Adapter.Fill(dtEdit);
            dg.AutoGenerateColumns = false;
            dg.DataSource = dt;
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
                CLEAR_CONT();
                impfunc.ADD_EDIT_FUNCTION("ADD", btnAdd, btnEdit, btnDelete, grpMaster, grpAmount, grpItem);
                grpSearch.Enabled = false;
                chksalebyepi.Enabled = false;
                chksalebyquot.Enabled = false;
                txtBillNo.Text = impfunc.GENERATE_MAX(impfunc.cnn, "SALE_RETURN_MASTER", "BILLNO", ("COMPANYID="
                                + (impfunc._COMPANYID + ""))).ToString();
                txtBillNo.Focus();
                return;
            }
            else
            {
                if ((impfunc.VALIDATION_BLANK(txtBillNo) == true))
                {
                    return;
                }

                if ((impfunc.VALIDATION_BLANK(cboParty) == true))
                {
                    return;
                }

                if ((dt.Rows.Count < 1))
                {
                    MessageBox.Show("There should be atleast one item to sale return !!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Question); ;
                    return;
                }

                if ((impfunc.EXISTS_RECORD(impfunc.cnn, "SALE_RETURN_MASTER", "BILLNO", ("BILLNO=\'"
                            + (txtBillNo.Text.Trim() + "\'")), false) == true))
                {
                    txtBillNo.Text = impfunc.GENERATE_MAX(impfunc.cnn, "SALE_RETURN_MASTER", "BILLNO", ("COMPANYID="
                                    + (impfunc._COMPANYID + ""))).ToString();
                }

                try
                {
                    txtRoundOff.Text = Math.Round((Math.Round(Convert.ToDouble(txtfinalamount.Text), 0) - Convert.ToDouble(txtfinalamount.Text)), 2).ToString();
             
                    impfunc._Command = new SqlCommand();
                    impfunc._Command.Connection = impfunc.cnn;
                    impfunc.OPENCONNECTION();
                    impfunc._TR = impfunc.cnn.BeginTransaction(IsolationLevel.ReadCommitted);
                    impfunc._Command.Transaction = impfunc._TR;
                    calc_vat();
                    impfunc.SAVE_RECORDS(impfunc.cnn, "SALE_RETURN_MASTER", impfunc._TR, "BILLNO", "BILLDATE", "LEDGERID", "FYEARID", "TOTALAMOUNT", "TOTALDISCOUNT", "TOTALVAT", "SUBTOTAL", "ROUNDOFF", "GRANDTOTAL", "SALE_RETURN_0", "SALE_RETURN_4_5", "SALE_RETURN_13_5", "SALE_RETURN_OTHER", "VAT_4_5", "VAT_13_5", "VAT_OTHER", "PARTYNAME", "ADDRESS", "CONTACTNO", "FINALAMOUNT", "SHOWBILLDATE", "COMPANYID", txtBillNo.Text, dtpBillDate.Value.Date.ToString("dd/MMM/yyyy"), cboParty.SelectedValue.ToString(), impfunc._FYEARID.ToString(), txtTotalAmount.Text, txtTotalDiscount.Text, txtTotalVat.Text, txtSubTotal.Text, txtRoundOff.Text, txtGrandTotal.Text, SALE_RETURN_0.ToString(), SALE_RETURN_4_5.ToString(), SALE_RETURN_13_5.ToString(), SALE_RETURN_OTHER.ToString(), VAT_4_5.ToString(), VAT_13_5.ToString(), VAT_OTHER.ToString(),  txtParty.Text, txtAddress.Text, txtMobileNo.Text, Math.Round(double.Parse(txtfinalamount.Text), 0).ToString(), (chkShowBillDate.Checked ? 1 : 0).ToString(), impfunc._COMPANYID.ToString());
                    MASTERID = Convert.ToInt32(impfunc.GET_ID_AFTER_SAVE(impfunc.cnn, "SALE_RETURN_MASTER", impfunc._TR));
                    for (int i = 0; (i
                                <= (dg.RowCount - 1)); i++)
                    {
                        impfunc.SAVE_RECORDS(impfunc.cnn, "SALE_RETURN_SLAVE", impfunc._TR, "SALE_RETURNMASTERID", "ITEMID", "QTY", "SALE_RETURNPRICE", "AMOUNT", "DISCOUNTPER", "DISCOUNT", "VATPER", "VATAMOUNT", "NETAMOUNT", MASTERID.ToString(), dg.Rows[i].Cells["colITEMID"].Value.ToString(), dg.Rows[i].Cells["colQTY"].Value.ToString(), dg.Rows[i].Cells["colSALE_RETURNPRICE"].Value.ToString(), dg.Rows[i].Cells["colAMOUNT"].Value.ToString(), dg.Rows[i].Cells["colDISPER"].Value.ToString(), dg.Rows[i].Cells["colDISCOUNT"].Value.ToString(), dg.Rows[i].Cells["colVATPER"].Value.ToString(), dg.Rows[i].Cells["colVAT"].Value.ToString(), dg.Rows[i].Cells["colNETAMOUNT"].Value.ToString());
                        impfunc.UPDATE_RECORDS(impfunc.cnn, "ITEM_STOCK", impfunc._TR, ("SET STOCKOUT=STOCKOUT-"
                                        + (dg.Rows[i].Cells["colQTY"].Value + (",CURRENTSTOCK=CURRENTSTOCK+"
                                        + (dg.Rows[i].Cells["colQTY"].Value + (",SALEPRICE="
                                        + (dg.Rows[i].Cells["colSALE_RETURNPRICE"].Value + (" WHERE ITEMID="
                                        + (dg.Rows[i].Cells["colITEMID"].Value )))))))));
                    }
                    if ((cboParty.Text == "CASH SALE_RETURN"))
                    {
                        int receiptno = 0;
                        int ID = 0;
                        receiptno = Convert.ToInt32(impfunc.GENERATE_MAX(impfunc.cnn, impfunc._TR, "RECEIPT_MASTER", "RECEIPTNO", ("COMPANYID="
                                            + (impfunc._COMPANYID + ""))));
                        impfunc.SAVE_RECORDS(impfunc.cnn, "RECEIPT_MASTER", impfunc._TR, "RECEIPTNO", "RECEIPTDATE", "LEDGERID", "PAYMODE", "CASHPAID", "TOTALPAID", "TABLENAME", "COMPANYID", receiptno.ToString(), dtpBillDate.Value.Date.ToString("dd/MMM/yyyy"), cboParty.SelectedValue.ToString(), "CASH", txtfinalamount.Text, txtfinalamount.Text, "SALE_RETURN_MASTER", impfunc._COMPANYID.ToString());
                        impfunc._ID = impfunc.GET_ID_AFTER_SAVE(impfunc.cnn, "RECEIPT_MASTER", impfunc._TR);
                        impfunc.SAVE_RECORDS(impfunc.cnn, "RECEIPT_SLAVE_SALE_RETURN", impfunc._TR, "RECEIPTMASTERID", "SALE_RETURNMASTERID", "PAIDAMOUNT", impfunc._ID.ToString(), MASTERID.ToString(), txtfinalamount.Text);
                    }
                    JOURNAL();
                    SHOWBILLDATE = Convert.ToInt32(impfunc.GET_ONEFIELD(impfunc.cnn, impfunc._TR, "SALE_RETURN_MASTER_VIEW", "SHOWBILLDATE", ("SALE_RETURNMASTERID=" + MASTERID)));
                    impfunc._TR.Commit();
                    impfunc.CLOSECONNECTION();
              
                    BILLMASTERID = MASTERID;
                    btnReset_Click(e, e);
                    //if ((MsgBox(("SAVED SUCCESSFULLY !!" + ("\r\n" + " DO YOU WANT TO VIEW BILL ?")), MsgBoxStyle.YesNo, "Infotech Consultants") == MsgBoxResult.Yes))
                    //{
                    //    frmReportFullPage frm = new frmReportFullPage();
                    //    Check_ChildForm(Mainform);
                    //    Add_ChildAtTab(frm, Mainform);
                    //    ViewReport(frm.cr, "SALE_RETURNBILL.rpt", "", false, frm, ("SALE_RETURNMASTERID=" + BILLMASTERID), ("SHOWBILLDATE=" + SHOWBILLDATE));
                    //}

                }
                catch (Exception ex)
                { 
                    impfunc._TR.Rollback();
                    impfunc.CLOSECONNECTION();
                    //SHOW_PLEASE_WAIT(false);
                    //MsgBox(("Following error Occured :: " + ex.Message), MsgBoxStyle.Critical, "Infotech Consultants");
                }

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            impfunc.ADD_EDIT_FUNCTION("RESET", btnAdd, btnEdit, btnDelete, grpMaster, grpItem, grpAmount);
            CLEAR_CONT();
            FILL_SUPPLIER();
            cboParty_SelectionChangeCommitted(e, e);
            fill_Cateogry();
            cboCategory_SelectionChangeCommitted(e, e);
       
            chksalebyquot.Checked = false;
            FILL_LISTBOX();
            btnAdd.Focus();
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

            DR["SALE_RETURNPRICE"] = Convert.ToDouble(txtSalePrice.Text);
            DR["QTY"] = Convert.ToDouble(txtQty.Text);
            DR["AMOUNT"] = Convert.ToDouble(txtAmount.Text);
            DR["DISCOUNTPER"] = Convert.ToDouble(txtDisPer.Text);
            DR["DISCOUNT"] = Convert.ToDouble(txtDiscount.Text);
            DR["VATPER"] = Convert.ToDouble(txtVatPer.Text);
            DR["VATAMOUNT"] = Convert.ToDouble(txtVat.Text);
            DR["NETAMOUNT"] = Convert.ToDouble(txtNetAmount.Text);
            DR["SSUBCATEGORY_ID"] = ssubcatid;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            impfunc.Remove_Child(this);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            impfunc.Remove_Child(this);
        }

        private void lstBox_Click(object sender, EventArgs e)
        {
            try
            {
              
                    MASTERID = Convert.ToInt32(lstBox.SelectedValue);
               

                fill_edit();
                CALC_TOTAL();
            }
            catch (Exception ex)
            {
            }
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

        private void dtpMonthSearch_ValueChanged(object sender, EventArgs e)
        {
            FILL_LISTBOX();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((impfunc.VALIDATION_BLANK(txtBillNo) == true))
            {
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Sure, You want to delete Record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    EXIST_COUNT = Convert.ToInt32(impfunc.GET_ONEFIELD(impfunc.cnn, "SALE_RETURN_MASTER", "COUNT(SALE_RETURNMASTERID)", ("SALE_RETURNMASTERID=" + MASTERID)));
                    if ((EXIST_COUNT != 1))
                    {

                        MessageBox.Show("Please select bill properly !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // SHOW_PLEASE_WAIT(true);
                    impfunc._Command = new SqlCommand();
                    impfunc._Command.Connection = impfunc.cnn;
                    impfunc.OPENCONNECTION();
                    impfunc._TR = impfunc.cnn.BeginTransaction(IsolationLevel.ReadCommitted);
                    impfunc._Command.Transaction = impfunc._TR;
                    foreach (DataRow DR in dtEdit.Rows)
                    {
                        impfunc.UPDATE_RECORDS(impfunc.cnn, "ITEM_STOCK", impfunc._TR, ("SET STOCKIN=STOCKIN+"
                                        + (DR["QTY"] + (",CURRENTSTOCK=CURRENTSTOCK-"
                                        + (DR["QTY"] + (" WHERE ITEMID="
                                        + (DR["ITEMID"])))))));
                    }

                    impfunc.DELETE_RECORDS(impfunc.cnn, "SALE_RETURN_MASTER", impfunc._TR, "SALE_RETURNMASTERID", MASTERID);
                    impfunc.DELETE_RECORDS(impfunc.cnn, "SALE_RETURN_SLAVE", impfunc._TR, "SALE_RETURNMASTERID", MASTERID);
                    impfunc.DELETE_FROM_JOURNAL(impfunc.cnn, impfunc._TR, ("VTYPE='SALE_RETURN' AND TRANSACTIONID=" + MASTERID));
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if ((impfunc.VALIDATION_BLANK(txtBillNo) == true))
            {
                return;
            }

            if ((btnEdit.Text == "Edit(F4)"))
            {
                impfunc.ADD_EDIT_FUNCTION("EDIT", btnAdd, btnEdit, btnDelete, grpMaster, grpAmount, grpItem);
                txtBillNo.Focus();
            }
            else
            {
                if ((impfunc.VALIDATION_BLANK(txtBillNo) == true))
                {
                    return;
                }

                if ((impfunc.VALIDATION_BLANK(cboParty) == true))
                {
                    return;
                }

                if ((dt.Rows.Count < 1))
                {
                    MessageBox.Show("There should be atleast one item to SALE_RETURN !! ?", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
                    return;
                }

                EXIST_COUNT = Convert.ToInt32(impfunc.GET_ONEFIELD(impfunc.cnn, "SALE_RETURN_MASTER", "COUNT(SALE_RETURNMASTERID)", ("COMPANYID="
                                    + (impfunc._COMPANYID + (" AND SALE_RETURNMASTERID=" + MASTERID)))));
                if ((EXIST_COUNT != 1))
                {
              
                    MessageBox.Show("Please select bill properly !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if ((impfunc.EXISTS_RECORD(impfunc.cnn, "SALE_RETURN_MASTER", "BILLNO", ("COMPANYID="
                                + (impfunc._COMPANYID + (" AND BILLNO=\'"
                                + (txtBillNo.Text.Trim() + ("\' AND SALE_RETURNMASTERID<>" + MASTERID))))), false) == true))
                {
                    txtBillNo.Focus();
                    return;
                }

                try
                {
                    txtRoundOff.Text = Math.Round((Math.Round(Convert.ToDouble(txtfinalamount.Text), 0) - Convert.ToDouble(txtfinalamount.Text)), 2).ToString();

                    impfunc._Command = new SqlCommand();
                    impfunc._Command.Connection = impfunc.cnn;
                    impfunc.OPENCONNECTION();
                    impfunc._TR = impfunc.cnn.BeginTransaction(IsolationLevel.ReadCommitted);
                    impfunc._Command.Transaction = impfunc._TR;
                    calc_vat();
                    foreach (DataRow DR in dtEdit.Rows)
                    {
                        impfunc.UPDATE_RECORDS(impfunc.cnn, "ITEM_STOCK", impfunc._TR, ("SET STOCKOUT=STOCKOUT+"
                                        + (DR["QTY"] + (",CURRENTSTOCK=CURRENTSTOCK-"
                                        + (DR["QTY"] + (" WHERE ITEMID="
                                        + (DR["ITEMID"] )))))));
                    }

                    impfunc.UPDATE_RECORDS(impfunc.cnn, "SALE_RETURN_MASTER", impfunc._TR, "BILLNO", "BILLDATE", "LEDGERID", "FYEARID", "TOTALAMOUNT", "TOTALDISCOUNT", "TOTALVAT", "SUBTOTAL", "ROUNDOFF", "GRANDTOTAL", "SALE_RETURN_0", "SALE_RETURN_4_5", "SALE_RETURN_13_5", txtBillNo.Text, dtpBillDate.Value.Date.ToString("dd/MMM/yyyy"), cboParty.SelectedValue.ToString(), impfunc._FYEARID.ToString(), txtTotalAmount.Text, txtTotalDiscount.Text, txtTotalVat.Text, txtSubTotal.Text, txtRoundOff.Text, txtGrandTotal.Text, SALE_RETURN_0.ToString(), SALE_RETURN_4_5.ToString(), SALE_RETURN_13_5.ToString(), "SALE_RETURNMASTERID", MASTERID);
                    impfunc.UPDATE_RECORDS(impfunc.cnn, "SALE_RETURN_MASTER", impfunc._TR, "SALE_RETURN_OTHER", "VAT_4_5", "VAT_13_5", "VAT_OTHER", "PARTYNAME", "ADDRESS", "CONTACTNO", "FINALAMOUNT", "SHOWBILLDATE", "COMPANYID", SALE_RETURN_OTHER.ToString(), VAT_4_5.ToString(), VAT_13_5.ToString(), VAT_OTHER.ToString(), txtParty.Text, txtAddress.Text, txtMobileNo.Text, Math.Round(double.Parse(txtfinalamount.Text), 0).ToString(), (chkShowBillDate.Checked ? 1 : 0).ToString(), impfunc._COMPANYID.ToString(), "SALE_RETURNMASTERID", MASTERID);

                    impfunc.DELETE_RECORDS(impfunc.cnn, "SALE_RETURN_SLAVE", impfunc._TR, "SALE_RETURNMASTERID", MASTERID);
              
                    //if ((cboParty.Text == "CASH SALE_RETURN"))
                    //{
                    //    int receiptno = 0;
                    //    int ID = 0;
                    //    receiptno = Convert.ToInt32(impfunc.GENERATE_MAX(impfunc.cnn, impfunc._TR, "RECEIPT_MASTER", "RECEIPTNO", ("COMPANYID="
                    //                        + (impfunc._COMPANYID + ""))));
                    //    impfunc.SAVE_RECORDS(impfunc.cnn, "RECEIPT_MASTER", impfunc._TR, "RECEIPTNO", "RECEIPTDATE", "LEDGERID", "PAYMODE", "CASHPAID", "TOTALPAID",  "TABLENAME", "COMPANYID", receiptno.ToString(), dtpBillDate.Value.Date.ToString("dd/MMM/yyyy"), cboParty.SelectedValue.ToString(), "CASH", txtfinalamount.Text, txtfinalamount.Text, "SALE_RETURN_MASTER",impfunc._COMPANYID.ToString());
                    //    impfunc._ID = impfunc.GET_ID_AFTER_SAVE(impfunc.cnn, "RECEIPT_MASTER", impfunc._TR);
                    //    impfunc.SAVE_RECORDS(impfunc.cnn, "RECEIPT_SLAVE_SALE_RETURN", impfunc._TR, "RECEIPTMASTERID", "SALE_RETURNMASTERID", "PAIDAMOUNT", impfunc._ID.ToString(), MASTERID.ToString(),txtfinalamount.Text);
                    //}

                    for (int i = 0; (i
                                <= (dg.RowCount - 1)); i++)
                    {
                        impfunc.SAVE_RECORDS(impfunc.cnn, "SALE_RETURN_SLAVE", impfunc._TR, "SALE_RETURNMASTERID", "ITEMID", "QTY", "SALE_RETURNPRICE", "AMOUNT", "DISCOUNTPER", "DISCOUNT", "VATPER", "VATAMOUNT", "NETAMOUNT", MASTERID.ToString(), dg.Rows[i].Cells["colITEMID"].Value.ToString(), dg.Rows[i].Cells["colQTY"].Value.ToString(), dg.Rows[i].Cells["colSALE_RETURNPRICE"].Value.ToString(), dg.Rows[i].Cells["colAMOUNT"].Value.ToString(), dg.Rows[i].Cells["colDISPER"].Value.ToString(), dg.Rows[i].Cells["colDISCOUNT"].Value.ToString(), dg.Rows[i].Cells["colVATPER"].Value.ToString(), dg.Rows[i].Cells["colVAT"].Value.ToString(), dg.Rows[i].Cells["colNETAMOUNT"].Value.ToString());
                        impfunc.UPDATE_RECORDS(impfunc.cnn, "ITEM_STOCK", impfunc._TR, ("SET STOCKOUT=STOCKOUT-"
                                        + (dg.Rows[i].Cells["colQTY"].Value + (",CURRENTSTOCK=CURRENTSTOCK+"
                                        + (dg.Rows[i].Cells["colQTY"].Value + (",SALEPRICE="
                                        + (dg.Rows[i].Cells["colSALE_RETURNPRICE"].Value + (" WHERE ITEMID="
                                        + (dg.Rows[i].Cells["colITEMID"].Value)))))))));
                    }

                    impfunc.DELETE_FROM_JOURNAL(impfunc.cnn, impfunc._TR, ("VTYPE=\'SALE_RETURN\' AND TRANSACTIONID=" + MASTERID));
                    JOURNAL();
                    SHOWBILLDATE = Convert.ToInt32(impfunc.GET_ONEFIELD(impfunc.cnn, impfunc._TR, "SALE_RETURN_MASTER_VIEW", "SHOWBILLDATE", ("SALE_RETURNMASTERID=" + MASTERID)));
                    impfunc._TR.Commit();
                    impfunc.CLOSECONNECTION();
                  
                    BILLMASTERID = MASTERID;
                    btnReset_Click(e, e);
                    //if ((MsgBox(("SAVED SUCCESSFULLY !!" + ("\r\n" + " DO YOU WANT TO VIEW BILL ?")), MsgBoxStyle.YesNo, "Infotech Consultants") == MsgBoxResult.Yes))
                    //{
                    //    frmReportFullPage frm = new frmReportFullPage();
                    //    Check_ChildForm(Mainform);
                    //    Add_ChildAtTab(frm, Mainform);
                    //    ViewReport(frm.cr, "SALE_RETURNBILL.rpt", "", false, frm, ("SALE_RETURNMASTERID=" + BILLMASTERID), ("SHOWBILLDATE=" + SHOWBILLDATE));
                    //}

                    btnReset_Click(e, e);
                }
                catch (Exception ex)
                {
                    impfunc._TR.Rollback();
                    impfunc.CLOSECONNECTION();
                    MessageBox.Show(("ERROR: " + (ex.Message + ("\r\n" + "PLEASE CONTACT Mr. Amit Tiwari"))));
                }

            }
        }
    }
}