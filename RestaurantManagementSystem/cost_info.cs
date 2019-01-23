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
    public partial class cost_info : Form
    {
        private OleDbConnection conn = new OleDbConnection();
        public cost_info()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =RestaurantManagement.accdb";
        }

        private void cost_info_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("Select * from cost_info", conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable scores = new DataTable();
                da.Fill(scores);
                dataGridView1.DataSource = scores;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime a, b;
            try
            {
                a = Convert.ToDateTime(dateTimePicker1.Value);
                b = Convert.ToDateTime(dateTimePicker2.Value);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * from cost_info Where c_date between #" + a + "# AND #" + b + "#", conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt;
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                
                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                }
                textBox1.Text = sum.ToString(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!! " + ex);
            }
            conn.Close();
        }
    }
}
