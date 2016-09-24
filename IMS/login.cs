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
using System.Configuration;
using AMIT_FUNCTIONS;

namespace IMS
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
  

        private void login_btn_Click(object sender, EventArgs e)
        {
            check_login();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
           
        }

        public void check_login()
        {
            try
            {
                if ((txt_usr.Text.Length != 0) && (txt_pwd.Text.Length != 0))
                {
                    lbl_error.Visible = false;
                 //   SqlConnection con = new SqlConnection(db.sqlcon);

                    SqlCommand cmd = new SqlCommand("select * from user_view where usr_name=@usr and usr_pwd=@pwd", impfunc.cnn);
                    cmd.Parameters.AddWithValue("@usr", txt_usr.Text);
                    cmd.Parameters.AddWithValue("@pwd", txt_pwd.Text);
                    impfunc.OPENCONNECTION();

                    SqlDataReader read = cmd.ExecuteReader();
                    read.Read();
                    if (read.HasRows)
                    {
                        impfunc._LOGINID = Convert.ToInt32(read["ID"]);
                        impfunc._USERNAME = read["usr_name"].ToString();
                        impfunc._USERTYPE = read["role_name"].ToString();
                        this.Close();
                        read.Dispose();
                        cmd.Dispose();
                        impfunc.CLOSECONNECTION();
                        frmFinancialYear frm = new frmFinancialYear();
                        frm.Show();

                    }
                    else
                    {
                        read.Dispose();
                        cmd.Dispose();
                        impfunc.CLOSECONNECTION();
                        lbl_error.Visible = true;
                        lbl_error.Text = "*** Invalid Username and Password." + Environment.NewLine + "Please enter the correct Username and Password.?";
                    }
                    read.Dispose();
                    cmd.Dispose();
                    impfunc.cnn.Close();

                }
                else if ((txt_usr.Text.Length == 0) && (txt_pwd.Text.Length == 0))
                {
                    txt_usr.Focus();
                    lbl_error.Visible = true;
                    lbl_error.Text = "*** Make sure Username & Password cannot be blank..?";
                }
                else if (txt_usr.Text.Length == 0)
                {
                    txt_usr.Focus();
                    lbl_error.Visible = true;
                    lbl_error.Text = "*** Make sure Username cannot be blank.?";
                }
                else if (txt_pwd.Text.Length == 0)
                {
                    txt_pwd.Focus();
                    lbl_error.Visible = true;
                    lbl_error.Text = "*** Make sure Password cannot be blank.?";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something goes wrong : "+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
                       

        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                impfunc.NEXTTAB(this, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

   

        private void btnLogin_Click(object sender, EventArgs e)
        {
            check_login();
        } 

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {
            impfunc._COMPANYID = 1;
      string  SERVERNAME = ConfigurationManager.AppSettings["Sname"];
     string   dataBaseName = ConfigurationManager.AppSettings["dname"];
     string REPORTSPATH = Application.StartupPath + ConfigurationManager.AppSettings["ShareFolder"];
   impfunc.SET_CONNECTIONSTRING(SERVERNAME, dataBaseName);

        }

       

   

        
    }
}
