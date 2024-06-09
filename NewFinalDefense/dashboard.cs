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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void MachineButton_Click(object sender, EventArgs e)
        {
            machineUC m1 = new machineUC();
            this.Show();
            m1.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(m1);
            m1.BringToFront();
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            paymentUC payment = new paymentUC();
            this.Show();
            payment.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(payment);
            payment.BringToFront();

        }

        private void SchedulingButton_Click(object sender, EventArgs e)
        {
            scheduleUC payment = new scheduleUC();
            this.Show();
            payment.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(payment);
            payment.BringToFront();
        }

        private void CustomerManageButton_Click(object sender, EventArgs e)
        {
            managecustomerUC mc1 = new managecustomerUC();
            this.Show();
            mc1.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(mc1);
            mc1.BringToFront();
        }

        private void StorageButton_Click(object sender, EventArgs e)
        {
            inventoryUC inventory = new inventoryUC();
            this.Show();
            inventory.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(inventory);
            inventory.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            signin sn = new signin();
            sn.Show();  
            this.Hide();
        }
    }
}
