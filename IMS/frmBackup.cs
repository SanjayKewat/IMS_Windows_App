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

namespace IMS
{
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }
  
  
        string dataBaseName = "IMS";

          private void setProgressValue(int value)
    {
        pb.Value = value;
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            
            savefile.DefaultExt = "SqlBackup";
            savefile.Filter = "SQL SERVER DATA BACKUP (*.SqlBackup)|*.SqlBackup";
            savefile.Title = (dataBaseName + " DATA BACKUP");
            //savefile.FileName = savefile.FileName = dataBaseName;
            savefile.FileName = (dataBaseName + "_" + String.Format("{0:ddd, MMM d, yyyy}", DateTime.Now));
            try
            {
                savefile.InitialDirectory = (Application.StartupPath + "\\DATA BACKUP\\");
            }
            catch (Exception ex)
            {
                savefile.InitialDirectory = Application.StartupPath;
            }

            try
            {
                if ((savefile.ShowDialog() == DialogResult.OK))
                {
                    if ((savefile.FileName == ""))
                    {
                        savefile.FileName = (dataBaseName + "_" + String.Format("{0:ddd, MMM d, yyyy}", DateTime.Now));
                 //       savefile.FileName = savefile.FileName = (dataBaseName + (" " + DateTime.Now.ToString("d/MMM/yyyy").ToString()));
                        return;
                    }
                    else
                    {
                        txtPath.Text = savefile.FileName;
                    }

                }

            }
            catch (Exception ex)
            {
            }

        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (txtPath.Text == "")
            {
                MessageBox.Show("PLEASE SELECT PROPER BACKUP DEVICE PATH....");
          
                return;
            }

            try
            {
                pb.Visible = true;
                setProgressValue(20);
                setProgressValue(30);
                setProgressValue(40);
                setProgressValue(50);
                setProgressValue(60);
                setProgressValue(70);
                setProgressValue(80);
                if ((System.IO.Directory.Exists((Application.StartupPath + ("\\" + "DATA BACKUP"))) == false))
                {
                    System.IO.Directory.CreateDirectory((Application.StartupPath + ("\\" + "DATA BACKUP")));
                }

         

                SqlCommand cmd = new SqlCommand(("BACKUP DATABASE " + (dataBaseName + (" TO DISK =\'" + (txtPath.Text + "\'")))), impfunc.cnn);
              
                impfunc.cnn.Open();

                setProgressValue(90);
                cmd.ExecuteScalar();
                setProgressValue(100);
               MessageBox.Show("DATABASE BACKUP IS DONE..","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                pb.Visible = false;
                setProgressValue(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(("ERROR: "+ (ex.Message + ("\r\n" + "PLEASE CONTACT Mr. Amit Tiwari"))));
                setProgressValue(80);
                setProgressValue(70);
                setProgressValue(60);
                setProgressValue(50);
                setProgressValue(40);
                setProgressValue(30);
                setProgressValue(20);
                setProgressValue(10);
                setProgressValue(0);
                pb.Visible = false;
            }
            finally
            {
                setProgressValue(0);
                pb.Visible = false;
                impfunc.cnn.Close();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            impfunc.Remove_Child(this);
        }

        private void frmBackup_KeyDown(object sender, KeyEventArgs e)
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

        private void frmBackup_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            if (pnlMain.BorderStyle == BorderStyle.FixedSingle) 
            {
                int thickness = 2;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.White, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              pnlMain.ClientSize.Width - thickness,
                                                              pnlMain.ClientSize.Height - thickness));
                }
            }
        }
    }
}
