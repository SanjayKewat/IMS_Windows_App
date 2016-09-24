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
    public partial class frmAddCategory : Form
    {
        public frmAddCategory()
        {
            InitializeComponent();
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
            tblnew.Name = "tlp"+subcategorycount;
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
            txtnew.Name = "txtSubcat"+subcategorycount;
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
            btnnew.Name = "btnssubcat"+subcategorycount;
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

        private void clear_control()
        {
            txtCATCODE.Text = "";
            txtCategoryName.Text = "";
            pnlSubMain1.Controls.Clear();
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


         string   resultString = Regex.Match(((System.Windows.Forms.Button)sender).Parent.Parent.Name, @"\d+").Value;
      
           // Panel pnlNew= ((System.Windows.Forms.Button)sender).Parent.Parent.Name;
          
         
            TableLayoutPanel tblnew = new TableLayoutPanel();

            tblnew.ColumnCount = 4;
            tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 397F));
            tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            
            tblnew.Location = new System.Drawing.Point(3, 3);
            tblnew.Name = "tlp" + resultString +"_"+ countTBL;
   
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

            lblnew.Text = resultString + "." + countTBL +" Sub-Category :";
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

        private void frmAddCategory_Load(object sender, EventArgs e)
        {
           // btnAddSUBCategory_Click(sender, e);
        }

      
      

        private void btnExit_Click(object sender, EventArgs e)
        {
            impfunc.Remove_Child(this);
        }

        private void frmAddCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                impfunc.NEXTTAB(this, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnExit_Click(sender, e);
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            int countpnl=1;
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

           
              
     //=============================================================add category===========================================================================
            if ((impfunc.EXISTS_RECORD(impfunc.cnn, "CATEGORY_MASTER", "CATEGORY_NAME", ("CATEGORY_NAME=\'"
                         + (txtCategoryName.Text.Trim() + "\'")), false) == true))
            {
                MessageBox.Show("Category allready Exist!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; 
            }
            impfunc.OPENCONNECTION();
            impfunc._Command = new SqlCommand("insert into CATEGORY_MASTER(CATEGORY_CODE,CATEGORY_NAME)VALUES ('" + txtCATCODE.Text.Trim() + "','" + txtCategoryName.Text.Trim() + "')", impfunc.cnn);
            impfunc._TR = impfunc.cnn.BeginTransaction(IsolationLevel.ReadCommitted);
            impfunc._Command.Transaction = impfunc._TR;

            impfunc._Command.ExecuteNonQuery();
                int id = Convert.ToInt32(impfunc.GET_ID_AFTER_SAVE(impfunc.cnn, "CATEGORY_MASTER", impfunc._TR));
                int subid=0;
                this.Tag = id;
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
                                    sub_name = c2.Text.Trim();
                                    sublab = c2.Name;

                                }
                                if (c2.GetType() == typeof(TextBox))
                                {
                                    if (impfunc.VALIDATION_BLANK(c2) == true)
                                    {
                                        impfunc._TR.Rollback();
                                        return;
                                    }
                                    sub_value = c2.Text.Trim();

                                }

                               
                            }
                            int length = sublab.Length;

                            if (length == 15)
                            {


                                impfunc.SAVE_RECORDS(impfunc.cnn, "SUBCATEGORY_MASTER", impfunc._TR, "CATEGORY_ID", "SUBCATEGORY_NAME", "SUBCATEGORY_VALUE", Convert.ToString(id), sub_name, sub_value);
                                subid = Convert.ToInt32(impfunc.GET_ID_AFTER_SAVE(impfunc.cnn, "SUBCATEGORY_MASTER", impfunc._TR));
                            }
                            else
                            {
                                impfunc.SAVE_RECORDS(impfunc.cnn, "SSUBCATEGORY_MASTER", impfunc._TR, "CATEGORY_ID", "SUB_CATEGORY_ID", "SSUBCATEGORY_NAME", "SSUBCATEGORY_VALUE", Convert.ToString(id), Convert.ToString(subid), sub_name, sub_value);
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
                impfunc.cnn.Close();
                MessageBox.Show(("ERROR: " + (ex.Message + ("\r\n" + "PLEASE CONTACT Mr. Amit Tiwari"))));
            }
            finally
            {
                impfunc.CLOSECONNECTION();
              
               // clear_control();
                 
              
            }

        
       
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



        private void hid_pnlHead_item()
        {
            
       
            foreach (Control c in pnlHead.Controls)
            {
           
                 //if (c.GetType() != typeof(Button))
                 //{
                     c.Enabled = false;
               //  }


            }
        }

        private void hid_pnlsub1_item()
        {


            foreach (Control c in pnlSubMain1.Controls)
            {
                c.Hide();


                  
            }
           
        }

        private void create_sub_cat()
        { 

           int id=  GENERATE_MAX(impfunc.cnn, "CATEGORY_MASTER", "CATEGORY_ID");
           DataTable dtsubcat = new DataTable();
           impfunc._Adapter = new SqlDataAdapter("SELECT * FROM SUBCATEGORY_MASTER where CATEGORY_ID=" + id + " order by SUBCATEGORY_VALUE", impfunc.cnn);
           impfunc._Adapter.Fill(dtsubcat);
           if (dtsubcat.Rows.Count > 0)
           {
               //DataRow row = dtsubcat.NewRow();
               //row["SUBCATEGORY_VALUE"] = "<--SELECT SUB_CATEGORY-->";
               //dtsubcat.Rows.InsertAt(row, 0);


               TableLayoutPanel tblnew = new TableLayoutPanel();
               tblnew.ColumnCount = 2;
               tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.50333F));
               tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.49667F));

               tblnew.Location = new System.Drawing.Point(3, 3);
               tblnew.Name = "tlpSUBCATEGORY";
               tblnew.RowCount = 1;
               tblnew.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
               tblnew.Size = new System.Drawing.Size(748, 30);
               //////////////////////////////////////////////////////////////////////////////////////////////
               Label lblnew = new Label();

               lblnew.Anchor = System.Windows.Forms.AnchorStyles.Right;
               lblnew.AutoSize = true;
               lblnew.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               lblnew.ForeColor = System.Drawing.Color.White;

               lblnew.Name = "lblSubcategory";
               lblnew.Size = new System.Drawing.Size(105, 16);

               lblnew.Text = "Sub-Category:";
               lblnew.TextAlign = System.Drawing.ContentAlignment.TopCenter;
               //////////////////////////////////////////////////////////////////////////////////////////////////////////
               ComboBox cmbnew = new ComboBox();
               cmbnew.Anchor = System.Windows.Forms.AnchorStyles.Left;
               cmbnew.BackColor = System.Drawing.SystemColors.WindowFrame;
               cmbnew.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
               cmbnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               cmbnew.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               cmbnew.ForeColor = System.Drawing.Color.White;
               cmbnew.FormattingEnabled = true;
               cmbnew.Location = new System.Drawing.Point(124, 22);
               cmbnew.Name = "drpdnsubcat";
               cmbnew.Size = new System.Drawing.Size(387, 27);
               cmbnew.DataSource = dtsubcat;

               cmbnew.DisplayMember = "SUBCATEGORY_VALUE";
               cmbnew.ValueMember = "SUB_CATEGORY_ID";


               tblnew.Controls.Add(lblnew, 0, 0);
               tblnew.Controls.Add(cmbnew, 1, 0);
               pnlSubMain1.Controls.Add(tblnew);

               cmbnew.SelectionChangeCommitted += new EventHandler(cmbnew_SelectionChangeCommitted);
           }
 
        }


        public  int GENERATE_MAX(SqlConnection Con, string Table, string Field)
        {
            int num = 0;
            try
            {
                impfunc._Command = new SqlCommand(("SELECT ISNULL(MAX("
                                + (Field + (" ),0) FROM " + Table))), Con);
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }
                num = Convert.ToInt32(impfunc._Command.ExecuteScalar());
            }
            catch (Exception exception)
            {
                throw exception;
            }

            Con.Close();
            return num;
        }


        void cmbnew_SelectionChangeCommitted(object sender, EventArgs e)
        {

            foreach (Control c in pnlSubMain1.Controls)
            {
                if (c.Name == "tlpSSUBCATEGORY")
                {
                    pnlSubMain1.Controls.Remove(c);
                }
            }
          
            
          string id =Convert.ToString(((System.Windows.Forms.ComboBox)sender).SelectedValue);
          DataTable dtsubcat = new DataTable();
          impfunc._Adapter = new SqlDataAdapter("SELECT * FROM SSUBCATEGORY_MASTER where SUB_CATEGORY_ID=" + id + " order by SSUBCATEGORY_VALUE", impfunc.cnn);
          impfunc._Adapter.Fill(dtsubcat);
          if (dtsubcat.Rows.Count > 0)
          {
              //DataRow row = dtsubcat.NewRow();
              //row["SSUBCATEGORY_VALUE"] = "<--SUB SUB_CATEGORY-->";
              //dtsubcat.Rows.InsertAt(row, 0);


              TableLayoutPanel tblnew = new TableLayoutPanel();
              tblnew.ColumnCount = 2;
              tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.50333F));
              tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.49667F));


              tblnew.Location = new System.Drawing.Point(3, 3);
              tblnew.Name = "tlpSSUBCATEGORY";
              tblnew.RowCount = 1;
              tblnew.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
              tblnew.Size = new System.Drawing.Size(748, 30);
              //////////////////////////////////////////////////////////////////////////////////////////////
              Label lblnew = new Label();

              lblnew.Anchor = System.Windows.Forms.AnchorStyles.Right;
              lblnew.AutoSize = true;
              lblnew.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
              lblnew.ForeColor = System.Drawing.Color.White;

              lblnew.Name = "lblSSubcategory";
              lblnew.Size = new System.Drawing.Size(105, 16);

              lblnew.Text = "select SSub Category";
              lblnew.TextAlign = System.Drawing.ContentAlignment.TopCenter;


              //////////////////////////////////////////////////////////////////////////////////////////////////////////
          
              ComboBox cmbnew = new ComboBox();
              cmbnew.Anchor = System.Windows.Forms.AnchorStyles.Left;
              cmbnew.BackColor = System.Drawing.SystemColors.WindowFrame;
              cmbnew.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
              cmbnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
              cmbnew.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
              cmbnew.ForeColor = System.Drawing.Color.White;
              cmbnew.FormattingEnabled = true;
              cmbnew.Location = new System.Drawing.Point(124, 22);
              cmbnew.Name = "drpdsnsubcat";
              cmbnew.Size = new System.Drawing.Size(387, 27);
              cmbnew.DataSource = dtsubcat;

              cmbnew.DisplayMember = "SSUBCATEGORY_VALUE";
              cmbnew.ValueMember = "SSUB_CATEGORY_ID";


              tblnew.Controls.Add(lblnew, 0, 0);
              tblnew.Controls.Add(cmbnew, 1, 0);
              pnlSubMain1.Controls.Add(tblnew);

          }
        }

          
    }
}
