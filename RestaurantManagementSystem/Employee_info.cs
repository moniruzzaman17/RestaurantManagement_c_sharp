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
    public partial class Employee_info : Form
    {
        private OleDbConnection conn = new OleDbConnection();
        public Employee_info()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =RestaurantManagement.accdb";
        }

        private void Employee_info_Load(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from employee_registration", conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable scores = new DataTable();
            da.Fill(scores);
            dataGridView1.DataSource = scores;
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox1.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();
                textBox4.Text = row.Cells[4].Value.ToString();
                textBox5.Text = row.Cells[5].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            Employee_info_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (textBox1.Text != "")
                {
                    OleDbCommand cmd = new OleDbCommand("select * from employee_registration Where em_user_name='" + textBox1.Text + "'", conn);
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    DataTable dt;
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Invalid User Name!! ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!! " + ex);
            }
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("delete from employee_registration Where em_user_name='" + textBox1.Text + "'", conn);
                if (textBox1.Text != "")
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfull");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
                else
                    MessageBox.Show("User name not selsected");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! " + ex);
            }
            conn.Close();
            button2_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("update employee_registration set em_name= '" + textBox2.Text + "', em_password='" + textBox3.Text + "', em_email='" + textBox4.Text + "', em_phone='" + textBox5.Text + "' Where em_user_name='" + textBox1.Text + "'", conn);
                if (textBox1.Text != "")
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully..");
                }
                else
                {
                    MessageBox.Show("Invalid Username..!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!! " + ex);
            }
            conn.Close();
            button2_Click(sender, e);
        }
    }
}
