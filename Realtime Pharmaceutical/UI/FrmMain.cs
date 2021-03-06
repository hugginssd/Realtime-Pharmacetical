﻿using System;
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
            userNewOrders.Visible = true;
            userNewOrders.BringToFront();
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(0, 196);
            sidePanel.BringToFront();
            userNewCustomers.Visible = true;
            userNewCustomers.BringToFront();
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
            userNewProducts.Visible = true;
            userNewProducts.BringToFront();
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
            userNewSystemUsers.Visible = false;
            userNewSystemUsers.BringToFront();
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
            userDashboard.Visible = true;
            userDashboard.BringToFront();
            userNewOrders.Visible = false;
            userNewCustomers.Visible = false;
            userNewSystemUsers.Visible = false;
        }
    }
}
