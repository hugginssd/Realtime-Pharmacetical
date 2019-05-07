using Realtime_Pharmaceutical.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Realtime_Pharmaceutical.UI
{
    public partial class FrmSignIn : Form
    {
        public FrmSignIn()
        {
            InitializeComponent();
        }
        Functions _fns = new Functions();
        UserDAL udal = new UserDAL();
        UserBLL ubll = new UserBLL();
        private void BtnSignIn_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void FrmSignIn_Load(object sender, EventArgs e)
        {
        }
    }
}
