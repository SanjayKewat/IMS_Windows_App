using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AMIT_FUNCTIONS;

namespace IMS.Inventory
{
    public partial class frmAddItem : Form
    {
        public frmAddItem()
        {
            InitializeComponent();
        }

        void clear_control()
        {
            txtItemcode.Text = "";
            txtItemName.Text = "";
            txtMinQty.Text = "0";
            txtBrand.Text = "";
            txtdisc.Text = "0";
            txtOpgQty.Text = "0";
            txtPurchase.Text = "0";
            txtSale.Text = "0";
            txtSize.Text = "";
            txtVatPer.Text = "0";
        }
        private void frmAddItem_Load(object sender, EventArgs e)
        {
            fill_combo();
            impfunc.FILL_COMBO(impfunc.cnn, cboBrand, "BRAND", "BRAND", "BRANDID");
            impfunc.FILL_COMBO(impfunc.cnn,cboUnit, "UNIT_MASTER", "UNIT", "UNITID");
            drpdnCategory_SelectionChangeCommitted(e, e);
            fill_ITEMDETAIL();
           
        }
        private void fill_combo()
        {

            impfunc._DTABLE = new DataTable();
              impfunc._Adapter = new SqlDataAdapter("SELECT CATEGORY_NAME,CATEGORY_ID FROM CATEGORY_MASTER order by CATEGORY_NAME ",      impfunc.cnn);
              impfunc._Adapter.Fill(impfunc._DTABLE);

              drpdnCategory.DataSource = impfunc._DTABLE;

            drpdnCategory.DisplayMember = "CATEGORY_NAME";
            drpdnCategory.ValueMember = "CATEGORY_ID";


            //  impfunc._DTABLE = new DataTable();
            //  impfunc._Adapter = new SqlDataAdapter("SELECT SUBCATEGORY_VALUE,SUB_CATEGORY_ID FROM SUBCATEGORY_MASTER  where CATEGORY_ID="+Convert.ToString(drpdnCategory.SelectedValue)+" order by SUBCATEGORY_VALUE ",      impfunc.cnn);
            //  impfunc._Adapter.Fill(impfunc._DTABLE);
            //  if (impfunc._DTABLE.Rows.Count > 0)
            //{
            //    lblSubCategory.Visible = true;
            //    drpdnsubcat.Visible = true;
            //    drpdnsubcat.DataSource = impfunc._DTABLE;

            //    drpdnsubcat.DisplayMember = "SUBCATEGORY_VALUE";
            //    drpdnsubcat.ValueMember = "SUB_CATEGORY_ID";
            //}
         
            //  impfunc._DTABLE = new DataTable();
            //  impfunc._Adapter = new SqlDataAdapter("SELECT SSUBCATEGORY_VALUE,SSUB_CATEGORY_ID FROM SSUBCATEGORY_MASTER  where SUB_CATEGORY_ID=" + Convert.ToString(drpdnsubcat.SelectedValue) + " order by SSUBCATEGORY_VALUE",      impfunc.cnn);
            //  impfunc._Adapter.Fill(impfunc._DTABLE);
            //  if (impfunc._DTABLE.Rows.Count > 0)
            //{
            //    lblssubcat.Visible = true;
            //    drpdnssubcat.Visible = true;
            //    drpdnssubcat.DataSource = impfunc._DTABLE;

            //    drpdnssubcat.DisplayMember = "SSUBCATEGORY_VALUE";
            //    drpdnssubcat.ValueMember = "SSUB_CATEGORY_ID";
            //}
             
        }

        void fill_ITEMDETAIL()
        {
            if (drpdnCategory.Text.Trim() == "Plywood & Board")
            {
                lblLength.Enabled = true;cboLength.Enabled = true;
                impfunc.FILL_COMBO(impfunc.cnn, cboLength, "PLY_LENGTH", "LENGTH", "ID", "DIFF='PLY'");
                lblwidth.Enabled = true; cbowidth.Enabled = true;
                impfunc.FILL_COMBO(impfunc.cnn, cbowidth, "PLY_WIDTH", "WIDTH", "ID", "DIFF='PLY'");
                lblThick.Enabled = true; cboThick.Enabled = true;
                impfunc.FILL_COMBO(impfunc.cnn, cboThick, "PLY_THIKNESS", "THICKNESS", "ID", "DIFF='PLY'");
                lblplyType.Enabled = true; cboplytype.Enabled = true;
                impfunc.FILL_COMBO(impfunc.cnn, cboplytype, "TYPE_PLY", "TYPE", "ID", "DIFF='PLY'");
               lblQuality.Enabled = true;cboQuality.Enabled = true;
               impfunc.FILL_COMBO(impfunc.cnn, cboQuality, "PLY_QUALITY", "QUALITY", "ID", "DIFF='PLY'");
               txtSize.Text = cboLength.Text + "X" + cbowidth.Text + "X" + cboThick.Text;
               txtSize.Enabled = false;

            }
            else if (drpdnCategory.Text.Trim() == "Doors")
            {
                lblLength.Enabled = true; cboLength.Enabled = true;
                impfunc.FILL_COMBO(impfunc.cnn, cboLength, "PLY_LENGTH", "LENGTH", "ID", "DIFF='DO'");
                lblwidth.Enabled = true; cbowidth.Enabled = true;
                impfunc.FILL_COMBO(impfunc.cnn, cbowidth, "PLY_WIDTH", "WIDTH", "ID", "DIFF='DO'");
                lblThick.Enabled = true; cboThick.Enabled = true;
                impfunc.FILL_COMBO(impfunc.cnn, cboThick, "PLY_THIKNESS", "THICKNESS", "ID", "DIFF='DO'");
                lblplyType.Enabled = true; cboplytype.Enabled = true;
                impfunc.FILL_COMBO(impfunc.cnn, cboplytype, "TYPE_PLY", "TYPE", "ID", "DIFF='DO'");
                lblQuality.Enabled = true; cboQuality.Enabled = true;
                impfunc.FILL_COMBO(impfunc.cnn, cboQuality, "PLY_QUALITY", "QUALITY", "ID", "DIFF='DO'");
                txtSize.Text = cboLength.Text + "X" + cbowidth.Text + "X" + cboThick.Text;
                txtSize.Enabled = false;
            }
            else
            {
                cboLength.DataSource = null; cbowidth.DataSource = null; cboThick.DataSource = null; cboQuality.DataSource = null; cboQuality.DataSource = null;
                lblLength.Enabled = false; cboLength.Enabled = false; lblwidth.Enabled = false; cbowidth.Enabled = false; lblThick.Enabled = false; cboThick.Enabled = false;
                lblplyType.Enabled = false; cboplytype.Enabled = false; lblQuality.Enabled = false; cboQuality.Enabled = false; txtSize.Enabled = true;
            }
        }

        


        private void frmAddItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                impfunc.Remove_Child(this);
            }
        }


        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            impfunc.CHECK_NUMERIC_WITH_DOT(txtPurchase, e);
        }

        private void drpdnCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            drpdnsubcat.DataSource = null;
            lblSubCategory.Visible = false;
            drpdnsubcat.Visible = false;
              impfunc._DTABLE = new DataTable();
              impfunc._Adapter = new SqlDataAdapter("SELECT SUBCATEGORY_VALUE,SUB_CATEGORY_ID FROM SUBCATEGORY_MASTER  where CATEGORY_ID=" + Convert.ToString(drpdnCategory.SelectedValue) + " order by SUBCATEGORY_VALUE ",      impfunc.cnn);
              impfunc._Adapter.Fill(impfunc._DTABLE);
              if (impfunc._DTABLE.Rows.Count > 0)
            {
                lblSubCategory.Visible = true;
                drpdnsubcat.Visible = true;
                drpdnsubcat.DataSource = impfunc._DTABLE;

                drpdnsubcat.DisplayMember = "SUBCATEGORY_VALUE";
                drpdnsubcat.ValueMember = "SUB_CATEGORY_ID";
            }
            drpdnsubcat_SelectionChangeCommitted(e, e);
        }

        private void drpdnsubcat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int subcatid = 0;
            if (drpdnsubcat.SelectedValue != null)
            {
                subcatid = Convert.ToInt32(drpdnsubcat.SelectedValue);
            }

            lblssubcat.Visible = false;
            drpdnssubcat.Visible = false;
            drpdnssubcat.DataSource = null;

              impfunc._DTABLE = new DataTable();
              impfunc._Adapter = new SqlDataAdapter("SELECT SSUBCATEGORY_VALUE,SSUB_CATEGORY_ID FROM SSUBCATEGORY_MASTER  where SUB_CATEGORY_ID=" + Convert.ToString(subcatid) + " order by SSUBCATEGORY_VALUE",      impfunc.cnn);
              impfunc._Adapter.Fill(impfunc._DTABLE);
              if (impfunc._DTABLE.Rows.Count > 0)
            {
                lblssubcat.Visible = true;
                drpdnssubcat.Visible = true;
                drpdnssubcat.DataSource = impfunc._DTABLE;

                drpdnssubcat.DisplayMember = "SSUBCATEGORY_VALUE";
                drpdnssubcat.ValueMember = "SSUB_CATEGORY_ID";
            }
            drpdnssubcat_SelectionChangeCommitted(e, e);
        }

        private void drpdnssubcat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fill_ITEMDETAIL();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (impfunc.VALIDATION_BLANK(txtItemcode) == true)
                {
                    return;
                }
                if (impfunc.VALIDATION_BLANK(txtItemName) == true)
                {
                    return;
                }
                   int catid = 0; int subcatid = 0; int ssubcatid = 0;
                if (drpdnCategory.SelectedValue != null)
                {
                    catid = Convert.ToInt32(drpdnCategory.SelectedValue);
                }
                if (drpdnsubcat.SelectedValue != null)
                {
                    subcatid = Convert.ToInt32(drpdnsubcat.SelectedValue);
                }
                if (drpdnssubcat.SelectedValue != null)
                {
                    ssubcatid = Convert.ToInt32(drpdnssubcat.SelectedValue);
                }

                if (impfunc.EXISTS_RECORD(impfunc.cnn, "ITEM_MASTER", "ITEMNAME", "ITEMNAME=" + txtItemName.Text.Trim() + " AND COMPANYID=" + impfunc._COMPANYID + "", true) == true)
                  {   
                      txtItemcode.Focus();
                      return;
            }

             double OPGQTY=0,VATPER=0,PURCHASEPRICE=0,SALEPRICE=0,DISCPER=0,MINQTY=0;
                if(txtOpgQty.Text!="")
                {
                    OPGQTY=Convert.ToDouble(txtOpgQty.Text);
                }
                  if(txtVatPer.Text!="")
                {
                    VATPER=Convert.ToDouble(txtVatPer.Text);
                }
                  if(txtPurchase.Text!="")
                {
                    PURCHASEPRICE=Convert.ToDouble(txtPurchase.Text);
                }
                  if(txtSale.Text!="")
                {
                    SALEPRICE=Convert.ToDouble(txtSale.Text);
                }
                  if(txtdisc.Text!="")
                {
                    DISCPER=Convert.ToDouble(txtdisc.Text);
                }
                  if (txtMinQty.Text != "")
                  {
                      MINQTY = Convert.ToDouble(txtMinQty.Text);
                  }
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = impfunc.cnn;
                impfunc.OPENCONNECTION();

                //impfunc._Command = new SqlCommand("update  ITEM_MASTER set ITEM_CODE='" + txtItemcode.Text + "',ITEM_NAME='" + txtItemName.Text + "',CATEGORY_ID='" + catid.ToString() + "',SUBCATEGORY_ID='" + subcatid.ToString() + "',SSUBCATEGORY_ID='" + ssubcatid.ToString() + "',RATE='" + txtRate.Text + "'  where ITEM_ID=" + Convert.ToInt32(this.Tag), impfunc.cnn);
                //impfunc._TR = impfunc.cnn.BeginTransaction(IsolationLevel.ReadCommitted);
                //impfunc._Command.Transaction = impfunc._TR;

                //impfunc._Command.ExecuteNonQuery();
             
                impfunc._TR = impfunc.cnn.BeginTransaction(IsolationLevel.ReadCommitted);
                impfunc._Command.Transaction = impfunc._TR;
                impfunc.SAVE_RECORDS(impfunc.cnn, "ITEM_MASTER", impfunc._TR, "ITEM_CODE", "ITEM_NAME", "CATEGORY_ID", "SUBCATEGORY_ID", "SSUBCATEGORY_ID", "OPGQTY", "VATPER", "PURCHASEPRICE", "SALEPRICE", "DISCPER", "LENGTH", "WIDTH", "THICKNESS", "BRAND", "QUALITY", "TYPE_PLY", "COMPANYID", "UNIT_ID","SIZE", txtItemcode.Text, txtItemName.Text.Trim(), catid.ToString(), subcatid.ToString(), ssubcatid.ToString(), OPGQTY.ToString(), VATPER.ToString(), PURCHASEPRICE.ToString(), SALEPRICE.ToString(), DISCPER.ToString(),cboLength.Text,cbowidth.Text,cboThick.Text,txtBrand.Text,cboQuality.Text,cboplytype.Text,impfunc._COMPANYID.ToString(),cboUnit.SelectedValue.ToString(),txtSize.Text);
           
                int itemid = Convert.ToInt32(impfunc.GET_ID_AFTER_SAVE(impfunc.cnn,"ITEM_MASTER",impfunc._TR));
                impfunc.SAVE_RECORDS(impfunc.cnn, "ITEM_STOCK", impfunc._TR, "ITEMID", "PURCHASEPRICE", "SALEPRICE", "OPGQTY", "CURRENTSTOCK", "COMPANYID", "VATPER", "DISCPER", "MINQTY", itemid.ToString(), PURCHASEPRICE.ToString(), SALEPRICE.ToString(), OPGQTY.ToString(), OPGQTY.ToString(), impfunc._COMPANYID.ToString(), VATPER.ToString(), DISCPER.ToString(),txtMinQty.Text);
                
                impfunc._TR.Commit();
                impfunc.CLOSECONNECTION();
                btnReset_Click(e, e);
                MessageBox.Show("Data Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                impfunc._TR.Rollback();
                impfunc.CLOSECONNECTION();
                MessageBox.Show(("ERROR: " + (ex.Message + ("\r\n" + "PLEASE CONTACT Mr. Amit Tiwari"))));
            } 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            impfunc.Remove_Child(this);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            clear_control();
            drpdnCategory_SelectionChangeCommitted(e, e);
        }

        private void txtSale_KeyPress(object sender, KeyPressEventArgs e)
        {
            impfunc.CHECK_NUMERIC_WITH_DOT(txtSale, e);
        }

        private void txtOpgQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            impfunc.CHECK_NUMERIC_WITH_DOT(txtOpgQty, e);
        }

        private void txtMinQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            impfunc.CHECK_NUMERIC_WITH_DOT(txtMinQty, e);
        }

        private void txtVatPer_KeyPress(object sender, KeyPressEventArgs e)
        {
            impfunc.CHECK_NUMERIC_WITH_DOT(txtVatPer, e);
        }

        private void txtdisc_KeyPress(object sender, KeyPressEventArgs e)
        {
            impfunc.CHECK_NUMERIC_WITH_DOT(txtdisc, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBrand.Visible == false)
            {
                txtBrand.Visible = true;
                cboBrand.Visible = false;
            }
            else
            {
                txtBrand.Visible = false;
                cboBrand.Visible = true;
            }
        }

        private void cboBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtBrand.Text = cboBrand.Text;
        }

        private void cboLength_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (drpdnCategory.Text.Trim() == "Plywood & Board")
            {
           
                txtSize.Text = cboLength.Text + "X" + cbowidth.Text + "X" + cboThick.Text;
           

            }
            else if (drpdnCategory.Text.Trim() == "Doors")
            {
                txtSize.Text = cboLength.Text + "X" + cbowidth.Text + "X" + cboThick.Text;
               
            }
            else
            {
                
            }
        }

        private void cbowidth_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (drpdnCategory.Text.Trim() == "Plywood & Board")
            {

                txtSize.Text = cboLength.Text + "X" + cbowidth.Text + "X" + cboThick.Text;


            }
            else if (drpdnCategory.Text.Trim() == "Doors")
            {
                txtSize.Text = cboLength.Text + "X" + cbowidth.Text + "X" + cboThick.Text;

            }
            else
            {

            }
        }

        private void cboThick_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (drpdnCategory.Text.Trim() == "Plywood & Board")
            {

                txtSize.Text = cboLength.Text + "X" + cbowidth.Text + "X" + cboThick.Text;


            }
            else if (drpdnCategory.Text.Trim() == "Doors")
            {
                txtSize.Text = cboLength.Text + "X" + cbowidth.Text + "X" + cboThick.Text;

            }
            else
            {

            }
        }

    }
}
 