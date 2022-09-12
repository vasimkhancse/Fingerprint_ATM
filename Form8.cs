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
    public partial class Form8 : Form
    {

        public SqlConnection con = new SqlConnection();
        public SqlCommand com = new SqlCommand();
        SqlDataReader rd;
        public Form8(String a, String b)
        {
            InitializeComponent();
            udl1.Text = a;
            udl2.Text = b;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            com.Connection = con;
            con.ConnectionString = "Data Source=VASIM\\SQLEXPRESS;Initial Catalog=a;Integrated Security=True";
            con.Open();

            com.Connection = con;
            com.CommandText = "select * from a where name='" + udl1.Text + "' ";
            rd = com.ExecuteReader();
            if (rd.Read())
            {
                udl3.Text = rd.GetString(0);
                udl4.Text = rd.GetString(5);
                udl5.Text = rd.GetString(6);
                udl6.Text = rd.GetString(7);
                udl7.Text = rd.GetString(8);
                udl8.Text = rd.GetString(9);
                udl9.Text = rd.GetString(10);
                udl10.Text = rd.GetString(11);

            } rd.Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3(udl1.Text, udl2.Text);
            f.Show();
        }
    }
}
