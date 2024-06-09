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
    public partial class inventoryUC : UserControl
    {
        public inventoryUC()
        {
            InitializeComponent();
        }

        private void BackDashboardButton_Click(object sender, EventArgs e)
        {
            dashboardUC m1 = new dashboardUC();
            this.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(m1);
            m1.BringToFront();
        }
    }
}
