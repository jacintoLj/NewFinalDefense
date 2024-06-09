using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewFinalDefense
{
    public partial class machineUC : UserControl
    {
        public machineUC()
        {
            InitializeComponent();
        }

        private void AvailableButton1_Click(object sender, EventArgs e)
        {

            Machine1 mf = new Machine1();
            mf.Show();
           
        }

        private void BackDashboardButton_Click(object sender, EventArgs e)
        {
            dashboardUC db = new dashboardUC();           
            this.Show();
            db.Dock = DockStyle.Fill;
            db.BringToFront();


        }
    }
}
