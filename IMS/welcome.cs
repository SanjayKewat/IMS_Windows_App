using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
            ims_timer.Start();
        }

        private void ims_timer_Tick(object sender, EventArgs e)
        {
            int i = 1;
            if (i <= 40)
            {
                i++;
                this.Hide();
                login log = new login();
                log.Show();
                ims_timer.Stop();
                
            }
        }

        private void welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
