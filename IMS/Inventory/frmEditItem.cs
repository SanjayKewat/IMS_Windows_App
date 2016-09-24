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

namespace IMS.Inventory
{
    public partial class frmEditItem : Form
    {
        public frmEditItem()
        {
            InitializeComponent();
        }
     
   
        private void drpdnCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            drpdnsubcat.DataSource = null;
            lblSubCategory.Visible = false;
            drpdnsubcat.Visible = false;
             impfunc._DTABLE = new DataTable();
             impfunc._Adapter = new SqlDataAdapter("SELECT SUBCATEGORY_VALUE,SUB_CATEGORY_ID FROM SUBCATEGORY_MASTER  where CATEGORY_ID=" + Convert.ToString(drpdnCategory.SelectedValue) + " order by SUBCATEGORY_VALUE ",  impfunc.cnn);
             impfunc._Adapter.Fill( impfunc._DTABLE);
            if ( impfunc._DTABLE.Rows.Count > 0)
            {
                lblSubCategory.Visible = true;
                drpdnsubcat.Visible = true;
                drpdnsubcat.DataSource =  impfunc._DTABLE;

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
             impfunc._Adapter = new SqlDataAdapter("SELECT SSUBCATEGORY_VALUE,SSUB_CATEGORY_ID FROM SSUBCATEGORY_MASTER  where SUB_CATEGORY_ID=" + Convert.ToString(subcatid) + " order by SSUBCATEGORY_VALUE",  impfunc.cnn);
             impfunc._Adapter.Fill( impfunc._DTABLE);
            if ( impfunc._DTABLE.Rows.Count > 0)
            {
                lblssubcat.Visible = true;
                drpdnssubcat.Visible = true;
                drpdnssubcat.DataSource =  impfunc._DTABLE;

                drpdnssubcat.DisplayMember = "SSUBCATEGORY_VALUE";
                drpdnssubcat.ValueMember = "SSUB_CATEGORY_ID";
            }
            drpdnssubcat_SelectionChangeCommitted(e, e);
        }

        private void drpdnssubcat_SelectionChangeCommitted(object sender, EventArgs e)
        {
        
        }

        private void frmEditItem_Load(object sender, EventArgs e)
        {
            fill_combo();
        
          
        }
        private void fill_combo()
        {

             impfunc._DTABLE = new DataTable();
             impfunc._Adapter = new SqlDataAdapter("SELECT CATEGORY_NAME,CATEGORY_ID FROM CATEGORY_MASTER order by CATEGORY_NAME ",  impfunc.cnn);
             impfunc._Adapter.Fill( impfunc._DTABLE);

            drpdnCategory.DataSource =  impfunc._DTABLE;

            drpdnCategory.DisplayMember = "CATEGORY_NAME";
            drpdnCategory.ValueMember = "CATEGORY_ID";


             impfunc._DTABLE = new DataTable();
             impfunc._Adapter = new SqlDataAdapter("SELECT SUBCATEGORY_VALUE,SUB_CATEGORY_ID FROM SUBCATEGORY_MASTER  where CATEGORY_ID=" + Convert.ToString(drpdnCategory.SelectedValue) + " order by SUBCATEGORY_VALUE ",  impfunc.cnn);
             impfunc._Adapter.Fill( impfunc._DTABLE);
            if ( impfunc._DTABLE.Rows.Count > 0)
            {
                lblSubCategory.Visible = true;
                drpdnsubcat.Visible = true;
                drpdnsubcat.DataSource =  impfunc._DTABLE;

                drpdnsubcat.DisplayMember = "SUBCATEGORY_VALUE";
                drpdnsubcat.ValueMember = "SUB_CATEGORY_ID";
            }

             impfunc._DTABLE = new DataTable();
             impfunc._Adapter = new SqlDataAdapter("SELECT SSUBCATEGORY_VALUE,SSUB_CATEGORY_ID FROM SSUBCATEGORY_MASTER  where SUB_CATEGORY_ID=" + Convert.ToString(drpdnsubcat.SelectedValue) + " order by SSUBCATEGORY_VALUE",  impfunc.cnn);
             impfunc._Adapter.Fill( impfunc._DTABLE);
            if ( impfunc._DTABLE.Rows.Count > 0)
            {
                lblssubcat.Visible = true;
                drpdnssubcat.Visible = true;
                drpdnssubcat.DataSource =  impfunc._DTABLE;

                drpdnssubcat.DisplayMember = "SSUBCATEGORY_VALUE";
                drpdnssubcat.ValueMember = "SSUB_CATEGORY_ID";
            }

             impfunc._DTABLE = new DataTable();
             impfunc._Adapter = new SqlDataAdapter("SELECT * from ITEM_MASTER_VIEW  where ITEM_ID=" + Convert.ToString(this.Tag), impfunc.cnn);
             impfunc._Adapter.Fill( impfunc._DTABLE);
            txtItemcode.Text =  impfunc._DTABLE.Rows[0]["ITEM_CODE"].ToString();
            txtItemName.Text =  impfunc._DTABLE.Rows[0]["ITEM_NAME"].ToString();
            txtPurchase.Text = impfunc._DTABLE.Rows[0]["PURCHASEPRICE"].ToString();
            txtSale.Text = impfunc._DTABLE.Rows[0]["SALEPRICE"].ToString();
        txtOpgQty.Text = impfunc._DTABLE.Rows[0]["OPGQTY"].ToString();
        txtVatPer.Text = impfunc._DTABLE.Rows[0]["VATPER"].ToString();
        txtdisc.Text = impfunc._DTABLE.Rows[0]["DISCPER"].ToString();
           // txtRate.Text =  impfunc._DTABLE.Rows[0]["RATE"].ToString();
            drpdnCategory.SelectedValue =  impfunc._DTABLE.Rows[0]["CATEGORY_ID"].ToString();
         
            drpdnsubcat.SelectedValue =  impfunc._DTABLE.Rows[0]["SUBCATEGORY_ID"].ToString();
            if (Convert.ToInt32(drpdnsubcat.SelectedValue) == 0)
            {
                lblSubCategory.Visible = false;
                drpdnsubcat.Visible = false;
            }
            drpdnssubcat.SelectedValue =  impfunc._DTABLE.Rows[0]["SSUBCATEGORY_ID"].ToString();
            if (Convert.ToInt32(drpdnssubcat.SelectedValue) == 0)
            {
               lblssubcat.Visible = false;
                drpdnssubcat.Visible = false;
            }
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

                double OPGQTY = 0, VATPER = 0, PURCHASEPRICE = 0, SALEPRICE = 0, DISCPER = 0;
                if (txtOpgQty.Text != "")
                {
                    OPGQTY = Convert.ToDouble(txtOpgQty.Text);
                }
                if (txtVatPer.Text != "")
                {
                    VATPER = Convert.ToDouble(txtVatPer.Text);
                }
                if (txtPurchase.Text != "")
                {
                    PURCHASEPRICE = Convert.ToDouble(txtPurchase.Text);
                }
                if (txtSale.Text != "")
                {
                    SALEPRICE = Convert.ToDouble(txtSale.Text);
                }
                if (txtdisc.Text != "")
                {
                    DISCPER = Convert.ToDouble(txtdisc.Text);
                }
                impfunc._Command = new SqlCommand();
                impfunc._Command.Connection = impfunc.cnn;
                impfunc.OPENCONNECTION();

               
                impfunc._TR = impfunc.cnn.BeginTransaction(IsolationLevel.ReadCommitted);
                impfunc._Command.Transaction = impfunc._TR;
                impfunc.UPDATE_RECORDS(impfunc.cnn, "ITEM_MASTER", impfunc._TR, "ITEM_CODE", "ITEM_NAME", "CATEGORY_ID", "SUBCATEGORY_ID", "SSUBCATEGORY_ID", "OPGQTY", "VATPER", "PURCHASEPRICE", "SALEPRICE", "DISCPER", txtItemcode.Text, txtItemName.Text, catid.ToString(), subcatid.ToString(), ssubcatid.ToString(), OPGQTY.ToString(), VATPER.ToString(), PURCHASEPRICE.ToString(), SALEPRICE.ToString(), DISCPER.ToString(),"ITEM_ID",Convert.ToInt32(this.Tag));
           
                int itemid = Convert.ToInt32(this.Tag);

                int EXIST_COUNT= Convert.ToInt32(impfunc.GET_ONEFIELD(impfunc.cnn, impfunc._TR, "ITEM_STOCK", "COUNT(ITEMSTOCKID)", "ITEMID=" +this.Tag));
                if(EXIST_COUNT < 1)
                {
                    impfunc.SAVE_RECORDS(impfunc.cnn, "ITEM_STOCK", impfunc._TR, "ITEMID", "PURCHASEPRICE", "SALEPRICE", "OPGQTY", "CURRENTSTOCK", "COMPANYID", "VATPER", "DISCPER", itemid.ToString(), PURCHASEPRICE.ToString(), SALEPRICE.ToString(), OPGQTY.ToString(), OPGQTY.ToString(), impfunc._COMPANYID.ToString(), VATPER.ToString(), DISCPER.ToString());
             
                } else{
                    impfunc.UPDATE_RECORDS(impfunc.cnn, "ITEM_STOCK", impfunc._TR, "SET PURCHASEPRICE=" + PURCHASEPRICE.ToString() + ", CURRENTSTOCK=CURRENTSTOCK-OPGQTY +" + OPGQTY + ",OPGQTY=" + OPGQTY + ",SALEPRICE=" + SALEPRICE.ToString() + ",VATPER=" + VATPER.ToString() + ",DISCPER=" + DISCPER.ToString() + " WHERE  ITEMID=" + Convert.ToInt32(this.Tag));
                }
           
                //  impfunc.DELETE_RECORDS( impfunc.cnn, "PRODUCT_DETAIL",  impfunc._TR, "CATEGORY_ID", Convert.ToInt32(drpdnCategory.SelectedValue));
                impfunc._TR.Commit();
                 impfunc.cnn.Close();
                MessageBox.Show("Data Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                 impfunc._TR.Rollback();
                 impfunc.cnn.Close();
                MessageBox.Show(("ERROR: " + (ex.Message + ("\r\n" + "PLEASE CONTACT Mr. Amit Tiwari"))));
            } 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            impfunc.Remove_Child(this);
        }

        private void frmEditItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                impfunc.Remove_Child(this);
            }
        }
    }
}
