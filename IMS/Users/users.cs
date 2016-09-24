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
using IMS.Users;
using AMIT_FUNCTIONS;

namespace IMS
{
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
        }
 
        public static int usr_id = 0;

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
            add_usr_panel.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
        }
        public void add_usr_MouseLeave()
        {
            add_usr_panel.BackColor = System.Drawing.Color.Transparent;
        }

        private void add_usr_panel_MouseEnter(object sender, EventArgs e)
        {
            add_usr_MouseEnter();
        }

        private void add_usr_panel_MouseLeave(object sender, EventArgs e)
        {
            add_usr_MouseLeave();
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

        private void users_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            bind_grid();
            bind_drop();
        }

        private void back_btn_MouseHover(object sender, EventArgs e)
        {
            back_btn_color();
        }

        public void back_btn_color()
        {
            back_btn.BackColor = Color.FromArgb(40, 44, 48);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            impfunc.Remove_Child(this);
            back_btn_color();


        }

        public void bind_grid()
        {
            SqlDataAdapter ad = new SqlDataAdapter("select id,user_id,first_name,last_name,usr_name,role_name,mob_no,usr_address,email_id from user_view order by id desc",   impfunc.cnn);
            DataTable dt = new System.Data.DataTable();
            ad.Fill(dt);
            usr_grd.DataSource = dt;
            // this.dataGridView1.Columns[0].Visible = false;
            ad.Dispose(); dt.Dispose();
        }

        public void bind_drop()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from role_master",   impfunc.cnn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            role_drop.DisplayMember = "role_name";
            role_drop.ValueMember = "id";
            role_drop.DataSource = dt;
        }

        public void add_userfrm()
        {
            add_usr_frm usr = new add_usr_frm();
            usr.ShowDialog();
            bind_grid();
        }

        private void add_usr_panel_Click(object sender, EventArgs e)
        {
            add_userfrm();
        }

        private void add_usr_pic_Click(object sender, EventArgs e)
        {
            add_userfrm();
        }

        private void add_lbl_Click(object sender, EventArgs e)
        {
            add_userfrm();
        }

        private void usr_grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == usr_grd.Columns["editBtn"].Index && e.RowIndex >= 0)
            {
                //MessageBox.Show("Edit ID : "+usr_grd.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                usr_id = Convert.ToInt32(usr_grd.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                Edituser edt = new Edituser();
                edt.ShowDialog();
                bind_grid();
            }
            if (e.ColumnIndex == usr_grd.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                // MessageBox.Show("Deleted ID : "+usr_grd.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                usr_id = Convert.ToInt32(usr_grd.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                delete(usr_id);
            }


        }

        public void delete(int u_id)
        {

            try
            {
                DialogResult dr = new System.Windows.Forms.DialogResult();
                dr = MessageBox.Show(this, "Are You Sure ? You want to delete records...", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

                if (dr == DialogResult.Yes)
                {
                    SqlDataAdapter da = new SqlDataAdapter("delete user_tab where ID=" + u_id,   impfunc.cnn);
                    DataSet ds = new DataSet();

                    //Fill the DataSet.
                    da.Fill(ds, "user_tab");

                    da.Dispose();
                    ds.Dispose();

                    bind_grid();
                    MessageBox.Show("Data Deleted Successfully !","Deleted",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete Operation Cancel !", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch { MessageBox.Show("Please Select a Row First !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }

        private void srch_btn_Click(object sender, EventArgs e)
        {
            search_usr();
        }
        public void search_usr()
        {
            string query = "";
            if ((fname_txt.Text.Length == 0) && (lname_txt.Text.Length == 0))
            {
                query = "select id,user_id,first_name,last_name,usr_name,role_name,mob_no,usr_address,email_id from user_view where role_id=" + role_drop.SelectedIndex;
            }
            else if ((fname_txt.Text.Length != 0) && (role_drop.SelectedIndex != 0))
            {
                query = "select id,user_id,first_name,last_name,usr_name,role_name,mob_no,usr_address,email_id from user_view where first_name='" + fname_txt.Text.Trim() + "' and role_id=" + role_drop.SelectedIndex;
            }
            else if (fname_txt.Text.Length != 0)
            {
                query = "select id,user_id,first_name,last_name,usr_name,role_name,mob_no,usr_address,email_id from user_view where first_name='" + fname_txt.Text.Trim() + "'";
            }
            else
            {
                query = "select id,user_id,first_name,last_name,usr_name,role_name,mob_no,usr_address,email_id from user_view where first_name='" + fname_txt.Text.Trim() + "' and last_name='" + lname_txt.Text.Trim() + "' and role_id=" + role_drop.SelectedIndex;
            }

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
                MessageBox.Show("Something goes wrong, please close the software and open again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void reset()
        {
            fname_txt.Clear();
            lname_txt.Clear();
            role_drop.SelectedIndex = 0;
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            bind_grid();
            reset();
        }

        private void users_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                impfunc.NEXTTAB(this, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                impfunc.Remove_Child(this);
            }
        }
    }
}