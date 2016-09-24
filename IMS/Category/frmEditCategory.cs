using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using AMIT_FUNCTIONS;

namespace IMS.Category
{
    public partial class frmEditCategory : Form
    {
        public frmEditCategory()
        {
            InitializeComponent();
        }

        DataTable dt1;
        DataTable dt2;

        private void clear_control()
        {
            txtCATCODE.Text = "";
            txtCategoryName.Text = "";
            pnlSubMain1.Controls.Clear();
        }      
        private void frmEditCategory_Load(object sender, EventArgs e)
        {
            fill_data();
        }

        private void fill_data()
        {
         
            impfunc._DTABLE = new DataTable();
            impfunc._Adapter = new SqlDataAdapter("SELECT * from CATEGORY_MASTER where CATEGORY_ID="+this.Tag, impfunc.cnn);
            impfunc._Adapter.Fill(impfunc._DTABLE);
            txtCATCODE.Text = impfunc._DTABLE.Rows[0]["CATEGORY_CODE"].ToString();
            txtCategoryName.Text = impfunc._DTABLE.Rows[0]["CATEGORY_NAME"].ToString();
            dt1 = new DataTable();
            impfunc._Adapter = new SqlDataAdapter("SELECT * from SUBCATEGORY_MASTER where CATEGORY_ID=" + this.Tag, impfunc.cnn);
            impfunc._Adapter.Fill(dt1);
            int pnl=dt1.Rows.Count;
            create_sub_panel(dt1);
            //impfunc._DTABLE = new DataTable();
            //impfunc._Adapter = new SqlDataAdapter("SELECT * from CATEGORY_MASTER where CATEGORY_ID=" + this.Tag, impfunc.cnn);
            //impfunc._Adapter.Fill(impfunc._DTABLE);
          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            impfunc.Remove_Child(this);
        }

        private void create_sub_panel(DataTable dt1)
        {
            for (int i = 1; i <= dt1.Rows.Count; i++)
            {
                FlowLayoutPanel pnlNew = new FlowLayoutPanel();

                pnlNew.BorderStyle = BorderStyle.FixedSingle;
                pnlNew.Size = new System.Drawing.Size(760, 40);
                pnlNew.AutoSize = true;
                pnlNew.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
                pnlNew.Name = "pnlSubCat" + i;
                pnlSubMain1.Controls.Add(pnlNew);

                //----------------------------------------------------------------create new table layout-----------------------------------------------
             


                TableLayoutPanel tblnew = new TableLayoutPanel();

                tblnew.ColumnCount = 4;

                tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 397F));
                tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
                tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
                tblnew.Location = new System.Drawing.Point(3, 3);
                tblnew.Name = "tlp" + i;
                tblnew.RowCount = 1;
                tblnew.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
                tblnew.Size = new System.Drawing.Size(748, 30);
                pnlNew.Controls.Add(tblnew);
                //-----------------------------------------------------------------create new label-------------------------------------------------------------------------
                Label lblnew = new Label();
                lblnew.Anchor = System.Windows.Forms.AnchorStyles.Right;
                lblnew.AutoSize = true;
                lblnew.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblnew.ForeColor = System.Drawing.Color.White;

                lblnew.Name = "lblSubcategory" + i;
                lblnew.Size = new System.Drawing.Size(105, 16);

                lblnew.Text = dt1.Rows[i-1]["SUBCATEGORY_NAME"].ToString();
                lblnew.TextAlign = System.Drawing.ContentAlignment.TopCenter;

                ///-----------------------------------------------------create New text box------------------------------------------------------
                TextBox txtnew = new TextBox();
                txtnew.Anchor = System.Windows.Forms.AnchorStyles.Left;
                txtnew.BackColor = System.Drawing.SystemColors.WindowFrame;
                txtnew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                txtnew.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                txtnew.ForeColor = System.Drawing.Color.White;
                txtnew.Location = new System.Drawing.Point(169, 7);
                txtnew.Name = "txtSubcat" + i;
                txtnew.Size = new System.Drawing.Size(388, 27);
                txtnew.Text = dt1.Rows[i-1]["SUBCATEGORY_VALUE"].ToString();
                ///-------------------------------------------------------------------------------------------------
                Button btnnew = new Button();
                btnnew.Anchor = System.Windows.Forms.AnchorStyles.Right;
                btnnew.BackgroundImage = global::IMS.Properties.Resources.Add;
                btnnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                btnnew.FlatAppearance.BorderSize = 0;
                btnnew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                btnnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnnew.Location = new System.Drawing.Point(620, 7);
                btnnew.Name = "btnssubcat" + i;
                btnnew.Size = new System.Drawing.Size(30, 30);

                btnnew.UseVisualStyleBackColor = true;
                btnnew.Click += new EventHandler(btnnew_Click);
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                Button btnnew2 = new Button();
                btnnew2.Anchor = System.Windows.Forms.AnchorStyles.Left;
                btnnew2.BackgroundImage = global::IMS.Properties.Resources.Minus;
                btnnew2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                btnnew2.FlatAppearance.BorderSize = 0;
                btnnew2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                btnnew2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                btnnew2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnnew2.Location = new System.Drawing.Point(620, 7);
                btnnew2.Name = "btnrssubcat" + i;
                btnnew2.Size = new System.Drawing.Size(30, 30);

                btnnew2.UseVisualStyleBackColor = true;
                btnnew2.Click += new EventHandler(btnnew2_Click);


                //===========================================add controls in table layout===============================================
                tblnew.Controls.Add(lblnew, 0, 0);
                tblnew.Controls.Add(txtnew, 1, 0);
                tblnew.Controls.Add(btnnew, 2, 0);
                tblnew.Controls.Add(btnnew2, 3, 0);
                

            
                dt2 = new DataTable();
                impfunc._Adapter = new SqlDataAdapter("SELECT * from SSUBCATEGORY_MASTER where SUB_CATEGORY_ID=" + dt1.Rows[i - 1]["SUB_CATEGORY_ID"].ToString(), impfunc.cnn);
                impfunc._Adapter.Fill(dt2);

                create_ssub_panel(pnlNew, Convert.ToString(i), dt2);
            }

        }


        private void create_ssub_panel(Panel pnlnew,string indx,DataTable dt)
        {

            for (int i = 1; i <= dt.Rows.Count; i++)
            {

                TableLayoutPanel tblnew = new TableLayoutPanel();

                tblnew.ColumnCount = 4;
                tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 397F));
                tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
                tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));

                tblnew.Location = new System.Drawing.Point(3, 3);
                tblnew.Name = "tlp" + indx + "_" + i;

                tblnew.RowCount = 1;
                tblnew.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
                tblnew.Size = new System.Drawing.Size(748, 30);
           pnlnew.Controls.Add(tblnew);
                //-----------------------------------------------------------------create new label-------------------------------------------------------------------------
              Label lblnew = new Label();
              lblnew.Anchor = System.Windows.Forms.AnchorStyles.Right;
              lblnew.AutoSize = true;
              lblnew.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
              lblnew.ForeColor = System.Drawing.Color.White;

              lblnew.Name = "lblSubcategory" + indx + "_" + i;
              lblnew.Size = new System.Drawing.Size(105, 16);

              lblnew.Text = dt.Rows[i - 1]["SSUBCATEGORY_NAME"].ToString();
              lblnew.TextAlign = System.Drawing.ContentAlignment.TopCenter;

              ///-----------------------------------------------------create New text box------------------------------------------------------
              TextBox txtnew = new TextBox();
              txtnew.Anchor = System.Windows.Forms.AnchorStyles.Left;
              txtnew.BackColor = System.Drawing.SystemColors.WindowFrame;
              txtnew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
              txtnew.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
              txtnew.ForeColor = System.Drawing.Color.White;
              txtnew.Location = new System.Drawing.Point(169, 7);
              txtnew.Name = "txtSubcat" + indx + "_" + i;
              txtnew.Size = new System.Drawing.Size(388, 27);
              txtnew.Text = dt.Rows[i - 1]["SSUBCATEGORY_VALUE"].ToString();


              //===========================================add controls in table layout===============================================
              tblnew.Controls.Add(lblnew, 0, 0);
              tblnew.Controls.Add(txtnew, 1, 0);

            }
        }





        void btnnew_Click(object sender, EventArgs e)
        {


            int countTBL = 0;
            foreach (Control c in ((System.Windows.Forms.Button)sender).Parent.Parent.Controls)
            {
                if (c.GetType() == typeof(TableLayoutPanel))
                {
                    countTBL++;
                }

            }

            //      MessageBox.Show(Convert.ToString(countTBL));


            string resultString = Regex.Match(((System.Windows.Forms.Button)sender).Parent.Parent.Name, @"\d+").Value;

            // Panel pnlNew= ((System.Windows.Forms.Button)sender).Parent.Parent.Name;


            TableLayoutPanel tblnew = new TableLayoutPanel();

            tblnew.ColumnCount = 4;
            tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 397F));
            tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));

            tblnew.Location = new System.Drawing.Point(3, 3);
            tblnew.Name = "tlp" + resultString + "_" + countTBL;

            tblnew.RowCount = 1;
            tblnew.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tblnew.Size = new System.Drawing.Size(748, 30);
            ((System.Windows.Forms.Button)sender).Parent.Parent.Controls.Add(tblnew);
            //-----------------------------------------------------------------create new label-------------------------------------------------------------------------
            Label lblnew = new Label();
            lblnew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lblnew.AutoSize = true;
            lblnew.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblnew.ForeColor = System.Drawing.Color.White;

            lblnew.Name = "lblSubcategory" + resultString + "_" + countTBL;
            lblnew.Size = new System.Drawing.Size(105, 16);

            lblnew.Text = resultString + "." + countTBL + " Sub-Category :";
            lblnew.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            ///-----------------------------------------------------create New text box------------------------------------------------------
            TextBox txtnew = new TextBox();
            txtnew.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtnew.BackColor = System.Drawing.SystemColors.WindowFrame;
            txtnew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtnew.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtnew.ForeColor = System.Drawing.Color.White;
            txtnew.Location = new System.Drawing.Point(169, 7);
            txtnew.Name = "txtSubcat" + resultString + "_" + countTBL;
            txtnew.Size = new System.Drawing.Size(388, 27);



            //===========================================add controls in table layout===============================================
            tblnew.Controls.Add(lblnew, 0, 0);
            tblnew.Controls.Add(txtnew, 1, 0);
            //tblnew.Controls.Add(btnnew, 2, 0);


            //  MessageBox.Show(((System.Windows.Forms.Label)sender).Name);
            // MessageBox.Show(((System.Windows.Forms.Button)sender).Parent.Parent.Name + " clicked");
        }

        private void btnAddSUBCategory_Click(object sender, EventArgs e)
        {

            int subcategorycount = 1;
            foreach (Control c in pnlSubMain1.Controls)
            {
                if (c.GetType() == typeof(FlowLayoutPanel))
                {
                    subcategorycount++;
                }

            }
            //--------------------------------------------------------------crate new flowlayout panel-----------------------------------
            FlowLayoutPanel pnlNew = new FlowLayoutPanel();

            pnlNew.BorderStyle = BorderStyle.FixedSingle;
            pnlNew.Size = new System.Drawing.Size(760, 40);
            pnlNew.AutoSize = true;
            pnlNew.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            pnlNew.Name = "pnlSubCat" + subcategorycount;
            pnlSubMain1.Controls.Add(pnlNew);
            //----------------------------------------------------------------create new table layout-----------------------------------------------
            TableLayoutPanel tblnew = new TableLayoutPanel();

            tblnew.ColumnCount = 4;

            tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 397F));
            tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            tblnew.Location = new System.Drawing.Point(3, 3);
            tblnew.Name = "tlp" + subcategorycount;
            tblnew.RowCount = 1;
            tblnew.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tblnew.Size = new System.Drawing.Size(748, 30);
            pnlNew.Controls.Add(tblnew);
            //-----------------------------------------------------------------create new label-------------------------------------------------------------------------
            Label lblnew = new Label();
            lblnew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lblnew.AutoSize = true;
            lblnew.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblnew.ForeColor = System.Drawing.Color.White;

            lblnew.Name = "lblSubcategory" + subcategorycount;
            lblnew.Size = new System.Drawing.Size(105, 16);

            lblnew.Text = subcategorycount + " Sub-Category :";
            lblnew.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            ///-----------------------------------------------------create New text box------------------------------------------------------
            TextBox txtnew = new TextBox();
            txtnew.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtnew.BackColor = System.Drawing.SystemColors.WindowFrame;
            txtnew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtnew.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtnew.ForeColor = System.Drawing.Color.White;
            txtnew.Location = new System.Drawing.Point(169, 7);
            txtnew.Name = "txtSubcat" + subcategorycount;
            txtnew.Size = new System.Drawing.Size(388, 27);

            ///-------------------------------------------------------------------------------------------------
            Button btnnew = new Button();
            btnnew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            btnnew.BackgroundImage = global::IMS.Properties.Resources.Add;
            btnnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnnew.FlatAppearance.BorderSize = 0;
            btnnew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnnew.Location = new System.Drawing.Point(620, 7);
            btnnew.Name = "btnssubcat" + subcategorycount;
            btnnew.Size = new System.Drawing.Size(30, 30);

            btnnew.UseVisualStyleBackColor = true;
            btnnew.Click += new EventHandler(btnnew_Click);
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Button btnnew2 = new Button();
            btnnew2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btnnew2.BackgroundImage = global::IMS.Properties.Resources.Minus;
            btnnew2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnnew2.FlatAppearance.BorderSize = 0;
            btnnew2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnnew2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnnew2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnnew2.Location = new System.Drawing.Point(620, 7);
            btnnew2.Name = "btnrssubcat" + subcategorycount;
            btnnew2.Size = new System.Drawing.Size(30, 30);

            btnnew2.UseVisualStyleBackColor = true;
            btnnew2.Click += new EventHandler(btnnew2_Click);


            //===========================================add controls in table layout===============================================
            tblnew.Controls.Add(lblnew, 0, 0);
            tblnew.Controls.Add(txtnew, 1, 0);
            tblnew.Controls.Add(btnnew, 2, 0);
            tblnew.Controls.Add(btnnew2, 3, 0);



        }




        void btnnew2_Click(object sender, EventArgs e)
        {


            int countTBL = 0;
            foreach (Control c in ((System.Windows.Forms.Button)sender).Parent.Parent.Controls)
            {
                if (c.GetType() == typeof(TableLayoutPanel))
                {
                    countTBL++;
                }

                if (((System.Windows.Forms.Button)sender).Parent.Parent.Controls.IndexOf(c) == ((System.Windows.Forms.Button)sender).Parent.Parent.Controls.Count - 1)
                {
                    // this is the last item

                    if (c.Controls.Count == 2)
                    {
                        ((System.Windows.Forms.Button)sender).Parent.Parent.Controls.Remove(c);
                    }
                    else
                    {
                        MessageBox.Show("Can't Remove Last Category");
                    }
                }



            }



            //Control ctn = pnlSubMain1.Controls["pnlSubCat" + countpnl];
            //pnlSubMain1.Controls.Remove(ctn);

        }

        private void fill_category()
        {

        }

        private void btnDeleteSubCAt_Click(object sender, EventArgs e)
        {
            int countpnl = 0;
            foreach (Control c in pnlSubMain1.Controls)
            {
                if (c.GetType() == typeof(FlowLayoutPanel))
                {
                    countpnl++;
                }

            }
            Control ctn = pnlSubMain1.Controls["pnlSubCat" + countpnl];
            pnlSubMain1.Controls.Remove(ctn);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            int countpnl = 1;
            if (impfunc.VALIDATION_BLANK(txtCATCODE) == true)
            {
                return;
            }
            if (impfunc.VALIDATION_BLANK(txtCategoryName) == true)
            {
                return;
            }
            try
            {

                if ((impfunc.EXISTS_RECORD(impfunc.cnn, "CATEGORY_MASTER", "CATEGORY_NAME", ("COMPANYID="
                             + (impfunc._COMPANYID + (" AND CATEGORY_NAME=\'"
                             + (txtCategoryName.Text.Trim() + ("\' AND CATEGORY_ID<>" + Convert.ToInt32(this.Tag)))))), false) == true))
                {
                    MessageBox.Show("Category allready Exist!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCategoryName.Focus();
                    return;
                }
                impfunc.OPENCONNECTION();

                //=============================================================add category===========================================================================
                impfunc._Command = new SqlCommand("update  CATEGORY_MASTER set CATEGORY_CODE='" + txtCATCODE.Text + "',CATEGORY_NAME='" + txtCategoryName.Text + "' where CATEGORY_ID=" + Convert.ToInt32(this.Tag), impfunc.cnn);
                impfunc._TR = impfunc.cnn.BeginTransaction(IsolationLevel.ReadCommitted);
                impfunc._Command.Transaction = impfunc._TR;

                impfunc._Command.ExecuteNonQuery();
                int subid = 0;
                impfunc.DELETE_RECORDS(impfunc.cnn, "SUBCATEGORY_MASTER", impfunc._TR, "CATEGORY_ID", Convert.ToInt32(this.Tag));
                impfunc.DELETE_RECORDS(impfunc.cnn, "SSUBCATEGORY_MASTER", impfunc._TR, "CATEGORY_ID", Convert.ToInt32(this.Tag));
                //================================================================add Sub category=================================================================
                foreach (Control c in pnlSubMain1.Controls)
                {
                    int counttbl = 1;
                    if (c.GetType() == typeof(FlowLayoutPanel))
                    {

                        Control ctn = pnlSubMain1.Controls["pnlSubCat" + countpnl];

                        foreach (Control c1 in ctn.Controls)
                        {
                            Control ctn2;
                            int count;
                            if (counttbl == 1)
                            {
                                ctn2 = ctn.Controls["tlp" + countpnl];
                            }
                            else
                            {
                                count = counttbl - 1;
                                ctn2 = ctn.Controls["tlp" + countpnl + "_" + count];
                            }
                            string sub_name = ""; string sub_value = ""; string sublab = "";
                            foreach (Control c2 in ctn2.Controls)
                            {

                                if (c2.GetType() == typeof(Label))
                                {
                                    if (impfunc.VALIDATION_BLANK(c2) == true)
                                    {
                                        impfunc._TR.Rollback();
                                        return;
                                    }
                                    sub_name = c2.Text;
                                    sublab = c2.Name;

                                }
                                if (c2.GetType() == typeof(TextBox))
                                {
                                    if (impfunc.VALIDATION_BLANK(c2) == true)
                                    {
                                        impfunc._TR.Rollback();
                                        return;
                                    }
                                    sub_value = c2.Text;

                                }


                            }
                            int length = sublab.Length;

                            if (length == 15)
                            {


                                impfunc.SAVE_RECORDS(impfunc.cnn, "SUBCATEGORY_MASTER", impfunc._TR, "CATEGORY_ID", "SUBCATEGORY_NAME", "SUBCATEGORY_VALUE", Convert.ToString(this.Tag), sub_name, sub_value);
                                subid = Convert.ToInt32(impfunc.GET_ID_AFTER_SAVE(impfunc.cnn, "SUBCATEGORY_MASTER", impfunc._TR));
                            }
                            else
                            {
                                impfunc.SAVE_RECORDS(impfunc.cnn, "SSUBCATEGORY_MASTER", impfunc._TR, "CATEGORY_ID", "SUB_CATEGORY_ID", "SSUBCATEGORY_NAME", "SSUBCATEGORY_VALUE", Convert.ToString(this.Tag), Convert.ToString(subid), sub_name, sub_value);
                            }

                            counttbl = counttbl + 1;


                        }
                        countpnl = countpnl + 1;

                    }

                }




                impfunc._TR.Commit();
                impfunc.CLOSECONNECTION();
                //hid_pnlHead_item();
                //hid_pnlsub1_item();
                //create_sub_cat();
              clear_control();
                MessageBox.Show("Data Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                impfunc.CLOSECONNECTION();
                MessageBox.Show(("ERROR: " + (ex.Message + ("\r\n" + "PLEASE CONTACT Mr. Amit Tiwari"))));
            }
            finally
            {
                impfunc.cnn.Close();
                impfunc.Remove_Child(this);
                // clear_control();


            }

        
       
        }

        





    }
}
