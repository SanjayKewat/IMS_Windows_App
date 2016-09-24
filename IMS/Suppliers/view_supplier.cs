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
    public partial class view_supplier : Form
    {
        public view_supplier()
        {
            InitializeComponent();
        }

        int s_id = suppliers.sup_id;
        private void view_supplier_Load(object sender, EventArgs e)
        {
            show_usr(s_id);
        }


        public void show_usr(int u_id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from SUPPLIER_MASTER where ID=" + u_id, impfunc.cnn);
                  impfunc.cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    fname_txt.Text = reader["first_name"].ToString();
                    lname_txt.Text = reader["last_name"].ToString();
                    usr_addrs.Text = reader["sup_address"].ToString();
                    txt_email.Text = reader["email_id"].ToString();
                    city_txt.Text = reader["city"].ToString();
                    txt_state.Text = reader["sup_state"].ToString();
                    mob_txt.Text = reader["mob_no"].ToString();
                    std_txt.Text = reader["lnd_std"].ToString();
                    phn_txt.Text = reader["lnd_no"].ToString();


                }
                cmd.Dispose();
                  impfunc.cnn.Close();
                reader.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something goes wrong, please close the software and open again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            impfunc.Remove_Child(this);
        }

        private void srch_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Edit_supplier edt = new Edit_supplier();
            edt.ShowDialog();
        }

        private void view_supplier_KeyDown(object sender, KeyEventArgs e)
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
