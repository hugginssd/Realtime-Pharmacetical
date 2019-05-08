using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Realtime_Pharmaceutical.UI
{
    public partial class UserDashboard : UserControl
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            lblCity1.Text = "Mutare";
            lblCity2.Text = "Bindura";
            lblCity3.Text = "Harare";
            //Drugs initial data
            lblDrug1.Text = "Chloroquin";
            lblDrug2.Text = "Metabisulphate";
            lblDrug3.Text = "Bioplus";
            lblDrug4.Text = "Paracetamol";
            //Drugs initial data
            lblDrug1City3.Text = "Amoxilin";
            lblDrug2City3.Text = "Metabisulphate";
            lblDrug3City3.Text = "Bioplus";
            lblDrug4City3.Text = "Paracetamol";
        }
    }
}
