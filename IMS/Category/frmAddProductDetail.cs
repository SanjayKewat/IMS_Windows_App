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

namespace IMS.Category
{
    public partial class frmAddProductDetail : Form
    {
        public frmAddProductDetail()
        {
            InitializeComponent();
        }
        DataTable dt;
        private void frmAddProductDetail_Load(object sender, EventArgs e)
        {

        }

        private void fill_category()
        {
            dt = new DataTable();
        }

    }
}
