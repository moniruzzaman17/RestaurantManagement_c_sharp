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
    public partial class Food_menu : Form
    {
        private OleDbConnection conn = new OleDbConnection();
        public Food_menu()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =RestaurantManagement.accdb";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Food_menu_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("Select * from food_menu_price", conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable scores = new DataTable();
                da.Fill(scores);
                dataGridView1.DataSource = scores;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error!! " + ex);
            }
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                textBox8.Text = row.Cells[0].Value.ToString();
                textBox7.Text = row.Cells[1].Value.ToString();
                textBox6.Text = row.Cells[2].Value.ToString();
                textBox5.Text = row.Cells[3].Value.ToString();
                textBox4.Text = row.Cells[4].Value.ToString();
                textBox3.Text = row.Cells[5].Value.ToString();
                textBox2.Text = row.Cells[6].Value.ToString();
                textBox1.Text = row.Cells[7].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("update food_menu_price set tea= '" + textBox8.Text + "', coffe='" + textBox7.Text + "', singara='" + textBox6.Text + "', samusa='" + textBox5.Text +
                     "', dalpuri='" + textBox4.Text + "', hotchpotch='" + textBox3.Text + "', rice='" + textBox2.Text + "', vegetable='" + textBox1.Text + "' Where food_code= 'sfr1'", conn);
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" &&
                    textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully..");
                }
                else
                {
                    MessageBox.Show("Please Select price row below first!");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!! " + ex);
            }
            conn.Close();
            Food_menu_Load(sender, e);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }
    }
}
