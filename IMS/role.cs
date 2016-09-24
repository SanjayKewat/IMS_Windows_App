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
using System.Collections;
using AMIT_FUNCTIONS;

namespace IMS
{
    public partial class role : Form
    {
        public role()
        {
            InitializeComponent();
        }

        //        permisssion,role
        Dictionary<int, int> role_perm = new Dictionary<int, int>();
        List<CheckBox> CheckBoxes = new List<CheckBox>();
        private void role_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            table_layout();
      
            //calling methods to get any control in form by just passing control
        //    var c = GetAll(this, typeof(CheckBox));          
         //   MessageBox.Show("Previous Role Assign Successfully " + c.Count(), "Role Assign", MessageBoxButtons.OK, MessageBoxIcon.Information);
     
            assign_role();
        }
        ArrayList tab_list = new ArrayList();
        private void table_layout()
        {
            try
            {
                Dictionary<string, string> role_btn = new Dictionary<string, string>();
                role_btn.Add("save", "Click for Save..!"); //Click for Save..!  
                role_btn.Add("del", "Click for Delete..!");
                int coun_row = 0;

                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Command = new SqlCommand("select * from PERMIT_MASTER",   impfunc.cnn);
                impfunc._Adapter.SelectCommand = impfunc._Command;
                DataTable dt = new DataTable();
                impfunc._Adapter.Fill(dt);

                SqlDataAdapter role_ad = new SqlDataAdapter();
                SqlCommand role_cmd = new SqlCommand("select * from role_master",   impfunc.cnn);
                role_ad.SelectCommand = role_cmd;
                DataTable role_dt = new DataTable();
                role_ad.Fill(role_dt);

                ArrayList role_array = new ArrayList();
                for (int i = 1; i < role_dt.Rows.Count; i++)
                {
                    role_array.Add(role_dt.Rows[i]["role_name"].ToString() + "_" + role_dt.Rows[i]["id"].ToString());
                }

                int rows = dt.Rows.Count;
                rows += 3;
                // main_flow_tab
                TableLayoutPanel TLB = new TableLayoutPanel();

                TLB.ColumnCount = 1;
                //  TLB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.53846F));
                TLB.RowCount = rows;
                TLB.AutoSize = true;
                TLB.Location = new System.Drawing.Point(81, 173);

                for (int i = 0; i < rows; i++)
                {
                    if (i == 0)
                    {
                        TLB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.42857F));
                    }
                    else
                    {
                        TLB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
                    }
                }

                //
                Label lblnew = new Label();
                lblnew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                lblnew.AutoSize = true;
                lblnew.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblnew.ForeColor = System.Drawing.Color.White;
                lblnew.Location = new System.Drawing.Point(3, 13);
                lblnew.Name = "lbl_lname";
                lblnew.Size = new System.Drawing.Size(113, 16);
                lblnew.Text = "Permission/Role";
                lblnew.TextAlign = System.Drawing.ContentAlignment.TopCenter;

                Panel pan = new Panel();
                pan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));

                pan.Dock = System.Windows.Forms.DockStyle.Fill;
                pan.Location = new System.Drawing.Point(3, 3);
                pan.Name = "panel1";
                pan.Size = new System.Drawing.Size(169, 48);
                pan.Controls.Add(lblnew);


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Label lbl_usr = new Label();
                    lbl_usr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
                    lbl_usr.AutoSize = true;
                    lbl_usr.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lbl_usr.ForeColor = System.Drawing.Color.White;
                    lbl_usr.Location = new System.Drawing.Point(3, 66);
                    lbl_usr.Name = "label_" + i.ToString();
                    lbl_usr.Size = new System.Drawing.Size(170, 16);
                    lbl_usr.Text = dt.Rows[i]["PERMIT_NAME"].ToString();
                    lbl_usr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                    //column,row
                    TLB.Controls.Add(lbl_usr, 0, i);
                }
                //column,row
                //  TLB.Controls.Add(lblnew, 0, 0);           
                TLB.Controls.Add(pan, 0, 0);
                main_flow_tab.Controls.Add(TLB);

                ///here generating Dynamic tables,Button and check boxes        
                //adding roll dynamic on table
                for (int i = 0; i < role_array.Count; i++)
                {


                    TableLayoutPanel TLB_role = new TableLayoutPanel();
                    TLB_role.ColumnCount = 1;
                    TLB_role.RowCount = rows;
                    TLB_role.AutoSize = true;
                    TLB_role.Location = new System.Drawing.Point(81, 170);


                    for (int k = 0; k < rows; k++)
                    {
                        if (k == 0)
                        {
                            TLB_role.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.42857F));
                        }
                        else
                        {
                            TLB_role.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
                        }
                    }

                    string role_name = role_array[i] as string;
                    var role_nm = role_name.Split('_');
                    Label lbl = new Label();
                    lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                    lbl.AutoSize = true;
                    lbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lbl.ForeColor = System.Drawing.Color.White;
                    lbl.Location = new System.Drawing.Point(3, 13);
                    lbl.Name = "lbl_" + role_name;
                    lbl.Size = new System.Drawing.Size(113, 16);
                    lbl.Text = role_nm[0];
                    lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;


                    TLB_role.Name = "tlb_" + role_nm[0];
                    tab_list.Add("tlb_" + role_nm[0]);
                    Panel pan_role = new Panel();
                    pan_role.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));

                    pan_role.Dock = System.Windows.Forms.DockStyle.Fill;
                    pan_role.Location = new System.Drawing.Point(3, 3);
                    pan_role.Name = "pan_" + role_name;
                    pan_role.Size = new System.Drawing.Size(169, 48);
                    pan_role.Controls.Add(lbl);

                    TLB_role.Controls.Add(pan_role, 0, 0);

                    // generate checkbox dynamically
                    for (int a = 0; a < dt.Rows.Count; a++)
                    {

                        CheckBox chk = new CheckBox();
                        chk.Anchor = System.Windows.Forms.AnchorStyles.None;
                        chk.AutoSize = true;
                        chk.Font = new System.Drawing.Font("Tahoma", 9.75F);
                        chk.Location = new System.Drawing.Point(221, 61);
                        chk.Name = "chk_" + role_name + "_" + dt.Rows[a]["PERMIT_ID"].ToString();
                        chk.Size = new System.Drawing.Size(15, 14);
                        chk.UseVisualStyleBackColor = true;
                        CheckBoxes.Add(chk);

                        //column,row
                        TLB_role.Controls.Add(chk, 0, a + 1);

                        coun_row = a + 1;
                    }


                    //Generate save or edit button dynamically
                    int img_index = 0;
                    foreach (var pair in role_btn)
                    {
                        coun_row++;
                        Button btn = new Button();
                        btn.Anchor = System.Windows.Forms.AnchorStyles.None;
                        btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
                        if (img_index == 0)
                        {
                            btn.BackgroundImage = global::IMS.Properties.Resources.edit_usr;
                            btn.Click += new EventHandler(btn_save);
                        }
                        else
                        {
                            btn.BackgroundImage = global::IMS.Properties.Resources.Cancel;
                            btn.Click += new EventHandler(btn_del);
                        }

                        btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                        btn.Cursor = System.Windows.Forms.Cursors.Hand;
                        btn.FlatAppearance.BorderSize = 0;
                        btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                        btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                        btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn.Location = new System.Drawing.Point(202, 360);
                        btn.Name = "btn_" + role_name + "_" + pair.Key;
                        btn.Size = new System.Drawing.Size(35, 30);
                        this.user_tip.SetToolTip(btn, pair.Value);
                        btn.UseVisualStyleBackColor = false;
                        TLB_role.Controls.Add(btn, 0, coun_row);

                        img_index++;
                    }


                    main_flow_tab.Controls.Add(TLB_role);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Something goes wrong, please close the software and open again."+ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
         
        }

        public int role_id = 0, perms = 0;
        public string role_name = "";
        void btn_save(object sender, EventArgs e)
        {
            try
            {
                role_perm.Clear();

                // string a = ((System.Windows.Forms.Button)sender).Name;
                foreach (Control c in ((System.Windows.Forms.Button)sender).Parent.Controls)
                {
                    if (c.GetType() == typeof(CheckBox))
                    {
                        string a = c.Name;
                        var arry = a.Split('_');
                        role_name = arry[1];
                        role_id = Convert.ToInt32(arry[2]);
                        perms = Convert.ToInt32(arry[3]);
                        if (((CheckBox)c).Checked == true)
                        {
                            role_perm.Add(perms, role_id);
                        }

                    }
                }

                role_save(role_id, role_name);
                //   MessageBox.Show(" Role ID : " + role_id + " Permission ID : " + perms);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something goes wrong, please close the software and open again." + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        }

        private void role_save(int role_id,string role_name)
        {
            try
            {
                  impfunc.cnn.Open();
                impfunc._Command = new SqlCommand("delete ROLE_PERMIT where ROLE_ID=" + role_id,   impfunc.cnn);
                impfunc._Command.ExecuteNonQuery();

                foreach (var pair in role_perm)
                {
                    impfunc._Command = new SqlCommand("insert ROLE_PERMIT(PERMIT_ID,ROLE_ID)values(" + pair.Key + "," + pair.Value + ")", impfunc.cnn);
                    impfunc._Command.ExecuteNonQuery();
                }
                  impfunc.cnn.Close();
                  impfunc._Command.Dispose();

                MessageBox.Show(role_name + " Role Assign Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something goes wrong, please close the software and open again." + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        void btn_del(object sender, EventArgs e)
        {
            try
            {

                // string a = ((System.Windows.Forms.Button)sender).Name;
                foreach (Control c in ((System.Windows.Forms.Button)sender).Parent.Controls)
                {
                    if (c.GetType() == typeof(CheckBox))
                    {
                        string a = c.Name;
                        var arry = a.Split('_');
                        role_name = arry[1];
                        role_id = Convert.ToInt32(arry[2]);
                        perms = Convert.ToInt32(arry[3]);

                        ((CheckBox)c).Checked = false;


                    }
                }

                role_reset(role_id, role_name);
                // MessageBox.Show("Delete Role ID : " + role_id + " Permission ID : " + perms);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something goes wrong, please close the software and open again." + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void role_reset(int role_id, string role_nam)
        {
            try
            {
                  impfunc.cnn.Open();
                  impfunc._Command = new SqlCommand("delete ROLE_PERMIT where ROLE_ID=" + role_id, impfunc.cnn);
                  impfunc._Command.ExecuteNonQuery();
                  impfunc.cnn.Close();
                  impfunc._Command.Dispose();

                MessageBox.Show(role_name + " Role Reset Successfully", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something goes wrong, please close the software and open again." + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

             

        //get any control on forms
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            SqlDataAdapter ad = new SqlDataAdapter();
            impfunc._Command = new SqlCommand("select * from ROLE_PERMIT", impfunc.cnn);
            ad.SelectCommand = impfunc._Command;
            DataTable dt = new DataTable();
            ad.Fill(dt);

            var controls = control.Controls.Cast<Control>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
               
            foreach (Control c in control.Controls.Cast<Control>())
            {
               
                    if (c.GetType() == typeof(CheckBox))
                    {
                        

                        string a = c.Name;
                        var arry = a.Split('_');
                        role_name = arry[1];
                        role_id = Convert.ToInt32(arry[2]);
                        perms = Convert.ToInt32(arry[3]);
                      //  MessageBox.Show(c.Name);
                        if ((role_id == Convert.ToInt32(dt.Rows[i]["ROLE_ID"].ToString())) && (perms == Convert.ToInt32(dt.Rows[i]["PERMIT_ID"].ToString())))
                        {
                            ((CheckBox)c).Checked = true;
                        }
                      
                    }
                }
               
            }

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }


        public void assign_role()
        {
            try
            {
                impfunc._Adapter = new SqlDataAdapter();
                impfunc._Command = new SqlCommand("select * from ROLE_PERMIT", impfunc.cnn);
                impfunc._Adapter.SelectCommand = impfunc._Command;
                DataTable dt = new DataTable();
                impfunc._Adapter.Fill(dt);

                foreach (CheckBox chk in CheckBoxes)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string a = chk.Name;
                        var arry = a.Split('_');
                        role_name = arry[1];
                        role_id = Convert.ToInt32(arry[2]);
                        perms = Convert.ToInt32(arry[3]);
                        if ((role_id == Convert.ToInt32(dt.Rows[i]["ROLE_ID"].ToString())) && (perms == Convert.ToInt32(dt.Rows[i]["PERMIT_ID"].ToString())))
                        {
                            chk.Checked = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something goes wrong, please close the software and open again." + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            impfunc.Remove_Child(this);
        }

        private void role_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                impfunc.Remove_Child(this);
            }
        }

    }
}
