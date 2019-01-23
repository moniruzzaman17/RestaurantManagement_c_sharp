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
    public partial class Form1 : Form
    {
        public void connection_mathod()
        {

        }
        private OleDbConnection conn = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; 
Data Source =RestaurantManagement.accdb";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select * from admin_registration where user_name='" + textBox1.Text + "' and [password]='" + textBox2.Text + "'", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (comboBox1.SelectedIndex == 0)
                    {
                        Visible = false;
                        Admin_Home ah = new Admin_Home();
                        ah.Show();
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        Visible = false;
                        Employee_Home eh = new Employee_Home();
                        eh.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Input or Type !!");
                    }
                    conn.Close();
                }


                else
                {
                    try
                    {
                        //conn.Open();
                        OleDbDataReader er = null;
                        OleDbCommand ecmd = new OleDbCommand("select * from employee_registration where em_user_name='" + textBox1.Text + "' and em_password='" + textBox2.Text + "'", conn);
                        er = ecmd.ExecuteReader();
                        if (er.Read())
                        {
                            if (comboBox1.SelectedIndex == 1)
                            {
                                Visible = false;
                                Employee_Home eh = new Employee_Home();
                                eh.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Input or Type !!");
                            }
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Input or Type !!");
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("ERROR !!" + ex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR !!" + ex);
            }
                    conn.Close();
        }
    }
}
