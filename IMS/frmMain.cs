using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IMS.Customers;
using IMS.Category;
using IMS.Suppliers;
using IMS.Inventory;
using IMS.Purchase;
using IMS.Sale;
using IMS.Account;
using AMIT_FUNCTIONS;

namespace IMS
{   
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

 
        
       

        private void frmMain_Load(object sender, EventArgs e)   
        {
            LBLUSERTYPE.Text = impfunc._USERTYPE;
            lblfinancialyear.Text = impfunc._FYEAR;
            lblDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            timer1.Start();
        }
    
      
        private void frmMain_MdiChildActivate_1(object sender, EventArgs e)     
        {
            if (this.ActiveMdiChild == null)
            {
                this.pnlMain.Visible = true;
                tabForms.Visible = false; // If no any child form, hide tabControl
            }
            else
            {
                tabForms.BringToFront();
                this.ActiveMdiChild.WindowState = FormWindowState.Maximized; // Child form always maximized

                // If child form is new and no has tabPage, create new tabPage
                if (this.ActiveMdiChild.Tag == null)
                {  
                    // Add a tabPage to tabControl with child form caption
                    TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                    int TabNo= (tabForms.TabCount) + 1;
                    tp.AutoScroll = true;
                    tp.BackColor = Color.SteelBlue;
                    tp.Tag = this.ActiveMdiChild;
                    tp.Parent = tabForms;
                    tabForms.SelectedTab = tp;
                    tabForms.SelectedIndex = TabNo - 1;
                    this.ActiveMdiChild.Tag = tp;
               
                    this.ActiveMdiChild.FormClosed += new FormClosedEventHandler(ActiveMdiChild_FormClosed);
                }

                if (!tabForms.Visible) tabForms.Visible = true;
            }
        }

        // If child form closed, remove tabPage
        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
            tabForms.SelectedIndex = tabForms.TabPages.Count - 1;
        }

    

        private void usr_pnl_Paint(object sender, PaintEventArgs e)
        {
            if (usr_pnl.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 2;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.White, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              usr_pnl.ClientSize.Width - thickness,
                                                              usr_pnl.ClientSize.Height - thickness));
                }
            }
        }

        public void usr_pnl_MouseEnter()
        {
            usr_pnl.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
        }
        public void usr_pnl_MouseLeave()
        {
            usr_pnl.BackColor = System.Drawing.Color.Transparent;
        }


        private void usr_pnl_MouseEnter(object sender, EventArgs e)
        {
            usr_pnl_MouseEnter();
        }

        private void usr_pnl_MouseLeave(object sender, EventArgs e)
        {
            usr_pnl_MouseLeave();
        }

        private void usr_pic_MouseEnter(object sender, EventArgs e)
        {
            usr_pnl_MouseEnter();
        }

        private void usr_pic_MouseLeave(object sender, EventArgs e)
        {
            usr_pnl_MouseLeave();
        }

        private void usr_lbl_MouseEnter(object sender, EventArgs e)
        {
            usr_pnl_MouseEnter();
        }

        private void usr_lbl_MouseLeave(object sender, EventArgs e)
        {
            usr_pnl_MouseLeave();
        }




        private void ivt_pnl_Paint(object sender, PaintEventArgs e)
        {
            if (ivt_pnl.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 2;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.White, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              ivt_pnl.ClientSize.Width - thickness,
                                                              ivt_pnl.ClientSize.Height - thickness));
                }
            }
        }

        public void ivt_pnl_MouseEnter()
        {
            ivt_pnl.BackColor = System.Drawing.Color.FromArgb(128, 57, 123);
        }
        public void ivt_pnl_MouseLeave()
        {
            ivt_pnl.BackColor = System.Drawing.Color.Transparent;
        }
       

        private void ivt_pnl_Leave(object sender, EventArgs e)
        {
            ivt_pnl_MouseLeave();
        }

        private void invt_pic_MouseEnter(object sender, EventArgs e)
        {
            ivt_pnl_MouseEnter();
        }

        private void invt_pic_MouseLeave(object sender, EventArgs e)
        {
            ivt_pnl_MouseLeave();
        }

    

        private void lbl_Inventry_MouseEnter(object sender, EventArgs e)
        {
            ivt_pnl_MouseEnter();
        }

        private void lbl_Inventry_MouseLeave(object sender, EventArgs e)
        {
            ivt_pnl_MouseLeave();
        }

        private void ivt_pnl_MouseEnter(object sender, EventArgs e)
        {
            ivt_pnl_MouseEnter();
        }

        private void ivt_pnl_MouseLeave(object sender, EventArgs e)
        {
            ivt_pnl_MouseLeave();
        }

        private void sale_pnl_Paint(object sender, PaintEventArgs e)
        {
            if (sale_pnl.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 2;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.White, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              sale_pnl.ClientSize.Width - thickness,
                                                              sale_pnl.ClientSize.Height - thickness));
                }
            }
        }

        public void sale_pnl_MouseEnter()
        {
            sale_pnl.BackColor = System.Drawing.Color.FromArgb(90, 172, 236);
        }
        public void sale_pnl_MouseLeave()
        {
            sale_pnl.BackColor = System.Drawing.Color.Transparent;
        }

        private void sale_pnl_MouseEnter(object sender, EventArgs e)
        {
            sale_pnl_MouseEnter();
        }

        private void sale_pnl_MouseLeave(object sender, EventArgs e)
        {
            sale_pnl_MouseLeave();
        }

        private void sale_pic_MouseEnter(object sender, EventArgs e)
        {
            sale_pnl_MouseEnter();
        }

        private void sale_pic_MouseLeave(object sender, EventArgs e)
        {
            sale_pnl_MouseLeave();
        }

        private void lbl_sale_MouseEnter(object sender, EventArgs e)
        {
            sale_pnl_MouseEnter();
        }

        private void lbl_sale_MouseLeave(object sender, EventArgs e)
        {
            sale_pnl_MouseLeave();
        }

        private void act_pnl_Paint(object sender, PaintEventArgs e)
        {
            if (act_pnl.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 2;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.White, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              act_pnl.ClientSize.Width - thickness,
                                                              act_pnl.ClientSize.Height - thickness));
                }
            }
        }

        private void act_pnl_MouseEnter(object sender, EventArgs e)
        {
            act_pnl_MouseEnter();
        }

        private void act_pnl_MouseLeave(object sender, EventArgs e)
        {
            act_pnl_MouseLeave();
        }

        private void account_pic_MouseEnter(object sender, EventArgs e)
        {
            act_pnl_MouseEnter();
        }

        private void account_pic_MouseLeave(object sender, EventArgs e)
        {
            act_pnl_MouseLeave();
        }

        private void act_lbl_MouseEnter(object sender, EventArgs e)
        {
            act_pnl_MouseEnter();
        }

        private void act_lbl_MouseLeave(object sender, EventArgs e)
        {
            act_pnl_MouseLeave();
        }

        public void act_pnl_MouseEnter()
        {
            act_pnl.BackColor = System.Drawing.Color.FromArgb(80, 38, 166);
        }
        public void act_pnl_MouseLeave()
        {
            act_pnl.BackColor = System.Drawing.Color.Transparent;
        }

        private void sup_pnl_Paint(object sender, PaintEventArgs e)
        {
            if (sup_pnl.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 2;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.White, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              sup_pnl.ClientSize.Width - thickness,
                                                              sup_pnl.ClientSize.Height - thickness));
                }
            }
        }

        private void sup_pnl_MouseEnter(object sender, EventArgs e)
        {
            sup_pnl_MouseEnter();
        }

        private void sup_pnl_MouseLeave(object sender, EventArgs e)
        {
            sup_pnl_MouseLeave();
        }

        private void supp_pic_MouseEnter(object sender, EventArgs e)
        {
            sup_pnl_MouseEnter();
        }

        private void supp_pic_MouseLeave(object sender, EventArgs e)
        {
            sup_pnl_MouseLeave();
        }

        private void lbl_supplier_MouseEnter(object sender, EventArgs e)
        {
            sup_pnl_MouseEnter();
        
        }

        private void lbl_supplier_MouseLeave(object sender, EventArgs e)
        {
            sup_pnl_MouseLeave();
        }
        public void sup_pnl_MouseLeave()
        {
            sup_pnl.BackColor = System.Drawing.Color.Transparent;
        }
        public void sup_pnl_MouseEnter()
        {
            sup_pnl.BackColor = System.Drawing.Color.FromArgb(70, 71, 68);
        }

        private void cus_pnl_Paint(object sender, PaintEventArgs e)
        {
            if (cus_pnl.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 2;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.White, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              cus_pnl.ClientSize.Width - thickness,
                                                              cus_pnl.ClientSize.Height - thickness));
                }
            }
        }

        public void cus_pnl_MouseEnter()
        {
            cus_pnl.BackColor = System.Drawing.Color.FromArgb(24, 142, 22);
        }
        public void cus_pnl_MouseLeave()
        {
            cus_pnl.BackColor = System.Drawing.Color.Transparent;
        }


        private void cus_pnl_MouseEnter(object sender, EventArgs e)
        {
            cus_pnl_MouseEnter();
        }

        private void cus_pnl_MouseLeave(object sender, EventArgs e)
        {
            cus_pnl_MouseLeave();
        }

        private void cus_pic_MouseEnter(object sender, EventArgs e)
        {
            cus_pnl_MouseEnter();
        }

        private void cus_pic_MouseLeave(object sender, EventArgs e)
        {
            cus_pnl_MouseLeave();
        }

        private void cus_lbl_MouseEnter(object sender, EventArgs e)
        {
            cus_pnl_MouseEnter();
        }

        private void cus_lbl_MouseLeave(object sender, EventArgs e)
        {
            cus_pnl_MouseLeave(); 
        }

        private void dbckTSMI_Click(object sender, EventArgs e)
        {
            frmBackup frm = new frmBackup();
          //  frm.FormBorderStyle = FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
            this.pnlMain.Visible = false;
            frm.MdiParent = this;

            frm.Show();
        }


        private void cus_pic_Click(object sender, EventArgs e)
        {
            

          bool IsOpen = false;
            int tabcount = 0;
            foreach (Form f in Application.OpenForms)
            {


                if (f.Text == "Customers")
                {
                    tabForms.SelectedTab = tabForms.TabPages[tabcount - 2];
                    IsOpen = true;
                    f.Focus();
                    break;
                }
                tabcount++;
            }




            if (IsOpen == false)
            {
                frmCustomers frm = new frmCustomers();
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
                this.pnlMain.Visible = false;
                frm.MdiParent = this;

                frm.Show();

            }
        }

        private void cus_lbl_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            int tabcount = 0;
            foreach (Form f in Application.OpenForms)
            {


                if (f.Text == "Customers")
                {
                    tabForms.SelectedTab = tabForms.TabPages[tabcount - 2];
                    IsOpen = true;
                    f.Focus();
                    break;
                }
                tabcount++;
            }




            if (IsOpen == false)
            {
                frmCustomers frm = new frmCustomers();
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
                this.pnlMain.Visible = false;
                frm.MdiParent = this;

                frm.Show();

            }

        }

        private void cus_pnl_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            int tabcount = 0;
            foreach (Form f in Application.OpenForms)
            {


                if (f.Text == "Customers")
                {
                    tabForms.SelectedTab = tabForms.TabPages[tabcount - 2];
                    IsOpen = true;
                    f.Focus();
                    break;
                }
                tabcount++;
            }




            if (IsOpen == false)
            {
                frmCustomers frm = new frmCustomers();
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
                this.pnlMain.Visible = false;
                frm.MdiParent = this;

                frm.Show();

            }

        }

        private void usr_pic_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            int tabcount = 0;
            foreach (Form f in Application.OpenForms)
            {


                if (f.Text == "User's")
                {
                    tabForms.SelectedTab = tabForms.TabPages[tabcount - 2];
                    IsOpen = true;
                    f.Focus();
                    break;
                }
                tabcount++;
            }




            if (IsOpen == false)
            {
                users frm = new users();
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
                this.pnlMain.Visible = false;
                frm.MdiParent = this;

                frm.Show();

            }
        }

        

        private void usr_lbl_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            int tabcount = 0;
            foreach (Form f in Application.OpenForms)
            {


                if (f.Text == "User's")
                {
                    tabForms.SelectedTab = tabForms.TabPages[tabcount - 2];
                    IsOpen = true;
                    f.Focus();
                    break;
                }
                tabcount++;
            }




            if (IsOpen == false)
            {
                users frm = new users();
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
                this.pnlMain.Visible = false;
                frm.MdiParent = this;

                frm.Show();

            }

        }

        private void usr_pnl_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            int tabcount = 0;
            foreach (Form f in Application.OpenForms)
            {


                if (f.Text == "User's")
                {
                    tabForms.SelectedTab = tabForms.TabPages[tabcount - 2];
                    IsOpen = true;
                    f.Focus();
                    break;
                }
                tabcount++;
            }




            if (IsOpen == false)
            {
                users frm = new users();
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
                this.pnlMain.Visible = false;
                frm.MdiParent = this;

                frm.Show();

            }
        }

        private void supp_pic_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            int tabcount = 0;
            foreach (Form f in Application.OpenForms)
            {


                if (f.Text == "suppliers")
                {
                    tabForms.SelectedTab = tabForms.TabPages[tabcount - 2];
                    IsOpen = true;
                    f.Focus();
                    break;
                }
                tabcount++;
            }




            if (IsOpen == false)
            {
                suppliers frm = new suppliers();
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
                this.pnlMain.Visible = false;
                frm.MdiParent = this;

                frm.Show();

            }
        }

        

        private void sup_pnl_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            int tabcount = 0;
            foreach (Form f in Application.OpenForms)
            {


                if (f.Text == "suppliers")
                {
                    tabForms.SelectedTab = tabForms.TabPages[tabcount - 2];
                    IsOpen = true;
                    f.Focus();
                    break;
                }
                tabcount++;
            }




            if (IsOpen == false)
            {
                suppliers frm = new suppliers();
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
                this.pnlMain.Visible = false;
                frm.MdiParent = this;

                frm.Show();

            }
        }

        private void lbl_supplier_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            int tabcount = 0;
            foreach (Form f in Application.OpenForms)
            {


                if (f.Text == "suppliers")
                {
                    tabForms.SelectedTab = tabForms.TabPages[tabcount - 2];
                    IsOpen = true;
                    f.Focus();
                    break;
                }
                tabcount++;
            }




            if (IsOpen == false)
            {
                suppliers frm = new suppliers();
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
                this.pnlMain.Visible = false;
                frm.MdiParent = this;

                frm.Show();

            }
        }



        private void invt_pic_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            int tabcount = 0;
            foreach (Form f in Application.OpenForms)
            {


                if (f.Text == "Inventory")
                {
                    tabForms.SelectedTab = tabForms.TabPages[tabcount - 2];
                    IsOpen = true;
                    f.Focus();
                    break;
                }
                tabcount++;
            }




            if (IsOpen == false)
            {
                frmInventory frm = new frmInventory();
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
                this.pnlMain.Visible = false;
                frm.MdiParent = this;

                frm.Show();

            }
          
        }

        private void lbl_Inventry_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            int tabcount = 0;
            foreach (Form f in Application.OpenForms)
            {


                if (f.Text == "Inventory")
                {
                    tabForms.SelectedTab = tabForms.TabPages[tabcount - 2];
                    IsOpen = true;
                    f.Focus();
                    break;
                }
                tabcount++;
            }




            if (IsOpen == false)
            {
                frmInventory frm = new frmInventory();
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
                this.pnlMain.Visible = false;
                frm.MdiParent = this;

                frm.Show();

            }
          
        }

        private void ivt_pnl_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            int tabcount = 0;
            foreach (Form f in Application.OpenForms)
            {


                if (f.Text == "Inventory")
                {
                    tabForms.SelectedTab = tabForms.TabPages[tabcount - 2];
                    IsOpen = true;
                    f.Focus();
                    break;
                }
                tabcount++;
            }




            if (IsOpen == false)
            {
                frmInventory frm = new frmInventory();
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
                this.pnlMain.Visible = false;
                frm.MdiParent = this;

                frm.Show();

            }
          
        }

        private void tabForms_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if ((tabForms.SelectedTab != null) && (tabForms.SelectedTab.Tag != null))
                (tabForms.SelectedTab.Tag as Form).Select();
        }

        private void tsPurchase_Click(object sender, EventArgs e)
        {
            


            bool IsOpen = false;
            int tabcount = 0;
            foreach (Form f in Application.OpenForms)
            {


                if (f.Text == "Purchase")
                {
                    tabForms.SelectedTab = tabForms.TabPages[tabcount - 2];
                    IsOpen = true;
                    f.Focus();
                    break;
                }
                tabcount++;
            }




            if (IsOpen == false)
            {
                frmPurchase frm = new frmPurchase();
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
                this.pnlMain.Visible = false;
                frm.MdiParent = this;

                frm.Show();

            }
        }

        private void tslPayment_Click(object sender, EventArgs e)
        {
         


            bool IsOpen = false;
            int tabcount = 0;
            foreach (Form f in Application.OpenForms)
            {


                if (f.Text == "Purchase Payment")
                {
                    tabForms.SelectedTab = tabForms.TabPages[tabcount - 2];
                    IsOpen = true;
                    f.Focus();
                    break;
                }
                tabcount++;
            }




            if (IsOpen == false)
            {
                frmPayment frm = new frmPayment();
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
                this.pnlMain.Visible = false;
                frm.MdiParent = this;

                frm.Show();

            }
        }

        private void tslPurchaseReturn_Click(object sender, EventArgs e)
        {
            
         

            bool IsOpen = false;
            int tabcount = 0;
            foreach (Form f in Application.OpenForms)
            {


                if (f.Text == "Purchase Return")
                {
                    tabForms.SelectedTab = tabForms.TabPages[tabcount - 2];
                    IsOpen = true;
                    f.Focus();
                    break;
                }
                tabcount++;
            }




            if (IsOpen == false)
            {
                frmPurchaseReturn frm = new frmPurchaseReturn();
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
                this.pnlMain.Visible = false;
                frm.MdiParent = this;

                frm.Show();

            }
        }

        private void tslPermissions_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            int tabcount = 0;
            foreach (Form f in Application.OpenForms)
            {


                if (f.Text == "Role & Permissions")
                {
                    tabForms.SelectedTab = tabForms.TabPages[tabcount - 2];
                    IsOpen = true;
                    f.Focus();
                    break;
                }
                tabcount++;
            }




            if (IsOpen == false)
            {
                role frm = new role();
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
                this.pnlMain.Visible = false;
                frm.MdiParent = this;

                frm.Show();

            }
        }

        private void tslLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE YOU WANT TO LOGOUT...?", "Log OUt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (dialogResult == DialogResult.Yes)
             {
                 login frm = new login();
                 frm.Show();
                 this.Close();

             }
             else
             {
                 return;
             }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("h:mm:ss tt");
        }

        private void tslCategory_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            int tabcount = 0;
            foreach (Form f in Application.OpenForms)
            {


                if (f.Text == "Category")
                {
                    tabForms.SelectedTab = tabForms.TabPages[tabcount - 2];
                    IsOpen = true;
                    f.Focus();
                    break;
                }
                tabcount++;
            }

            if (IsOpen == false)
            {
                frmCategory frm = new frmCategory();
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
                this.pnlMain.Visible = false;
                frm.MdiParent = this;

                frm.Show();

            }
        }

        private void sale_pic_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            int tabcount = 0;
            foreach (Form f in Application.OpenForms)
            {


                if (f.Text == "Sale")
                {
                    tabForms.SelectedTab = tabForms.TabPages[tabcount - 2];
                    IsOpen = true;
                    f.Focus();
                    break;
                }
                tabcount++;
            }

            if (IsOpen == false)
            {
                frmSale frm = new frmSale();
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
                this.pnlMain.Visible = false;
                frm.MdiParent = this;

                frm.Show();

            }
        }

        private void lbl_sale_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            int tabcount = 0;
            foreach (Form f in Application.OpenForms)
            {


                if (f.Text == "Sale")
                {
                    tabForms.SelectedTab = tabForms.TabPages[tabcount - 2];
                    IsOpen = true;
                    f.Focus();
                    break;
                }
                tabcount++;
            }

            if (IsOpen == false)
            {
                frmSale frm = new frmSale();
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
                this.pnlMain.Visible = false;
                frm.MdiParent = this;

                frm.Show();

            }
        }

      

        private void act_pnl_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            int tabcount = 0;
            foreach (Form f in Application.OpenForms)
            {


                if (f.Text == "Account")
                {
                    tabForms.SelectedTab = tabForms.TabPages[tabcount - 2];
                    IsOpen = true;
                    f.Focus();
                    break;
                }
                tabcount++;
            }

            if (IsOpen == false)
            {
                frmAccount frm = new frmAccount();
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
                this.pnlMain.Visible = false;
                frm.MdiParent = this;

                frm.Show();

            }
        }

        private void account_pic_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            int tabcount = 0;
            foreach (Form f in Application.OpenForms)
            {


                if (f.Text == "Account")
                {
                    tabForms.SelectedTab = tabForms.TabPages[tabcount - 2];
                    IsOpen = true;
                    f.Focus();
                    break;
                }
                tabcount++;
            }

            if (IsOpen == false)
            {
                frmAccount frm = new frmAccount();
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
                this.pnlMain.Visible = false;
                frm.MdiParent = this;

                frm.Show();

            }
        }

        private void act_lbl_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            int tabcount = 0;
            foreach (Form f in Application.OpenForms)
            {


                if (f.Text == "Account")
                {
                    tabForms.SelectedTab = tabForms.TabPages[tabcount - 2];
                    IsOpen = true;
                    f.Focus();
                    break;
                }
                tabcount++;
            }

            if (IsOpen == false)
            {
                frmAccount frm = new frmAccount();
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
                this.pnlMain.Visible = false;
                frm.MdiParent = this;

                frm.Show();

            }
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Sure, You want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
            //else
            //{
            //    return;
            //}
        }

     
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
              DialogResult dialogResult = MessageBox.Show("Sure, You want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
               e.Cancel=true;

            }
        }

        private void sale_pnl_Click_1(object sender, EventArgs e)
        {
            bool IsOpen = false;
            int tabcount = 0;
            foreach (Form f in Application.OpenForms)
            {


                if (f.Text == "Sale")
                {
                    tabForms.SelectedTab = tabForms.TabPages[tabcount - 2];
                    IsOpen = true;
                    f.Focus();
                    break;
                }
                tabcount++;
            }

            if (IsOpen == false)
            {
                frmSale frm = new frmSale();
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point((this.Width - frm.Width) / 2, this.Location.Y + (this.Height - frm.Height) / 2);
                this.pnlMain.Visible = false;
                frm.MdiParent = this;

                frm.Show();

            }
        }
        }

    

         
       
        
    }
     
    
 
