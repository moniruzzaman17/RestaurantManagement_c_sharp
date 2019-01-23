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
    public partial class Employee_Reg : Form
    {
        private OleDbConnection conn = new OleDbConnection();
        public Employee_Reg()
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
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("insert into employee_registration(em_name, em_user_name, em_password, em_email, em_phone) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Successfull !!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR !!" + ex);
            }
            conn.Close();
        }
    }
}
