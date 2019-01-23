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
    public partial class Admin_Home : Form
    {
        public Admin_Home()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            Form1 login = new Form1();
            login.Show();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void adminRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // pBox.Visible = false;
            Admin_Reg ar = new Admin_Reg();
            ar.MdiParent = this;
            ar.Show();

        }

        private void userRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Reg er = new Employee_Reg();
            er.MdiParent = this;
            er.Show();
        }

        private void adminInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_info ai = new Admin_info();
            ai.MdiParent = this;
            ai.Show();
        }

        private void employeeInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_info ei = new Employee_info();
            ei.MdiParent = this;
            ei.Show();
        }

        private void updateFoodMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Food_menu fm = new Food_menu();
            fm.MdiParent = this;
            fm.Show();
        }

        private void receiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Receipt r = new Receipt();
            r.MdiParent = this;
            r.Show();
        }

        private void costInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cost_info ci = new cost_info();
            ci.MdiParent = this;
            ci.Show();
        }

        private void costInformationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cost_info ci = new cost_info();
            ci.MdiParent = this;
            ci.Show();
        }
    }
}
