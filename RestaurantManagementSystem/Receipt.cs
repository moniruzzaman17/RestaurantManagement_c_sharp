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
    public partial class Receipt : Form
    {
        private OleDbConnection conn = new OleDbConnection();
        public Receipt()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =RestaurantManagement.accdb";
            
        }

        private void cash_btn_TextChanged(object sender, EventArgs e)
        {
            int t, c, s;
            t = Convert.ToInt32(total_btn.Text);
            c = Convert.ToInt32(cash_btn.Text);
            s = c-t;
            cash_back_btn.Text = s.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select * from food_menu_price Where food_code='sfr1'", conn);
                if (checkBox1.Checked == true)
                {
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        int te = Convert.ToInt16(dr["tea"]);
                        int tq = Convert.ToInt16(textBox2.Text);
                        int p = te * tq;
                        textBox1.Text = p.ToString();
                    }
                }
                else
                {
                    textBox1.Text = "0";
                    textBox2.Text = "1";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR!! " + ex);
            }
            conn.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select * from food_menu_price Where food_code='sfr1'", conn);
                if (checkBox2.Checked == true)
                {
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        int te = Convert.ToInt16(dr["coffe"]);
                        int tq = Convert.ToInt16(textBox3.Text);
                        int p = te * tq;
                        textBox4.Text = p.ToString();
                    }
                }
                else
                {
                    textBox4.Text = "0";
                    textBox3.Text = "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!! " + ex);
            }
            conn.Close();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select * from food_menu_price Where food_code='sfr1'", conn);
                if (checkBox3.Checked == true)
                {
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        int te = Convert.ToInt16(dr["singara"]);
                        int tq = Convert.ToInt16(textBox5.Text);
                        int p = te * tq;
                        textBox6.Text = p.ToString();
                    }
                }
                else
                {
                    textBox6.Text = "0";
                    textBox5.Text = "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!! " + ex);
            }
            conn.Close();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select * from food_menu_price Where food_code='sfr1'", conn);
                if (checkBox4.Checked == true)
                {
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        int te = Convert.ToInt16(dr["samusa"]);
                        int tq = Convert.ToInt16(textBox7.Text);
                        int p = te * tq;
                        textBox8.Text = p.ToString();
                    }
                }
                else
                {
                    textBox8.Text = "0";
                    textBox7.Text = "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!! " + ex);
            }
            conn.Close();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select * from food_menu_price Where food_code='sfr1'", conn);
                if (checkBox5.Checked == true)
                {
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        int te = Convert.ToInt16(dr["dalpuri"]);
                        int tq = Convert.ToInt16(textBox9.Text);
                        int p = te * tq;
                        textBox10.Text = p.ToString();
                    }
                }
                else
                {
                    textBox10.Text = "0";
                    textBox9.Text = "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!! " + ex);
            }
            conn.Close();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select * from food_menu_price Where food_code='sfr1'", conn);
                if (checkBox6.Checked == true)
                {
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        int te = Convert.ToInt16(dr["hotchpotch"]);
                        int tq = Convert.ToInt16(textBox11.Text);
                        int p = te * tq;
                        textBox12.Text = p.ToString();
                    }
                }
                else
                {
                    textBox12.Text = "0";
                    textBox11.Text = "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!! " + ex);
            }
            conn.Close();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select * from food_menu_price Where food_code='sfr1'", conn);
                if (checkBox7.Checked == true)
                {
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        int te = Convert.ToInt16(dr["rice"]);
                        int tq = Convert.ToInt16(textBox13.Text);
                        int p = te * tq;
                        textBox14.Text = p.ToString();
                    }
                }
                else
                {
                    textBox14.Text = "0";
                    textBox13.Text = "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!! " + ex);
            }
            conn.Close();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select * from food_menu_price Where food_code='sfr1'", conn);
                if (checkBox8.Checked == true)
                {
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        int te = Convert.ToInt16(dr["vegetable"]);
                        int tq = Convert.ToInt16(textBox15.Text);
                        int p = te * tq;
                        textBox16.Text = p.ToString();
                    }
                }
                else
                {
                    textBox16.Text = "0";
                    textBox15.Text = "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!! " + ex);
            }
            conn.Close();
        }

        private void total_btn_Click(object sender, EventArgs e)
        {
            int c1, c2, c3, c4, c5, c6, c7, c8, c9, c10,total;
            c1 = Convert.ToInt32(textBox1.Text);
            c2 = Convert.ToInt32(textBox4.Text);
            c3 = Convert.ToInt32(textBox6.Text);
            c4 = Convert.ToInt32(textBox8.Text);
            c5 = Convert.ToInt32(textBox10.Text);
            c6 = Convert.ToInt32(textBox12.Text);
            c7 = Convert.ToInt32(textBox14.Text);
            c8 = Convert.ToInt32(textBox16.Text);
            c9 = Convert.ToInt32(textBox18.Text);
            c10 = Convert.ToInt32(textBox20.Text);

            total = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c10;
            total_btn.Text = total.ToString();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbDataReader dr = null;
                OleDbCommand cmd = new OleDbCommand("select * from food_menu_price Where food_code='sfr1'", conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        textBox28.Text = (dr["tea"].ToString());
                        textBox27.Text = (dr["coffe"].ToString());
                        textBox26.Text = (dr["singara"].ToString());
                        textBox25.Text = (dr["samusa"].ToString());
                        textBox24.Text = (dr["dalpuri"].ToString());
                        textBox23.Text = (dr["hotchpotch"].ToString());
                        textBox22.Text = (dr["rice"].ToString());
                        textBox21.Text = (dr["vegetable"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!! " + ex);
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Arial",15, FontStyle.Regular), Brushes.Black, 150, 125);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = DateTime.Now + "\n\n\t     SQUARE FOOD & Restaurant \n \t\t IUBAT University \n \n \n \t Tea: \t \t" + textBox1.Text+
                "\n \t Coffe: \t \t" + textBox4.Text+ "\n \t Singara: \t \t" + textBox6.Text+ "\n \t Samusa: \t \t" + textBox8.Text + "\n  \t Dalpuri: \t \t" + textBox10.Text
                + "\n \t HotchPotch: \t" + textBox12.Text + "\n \t Rice: \t \t" + textBox14.Text + "\n \t Vegetable: \t" + textBox16.Text + "\n  \t Drinks: \t \t" + textBox18.Text
                + "\n \t Others: \t \t" + textBox20.Text+"\n\n\t ------------------------------------------ \n" + "\t Total cost:\t" +
                total_btn.Text + "\n\t Cash:\t \t" + cash_btn.Text + "\n\t Cash Back:\t" + cash_back_btn.Text
                + "\n\n\n\n\t % Thanks for Choose our Restaurant %";

            
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("insert into cost_info(c_date, daily_cost) values('" + DateTime.Now + "','" + total_btn.Text + "')", conn);
                cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!! " + ex);
            }
            conn.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
