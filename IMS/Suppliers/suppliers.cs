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

namespace IMS.Suppliers
{
    public partial class suppliers : Form
    {
        public suppliers()
        {
            InitializeComponent();
        }

        public static int sup_id = 0;
        public static int LedgerId = 0;
        private void add_usr_panel_Paint(object sender, PaintEventArgs e)
        {
            if (add_usr_panel.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 2;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.White, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              add_usr_panel.ClientSize.Width - thickness,
                                                              add_usr_panel.ClientSize.Height - thickness));
                }
            }
        }

        public void add_usr_MouseEnter()
        {
            add_usr_panel.BackColor = System.Drawing.Color.FromArgb(70, 71, 68);
        }
        public void add_usr_MouseLeave()
        {
            add_usr_panel.BackColor = System.Drawing.Color.Transparent;
        }

        private void add_usr_panel_MouseLeave(object sender, EventArgs e)
        {
            add_usr_MouseLeave();
        }

        private void add_usr_panel_MouseEnter(object sender, EventArgs e)
        {
            add_usr_MouseEnter();
        }

        private void add_usr_pic_MouseEnter(object sender, EventArgs e)
        {
            add_usr_MouseEnter();
        }

        private void add_usr_pic_MouseLeave(object sender, EventArgs e)
        {
            add_usr_MouseLeave();
        }

        private void add_lbl_MouseEnter(object sender, EventArgs e)
        {
            add_usr_MouseEnter();
        }

        private void add_lbl_MouseLeave(object sender, EventArgs e)
        {
            add_usr_MouseLeave();
        }

        private void add_usr_panel_Click(object sender, EventArgs e)
        {
            add_suppfrm();
        }
        public void add_suppfrm()
        {
            add_suuplier usr = new add_suuplier();
            usr.ShowDialog();
            bind_data();
           
        }

        private void add_usr_pic_Click(object sender, EventArgs e)
        {
            add_suppfrm();
        }

        private void add_lbl_Click(object sender, EventArgs e)
        {
            add_suppfrm();
        }

        public void bind_grid()
        {
            SqlDataAdapter ad = new SqlDataAdapter("select id,LedgerId,supplier_id,SUP_FULLNAME,mob_no,sup_address,email_id from SUPPLIER_MASTER order by supplier_id", impfunc.cnn);
            DataTable dt = new System.Data.DataTable();
            ad.Fill(dt);
            usr_grd.DataSource = dt;
            // this.dataGridView1.Columns[0].Visible = false;
            ad.Dispose(); dt.Dispose();  
        }

        private void suppliers_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            bind_data();
        }

        public void bind_data()
        {
            bind_grid();
            bind_sup();
            bind_city();
            bind_state();
        }

        private void usr_grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == usr_grd.Columns["editBtn"].Index && e.RowIndex >= 0)
            {
                //MessageBox.Show("Edit ID : "+usr_grd.Rows[e.RowIndex].Cells["ID"].Value.ToString());LedgerId
                sup_id = Convert.ToInt32(usr_grd.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                LedgerId = Convert.ToInt32(usr_grd.Rows[e.RowIndex].Cells["colLEDGERID"].Value.ToString());
                Edit_supplier edt = new Edit_supplier();
               edt.ShowDialog();
               bind_data();
            }
            if (e.ColumnIndex == usr_grd.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                // MessageBox.Show("Deleted ID : "+usr_grd.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                sup_id = Convert.ToInt32(usr_grd.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            LedgerId = Convert.ToInt32(usr_grd.Rows[e.RowIndex].Cells["colLEDGERID"].Value.ToString());
             
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

                            impfunc.DELETE_RECORDS(impfunc.cnn, "SUPPLIER_MASTER", impfunc._TR, "ID", sup_id);
                            impfunc.DELETE_RECORDS(impfunc.cnn, "LEDGER", impfunc._TR, "LedgerId", LedgerId);
                            impfunc.DELETE_RECORDS(impfunc.cnn, "JOURNAL", impfunc._TR, "LedgerId", LedgerId);
                            impfunc._TR.Commit();
                            impfunc.cnn.Close();
                           bind_data();
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
            if (e.ColumnIndex == usr_grd.Columns["btnAccount"].Index && e.RowIndex >= 0)
            {
                // MessageBox.Show("Deleted ID : "+usr_grd.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                sup_id = Convert.ToInt32(usr_grd.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                view_supplier edt = new view_supplier();
                edt.ShowDialog();
                bind_data();
            }
        }


        public class ComboBoxItem
        {
            public string Value;
            public string Text;

            public ComboBoxItem(string val, string text)
            {
                Value = val;
                Text = text;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        public void bind_sup()
        {
            drp_sup.Items.Clear();

            drp_sup.Items.Add(new ComboBoxItem("0", "Select Supplier"));
            SqlCommand cmd = new SqlCommand("select distinct SUP_FULLNAME from SUPPLIER_MASTER", impfunc.cnn);
              impfunc.cnn.Open();
            int i = 0;            
            SqlDataReader reader = cmd.ExecuteReader();
         
           while(reader.Read()) {
                i++;

                drp_sup.Items.Add(new ComboBoxItem(i.ToString(), reader["SUP_FULLNAME"].ToString()));

            }         

              impfunc.cnn.Close();
            reader.Dispose();
            cmd.Dispose();
           drp_sup.SelectedIndex = 0;
        }

        public void bind_city()
        {

            drp_city.Items.Clear();
            drp_city.Items.Add(new ComboBoxItem("0", "Select City"));
            SqlCommand cmd = new SqlCommand("select distinct city from SUPPLIER_MASTER", impfunc.cnn);
              impfunc.cnn.Open();
            int i = 0;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                i++;

                drp_city.Items.Add(new ComboBoxItem(i.ToString(), reader["city"].ToString()));

            }

              impfunc.cnn.Close();
            reader.Dispose();
            cmd.Dispose();
            drp_city.SelectedIndex = 0;
        }

        public void bind_state()
        {
            drp_state.Items.Clear();

            drp_state.Items.Add(new ComboBoxItem("0", "Select State"));
            SqlCommand cmd = new SqlCommand("select distinct sup_state from SUPPLIER_MASTER", impfunc.cnn);
              impfunc.cnn.Open();
            int i = 0;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                i++;

                drp_state.Items.Add(new ComboBoxItem(i.ToString(), reader["sup_state"].ToString()));

            }

              impfunc.cnn.Close();
            reader.Dispose();
            cmd.Dispose();

            drp_state.SelectedIndex = 0;
        }

        public void reset()
        {
             drp_city. SelectedIndex = 0;
            drp_state.SelectedIndex = 0;
            drp_sup.SelectedIndex = 0;
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            reset();
            bind_data();
        }

        private void srch_btn_Click(object sender, EventArgs e)
        {
            search_usr();
        }

        public void search_usr()
        {
           // MessageBox.Show("Sup : " + drp_sup.SelectedIndex.ToString() + " City : " + drp_city.SelectedIndex.ToString()+" State : "+drp_state.SelectedIndex.ToString());
          //  MessageBox.Show(drp_city.Text);
            string query = "";
            if ((drp_sup.SelectedIndex != 0) && (drp_city.SelectedIndex != 0) && (drp_state.SelectedIndex != 0))
            {
                query = "select id,supplier_id,SUP_FULLNAME,mob_no,sup_address,email_id from SUPPLIER_MASTER where SUP_FULLNAME='" + drp_sup.Text + "' and city='" + drp_city.Text + "' and sup_state='" + drp_state.Text + "'";
            }
            else if ((drp_sup.SelectedIndex != 0) && (drp_state.SelectedIndex != 0))
            {
                query = "select id,supplier_id,SUP_FULLNAME,mob_no,sup_address,email_id from SUPPLIER_MASTER where SUP_FULLNAME='" + drp_sup.Text + "' and sup_state='" + drp_state.Text + "'";
            }
            else if ((drp_sup.SelectedIndex != 0) && (drp_city.SelectedIndex != 0))
            {
                query = "select id,supplier_id,SUP_FULLNAME,mob_no,sup_address,email_id from SUPPLIER_MASTER where SUP_FULLNAME='" + drp_sup.Text + "' and city='" + drp_city.Text + "'";
            }
            else if (drp_sup.SelectedIndex != 0)
            {
                query = "select id,supplier_id,SUP_FULLNAME,mob_no,sup_address,email_id from SUPPLIER_MASTER where SUP_FULLNAME='" + drp_sup.Text + "' order by id desc";
            }
            else if (drp_city.SelectedIndex != 0)
            {
                query = "select id,supplier_id,SUP_FULLNAME,mob_no,sup_address,email_id from SUPPLIER_MASTER where city='" + drp_city.Text + "' order by id desc";
            }
            else if (drp_state.SelectedIndex != 0)
            {
                query = "select id,supplier_id,SUP_FULLNAME,mob_no,sup_address,email_id from SUPPLIER_MASTER where sup_state='" + drp_state.Text + "' order by id desc";
            }
            else
            {
                query = "select id,supplier_id,SUP_FULLNAME,mob_no,sup_address,email_id from SUPPLIER_MASTER where city='" + drp_city.Text + "' and sup_state='" + drp_state.Text + "' order by id desc";
            }

        //    MessageBox.Show(query);

            try
            {

                SqlDataAdapter ad = new SqlDataAdapter(query,   impfunc.cnn);
                DataTable dt = new System.Data.DataTable();
                ad.Fill(dt);
                usr_grd.DataSource = dt;
                // this.dataGridView1.Columns[0].Visible = false;
                ad.Dispose(); dt.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("First Select any field then click on Search button.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            query = "";
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            impfunc.Remove_Child(this);
        }

        private void suppliers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                impfunc.Remove_Child(this);
            }
        }
    }
}
