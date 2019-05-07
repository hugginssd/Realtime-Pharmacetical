using Realtime_Pharmaceutical.BLL;
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
            ubll.UserName = txtUsername.Text;
            ubll.Password = txtPassword.Text;
            bool IsSuccess = udal.Search(ubll);
            if (IsSuccess)
            {
                FrmMain frmMain = new FrmMain();
                frmMain.Show();
            }
            else
            {
                MessageBox.Show("Invalid login credentials","SignIn",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
                return;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void FrmSignIn_Load(object sender, EventArgs e)
        {
        }

        public void Reset()
        {

        }
    }
}
