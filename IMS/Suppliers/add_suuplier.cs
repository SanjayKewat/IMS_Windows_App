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
    public partial class add_suuplier : Form
    {
        public add_suuplier()
        {
            InitializeComponent();
        }
        int LedgerID;
  
        private void srch_btn_Click(object sender, EventArgs e)
        {
            save_user();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void save_user()
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
              

                    error.Clear();
                   
                    string name = fname_txt.Text + " " + lname_txt.Text;
                    if (impfunc.EXISTS_RECORD(impfunc.cnn, "Ledger", "NAME", "NAME='" + name + "' and ADDRESS1 ='" + usr_addrs.Text + "' and MOBILE ='" + mob_txt.Text + "' and COMPANYID=" + impfunc._COMPANYID + "", true) == true)
                    {
                        fname_txt.Focus();
                        return;
                    }
                    LedgerID = impfunc.GENERATE_MAX(impfunc.cnn, "LEDGER", "LEDGERID", "LEDGERID>299");
                    if (LedgerID == 1)
                    {
                        LedgerID = 300;
                    }
                    try
                    {
                        impfunc._Command = new SqlCommand();
               impfunc._Command.Connection =impfunc.cnn;
              impfunc.cnn.Open();
              impfunc._TR = impfunc.cnn.BeginTransaction(IsolationLevel.ReadCommitted);
                impfunc._Command.Transaction = impfunc._TR;
                impfunc.SAVE_RECORDS(impfunc.cnn, "LEDGER", impfunc._TR, "LEDGERID", "CompanyId", "LEDGERSUBGROUPID", "NAME", "OPENINGBALANCEDR",
                   "OPENINGBALANCECR", "ADDRESS1", "ADDRESS2", "PARTY_DL_NO", "PHONE2", "MOBILE", "FAX", "CITY", "STATE",
                   "COUNTRY", "TINNO", "STNO", "CSTNO", "CONT_PERSON", "DESIG", "EditAllowed", "PANNO", "LEDGERCODE",
                   LedgerID.ToString(), impfunc._COMPANYID.ToString(), "14",
                   name, "0", "0", usr_addrs.Text, usr_addrs.Text,
                  "", phn_txt.Text, mob_txt.Text, "", city_txt.Text,
                   txt_state.Text, "India", "", "", "",
                  "", "", "Y", "", "0");
                impfunc.SAVE_RECORDS(impfunc.cnn, "SUPPLIER_MASTER", impfunc._TR, "first_name", "last_name", "sup_address", "city", "sup_state", "mob_no", "lnd_std", "lnd_no", "email_id", "LedgerId", fname_txt.Text, lname_txt.Text, usr_addrs.Text, city_txt.Text, txt_state.Text, mob_txt.Text, std_txt.Text, phn_txt.Text, txt_email.Text,LedgerID.ToString());

                DateTime dt;
                if ((DateTime.Now.Month == 1) || (DateTime.Now.Month == 2)|| (DateTime.Now.Month == 3))
                {
                    dt = DateTime.Parse(("1/Apr/" + (DateTime.Now.Year - 1)));
                }
                else
                {
                    dt = DateTime.Parse(("1/Apr/" + DateTime.Now.Year));
                }

                impfunc.SAVE_IN_JOURNAL(impfunc.cnn, impfunc._TR, Convert.ToInt32(impfunc._COMPANYID), Convert.ToInt32(LedgerID), 0, dt.ToString("dd-MMM-yyyy"), 0, "Opening_Balance", "Opening_Balance", "Opening_Balance", "0", "0",0, 0, Convert.ToInt32(impfunc._FYEARID), 0, "1/1/1990");
              impfunc._TR.Commit();
              impfunc.cnn.Close();
//                    impfunc._Adapter = new SqlDataAdapter();
//                    SqlCommand cmd = new SqlCommand(@"insert into SUPPLIER_MASTER(first_name,last_name,sup_address,city,sup_state,mob_no,lnd_std,lnd_no,email_id)values(@first_name,@last_name,@sup_address
//                        ,@city,@sup_state," + Convert.ToInt32(mob_txt.Text) + "," + Convert.ToInt32(std_txt.Text) + "," + Convert.ToInt32(phn_txt.Text) + ",@email_id)", impfunc.cnn);

//                    cmd.Parameters.AddWithValue("@first_name", fname_txt.Text);
//                    cmd.Parameters.AddWithValue("@last_name", lname_txt.Text);
//                    cmd.Parameters.AddWithValue("@sup_address", usr_addrs.Text);
//                    cmd.Parameters.AddWithValue("@city", city_txt.Text);
//                    cmd.Parameters.AddWithValue("@sup_state", txt_state.Text);
//                    cmd.Parameters.AddWithValue("@email_id", txt_email.Text);
//                    impfunc._Adapter.SelectCommand = cmd;
//                    DataTable dt = new DataTable();
//                    impfunc._Adapter.Fill(dt);
//                    impfunc._Adapter.Dispose(); cmd.Dispose(); dt.Dispose();


                    MessageBox.Show("New Supplier " + fname_txt.Text + " " + lname_txt.Text + " Added Successfully !", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                }
                catch (Exception ex)
                {
                      impfunc._TR.Rollback();
                      impfunc.cnn.Close();
                    MessageBox.Show("Something goes wrong, please close the software and open again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
                   
    }
   
        private void reset()
        {
            error.Clear();
            fname_txt.Clear();
            lname_txt.Clear();          
            txt_email.Clear();
            usr_addrs.Clear();
            city_txt.Clear();
            txt_state.Clear();
            mob_txt.Clear();
            std_txt.Clear();
            phn_txt.Clear();
          


        }

        private void mob_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            impfunc.CHECK_NUMERIC_VALUE(mob_txt, e);
        }

        private void std_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            impfunc.CHECK_NUMERIC_VALUE(std_txt, e);
        }

        private void phn_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            impfunc.CHECK_NUMERIC_VALUE(phn_txt, e);
        }

        private void add_suuplier_KeyDown(object sender, KeyEventArgs e)
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

        private void add_suuplier_Load(object sender, EventArgs e)
        {

        }
    }
}
