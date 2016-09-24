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
    public partial class Edituser : Form
    {
        public Edituser()
        {
            InitializeComponent();
        }

 
        int u_id = users.usr_id;
        private void Edituser_Load(object sender, EventArgs e)
        {
            bind_drop();
            show_usr(u_id);
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
        public void show_usr(int u_id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from user_tab where ID=" + u_id,   impfunc.cnn);
                  impfunc.cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    fname_txt.Text = reader["first_name"].ToString();
                    lname_txt.Text = reader["last_name"].ToString();
                    usr_txt.Text = reader["usr_name"].ToString();
                    pwd_txt.Text = reader["usr_pwd"].ToString();
                    txt_email.Text = reader["email_id"].ToString();
                    usr_addrs.Text = reader["usr_address"].ToString();
                    city_txt.Text = reader["city"].ToString();
                    role_drop.SelectedIndex = Convert.ToInt32(reader["role_id"].ToString());
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
                    try
                    {
                        error.Clear();

                        SqlDataAdapter ad = new SqlDataAdapter();
                        SqlCommand cmd = new SqlCommand(@"update user_tab set first_name=@first_name,last_name=@last_name,usr_name=@usr_name,usr_address=@usr_address,city=@city,email_id=@email_id,mob_no=" + Convert.ToInt32(mob_txt.Text) + ",lnd_std=" + Convert.ToInt32(std_txt.Text) + ",lnd_no=" + Convert.ToInt32(phn_txt.Text) + ",role_id=" + role_drop.SelectedIndex + " where ID="+u_id,   impfunc.cnn);

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


                        MessageBox.Show("User " + usr_txt.Text + " Details updated Successfully !", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       this.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Something goes wrong, please close the software and open again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            impfunc.Remove_Child(this);
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
           update_usr();
        
        }

        private void Edituser_KeyDown(object sender, KeyEventArgs e)
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
