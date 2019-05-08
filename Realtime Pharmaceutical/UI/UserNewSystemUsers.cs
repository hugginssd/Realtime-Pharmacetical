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
    public partial class UserNewSystemUsers : UserControl
    {
        public UserNewSystemUsers()
        {
            InitializeComponent();
        }
        UserDAL udal = new UserDAL();
        UserBLL ubll = new UserBLL();
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            ubll.UserID = Convert.ToInt32(txtID.Text);
            ubll.FirstName = txtFirstname.Text.ToUpper();
            ubll.LastName = txtLastname.Text.ToUpper();
            ubll.UserName = txtUsername.Text;
            ubll.Password = txtPassword.Text;
            bool IsSuccess = udal.Insert(ubll);
            if (IsSuccess)
            {
                MessageBox.Show("Succeesfully created","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                DataTable dt = new DataTable();
                dt = udal.Select(txtUsername.Text);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to initiate a record", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        void Reset()
        {

        }
    }
}
