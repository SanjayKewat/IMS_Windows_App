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
    public partial class frmSaleReceipt : Form
    {
        public frmSaleReceipt()
        {
            InitializeComponent();
        }
        ReportFunc rptfunc = new ReportFunc();
        public int MASTERID=0, EXIST_COUNT=0, SALEMASTERID=0;
        DataTable DT = new DataTable();
        DataTable DTEDIT = new DataTable();
        DataView DV;
//=====================================================================Functions======================================================================================
        void FILL_LISTBOX()
        {
            try
            {
                txtRechargeNoSearch.Visible = false;
                dtpMonthSearch.Visible = false;
                CboPartySearch.Visible = false;
                if ((rdoRechargeNo.Checked == true))
                {
                    if ((txtRechargeNoSearch.Text.Trim() == ""))
                    {
                        impfunc.FILL_LISTBOX_DISTINCT(impfunc.cnn, lstBox, "RECEIPT_MASTER", "RECEIPTNO", "RECEIPTMASTERID", ("COMPANYID="
                                        + (impfunc._COMPANYID + " AND TABLENAME=\'SALE_MASTER\'")));
                    }
                    else
                    {
                        impfunc.FILL_LISTBOX_DISTINCT(impfunc.cnn, lstBox, "RECEIPT_MASTER", "RECEIPTNO", "RECEIPTMASTERID", ("COMPANYID="
                                        + (impfunc._COMPANYID + (" AND TABLENAME=\'SALE_MASTER\' AND RECEIPTNO LIKE \'%"
                                        + (txtRechargeNoSearch.Text + "%\'")))));
                    }

                    txtRechargeNoSearch.Visible = true;
                }
                else if ((rdoDate.Checked == true))
                {
                    impfunc.FILL_LISTBOX_DISTINCT(impfunc.cnn, lstBox, "RECEIPT_MASTER", "RECEIPTNO", "RECEIPTMASTERID", ("COMPANYID="
                                    + (impfunc._COMPANYID + (" AND TABLENAME=\'SALE_MASTER\' AND MONTH(RECEIPTDATE)="
                                    + (dtpMonthSearch.Value.Month + (" AND YEAR(RECEIPTDATE)=" + dtpMonthSearch.Value.Year))))));
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

                    impfunc.FILL_LISTBOX_DISTINCT(impfunc.cnn, lstBox, "RECEIPT_MASTER", "RECEIPTNO", "RECEIPTMASTERID", ("COMPANYID="
                                    + (impfunc. _COMPANYID + (" AND TABLENAME=\'SALE_MASTER\' AND LEDGERID=" + CboPartySearch.SelectedValue))));
                }

            }
            catch (Exception ex)
            {
                // MsgBox(ex.Message)
            }

        }


        void SAVE_JOURNAL()
        {
            int VNO = impfunc.GENERATE_MAX(impfunc.cnn, impfunc._TR, "JOURNAL", "VNO", "VTYPE=\'SALE RECEIPT\'");
            // _COMPANYID = 1
            if (Convert.ToDouble(txtTotalPaid.Text) > 0)
            {
                impfunc.SAVE_IN_JOURNAL(impfunc.cnn, impfunc._TR, impfunc._COMPANYID, Convert.ToInt32(cboParty.SelectedValue), 1, dtpBillDate.Value.Date.ToString("dd/MMM/yyyy"), VNO, ("SALE RECEIPT AGAINST RECEIPTNO " + txtBillNo.Text), "SALE RECEIPT", "SALE RECEIPT", "0", txtTotalPaid.Text, MASTERID, VNO, impfunc._FYEARID, 0, "1/1/1990");
                if ((cboPaymode.Text == "CASH"))
                {
                    impfunc.SAVE_IN_JOURNAL(impfunc.cnn, impfunc._TR, impfunc._COMPANYID, 3, 2, dtpBillDate.Value.Date.ToString("dd/MMM/yyyy"), VNO, ("SALE RECEIPT AGAINST RECEIPTNO " + txtBillNo.Text), "SALE RECEIPT", "SALE RECEIPT", txtCashPaid.Text, "0", MASTERID, VNO, impfunc._FYEARID, 0, "1/1/1990");
                }
                else if ((cboPaymode.Text == "BANK"))
                {
                    impfunc.SAVE_IN_JOURNAL(impfunc.cnn, impfunc._TR, impfunc._COMPANYID, Convert.ToInt32(cboBank.SelectedValue), 4, dtpBillDate.Value.Date.ToString("dd/MMM/yyyy"), VNO, ("SALE RECEIPT AGAINST RECEIPTNO " + txtBillNo.Text), "SALE RECEIPT", "SALE RECEIPT", txtCardPaid.Text, "0", MASTERID, VNO, impfunc._FYEARID, 0, "1/1/1990");
                }
                else if ((cboPaymode.Text == "BOTH"))
                {
                    impfunc.SAVE_IN_JOURNAL(impfunc.cnn, impfunc._TR, impfunc._COMPANYID, 3, 2, dtpBillDate.Value.Date.ToString("dd/MMM/yyyy"), VNO, ("SALE RECEIPT AGAINST RECEIPTNO " + txtBillNo.Text), "SALE RECEIPT", "SALE RECEIPT", txtCashPaid.Text, "0", MASTERID, VNO, impfunc._FYEARID, 0, "1/1/1990");
                    impfunc.SAVE_IN_JOURNAL(impfunc.cnn, impfunc._TR, impfunc._COMPANYID, Convert.ToInt32(cboBank.SelectedValue), 3, dtpBillDate.Value.Date.ToString("dd/MMM/yyyy"), VNO, ("SALE RECEIPT AGAINST RECEIPTNO " + txtBillNo.Text), "SALE RECEIPT", "SALE RECEIPT", txtCardPaid.Text, "0", MASTERID, VNO, impfunc._FYEARID, 0, "1/1/1990");
                }

            }

        }

        void FILL_TABLE()
        {
            impfunc._Adapter = new SqlDataAdapter(("SELECT * FROM SALE_MASTER_TOTALPAID WHERE COMPANYID="
                            + (impfunc._COMPANYID + " AND BALANCE>0")), impfunc.cnn);
            impfunc._Adapter.Fill(DT);
            DV = new DataView(DT);
            dg.DataSource = DV;
        }

        void CLEAT_CONT()
        {
            txtDescription.Clear();
            txtSearch.Clear();
            txtBillNo.Clear();
            txtAmount.Text = "0";
            dtpBillDate.ResetText();
            txtChqNo.Clear();
            txtBranch.Clear();
            txtCashPaid.Clear();
            txtCardPaid.Clear();
            MASTERID = 0;
            DT.Rows.Clear();
            DTEDIT.Rows.Clear();
            dgEdit.Visible = false;
            cboParty.Enabled = true;
        }

        void FILL_COMBOBOX()
        {
            try
            {
                impfunc.FILL_COMBO_DISTINCT(impfunc.cnn, cboParty, "SALE_MASTER_VIEW", "NAME", "LEDGERID", ("COMPANYID="
                                + (impfunc._COMPANYID + "")));
                impfunc.FILL_COMBO(impfunc.cnn, cboBank, "LEDGER", "NAME", "LEDGERID", ("COMPANYID="
                                + (impfunc._COMPANYID + " AND LEDGERSUBGROUPID=4")));
                impfunc.FILL_COMBO_DISTINCT(impfunc.cnn, CboPartySearch, "RECEIPT_MASTER_VIEW", "NAME", "LEDGERID", ("COMPANYID="
                                + (impfunc._COMPANYID + "")));
            }
            catch (Exception ex)
            {
                MessageBox.Show(("ERROR: " + (ex.Message + ("\r\n" + "PLEASE CONTACT Mr. Amit Tiwari"))));
            }

        }

        void fill_edit()
          {
              try
              {

                  impfunc.FILL_RECORD(impfunc.cnn, "RECEIPT_MASTER_VIEW", ("RECEIPTMASTERID=" + MASTERID), "RECEIPTNO", txtBillNo, "RECEIPTDATE", dtpBillDate, "NAME", cboParty, "DESCRIPTION", txtDescription, "TOTALPAID", txtAmount, "PAYMODE", cboPaymode);
                  cboPaymode_SelectionChangeCommitted(null, null);
                  impfunc.FILL_RECORD(impfunc.cnn, "RECEIPT_MASTER_VIEW", ("RECEIPTMASTERID=" + MASTERID), "BANK", cboBank, "BRANCH", txtBranch, "CHQNO", txtChqNo, "CHQDATE", dtpCardDate, "CASHPAID", txtCashPaid, "CARDPAID", txtCardPaid, "TOTALPAID", txtTotalPaid);
                  dgEdit.Visible = true;
                  impfunc._Adapter = new SqlDataAdapter(("SELECT * FROM RECEIPT_SLAVE_SALE_VIEW WHERE RECEIPTMASTERID=" + MASTERID), impfunc.cnn);
                  DTEDIT.Rows.Clear();
                  impfunc._Adapter.Fill(DTEDIT);
                  dgEdit.DataSource = DTEDIT;
                  for (int i = 0; i <= DTEDIT.Rows.Count - 1; i++)
                  {

                      dgEdit.Rows[i].Cells[0].Value = true;

                  }
              }
              catch (Exception ex)
              {
                  MessageBox.Show(("ERROR: " + (ex.Message + ("\r\n" + "PLEASE CONTACT Mr. Amit Tiwari"))));
              }
    
}
//===========================================================================================================================================================
        private void frmSaleReceipt_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            rdoRechargeNo.Focus();
            dg.AutoGenerateColumns = false;
            dgEdit.AutoGenerateColumns = false;
            btnReset_Click(e, e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
           impfunc.CLOSECONNECTION();
           impfunc.ADD_EDIT_FUNCTION("RESET", btnAdd, btnEdit, btnDelete, grpContainer, GroupBox1, grpPayMent);
            FILL_COMBOBOX();
            CLEAT_CONT();
            FILL_LISTBOX();
            cboPaymode.Text = "Cash";
            cboBank.Enabled = false;
            dtpCardDate.Enabled = false;
            txtBranch.ReadOnly = true;
            txtCardPaid.ReadOnly = true;
            txtChqNo.ReadOnly = true;
            cboBank.TabStop = false;
            dtpCardDate.TabStop = false;
            txtBranch.TabStop = false;
            txtCardPaid.TabStop = false;
            txtChqNo.TabStop = false;
            btnAdd.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            impfunc.Remove_Child(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (impfunc.VALIDATION_BLANK(txtBillNo) == true)
            {
                return;
            }
            DialogResult dialogResult = MessageBox.Show("ARU YOU SURE YOU WANT TO DELETE THIS RECORD ??", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    impfunc._Command = new SqlCommand();
                    impfunc._Command.Connection = impfunc.cnn;
                    impfunc.OPENCONNECTION();
                    impfunc._TR = impfunc.cnn.BeginTransaction(IsolationLevel.ReadCommitted);
                    impfunc._Command.Transaction = impfunc._TR;
                    // For I As Integer = 0 To DTEDIT.Rows.Count - 1
                    //     UPDATE_RECORDS(cnn, "SALE_MASTER", _TR, "PAIDSTATUS", 0, "SALEMASTERID", dgEdit.Rows(I).Cells("colSaleMasterIdEdit").Value)
                    // Next
                    impfunc.DELETE_RECORDS(impfunc.cnn, "RECEIPT_MASTER", impfunc._TR, "RECEIPTMASTERID", MASTERID);
                    impfunc.DELETE_RECORDS(impfunc.cnn, "RECEIPT_SLAVE_SALE", impfunc._TR, "RECEIPTMASTERID", MASTERID);
                    impfunc.DELETE_FROM_JOURNAL(impfunc.cnn, impfunc._TR, "VTYPE='SALE RECEIPT' and TRANSACTIONID =" + MASTERID + "");
                    impfunc._TR.Commit();

                    MessageBox.Show("Receipt successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnReset_Click(e, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(("ERROR: " + (ex.Message + ("\r\n" + "PLEASE CONTACT Mr. Amit Tiwari"))));
                    impfunc._TR.Rollback();
                }
                finally
                {
                    impfunc.CLOSECONNECTION();
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
            if (impfunc.VALIDATION_BLANK(txtBillNo) == true)
            {
                return;
            }

            if ((btnEdit.Text == "Edit(F4)"))
            {
                impfunc.ADD_EDIT_FUNCTION("EDIT", btnAdd, btnEdit, btnDelete, grpContainer, GroupBox1, grpPayMent);
                cboParty.Enabled = false;
                txtBillNo.Focus();
            }
            else
            {
                if (impfunc.VALIDATION_BLANK(cboParty) == true)
                {
                    cboParty.Focus();
                    return;
                }

                if ((double.Parse(txtAmount.Text) == 0))
                {
                    MessageBox.Show("Please select atleast one Bill.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dg.Focus();
                    return;
                }

                if ((double.Parse(txtTotalPaid.Text) < 1))
                {
                    MessageBox.Show("Paid amount must be greater than zero.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCashPaid.Focus();
                    return;
                }

                int counter = 0;
                for (int i = 0; (i
                            <= (DTEDIT.Rows.Count - 1)); i++)
                {
                    if ((dgEdit.Rows[i].Cells[0].Value != null))
                    {
                        counter++;
                    }

                }
                if ((counter > 1))
                {
                    if ((double.Parse(txtBalance.Text) > 0))
                    {
                        MessageBox.Show("Paid amount must be equal to Net Amount.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCashPaid.Focus();
                        return;
                    }

                }
                EXIST_COUNT = Convert.ToInt32(impfunc.GET_ONEFIELD(impfunc.cnn, "RECEIPT_MASTER", "COUNT(RECEIPTMASTERID)", ("RECEIPTMASTERID=" + MASTERID)));
                if ((EXIST_COUNT != 1))
                {

                    MessageBox.Show("Please select bill properly !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if ((impfunc.EXISTS_RECORD(impfunc.cnn, "RECEIPT_MASTER", "RECEIPTNO", ("COMPANYID="
                                 + (impfunc._COMPANYID + (" AND RECEIPTNO="
                                 + (txtBillNo.Text.Trim() + (" and RECEIPTMASTERID<>" + MASTERID))))), false) == true))
                {
                    txtBillNo.Text = impfunc.GENERATE_MAX(impfunc.cnn, "RECEIPT_MASTER", "RECEIPTNO", ("COMPANYID="
                                    + (impfunc._COMPANYID + ""))).ToString();
                }

                

                try
                {
                    int LEDGERBANKID=0;
                    if ((cboPaymode.Text == "CASH"))
                    {
                        LEDGERBANKID = 4;
                    }
                    else if ((cboPaymode.Text == "BANK"))
                    {
                        if ((impfunc.VALIDATION_BLANK(cboBank) == true))
                        {
                            return;
                        }

                        LEDGERBANKID = Convert.ToInt32(cboBank.SelectedValue);
                    }
                    else if ((cboPaymode.Text == "BOTH"))
                    {
                        if ((impfunc.VALIDATION_BLANK(cboBank) == true))
                        {
                            return;
                        }

                        LEDGERBANKID = Convert.ToInt32(cboBank.SelectedValue);
                    }

                    impfunc._Command = new SqlCommand();
                    impfunc._Command.Connection = impfunc.cnn;
                    impfunc.OPENCONNECTION();
                    impfunc._TR = impfunc.cnn.BeginTransaction(IsolationLevel.ReadCommitted);
                    impfunc._Command.Transaction = impfunc._TR;
                    impfunc.UPDATE_RECORDS(impfunc.cnn, "RECEIPT_MASTER", impfunc._TR, "RECEIPTNO", "RECEIPTDATE", "LEDGERID", "DESCRIPTION", "PAYMODE", "BANKID", "BRANCH", "CHQNO", "CHQDATE", "CASHPAID", "CARDPAID", "TOTALPAID",  txtBillNo.Text, dtpBillDate.Value.Date.ToString("dd/MMM/yyyy"), cboParty.SelectedValue.ToString(), txtDescription.Text, cboPaymode.Text, LEDGERBANKID.ToString(), txtBranch.Text.Trim(), txtChqNo.Text.Trim(), dtpCardDate.Value.Date.ToString("dd/MMM/yyyy"), txtCashPaid.Text, txtCardPaid.Text,txtTotalPaid.Text,  "RECEIPTMASTERID", MASTERID);
                    impfunc.DELETE_RECORDS(impfunc.cnn, "RECEIPT_SLAVE_SALE", impfunc._TR, "RECEIPTMASTERID", MASTERID);
                    for (int I = 0; (I
                                <= (DTEDIT.Rows.Count - 1)); I++)
                    {
                        if ((dgEdit.Rows[I].Cells[0].Value != null))
                        {
                            impfunc.SAVE_RECORDS(impfunc.cnn, "RECEIPT_SLAVE_SALE", impfunc._TR, "RECEIPTMASTERID", "SALEMASTERID", "PAIDAMOUNT", MASTERID.ToString(), dgEdit.Rows[I].Cells["colSaleMasterIdEdit"].Value.ToString(), ((counter > 1) ? dgEdit.Rows[I].Cells["colPaidByThisReceipt"].Value : Convert.ToDouble(txtTotalPaid.Text)).ToString());
                            // If counter > 1 Or Val(txtBalance.Text) < 1 Then
                            //     UPDATE_RECORDS(cnn, "SALE_MASTER", _TR, "PAIDSTATUS", 1, "SALEMASTERID", dgEdit.Rows(I).Cells("colSaleMasterIdEdit").Value)
                            // End If
                            // Else
                            //     UPDATE_RECORDS(cnn, "SALE_MASTER", _TR, "PAIDSTATUS", 0, "SALEMASTERID", dgEdit.Rows(I).Cells("colSaleMasterIdEdit").Value)
                        }

                    }

                    impfunc.DELETE_FROM_JOURNAL(impfunc.cnn, impfunc._TR, ("VTYPE=\'SALE RECEIPT\' and TRANSACTIONID =" + MASTERID));
                    SAVE_JOURNAL();
                    impfunc._TR.Commit();
                    //frmReportFullPage frm = new frmReportFullPage();
                    //Check_ChildForm(Mainform);
                    //ViewReport(frm.cr, "RECEIPT.rpt", "", false, frm, ("RECEIPTMASTERID=" + MASTERID));
                    //Add_ChildAtTab(frm, Mainform);
                    btnReset_Click(e, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(("ERROR: " + (ex.Message + ("\r\n" + "PLEASE CONTACT Mr. Amit Tiwari"))));
                    impfunc._TR.Rollback();
                }
                finally
                {
                    impfunc.CLOSECONNECTION();
                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((btnAdd.Text == "Add(F3)"))
            {
               impfunc.ADD_EDIT_FUNCTION("ADD", btnAdd, btnEdit, btnDelete, grpContainer, GroupBox1, grpPayMent);
                CLEAT_CONT();
                txtBillNo.Text = impfunc.GENERATE_MAX(impfunc.cnn, "RECEIPT_MASTER", "RECEIPTNO", ("COMPANYID="
                                + (impfunc._COMPANYID + ""))).ToString();
                txtBillNo.Focus();
                FILL_TABLE();
                if (Convert.ToInt32(cboParty.SelectedValue) > 0)
                {
                    cboParty_SelectionChangeCommitted(e, e);
                }

            }
            else
            {
                if ((impfunc.VALIDATION_BLANK(cboParty) == true))
                {
                    cboParty.Focus();
                    return;
                }

                if ((double.Parse(txtAmount.Text) == 0))
                {
                    MessageBox.Show("Please select atleast one Bill.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                    dg.Focus();
                    return;
                }

                if ((double.Parse(txtTotalPaid.Text) < 1))
                {
                    MessageBox.Show("Paid amount must be greater than zero..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCashPaid.Focus();
                    return;
                }


                int counter = 0;
                for (int i = 0; (i
                            <= (DV.Count - 1)); i++)
                {
                    if ((dg.Rows[i].Cells[0].Value != null))
                    {
                        counter++;
                    }

                }

                if ((counter > 1))
                {
                    if ((double.Parse(txtBalance.Text) > 0))
                    {
                        MessageBox.Show("Paid amount must be equal to Net Amount.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCashPaid.Focus();
                        return;
                    }

                }

                if ((impfunc.EXISTS_RECORD(impfunc.cnn, "RECEIPT_MASTER", "RECEIPTNO", ("COMPANYID="
                                + (impfunc._COMPANYID + (" AND RECEIPTNO="
                                + (txtBillNo.Text.Trim() + "")))), false) == true))
                {
                    txtBillNo.Text = impfunc.GENERATE_MAX(impfunc.cnn, "RECEIPT_MASTER", "RECEIPTNO", ("COMPANYID="
                                    + (impfunc._COMPANYID + ""))).ToString();
                }

                try
                {
                    int LEDGERBANKID=0;
                    if ((cboPaymode.Text == "CASH"))
                    {
                        LEDGERBANKID = 4;
                    }
                    else if ((cboPaymode.Text == "BANK"))
                    {
                        if ((impfunc.VALIDATION_BLANK(cboBank) == true))
                        {
                            return;
                        }

                        LEDGERBANKID = Convert.ToInt32(cboBank.SelectedValue);
                    }
                    else if ((cboPaymode.Text == "BOTH"))
                    {
                        if ((impfunc.VALIDATION_BLANK(cboBank) == true))
                        {
                            return;
                        }

                        LEDGERBANKID = Convert.ToInt32(cboBank.SelectedValue);
                    }

                    impfunc._Command = new SqlCommand();
                    impfunc._Command.Connection = impfunc.cnn;
                    impfunc.OPENCONNECTION();
                    impfunc._TR = impfunc.cnn.BeginTransaction(IsolationLevel.ReadCommitted);
                    impfunc._Command.Transaction = impfunc._TR;
                    impfunc.SAVE_RECORDS(impfunc.cnn, "RECEIPT_MASTER", impfunc._TR, "RECEIPTNO", "RECEIPTDATE", "LEDGERID", "DESCRIPTION", "PAYMODE", "BANKID", "BRANCH", "CHQNO", "CHQDATE", "CASHPAID", "CARDPAID", "TOTALPAID", "TABLENAME", "COMPANYID", txtBillNo.Text, dtpBillDate.Value.Date.ToString("dd/MMM/yyyy"), cboParty.SelectedValue.ToString(), txtDescription.Text, cboPaymode.Text, LEDGERBANKID.ToString(), txtBranch.Text.Trim().ToString(), txtChqNo.Text.Trim().ToString(), dtpCardDate.Value.Date.ToString("dd/MMM/yyyy"), txtCashPaid.Text, txtCardPaid.Text, txtTotalPaid.Text, "SALE_MASTER", impfunc._COMPANYID.ToString());
                    MASTERID = Convert.ToInt32(impfunc.GET_ID_AFTER_SAVE(impfunc.cnn, "RECEIPT_MASTER", impfunc._TR));
                    for (int I = 0; (I
                                  <= (DV.Count - 1)); I++)
                    {
                        if ((dg.Rows[I].Cells[0].Value != null))
                        {
                            impfunc.SAVE_RECORDS(impfunc.cnn, "RECEIPT_SLAVE_SALE", impfunc._TR, "RECEIPTMASTERID", "SALEMASTERID", "PAIDAMOUNT", MASTERID.ToString(), dg.Rows[I].Cells["colSaleMasterId"].Value.ToString(), ((counter > 1) ? dg.Rows[I].Cells["colBalance"].Value : Convert.ToDouble(txtTotalPaid.Text)).ToString());
                            // If counter > 1 Or Val(txtBalance.Text) < 1 Then
                            //     UPDATE_RECORDS(cnn, "SALE_MASTER", _TR, "PAIDSTATUS", 1, "SALEMASTERID", dg.Rows(I).Cells("colSaleMasterId").Value)
                            // End If
                        }

                    }

                    SAVE_JOURNAL();
                    impfunc._TR.Commit();
                    //frmReportFullPage frm = new frmReportFullPage();
                    //Check_ChildForm(Mainform);
                    //ViewReport(frm.cr, "RECEIPT.rpt", "", false, frm, ("RECEIPTMASTERID=" + MASTERID));
                    //Add_ChildAtTab(frm, Mainform);
                    this.Tag = "";
                    SALEMASTERID = 0;
                    btnReset_Click(e, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(("ERROR: " + (ex.Message + ("\r\n" + "PLEASE CONTACT Mr. Amit Tiwari"))));
                    impfunc._TR.Rollback();
                }
                finally
                {
                   impfunc.CLOSECONNECTION();
                }

            }
        }

        private void cboPaymode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtCashPaid.Clear();
            txtCardPaid.Clear();
            txtChqNo.Clear();
            txtBranch.Clear();
            try
            {
                if ((cboPaymode.Text == "CASH"))
                {
                    cboBank.Enabled = false;
                    dtpCardDate.Enabled = false;
                    txtBranch.ReadOnly = true;
                    txtCardPaid.ReadOnly = true;
                    txtChqNo.ReadOnly = true;
                    cboBank.TabStop = false;
                    dtpCardDate.TabStop = false;
                    txtBranch.TabStop = false;
                    txtCardPaid.TabStop = false;
                    txtChqNo.TabStop = false;
                    txtCashPaid.ReadOnly = false;
                    txtCashPaid.TabStop = true;
                }
                else if ((cboPaymode.Text == "BANK"))
                {
                    cboBank.Enabled = true;
                    dtpCardDate.Enabled = true;
                    txtBranch.ReadOnly = false;
                    txtCardPaid.ReadOnly = false;
                    txtChqNo.ReadOnly = false;
                    txtCashPaid.ReadOnly = true;
                    txtCashPaid.TabStop = false;
                    cboBank.TabStop = true;
                    dtpCardDate.TabStop = true;
                    txtBranch.TabStop = true;
                    txtCardPaid.TabStop = true;
                    txtChqNo.TabStop = true;
                }
                else if ((cboPaymode.Text == "BOTH"))
                {
                    cboBank.Enabled = true;
                    dtpCardDate.Enabled = true;
                    txtBranch.ReadOnly = false;
                    txtCardPaid.ReadOnly = false;
                    txtChqNo.ReadOnly = false;

                    txtCashPaid.ReadOnly = false;
                    txtCashPaid.TabStop = true;
                    cboBank.TabStop = true;
                    dtpCardDate.TabStop = true;
                    txtBranch.TabStop = true;
                    txtCardPaid.TabStop = true;
                    txtChqNo.TabStop = true;
                }

            }
            catch (Exception ex)
            {
            }
        }

        private void cboParty_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtSearch.Clear();
            DV.RowFilter = ("LEDGERID=" + cboParty.SelectedValue);
        }

        private void frmSaleReceipt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                impfunc.NEXTTAB(this, e);
            }
            else if (e.KeyCode == Keys.F3)
            {
                if (btnAdd.Enabled == true)
                {
                    btnAdd_Click(e, e);
                }
            }
            else if ((e.KeyCode == Keys.F8))
            {
                if ((btnAdd.Enabled == true))
                {
                    btnAdd_Click(e, e);
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
                btnClose_Click(e, e);
            }
            else if ((e.KeyCode == Keys.F2))
            {
                txtSearch.Focus();
            }
        }

        private void txtChqNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCashPaid_TextChanged(object sender, EventArgs e)
        {
            double cashpaid = 0, cardpaid = 0;
            if (txtCashPaid.Text != "")
            {
                cashpaid = double.Parse(txtCashPaid.Text);
            }
            if (txtCardPaid.Text != "")
            {
                cardpaid = double.Parse(txtCardPaid.Text);
            }
            txtTotalPaid.Text = Math.Round(cashpaid + cardpaid, 2).ToString();
            txtBalance.Text = Math.Round((Convert.ToDouble(txtAmount.Text) - Convert.ToDouble(txtTotalPaid.Text)), 2).ToString();
        }

        private void txtCardPaid_TextChanged(object sender, EventArgs e)
        {
            double cashpaid = 0, cardpaid = 0;
            if (txtCashPaid.Text != "")
            {
                cashpaid = double.Parse(txtCashPaid.Text);
            }
            if (txtCardPaid.Text != "")
            {
                cardpaid = double.Parse(txtCardPaid.Text);
            }
            txtTotalPaid.Text = Math.Round(cashpaid + cardpaid, 2).ToString();
            txtBalance.Text = Math.Round((Convert.ToDouble(txtAmount.Text) - Convert.ToDouble(txtTotalPaid.Text)), 2).ToString();
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dg.CommitEdit(DataGridViewDataErrorContexts.Commit);
            txtDescription.Clear();
            txtAmount.Text = "0";
            int counter = 0;
            for (int i = 0; (i
                        <= (DV.Count - 1)); i++)
            {
                if ((dg.Rows[i].Cells[0].Value != null))
                {
                    counter++;
                    if ((counter == 1))
                    {
                        txtDescription.Text = ("BillNo : " + dg.Rows[i].Cells["colBillNo"].Value);
                    }
                    else
                    {
                        txtDescription.Text = ((txtDescription.Text + ", ")
                                    + dg.Rows[i].Cells["colBillNo"].Value);
                    }

              
                    txtAmount.Text = (Convert.ToDouble(txtAmount.Text) + Convert.ToDouble(dg.Rows[i].Cells["colBalance"].Value)).ToString();
                }

            }

        }

        private void dgEdit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgEdit.CommitEdit(DataGridViewDataErrorContexts.Commit);
            txtDescription.Clear();
            txtAmount.Text = "0";
            int counter = 0;
            for (int i = 0; (i
                        <= (DTEDIT.Rows.Count - 1)); i++)
            {
                if ((dgEdit.Rows[i].Cells[0].Value != null))
                {
                    counter++;
                    if ((counter == 1))
                    {
                        txtDescription.Text = ("BillNo : " + dgEdit.Rows[i].Cells["colBillNoEdit"].Value);
                    }
                    else
                    {
                        txtDescription.Text = ((txtDescription.Text + ", ")
                                    + dgEdit.Rows[i].Cells["colBillNoEdit"].Value);
                    }
                    txtAmount.Text = (Convert.ToDouble(txtAmount.Text) + Convert.ToDouble(dgEdit.Rows[i].Cells["colPaidByThisReceipt"].Value)).ToString();
               
                }

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
            txtRechargeNoSearch.Focus();
        }

        private void CboPartySearch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FILL_LISTBOX();
            CboPartySearch.Focus();
           
        }

        private void dtpMonthSearch_ValueChanged(object sender, EventArgs e)
        {
            FILL_LISTBOX();
            dtpMonthSearch.Focus();
        }

        private void lstBox_Click(object sender, EventArgs e)
        {
            MASTERID = Convert.ToInt32(lstBox.SelectedValue);
            fill_edit();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            impfunc.Remove_Child(this);
        }
    }
}