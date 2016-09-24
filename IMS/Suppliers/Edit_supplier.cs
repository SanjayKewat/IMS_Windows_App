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
    public partial class Edit_supplier : Form
    {
     
        int s_id = suppliers.sup_id;
        int LedgerId = suppliers.LedgerId;
        public Edit_supplier()
        {
            InitializeComponent();
        }

        private void Edit_supplier_Load(object sender, EventArgs e)
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


        private void update_usr()
        {
            if (fname_txt.Text.Length == 0)
            {
                error.SetError(fname_txt, "FirstName cannot be blank..!");
            }

            if (lname_txt.Text.Length == 0)
            {
                error.SetError(lname_txt, "LastName cannot be blank..!");
            }

            if (std_txt.Text.Length == 0)
            {
                std_txt.Text = "0";
            }
            if (phn_txt.Text.Length == 0)
            {
                phn_txt.Text = "0";
            }
            if (city_txt.Text.Length == 0)
            {
                error.SetError(city_txt, "City cannot be blank..!");
            }

            if (txt_state.Text.Length == 0)
            {
                error.SetError(txt_state, "State cannot be blank..!");
            }

            if (mob_txt.Text.Length == 0)
            {
                error.SetError(mob_txt, "Mobile Number cannot be blank..!");
            }

            else
            {
                try
                {
                    error.Clear();
                    impfunc._COMPANYID = 1;
                    impfunc._FYEARID = 1;
                    string name = fname_txt.Text + " " + lname_txt.Text;
                    if (impfunc.EXISTS_RECORD(impfunc.cnn, "Ledger", "NAME", "NAME='" + name + "' and ADDRESS1 ='" + usr_addrs.Text + "' and MOBILE ='" + mob_txt.Text + "' and COMPANYID=" + impfunc._COMPANYID + "", true) == true)
                    {
                        fname_txt.Focus();
                        return;
                    }

                    impfunc._Command = new SqlCommand();
                    impfunc._Command.Connection = impfunc.cnn;
                    impfunc.cnn.Open();
                    impfunc._TR = impfunc.cnn.BeginTransaction(IsolationLevel.ReadCommitted);
                    impfunc._Command.Transaction = impfunc._TR;
                    
                    impfunc.UPDATE_RECORDS(impfunc.cnn, "Ledger", impfunc._TR,"NAME", "ADDRESS1","PHONE2", "MOBILE","CITY", "STATE",name.ToString(),usr_addrs.Text,std_txt.Text,mob_txt.Text,city_txt.Text,txt_state.Text, "LEDGERID", Convert.ToInt32(LedgerId));
                    impfunc.UPDATE_RECORDS(impfunc.cnn, "SUPPLIER_MASTER", impfunc._TR, "first_name", "last_name", "sup_address", "city", "sup_state", "email_id", "mob_no", "lnd_std", "lnd_no", fname_txt.Text, lname_txt.Text, usr_addrs.Text, city_txt.Text, txt_state.Text, txt_email.Text, mob_txt.Text, std_txt.Text, phn_txt.Text, "ID", Convert.ToInt32(s_id));

                    impfunc._TR.Commit();
                   impfunc.cnn.Close();

                    MessageBox.Show("Supplier " + fname_txt.Text + " " + lname_txt.Text + " Details updated Successfully !", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    impfunc._TR.Rollback();
               impfunc.cnn.Close();

                    MessageBox.Show("Something goes wrong, please close the software and open again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void srch_btn_Click(object sender, EventArgs e)
        {
            update_usr();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            impfunc.Remove_Child(this);
        }

        private void Edit_supplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                impfunc.Remove_Child(this);
            }
            if (e.KeyCode == Keys.Enter)
            {
                impfunc.NEXTTAB(this, e);
            }
        }
    }
}
