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
    public partial class UserManufacturers : UserControl
    {
        public UserManufacturers()
        {
            InitializeComponent();
        }
        ManufacturersBLL mbll = new ManufacturersBLL();
        ManufacturersDAL mdal = new ManufacturersDAL();
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            mbll.Address = TxtAddress.Text.ToUpper();
            mbll.ManufacturerLicense = TxtManufacturerLicense.Text.ToUpper();
            mbll.ManufacturerName = TxtManufacturerName.Text.ToUpper(); 
            try
            {
                bool IsSuccess = mdal.Insert(mbll);
                if (IsSuccess)
                {   
                    MessageBox.Show("Successfully created","Confirm",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                }   
                else
                {
                    MessageBox.Show("Failed to initiate a record","UI error",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"UI error",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
            }
        
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
