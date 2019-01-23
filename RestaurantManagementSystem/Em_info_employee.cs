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
    public partial class Em_info_employee : Form
    {
        private OleDbConnection conn = new OleDbConnection();
        public Em_info_employee()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =RestaurantManagement.accdb";
        }

        private void Em_info_employee_Load(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("Select em_name, em_user_name, em_email from employee_registration", conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable scores = new DataTable();
            da.Fill(scores);
            dataGridView1.DataSource = scores;
            conn.Close();
        }
    }
}
