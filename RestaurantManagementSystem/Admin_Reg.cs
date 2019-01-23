using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace RestaurantManagementSystem
{
    public partial class Admin_Reg : Form
    {
        private OleDbConnection conn = new OleDbConnection();
        public Admin_Reg()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; 
Data Source =RestaurantManagement.accdb";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("insert into admin_registration(a_name, user_name, [password]) values('"+textBox1.Text+"','"+textBox2.Text+"','" + textBox3.Text + "')",conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Successfull !!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR !!" + ex);
            }
            conn.Close();
        }
    }
}
