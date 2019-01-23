using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.OleDb;

namespace RestaurantManagementSystem
{
    public partial class Admin_info : Form
    {
        private OleDbConnection conn = new OleDbConnection();
        public Admin_info()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =RestaurantManagement.accdb";
        }

        private void Admin_info_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("Select * from admin_registration", conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable scores = new DataTable();
                da.Fill(scores);
                dataGridView1.DataSource = scores;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error! "+ ex);
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                textBox2.Text = row.Cells[3].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("select * from admin_registration Where user_name='"+textBox1.Text+"'", conn);

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt;
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                //da.Fill(dscontects);
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR!! " + ex);
            }
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("update admin_registration set a_name= '" + textBox2.Text + "', [password]='" + textBox3.Text + "' Where user_name='" + textBox1.Text + "'", conn);
                if (textBox1.Text != "")
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully..");
                    button1_Click_1(sender, e);
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
            Admin_info_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("delete from admin_registration Where user_name='" + textBox1.Text + "'", conn);
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
            catch(Exception ex)
            {
                MessageBox.Show("ERROR! " + ex);
            }
            conn.Close();
            Admin_info_Load(sender, e);
        }
    }
}
