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

            Reset();

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            pbll.BatchNumber = txtBatchNumber.Text.ToUpper();
            pbll.Comment = txtComment.Text.ToUpper();
            pbll.ExpiredDate = DtpExpiryDate.Value.Date;
            pbll.ImportedDate = DtpImportedDate.Value.Date;
            pbll.ManufacturedDate = DtpManfDate.Value.Date;
            pbll.ProdcutID = Convert.ToInt32(txtProductID.Text);
            pbll.ProductName = txtProductName.Text.ToUpper();
            pbll.Unit = Convert.ToInt32(txtUnits.Text);
            pbll.Taxing = Convert.ToDouble(txtTaxing.Text);
            pbll.ManufacturedID = Convert.ToInt32(CmbManufacturerID.SelectedValue);
            try
            {
                bool IsSuccess = pdal.Insert(pbll);
                if (IsSuccess)
                {
                    MessageBox.Show("Successfully created", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    DataTable dt = new DataTable();
                    dt = pdal.Select();
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Failed to initiate a record", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)   
            {   
                MessageBox.Show(ex.ToString(),"UI error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }  

        }
        public void Reset()
        {

        }
    }
}
