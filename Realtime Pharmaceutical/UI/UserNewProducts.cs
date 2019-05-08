using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Realtime_Pharmaceutical.BLL;
using Realtime_Pharmaceutical.DAL;

namespace Realtime_Pharmaceutical.UI
{
    public partial class UserNewProducts : UserControl
    {
        public UserNewProducts()
        {
            InitializeComponent();
        }
        ProductsBLL pbll = new ProductsBLL();
        ProductsDAL pdal = new ProductsDAL();
        private void BtnReset_Click(object sender, EventArgs e)
        {

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
