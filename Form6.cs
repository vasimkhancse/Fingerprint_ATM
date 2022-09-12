using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication4
{
    public partial class Form6 : Form
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand com = new SqlCommand();
        public Form6(String a, String b)
        {
            InitializeComponent();
            label1.Text = a;
            dp1.Text = b;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dpt1.Text == "")
            {
                MessageBox.Show("enter the amount");
            }
            else
            {

                com.Connection = con;
                com.CommandText = "update  a set  deposit='" + dpt1.Text + "'  where name='" + label1.Text + "' and password= '" + dp1.Text + "'";
                com.ExecuteNonQuery();
                com.CommandText = "update  a set  amount=amount+deposit where name='" + label1.Text + "' and password= '" + dp1.Text + "'";
                com.ExecuteNonQuery();
                MessageBox.Show("amount was deposit");
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            com.Connection = con;
            con.ConnectionString = "Data Source=VASIM\\SQLEXPRESS;Initial Catalog=a;Integrated Security=True";
            con.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3(label1.Text, dp1.Text);
            f.Show();
        }
    }
}
