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
    public partial class UserNewCustomers : UserControl
    {
        public UserNewCustomers()
        {
            InitializeComponent();
        }
        CustomersBLL cbll = new CustomersBLL();
        CustomersDAL cdal = new CustomersDAL();
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            cbll.Address = TxtAddress.Text.ToUpper();
            cbll.Contact = TxtContact.Text.ToUpper();
            cbll.CustomerName = TxtCustomerName.Text.ToUpper();
            cbll.Type = CmbCustomerType.Text.ToUpper();
            cbll.CustomerID = Convert.ToInt32(TxtCustomerID.Text);
            try
            {
                bool IsSuccess = cdal.Insert(cbll);
                if (IsSuccess)
                {
                    MessageBox.Show("Successfully created","Confirm",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                    DataTable dt = new DataTable();
                    dt = cdal.Select();
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Failed to initiate a record","Error",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"UI error",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {

        }
        void Reset()
        {

        }
    }
}
