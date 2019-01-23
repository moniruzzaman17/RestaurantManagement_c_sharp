using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class Employee_Home : Form
    {
        public Employee_Home()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            Form1 login = new Form1();
            login.Show();
        }

        private void employeeInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Em_info_employee eie = new Em_info_employee();
            eie.MdiParent = this;
            eie.Show();
        }

        private void receiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Receipt r = new Receipt();
            r.MdiParent = this;
            r.Show();
        }
    }
}
