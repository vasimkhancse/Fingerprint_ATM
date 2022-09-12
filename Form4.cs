using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml; 

namespace WindowsFormsApplication4
{
    public partial class Form4 : Form
    {
        
           public SqlConnection con = new SqlConnection();
           public SqlCommand com = new SqlCommand();
           SqlDataReader rd;
            
        
        public Form4(String a,String b)
        {
            InitializeComponent();
           label1.Text = a;
            label2.Text = b;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            com.Connection = con; 
            con.ConnectionString = "Data Source=VASIM\\SQLEXPRESS;Initial Catalog=a;Integrated Security=True";
            con.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            com.Connection = con;
            com.CommandText = "update  a set  withdrawal='" + wdt1.Text + "'  where name='" + label1.Text + "' and password= '" + label2.Text + "'";
            com.ExecuteNonQuery();

            com.CommandText = "select  amount " + " from a where name='" + label1.Text + "' ";
            rd = com.ExecuteReader();
            if (rd.Read())
            {
                wdl1.Text = (rd["amount"].ToString());


            } rd.Close();
            int a = Convert.ToInt32(wdl1.Text); int b = Convert.ToInt32(wdt1.Text);

            if (b <= a)
            {



                com.CommandText = "update  a set  amount=amount-withdrawal  where name='" + label1.Text + "' and password= '" + label2.Text + "'  ";
                com.ExecuteNonQuery();
                MessageBox.Show("amount was withdrawal");
            }
            else
            {
                MessageBox.Show("your balance is low");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3(label1.Text, label2.Text);
            f.Show();
        }
    }
}
