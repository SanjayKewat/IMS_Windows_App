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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }
      
        List<ComboBox> com = new List<ComboBox>();
        private void frmCategory_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
   

            fill_edit();
                  
        }
        public void fill_edit()
        {
            

            // tlpHeader
            // 
            TableLayoutPanel tblHead = new TableLayoutPanel();
            tblHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            tblHead.ColumnCount = 6;
            tblHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.91045F));
            tblHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.08955F));
            tblHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 221F));
            tblHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            tblHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
           tblHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
           tblHead.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
           tblHead.Location = new System.Drawing.Point(0, 0);
           tblHead.Margin = new System.Windows.Forms.Padding(1);
           tblHead.Name = "tblHead";
           tblHead.RowCount = 1;
           tblHead.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
           tblHead.Size = new System.Drawing.Size(968, 50);
           tblHead.TabIndex = 0;
       ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Label lblHDel=new Label();
         lblHDel.Anchor = System.Windows.Forms.AnchorStyles.None;
         lblHDel.AutoSize = true;
         lblHDel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         lblHDel.Location = new System.Drawing.Point(886, 17);
         lblHDel.Name = "lblHDel";
         lblHDel.Size = new System.Drawing.Size(50, 16);
         lblHDel.TabIndex = 5;
         lblHDel.Text = "Delete";
            // 
            // lblEdit
            // 
         Label lblEdit = new Label();
          lblEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
          lblEdit.AutoSize = true;
          lblEdit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          lblEdit.Location = new System.Drawing.Point(781, 17);
          lblEdit.Name = "lblEdit";
          lblEdit.Size = new System.Drawing.Size(32, 16);
          lblEdit.TabIndex = 4;
          lblEdit.Text = "Edit";
            // 
            // lblHSSubcat
            // 
            Label lblHSSubcat=new Label();
          lblHSSubcat.Anchor = System.Windows.Forms.AnchorStyles.None;
          lblHSSubcat.AutoSize = true;
          lblHSSubcat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          lblHSSubcat.Location = new System.Drawing.Point(584, 17);
          lblHSSubcat.Name = "lblHSSubcat";
          lblHSSubcat.Size = new System.Drawing.Size(122, 16);
          lblHSSubcat.TabIndex = 3;
          lblHSSubcat.Text = "Sub-SubCategory";
            // 
            // lblHSubcat
            // 
             Label lblHSubcat=new Label();
           lblHSubcat.Anchor = System.Windows.Forms.AnchorStyles.None;
           lblHSubcat.AutoSize = true;
           lblHSubcat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           lblHSubcat.Location = new System.Drawing.Point(389, 17);
           lblHSubcat.Name = "lblHSubcat";
           lblHSubcat.Size = new System.Drawing.Size(98, 16);
           lblHSubcat.TabIndex = 2;
           lblHSubcat.Text = "Sub-Category";
            // 
            // lblHCatName
            // 
               Label lblHCatName=new Label();
           lblHCatName.Anchor = System.Windows.Forms.AnchorStyles.None;
           lblHCatName.AutoSize = true;
           lblHCatName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           lblHCatName.Location = new System.Drawing.Point(172, 17);
           lblHCatName.Name = "lblHCatName";
           lblHCatName.Size = new System.Drawing.Size(107, 16);
           lblHCatName.TabIndex = 1;
           lblHCatName.Text = "Category Name";
            // 
            // lblHCatcode
            Label lblHCatcode=new Label();

            lblHCatcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblHCatcode.AutoSize = true;
            lblHCatcode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHCatcode.Location = new System.Drawing.Point(10, 17);
            lblHCatcode.Name = "lblHCatcode";
            lblHCatcode.Size = new System.Drawing.Size(104, 16);
            lblHCatcode.TabIndex = 0;
            lblHCatcode.Text = "Category Code";
          ///////////////////////////////////////////////////////////////////////////////////////////////


tblHead.Controls.Add(lblHDel, 5, 0);
           tblHead.Controls.Add(lblEdit, 4, 0);
           tblHead.Controls.Add(lblHSSubcat, 3, 0);
           tblHead.Controls.Add(lblHSubcat, 2, 0);
           tblHead.Controls.Add(lblHCatName, 1, 0);
           tblHead.Controls.Add(lblHCatcode, 0, 0);
       pnlHead.Controls.Add(tblHead);
           impfunc._DTABLE= new DataTable();
           impfunc._Adapter = new SqlDataAdapter("SELECT * FROM CATEGORY_MASTER", impfunc.cnn);

           impfunc._Adapter.Fill(impfunc._DTABLE);
            
            int rowcount = 0;
            //if (rowcount > 0)
            //{
                //for (int i = 1; i <= rowcount; i++)
                //{
            foreach (DataRow row in impfunc._DTABLE.Rows)
                    {
                        rowcount++;
                        TableLayoutPanel tblnew = new TableLayoutPanel();
                        tblnew.ColumnCount = 6;
                       tblnew.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.None;
                        tblnew.BackColor = System.Drawing.Color.Gray;
                        tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.91045F));
                        tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.08955F));
                        tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 221F));
                        tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192F));
                        tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
                        tblnew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
                        tblnew.Margin = new System.Windows.Forms.Padding(0);
                        tblnew.Location = new System.Drawing.Point(3, 3);
                        tblnew.Name = "tlpdet" + rowcount;

                        tblnew.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
                        tblnew.Size = new System.Drawing.Size(968, 35);

                        tblnew.RowCount = rowcount + 1;
                        ////////////////////////////////////////////////////////////////
                        Label catcode = new Label();
                        catcode.Anchor = System.Windows.Forms.AnchorStyles.None;
                        catcode.AutoSize = true;
                        catcode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        catcode.Location = new System.Drawing.Point(10, 17);
                        catcode.Name = "catcode" + rowcount;
                        catcode.Size = new System.Drawing.Size(104, 16);
                        catcode.TabIndex = 0;
                        catcode.Text = impfunc._DTABLE.Rows[rowcount - 1]["CATEGORY_CODE"].ToString();
                        ///////////////////////////////////////////////////////////////
                        Label catname = new Label();
                        catname.Anchor = System.Windows.Forms.AnchorStyles.None;
                        catname.AutoSize = true;
                        catname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        catname.Location = new System.Drawing.Point(10, 17);
                        catname.Name = "catName" + rowcount;
                        catname.Size = new System.Drawing.Size(104, 16);
                        catname.TabIndex = 0;
                        catname.Text = impfunc._DTABLE.Rows[rowcount - 1]["CATEGORY_NAME"].ToString();
                        ///////////////////////////////////////////////////////////////////////////////////////////////
                        ComboBox subcat = new ComboBox();
                        subcat.Anchor = System.Windows.Forms.AnchorStyles.None;

                        subcat.FormattingEnabled = true;
                        subcat.Location = new System.Drawing.Point(3, 59);
                        subcat.Name = "subcat" + rowcount;
                        subcat.Size = new System.Drawing.Size(161, 21);

                        DataTable dtsubcat = new DataTable();
                       impfunc._Adapter = new SqlDataAdapter("SELECT SUB_CATEGORY_ID,SUBCATEGORY_VALUE FROM SUBCATEGORY_MASTER where CATEGORY_ID=" +impfunc._DTABLE.Rows[rowcount - 1]["CATEGORY_ID"].ToString(), impfunc.cnn);

                       impfunc._Adapter.Fill(dtsubcat);
                        
                            subcat.DataSource = dtsubcat;
                            subcat.DisplayMember = "SUBCATEGORY_VALUE";
                            subcat.ValueMember = "SUB_CATEGORY_ID";
                        

                        ///////////////////////////////////////////////////////////////////////////////////////////////
                        ComboBox ssubcat = new ComboBox();
                        ssubcat.Anchor = System.Windows.Forms.AnchorStyles.None;

                        ssubcat.FormattingEnabled = true;
                        ssubcat.Location = new System.Drawing.Point(3, 59);
                        ssubcat.Name = "ssubcat" + rowcount;
                        ssubcat.Size = new System.Drawing.Size(161, 21);
                        
                        ////////////////////////////////////////////////////////////////////////////////////
                        Button btnedit = new Button();
                        btnedit.Anchor = System.Windows.Forms.AnchorStyles.None;
                        btnedit.BackgroundImage = global::IMS.Properties.Resources.edit_row;
                        btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                        btnedit.FlatAppearance.BorderSize = 0;
                        btnedit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                        btnedit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                        btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btnedit.Location = new System.Drawing.Point(620, 7);
                        btnedit.Name = "btnEdit" + rowcount;
                        btnedit.Size = new System.Drawing.Size(60, 30);

                        btnedit.UseVisualStyleBackColor = true;
                        btnedit.Tag = impfunc._DTABLE.Rows[rowcount - 1]["CATEGORY_ID"].ToString();

                        btnedit.Click += new EventHandler(btnedit_Click);
                        ////////////////////////////////////////////////////////////////////////////////////
                        Button btndel = new Button();
                        btndel.Anchor = System.Windows.Forms.AnchorStyles.None;
                        btndel.BackgroundImage = global::IMS.Properties.Resources.delete_row;
                        btndel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                        btndel.FlatAppearance.BorderSize = 0;
                        btndel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                        btndel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                        btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btndel.Location = new System.Drawing.Point(620, 7);
                        btndel.Name = "btndel" + rowcount;
                        btndel.Size = new System.Drawing.Size(60, 30);

                        btndel.UseVisualStyleBackColor = true;
                        btndel.Tag = impfunc._DTABLE.Rows[rowcount - 1]["CATEGORY_ID"].ToString();

                        btndel.Click += new EventHandler(btndel_Click);

                        subcat.SelectionChangeCommitted += new EventHandler(subcat_SelectionChangeCommitted);
                         
                        //  catname.Text = dt.Rows[i - 1]["CATEGORY_NAME"].ToString();

                        //   subcat_SelectionChangeCommitted(subcat,);


                        tblnew.Controls.Add(catcode, 0, 0);
                        tblnew.Controls.Add(catname, 1, 0);
                        tblnew.Controls.Add(subcat, 2, 0);
                        tblnew.Controls.Add(ssubcat, 3, 0);
                        tblnew.Controls.Add(btnedit, 4, 0);
                        tblnew.Controls.Add(btndel, 5, 0);





                        flpGrid.Controls.Add(tblnew);
                        string subcatid = "0";
                        if (subcat.SelectedValue != null)
                        {
                            subcatid = subcat.SelectedValue.ToString();
                        }

                        DataTable dtssubcat = new DataTable();
                       impfunc._Adapter = new SqlDataAdapter("SELECT SSUB_CATEGORY_ID,SSUBCATEGORY_VALUE FROM SSUBCATEGORY_MASTER where SUB_CATEGORY_ID=" + subcatid, impfunc.cnn);

                       impfunc._Adapter.Fill(dtssubcat);
                        ssubcat.DataSource = dtssubcat;
                        ssubcat.DisplayMember = "SSUBCATEGORY_VALUE";
                        ssubcat.ValueMember = "SSUB_CATEGORY_ID";
                       
                    }
              //  }
          //  }
         

        
             
         
        }


        void btnedit_Click(object sender, EventArgs e)
        {
            string id=((System.Windows.Forms.Button)sender).Tag.ToString();

            frmEditCategory frm = new frmEditCategory();
            frm.Tag = id;
            frm.ShowDialog();
            flpGrid.Controls.Clear();
            fill_edit();

           
        }

        void btndel_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(((System.Windows.Forms.Button)sender).Tag);

           
            DialogResult dialogResult = MessageBox.Show("Sure, You want to delete Category", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    impfunc._Command = new SqlCommand();
                    impfunc._Command.Connection = impfunc.cnn;
                    impfunc.cnn.Open();
                    impfunc._TR = impfunc.cnn.BeginTransaction(IsolationLevel.ReadCommitted);
                    impfunc._Command.Transaction = impfunc._TR;
                    impfunc.DELETE_RECORDS(impfunc.cnn, "CATEGORY_MASTER", impfunc._TR, "CATEGORY_ID", id);
                    impfunc.DELETE_RECORDS(impfunc.cnn, "SUBCATEGORY_MASTER", impfunc._TR, "CATEGORY_ID", id);
                    impfunc.DELETE_RECORDS(impfunc.cnn, "SSUBCATEGORY_MASTER", impfunc._TR, "CATEGORY_ID", id);
                    impfunc._TR.Commit();
                    impfunc.cnn.Close();
                    flpGrid.Controls.Clear();
                    fill_edit();
                }
                catch (Exception ex)
                {
                  impfunc._TR.Rollback();
                    impfunc.cnn.Close();
                    MessageBox.Show(("ERROR: " + (ex.Message + ("\r\n" + "PLEASE CONTACT Mr. Amit Tiwari"))));
                }
                finally
                {
                    impfunc.cnn.Close();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

                  

        }



        void subcat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string id = ((System.Windows.Forms.ComboBox)sender).SelectedValue.ToString();
                string subname = ((System.Windows.Forms.ComboBox)sender).Name;
                string resultString = Regex.Match(subname, @"\d+").Value;


                DataTable dtsubcat = new DataTable();
               impfunc._Adapter = new SqlDataAdapter("SELECT SSUB_CATEGORY_ID,SSUBCATEGORY_VALUE FROM SSUBCATEGORY_MASTER where SUB_CATEGORY_ID=" + id, impfunc.cnn);

               impfunc._Adapter.Fill(dtsubcat);
                //if (dtsubcat.Rows.Count > 0)
                //{
                    Control ctn = ((System.Windows.Forms.ComboBox)sender).Parent.Controls["ssubcat" + resultString];
                    ((ComboBox)ctn).DataSource=null;
                    ((ComboBox)ctn).DataSource = dtsubcat;
                    ((ComboBox)ctn).DisplayMember = "SSUBCATEGORY_VALUE";
                    ((ComboBox)ctn).ValueMember = "SSUB_CATEGORY_ID";
             //   }
            }
            catch (Exception ex)
            {
            }
        }
      


        private void back_btn_Click(object sender, EventArgs e)
        {
            impfunc.Remove_Child(this);
        }

        private void frmCategory_KeyDown(object sender, KeyEventArgs e)
        {
          if (e.KeyCode == Keys.Escape)
            {
                impfunc.Remove_Child(this);
            }
        }

        private void add_cat_pic_Click(object sender, EventArgs e)
        {
           frmAddCategory frm = new frmAddCategory();
           
            frm.Tag = 1;
            frm.ShowDialog();
        }

      

        private void add_cat_lbl_Click(object sender, EventArgs e)
        {
            frmAddCategory frm = new frmAddCategory();
         
            frm.Tag = 1;
            frm.ShowDialog();
        }

        private void add_cat_panel_Click(object sender, EventArgs e)
        {
          frmAddCategory frm = new frmAddCategory();
        
            frm.Tag = 1;
            frm.ShowDialog();
        }

        private void add_cat_panel_Paint(object sender, PaintEventArgs e)
        {
            if (add_cat_panel.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 2;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.White, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              add_cat_panel.ClientSize.Width - thickness,
                                                              add_cat_panel.ClientSize.Height - thickness));
                }
            }
        }

        private void add_cat_panel_MouseEnter(object sender, EventArgs e)
        {
            add_cat_panel.BackColor = System.Drawing.Color.FromArgb(24, 14, 22);
        }

        private void add_cat_panel_MouseLeave(object sender, EventArgs e)
        {
            add_cat_panel.BackColor = System.Drawing.Color.Transparent;
        }

        private void add_cat_pic_MouseEnter(object sender, EventArgs e)
        {
            add_cat_panel.BackColor = System.Drawing.Color.FromArgb(24, 14, 22);
        }

        private void add_cat_pic_MouseLeave(object sender, EventArgs e)
        {
            add_cat_panel.BackColor = System.Drawing.Color.Transparent;
        }

        private void add_cat_lbl_MouseEnter(object sender, EventArgs e)
        {
            add_cat_panel.BackColor = System.Drawing.Color.FromArgb(24, 14, 22);
        }

        private void add_cat_lbl_MouseLeave(object sender, EventArgs e)
        {
            add_cat_panel.BackColor = System.Drawing.Color.Transparent;
        }

       
    }
}
