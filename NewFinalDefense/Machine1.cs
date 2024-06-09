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
    public partial class Machine1 : Form
    {
        public Machine1()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            machineUC machine = new machineUC();
            machine.Show();
            this.Close();
        }
    }
}
