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
using IMS.Category;
using AMIT_FUNCTIONS;

namespace IMS.Inventory
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
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

        private void pnlAddItem_Paint(object sender, PaintEventArgs e)
        {
            if (pnlAddItem.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 2;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.White, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              pnlAddItem.ClientSize.Width - thickness,
                                                              pnlAddItem.ClientSize.Height - thickness));
                }
            }
      
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            fill_grid();
        }


        private void fill_grid()
        {
            impfunc._DTABLE = new DataTable();
            impfunc._Adapter = new SqlDataAdapter("SELECT ITEM_ID,ITEM_CODE,ITEM_NAME,CATEGORY_NAME,SUBCATEGORY_VALUE,SSUBCATEGORY_VALUE,OPGQTY,PURCHASEPRICE,SALEPRICE FROM ITEM_MASTER_VIEW order by ITEM_NAME", impfunc.cnn);
              impfunc._Adapter.Fill(impfunc._DTABLE);

            dg.DataSource =  impfunc._DTABLE;
        }

        private void pnlAddItem_MouseEnter(object sender, EventArgs e)
        {
            pnlAddItem.BackColor = System.Drawing.Color.FromArgb(128, 57, 123);
        }

        private void add_item_pic_MouseEnter(object sender, EventArgs e)
        {
            pnlAddItem.BackColor = System.Drawing.Color.FromArgb(128, 57, 123);
        }

        private void lblAddItem_MouseEnter(object sender, EventArgs e)
        {
            pnlAddItem.BackColor = System.Drawing.Color.FromArgb(128, 57, 123);
        }

        private void pnlAddItem_MouseLeave(object sender, EventArgs e)
        {
            pnlAddItem.BackColor = System.Drawing.Color.Transparent;
        }

        private void add_item_pic_MouseLeave(object sender, EventArgs e)
        {
            pnlAddItem.BackColor = System.Drawing.Color.Transparent;
        }

        private void lblAddItem_MouseLeave(object sender, EventArgs e)
        {
            pnlAddItem.BackColor = System.Drawing.Color.Transparent;
        }

        private void add_cat_panel_MouseEnter(object sender, EventArgs e)
        {
            add_cat_panel.BackColor = System.Drawing.Color.FromArgb(24, 14, 22);
        }

        private void add_cat_pic_MouseEnter(object sender, EventArgs e)
        {
            add_cat_panel.BackColor = System.Drawing.Color.FromArgb(24, 14, 22);
        }

        private void add_cat_lbl_MouseEnter(object sender, EventArgs e)
        {
            add_cat_panel.BackColor = System.Drawing.Color.FromArgb(24, 14, 22);
        }

        private void add_cat_panel_MouseLeave(object sender, EventArgs e)
        {
            add_cat_lbl.BackColor = System.Drawing.Color.Transparent;
        }

        private void add_cat_pic_MouseLeave(object sender, EventArgs e)
        { 
            add_cat_lbl.BackColor = System.Drawing.Color.Transparent;
        }

        private void add_cat_lbl_MouseLeave(object sender, EventArgs e)
        {
            add_cat_lbl.BackColor = System.Drawing.Color.Transparent;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            impfunc.Remove_Child(this);
        }

        private void frmInventory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                impfunc.Remove_Child(this);
            }
        }

        private void add_item_pic_Click(object sender, EventArgs e)
        {
            frmAddItem frm = new frmAddItem();
            frm.ShowDialog();
            fill_grid();
        }

        private void lblAddItem_Click(object sender, EventArgs e)
        {
            frmAddItem frm = new frmAddItem();
            frm.ShowDialog();
            fill_grid();
        }

        private void pnlAddItem_Click(object sender, EventArgs e)
        {
            frmAddItem frm = new frmAddItem();
            frm.ShowDialog();
            fill_grid();
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dg.Columns["editBtn"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dg.Rows[e.RowIndex].Cells["colItemId"].Value.ToString());
                frmEditItem frm = new frmEditItem();
              frm.Tag = id;
              frm.ShowDialog();
                fill_grid();
            }
            if (e.ColumnIndex == dg.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dg.Rows[e.RowIndex].Cells["colItemId"].Value.ToString());
             
                    DialogResult dialogResult = MessageBox.Show("Sure, You want to delete Customer", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            impfunc._Command = new SqlCommand();
                            impfunc._Command.Connection = impfunc.cnn;
                            impfunc.cnn.Open();
                            impfunc._TR = impfunc.cnn.BeginTransaction(IsolationLevel.ReadCommitted);
                            impfunc._Command.Transaction = impfunc._TR;

                            impfunc.DELETE_RECORDS(impfunc.cnn, "ITEM_MASTER", impfunc._TR, "ITEM_ID", id);
                            impfunc.DELETE_RECORDS(impfunc.cnn, "ITEM_SUB_DETAIL", impfunc._TR, "ITEM_ID", id);
                            impfunc._TR.Commit();
                            impfunc.cnn.Close();
                            fill_grid();
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
        }

        private void add_cat_pic_Click(object sender, EventArgs e)
        {
            frmAddCategory frm = new frmAddCategory();
            frm.ShowDialog();
        }

        private void add_cat_lbl_Click(object sender, EventArgs e)
        {
            frmAddCategory frm = new frmAddCategory();
            frm.ShowDialog();
        }

        private void add_cat_panel_Click(object sender, EventArgs e)
        {
            frmAddCategory frm = new frmAddCategory();
            frm.ShowDialog();
        }
    }
}
