using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMIT_FUNCTIONS; 

namespace IMS.Account
{
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
        }

        public static string rpttag = "";

        private void pnlCustomer_Paint(object sender, PaintEventArgs e)
        {
            if (pnlCustomer.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 2;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.White, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              pnlCustomer.ClientSize.Width - thickness,
                                                              pnlCustomer.ClientSize.Height - thickness));
                }
            }
        }

        private void pnlSupplier_Paint(object sender, PaintEventArgs e)
        {
            if (pnlSupplier.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 2;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.White, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              pnlSupplier.ClientSize.Width - thickness,
                                                              pnlSupplier.ClientSize.Height - thickness));
                }
            }
        }

        private void pnlArch_Paint(object sender, PaintEventArgs e)
        {
            if (pnlArch.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 2;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.White, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              pnlArch.ClientSize.Width - thickness,
                                                              pnlArch.ClientSize.Height - thickness));
                }
            }
        }

        private void pnlCustomer_MouseEnter(object sender, EventArgs e)
        {
            pnlCustomer.BackColor = System.Drawing.Color.FromArgb(24, 142, 22);
        }

        private void picCustomer_MouseEnter(object sender, EventArgs e)
        {
            pnlCustomer.BackColor = System.Drawing.Color.FromArgb(24, 142, 22);
        }

        private void lblCustomer_MouseEnter(object sender, EventArgs e)
        {
            pnlCustomer.BackColor = System.Drawing.Color.FromArgb(24, 142, 22);
        }

        private void lblCustomer_MouseLeave(object sender, EventArgs e)
        {
            pnlCustomer.BackColor = System.Drawing.Color.Transparent;
        }

        private void picCustomer_MouseLeave(object sender, EventArgs e)
        {
            pnlCustomer.BackColor = System.Drawing.Color.Transparent;
        }

        private void pnlCustomer_MouseLeave(object sender, EventArgs e)
        {
            pnlCustomer.BackColor = System.Drawing.Color.Transparent;
        }

        private void pnlArch_MouseEnter(object sender, EventArgs e)
        {
            pnlArch.BackColor = System.Drawing.Color.Silver;
        }

        private void picArch_MouseEnter(object sender, EventArgs e)
        {
            pnlArch.BackColor = System.Drawing.Color.Silver;
        }

        private void lblArch_MouseEnter(object sender, EventArgs e)
        {
            pnlArch.BackColor = System.Drawing.Color.Silver;
        }

        private void lblArch_MouseLeave(object sender, EventArgs e)
        {
            pnlArch.BackColor = System.Drawing.Color.Transparent;
        }

        private void picArch_MouseLeave(object sender, EventArgs e)
        {
            pnlArch.BackColor = System.Drawing.Color.Transparent;
        }

        private void pnlArch_MouseLeave(object sender, EventArgs e)
        {
            pnlArch.BackColor = System.Drawing.Color.Transparent;
        }

        private void pnlSupplier_MouseEnter(object sender, EventArgs e)
        {
            pnlSupplier.BackColor = System.Drawing.Color.FromArgb(70, 71, 68);
        }

        private void picSupplier_MouseEnter(object sender, EventArgs e)
        {
            pnlSupplier.BackColor = System.Drawing.Color.FromArgb(70, 71, 68);
        }

        private void lblSupplier_MouseEnter(object sender, EventArgs e)
        {
            pnlSupplier.BackColor = System.Drawing.Color.FromArgb(70, 71, 68);
        }

        private void pnlSupplier_MouseLeave(object sender, EventArgs e)
        {
            pnlSupplier.BackColor = System.Drawing.Color.Transparent;
        }

        private void picSupplier_MouseLeave(object sender, EventArgs e)
        {
            pnlSupplier.BackColor = System.Drawing.Color.Transparent;
        }

        private void lblSupplier_MouseLeave(object sender, EventArgs e)
        {
            pnlSupplier.BackColor = System.Drawing.Color.Transparent;
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            impfunc.Remove_Child(this);
        }

        private void frmAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                impfunc.NEXTTAB(this, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                back_btn_Click(sender, e);
            }
        }

        private void picCustomer_Click(object sender, EventArgs e)
        {

            frmDate_Selection frm = new frmDate_Selection();
            frmMain mainform = new frmMain();
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
              
                frm.MdiParent = this.MdiParent;
               rpttag = "CUSTOMER ACCOUNT";
                frm.Show();

          
        }

        private void lblCustomer_Click(object sender, EventArgs e)
        {
            frmDate_Selection frm = new frmDate_Selection();
            frmMain mainform = new frmMain();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
 
            frm.MdiParent = this.MdiParent;
            rpttag = "CUSTOMER ACCOUNT";
            frm.Show();

        }

        private void pnlCustomer_Click(object sender, EventArgs e)
        {
            frmDate_Selection frm = new frmDate_Selection();
            frmMain mainform = new frmMain();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
      
            frm.MdiParent = this.MdiParent;
            rpttag = "CUSTOMER ACCOUNT";
            frm.Show();

        }

        private void picSupplier_Click(object sender, EventArgs e)
        {
            frmDate_Selection frm = new frmDate_Selection();
            frmMain mainform = new frmMain();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
       
            frm.MdiParent = this.MdiParent;
            rpttag = "SUPPLIER ACCOUNT";
            frm.Show();
        }

        private void lblSupplier_Click(object sender, EventArgs e)
        {
            frmDate_Selection frm = new frmDate_Selection();
            frmMain mainform = new frmMain();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
       
            frm.MdiParent = this.MdiParent;
            rpttag = "SUPPLIER ACCOUNT";
            frm.Show();
        }

        private void pnlSupplier_Click(object sender, EventArgs e)
        {
            frmDate_Selection frm = new frmDate_Selection();
            frmMain mainform = new frmMain();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
        
            frm.MdiParent = this.MdiParent;
            rpttag = "SUPPLIER ACCOUNT";
            frm.Show();
        }
    }
}
