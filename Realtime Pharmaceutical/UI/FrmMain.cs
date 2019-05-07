using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Realtime_Pharmaceutical
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(0, 97);
            sidePanel.BringToFront();
        }

        private void BtnOrders_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(0, 147);
            sidePanel.BringToFront();
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(0, 196);
            sidePanel.BringToFront();
        }

        private void BtnPayments_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(0, 245);
            sidePanel.BringToFront();
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(0, 295);
            sidePanel.BringToFront();
        }

        private void BtnInvoices_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(0, 344);
            sidePanel.BringToFront();
        }

        private void BtnSystemUsers_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(0, 394);
            sidePanel.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(0, 444);
            sidePanel.BringToFront();
            if (MessageBox.Show("Are you sure you want to exit?","Quit",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) ==DialogResult.Yes)
            {
                Application.Exit();    
            }
            sidePanel.Location = new Point(0, 97);
            sidePanel.BringToFront();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(0, 97);
            sidePanel.BringToFront();
        }
    }
}
