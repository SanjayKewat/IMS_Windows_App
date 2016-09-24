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

namespace IMS.Customers
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }
        


        private void frmCustomers_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
       
            fill_edit();
            
      
        }

   

        private void frmCustomers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                impfunc.NEXTTAB(this, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                back_btn_Click(sender, e);
            }
        //ElseIf e.KeyCode = Keys.F3 Then
        //    If btnAdd.Enabled = True Then btnAdd_Click(e, e)
        //ElseIf e.KeyCode = Keys.F8 Then
        //    If btnAdd.Enabled = True Then btnAdd_Click(e, e)
        //ElseIf e.KeyCode = Keys.F4 Then
        //    If btnEdit.Enabled = True Then btnEdit_Click(e, e)
        //ElseIf e.KeyCode = Keys.F6 Then
        //    If btnEdit.Enabled = True Then btnEdit_Click(e, e)
        //ElseIf e.KeyCode = Keys.F7 Then
        //    If btnDelete.Enabled = True Then btnDelete_Click(e, e)
        //ElseIf e.KeyCode = Keys.F5 Then
        //    btnReset_Click(e, e)
        //ElseIf e.KeyCode = Keys.Escape Then

        //    btnClose_Click(e, e)
        //ElseIf e.KeyCode = Keys.F2 Then
        //    'txtSearch.Focus()
        //ElseIf e.KeyCode = Keys.F11 Then
        //    chkHideLedger.Checked = True
        //    btnEdit_Click(e, e)
        //    btnEdit_Click(e, e)
        //ElseIf e.KeyCode = Keys.F9 Then
        //    btnLedgerSubGroup_Click(e, e)
        //End If
        }

        private void add_cust_pic_Click(object sender, EventArgs e)
        {
            frmAddCustomer frm = new frmAddCustomer();
            frm.ShowDialog();
            fill_edit();
        }

     

        private void add_cust_lbl_Click(object sender, EventArgs e)
        {
            frmAddCustomer frm = new frmAddCustomer();
            frm.ShowDialog();
            fill_edit();
        }

        private void add_cust_panel_Click(object sender, EventArgs e)
        {
            frmAddCustomer frm = new frmAddCustomer();
            frm.ShowDialog();
            fill_edit();
        }

        private void add_cust_panel_Paint(object sender, PaintEventArgs e)
        {
            if (add_cust_panel.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 2;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.White, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              add_cust_panel.ClientSize.Width - thickness,
                                                              add_cust_panel.ClientSize.Height - thickness));
                }
            }
        }

        private void add_cust_panel_MouseEnter(object sender, EventArgs e)
        {
            add_cust_panel.BackColor = System.Drawing.Color.FromArgb(24, 142, 22);
        }

        private void add_cust_panel_MouseLeave(object sender, EventArgs e)
        {
            add_cust_panel.BackColor = System.Drawing.Color.Transparent;
        }

        private void add_cust_pic_MouseEnter(object sender, EventArgs e)
        {
            add_cust_panel.BackColor = System.Drawing.Color.FromArgb(24, 142, 22);
        }

        private void add_cust_pic_MouseLeave(object sender, EventArgs e)
        {
            add_cust_panel.BackColor = System.Drawing.Color.Transparent;
        }

        private void add_cust_lbl_MouseEnter(object sender, EventArgs e)
        {
            add_cust_panel.BackColor = System.Drawing.Color.FromArgb(24, 142, 22);
        }

        private void add_cust_lbl_MouseLeave(object sender, EventArgs e)
        {
            add_cust_panel.BackColor = System.Drawing.Color.Transparent;
            
        }


        public void fill_edit()
        {
        ////////////// FILL COMB BOX//////////////////////////////////////////////
            impfunc._DTABLE = new DataTable();
              impfunc._Adapter = new SqlDataAdapter("SELECT * FROM CUSTOMER_TYPE_MASTER order by CUSTOMER_TYPE",   impfunc.cnn);
              impfunc._Adapter.Fill(impfunc._DTABLE);
            DataRow row =  impfunc._DTABLE.NewRow();
            row["CUSTOMER_TYPE"] = "<--SELECT TYPE-->";
             impfunc._DTABLE.Rows.InsertAt(row, 0);
            drpdnType.DataSource =  impfunc._DTABLE;

            drpdnType.DisplayMember = "CUSTOMER_TYPE";
            drpdnType.ValueMember = "CUSTOMER_TYPE_ID";

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

             impfunc._DTABLE = new DataTable();
              impfunc._Adapter = new SqlDataAdapter("SELECT CUSTID,FuLL_NAME FROM customer where FuLL_NAME in(select distinct FuLL_NAME from CUSTOMER) order by FuLL_NAME",   impfunc.cnn);
              impfunc._Adapter.Fill(impfunc._DTABLE);
            row =  impfunc._DTABLE.NewRow();
            row["FuLL_NAME"] = "<--SELECT CUSTOMER-->";
             impfunc._DTABLE.Rows.InsertAt(row, 0);
            drpdnCustomer.DataSource =  impfunc._DTABLE;

            drpdnCustomer.DisplayMember = "FuLL_NAME";
            drpdnCustomer.ValueMember = "CUSTID";
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
             impfunc._DTABLE = new DataTable();
              impfunc._Adapter = new SqlDataAdapter("SELECT CUSTID,CITY FROM customer where CITY in(select distinct CITY from CUSTOMER) order by CITY",   impfunc.cnn);
              impfunc._Adapter.Fill(impfunc._DTABLE);
            row =  impfunc._DTABLE.NewRow();
            row["CITY"] = "<--SELECT CITY-->";
             impfunc._DTABLE.Rows.InsertAt(row, 0);
            drpdnCity.DataSource =  impfunc._DTABLE;

            drpdnCity.DisplayMember = "CITY";
            drpdnCity.ValueMember = "CUSTID";
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

             impfunc._DTABLE = new DataTable();
              impfunc._Adapter = new SqlDataAdapter("SELECT CUSTID,STATE FROM customer where STATE in(select distinct STATE from CUSTOMER) order by STATE",   impfunc.cnn);
              impfunc._Adapter.Fill(impfunc._DTABLE);
            row =  impfunc._DTABLE.NewRow();
            row["STATE"] = "<--SELECT STATE-->";
             impfunc._DTABLE.Rows.InsertAt(row, 0);
            drpdnState.DataSource =  impfunc._DTABLE;

            drpdnState.DisplayMember = "STATE";
            drpdnState.ValueMember = "CUSTID";
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

         
             impfunc._DTABLE = new DataTable();
              impfunc._Adapter = new SqlDataAdapter("SELECT CUSTID,CUSTOMERID,FuLL_NAME,FIRST_NAME,LAST_NAME,MOBILE,ADDRESS,EMAIL_ID,DISCOUNT_PLYWOOD,DISCOUNT_HARDWARE FROM CUSTOMER_DETAILS",   impfunc.cnn);
              impfunc._Adapter.Fill(impfunc._DTABLE);
          dg.DataSource =  impfunc._DTABLE;



        }


        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dg.Columns["editBtn"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dg.Rows[e.RowIndex].Cells["colCustId"].Value.ToString());
                frmEditCustomer frm = new frmEditCustomer();
                frm.Tag = id;
                frm.ShowDialog();
                fill_edit();
            }
            if (e.ColumnIndex == dg.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Sure, You want to delete Customer", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(dg.Rows[e.RowIndex].Cells["colCustId"].Value.ToString());
                        SqlCommand cmd = new SqlCommand("delete from CUSTOMER where custid=" + id,   impfunc.cnn);
                          impfunc.cnn.Open();
                        cmd.ExecuteNonQuery();
                        fill_edit();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }

                   
                }
                catch (Exception ex)
                {
                      impfunc.cnn.Close();
                    MessageBox.Show(("ERROR: " + (ex.Message + ("\r\n" + "PLEASE CONTACT Mr. Amit Tiwari"))));
                }
                finally
                {
                      impfunc.cnn.Close();
                }
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            impfunc.Remove_Child(this);
        }

        private void srch_btn_Click(object sender, EventArgs e)
        {
            string condition = "";
            if (drpdnCustomer.SelectedIndex != 0)
            {
                condition=condition+"and FuLL_NAME='" + drpdnCustomer.Text + "'";
            }
            if (drpdnState.SelectedIndex != 0)
            {
                condition = condition + "and STATE='" + drpdnState.Text + "'";
            }
            if (drpdnCity.SelectedIndex != 0)
            {
                condition = condition + "and CITY='" + drpdnCity.Text + "'";
            }
            if (drpdnType.SelectedIndex != 0)
            {
                condition = condition + "and CUSTOMER_TYPE='" + drpdnType.Text + "'";
            }

          
                 impfunc._DTABLE = new DataTable();
                  impfunc._Adapter = new SqlDataAdapter("SELECT CUSTID,CUSTOMERID,FuLL_NAME,FIRST_NAME,LAST_NAME,MOBILE,ADDRESS,EMAIL_ID,DISCOUNT_PLYWOOD,DISCOUNT_HARDWARE FROM CUSTOMER_DETAILS where CUSTID is not null " +condition,   impfunc.cnn);
                  impfunc._Adapter.Fill(impfunc._DTABLE);
                dg.DataSource =  impfunc._DTABLE;
        
        }

    }
}
