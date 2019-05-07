using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Realtime_Pharmaceutical.DAL;
using Realtime_Pharmaceutical.BLL;

namespace Realtime_Pharmaceutical.UI
{
    public partial class UserNewOrders : UserControl
    {
        public UserNewOrders()
        {
            InitializeComponent();
        }
        OrderDetailsDAL oddal = new OrderDetailsDAL();
        OrderDetailsBLL odbll = new OrderDetailsBLL();
        private void BtnCreate_Click(object sender, EventArgs e)
        {

            odbll.AmountPaid = Convert.ToDouble(txtAmountPaid.Text);
            odbll.Comment = txtComment.Text.ToUpper();
            odbll.Discount = Convert.ToDouble(txtDiscount.Text);
            odbll.PaymentMode = CmbPaymentMode.Text.ToUpper();
            odbll.PayDate = DateTime.Now.Date;
            odbll.Status = CmbStatus.Text.ToUpper();
            odbll.OrderDate = DateTime.Now.Date;
            odbll.UserID = Convert.ToInt32(CmbUserID.SelectedValue);
            odbll.CustomerID = Convert.ToInt32(CmbCustomerID.SelectedValue);
            try
            {
                bool IsSuccess = oddal.Insert(odbll);
                if (IsSuccess)  
                {
                    MessageBox.Show("Successfully created","Confirm",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                    DataTable dt = new DataTable();
                    dt = oddal.Select();
                    dataGridView1.DataSource = dt;
                }
                else
                {   
                    MessageBox.Show("Failed to initiate a record","Error",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"UI error",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }
        }

        private void UserNewOrders_Load(object sender, EventArgs e)
        {
            oddal.SelectCustomerIDAndUserID(CmbCustomerID,CmbUserID);
        }
        void Reset()
        {

        }
    }
}
