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

namespace IMS.Users
{
    public partial class add_usr_frm : Form
    {
        public add_usr_frm()
        {
            InitializeComponent();
        }
        users usr = new users();
  
        public void bind_drop()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from role_master",   impfunc.cnn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            role_drop.DisplayMember = "role_name";
            role_drop.ValueMember = "id";
            role_drop.DataSource = dt;
        }

        private void add_usr_frm_Load(object sender, EventArgs e)
        {
            bind_drop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void srch_btn_Click(object sender, EventArgs e)
        {
            save_user();
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
            
            if (usr_txt.Text.Length == 0)
            {
                error.SetError(usr_txt, "UserName cannot be blank..!");
            }
            if (std_txt.Text.Length == 0)
            {
                std_txt.Text = "0";
            }
            if (phn_txt.Text.Length == 0)
            {
                phn_txt.Text = "0";
            }
            if (pwd_txt.Text.Length == 0)
            {
                error.SetError(pwd_txt, "Password cannot be blank..!");
            }

            //if (txt_email.Text.Length == 0)
            //{
            //    error.SetError(txt_email, "Email cannot be blank..!");
            //}

            if (mob_txt.Text.Length == 0)
            {
                error.SetError(mob_txt, "Mobile Number cannot be blank..!");
            }

            if (role_drop.SelectedIndex == 0)
            {
                error.SetError(role_drop, "First select Role..!");
            }

            else
            {
                if (1 == check_uname())
                {

                    try
                    {
                        error.Clear();

                        SqlDataAdapter ad = new SqlDataAdapter();
                        SqlCommand cmd = new SqlCommand(@"insert into user_tab(first_name,last_name,usr_name,usr_pwd,usr_address,city,mob_no,lnd_std,lnd_no,role_id,email_id)values(@first_name,@last_name,@usr_name,@usr_pwd,
                @usr_address,@city," + Convert.ToInt32(mob_txt.Text) + "," + Convert.ToInt32(std_txt.Text) + "," + Convert.ToInt32(phn_txt.Text) + "," + role_drop.SelectedIndex + ",@email_id)",   impfunc.cnn);

                        cmd.Parameters.AddWithValue("@first_name", fname_txt.Text);
                        cmd.Parameters.AddWithValue("@last_name", lname_txt.Text);
                        cmd.Parameters.AddWithValue("@usr_name", usr_txt.Text);
                        cmd.Parameters.AddWithValue("@usr_pwd", pwd_txt.Text);
                        cmd.Parameters.AddWithValue("@usr_address", usr_addrs.Text);
                        cmd.Parameters.AddWithValue("@city", city_txt.Text);
                        cmd.Parameters.AddWithValue("@email_id", txt_email.Text);
                        ad.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        ad.Fill(dt);
                        ad.Dispose(); cmd.Dispose(); dt.Dispose();


                        MessageBox.Show("New User " + usr_txt.Text + " Added Successfully !", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reset();
                    }
                    catch (Exception ex)
                    {
                       
                        MessageBox.Show("Something goes wrong, please close the software and open again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reset();
                        
                    }
                }
            }
           
        }

        private void reset()
        {
            error.Clear();
            fname_txt.Clear();
            lname_txt.Clear();
            usr_txt.Clear();
            pwd_txt.Clear();
            txt_email.Clear();
            usr_addrs.Clear();
            city_txt.Clear();
            mob_txt.Clear();
            std_txt.Clear();
            phn_txt.Clear();
            role_drop.SelectedIndex = 0;


        }

        private int check_uname()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from user_tab where usr_name=@usr",   impfunc.cnn);
                cmd.Parameters.AddWithValue("@usr", usr_txt.Text);
                  impfunc.cnn.Open();
                SqlDataReader read = cmd.ExecuteReader();
                read.Read();
                if (read.HasRows)
                {

                    read.Dispose();
                    cmd.Dispose();
                      impfunc.cnn.Close();
                    MessageBox.Show("UserName " + usr_txt.Text + " already exist,try with another Username..!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return -1;

                }
                else
                {

                    read.Dispose();
                    cmd.Dispose();
                      impfunc.cnn.Close();
                    return 1;
                }
            }
            catch (Exception ex)
            {
               
                return 1;
            }
           
           
        }

        private void usr_txt_TextChanged(object sender, EventArgs e)
        {
            int result = check_uname();
            
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

        private void add_usr_frm_KeyDown(object sender, KeyEventArgs e)
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
