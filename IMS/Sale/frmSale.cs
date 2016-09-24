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

namespace IMS.Sale
{
    public partial class frmSale : Form
    {
        public frmSale()
        {
            InitializeComponent();
        }

        private void pnlGenOrder_Paint(object sender, PaintEventArgs e)
        {
            if (pnlGenOrder.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 2;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.White, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              pnlGenOrder.ClientSize.Width - thickness,
                                                              pnlGenOrder.ClientSize.Height - thickness));
                }
            }
        }

        private void pnlFinalOrder_Paint(object sender, PaintEventArgs e)
        {
            if (pnlFinalOrder.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 2;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.White, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              pnlFinalOrder.ClientSize.Width - thickness,
                                                              pnlFinalOrder.ClientSize.Height - thickness));
                }
            }
        }

        private void pnlGoodReturn_Paint(object sender, PaintEventArgs e)
        {
            if (pnlGoodReturn.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 2;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.White, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              pnlGoodReturn.ClientSize.Width - thickness,
                                                              pnlGoodReturn.ClientSize.Height - thickness));
                }
            }
        }

        private void pnlPaymentRec_Paint(object sender, PaintEventArgs e)
        {
            if (pnlPaymentRec.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 2;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.White, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              pnlPaymentRec.ClientSize.Width - thickness,
                                                              pnlPaymentRec.ClientSize.Height - thickness));
                }
            }
        }

        private void pnlGenOrder_MouseEnter(object sender, EventArgs e)
        {
            pnlGenOrder.BackColor = System.Drawing.Color.FromArgb(255, 192, 128);
        }

        private void picGenOrder_MouseEnter(object sender, EventArgs e)
        {
            pnlGenOrder.BackColor = System.Drawing.Color.FromArgb(255, 192, 128);
        }

        private void lbl_GenOrder_MouseEnter(object sender, EventArgs e)
        {
            pnlGenOrder.BackColor = System.Drawing.Color.FromArgb(255, 192, 128);
        }

        private void pnlGenOrder_MouseLeave(object sender, EventArgs e)
        {
            pnlGenOrder.BackColor = System.Drawing.Color.Transparent;
        }

        private void picGenOrder_MouseLeave(object sender, EventArgs e)
        {
            pnlGenOrder.BackColor = System.Drawing.Color.Transparent;
        }

        private void lbl_GenOrder_MouseLeave(object sender, EventArgs e)
        {
            pnlGenOrder.BackColor = System.Drawing.Color.Transparent;
        }

        private void pnlFinalOrder_MouseEnter(object sender, EventArgs e)
        {
            pnlFinalOrder.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
        }

        private void picFinalOrder_MouseEnter(object sender, EventArgs e)
        {
            pnlFinalOrder.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
        }

        private void lblFinalOrder_MouseEnter(object sender, EventArgs e)
        {
            pnlFinalOrder.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
        }

        private void lblFinalOrder_MouseLeave(object sender, EventArgs e)
        {
            pnlFinalOrder.BackColor = System.Drawing.Color.Transparent;
        }

        private void picFinalOrder_MouseLeave(object sender, EventArgs e)
        {
            pnlFinalOrder.BackColor = System.Drawing.Color.Transparent;
        }

        private void pnlFinalOrder_MouseLeave(object sender, EventArgs e)
        {
            pnlFinalOrder.BackColor = System.Drawing.Color.Transparent;
        }

        private void pnlGoodReturn_MouseEnter(object sender, EventArgs e)
        {
            pnlGoodReturn.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
        }

        private void picGoodReturn_MouseEnter(object sender, EventArgs e)
        {
            pnlGoodReturn.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
        }

        private void lblGoodReturns_MouseEnter(object sender, EventArgs e)
        {
            pnlGoodReturn.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
        }

        private void lblGoodReturns_MouseLeave(object sender, EventArgs e)
        {
            pnlGoodReturn.BackColor = System.Drawing.Color.Transparent;
        }

        private void picGoodReturn_MouseLeave(object sender, EventArgs e)
        {
            pnlGoodReturn.BackColor = System.Drawing.Color.Transparent;
        }

        private void pnlGoodReturn_MouseLeave(object sender, EventArgs e)
        {
            pnlGoodReturn.BackColor = System.Drawing.Color.Transparent;
        }

        private void pnlPaymentRec_MouseEnter(object sender, EventArgs e)
        {
            pnlPaymentRec.BackColor = System.Drawing.Color.FromArgb(64, 0, 64);
        }

        private void picPaymentRec_MouseEnter(object sender, EventArgs e)
        {
            pnlPaymentRec.BackColor = System.Drawing.Color.FromArgb(64, 0, 64);
        }

        private void lblPaymentRec_MouseEnter(object sender, EventArgs e)
        {
            pnlPaymentRec.BackColor = System.Drawing.Color.FromArgb(64, 0, 64);
        }

        private void lblPaymentRec_MouseLeave(object sender, EventArgs e)
        {
            pnlPaymentRec.BackColor = System.Drawing.Color.Transparent;
        }

        private void picPaymentRec_MouseLeave(object sender, EventArgs e)
        {
            pnlPaymentRec.BackColor = System.Drawing.Color.Transparent;
        }

        private void pnlPaymentRec_MouseLeave(object sender, EventArgs e)
        {
            pnlPaymentRec.BackColor = System.Drawing.Color.Transparent;
        }

        private void frmSale_KeyDown(object sender, KeyEventArgs e)
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

        private void back_btn_Click(object sender, EventArgs e)
        {
            impfunc.Remove_Child(this);
        }

        private void frmSale_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void picFinalOrder_Click(object sender, EventArgs e)
        {
            frmSaleout frm = new frmSaleout();
         
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);

            frm.MdiParent = this.MdiParent;
      
            frm.Show();
        }

        private void pnlFinalOrder_Click(object sender, EventArgs e)
        {
            frmSaleout frm = new frmSaleout();

            frm.FormBorderStyle = FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);

            frm.MdiParent = this.MdiParent;

            frm.Show();
        }

        private void lblFinalOrder_Click(object sender, EventArgs e)
        {
            frmSaleout frm = new frmSaleout();

            frm.FormBorderStyle = FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);

            frm.MdiParent = this.MdiParent;

            frm.Show();
        }

        private void picGenOrder_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();

            frm.FormBorderStyle = FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);

            frm.MdiParent = this.MdiParent;

            frm.Show();
        }

        private void lbl_GenOrder_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();

            frm.FormBorderStyle = FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);

            frm.MdiParent = this.MdiParent;

            frm.Show();
        }

        private void pnlGenOrder_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();

            frm.FormBorderStyle = FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);

            frm.MdiParent = this.MdiParent;

            frm.Show();
        }

        private void picPaymentRec_Click(object sender, EventArgs e)
        {
            frmSaleReceipt frm = new frmSaleReceipt();

            frm.FormBorderStyle = FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);

            frm.MdiParent = this.MdiParent;

            frm.Show();
        }

        private void lblPaymentRec_Click(object sender, EventArgs e)
        {
            frmSaleReceipt frm = new frmSaleReceipt();

            frm.FormBorderStyle = FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);

            frm.MdiParent = this.MdiParent;

            frm.Show();
        }

        private void pnlPaymentRec_Click(object sender, EventArgs e)
        {
            frmSaleReceipt frm = new frmSaleReceipt();

            frm.FormBorderStyle = FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);

            frm.MdiParent = this.MdiParent;

            frm.Show();
        }

        private void picGoodReturn_Click(object sender, EventArgs e)
        {
            frmSaleReturn frm = new frmSaleReturn();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);

            frm.MdiParent = this.MdiParent;

            frm.Show();
        }

        private void lblGoodReturns_Click(object sender, EventArgs e)
        {
            frmSaleReturn frm = new frmSaleReturn();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);

            frm.MdiParent = this.MdiParent;

            frm.Show();
        }

        private void pnlGoodReturn_Click(object sender, EventArgs e)
        {
            frmSaleReturn frm = new frmSaleReturn();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);

            frm.MdiParent = this.MdiParent;

            frm.Show();
        }
    }
}
