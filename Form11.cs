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
    public partial class Form11 : Form
    {
        public SqlCommand com = new SqlCommand();
        public SqlConnection con = new SqlConnection();
        public SqlDataReader rd;
        public Form11(string a,string b)
        {
            InitializeComponent();
            label1.Text = a;
            label2.Text = b;
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            com.Connection = con;
            con.ConnectionString = "Data Source=VASIM\\SQLEXPRESS;Initial Catalog=a;Integrated Security=True";
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            com.CommandText = "select * from a where name='" + label1.Text + "' and password='" + label2.Text + "' ";
            rd = com.ExecuteReader();
            if (rd.Read())
            {
                label3.Text = rd.GetString(12);
            } rd.Close();
            if (label3.Text == textBox1.Text)
            {
                this.Hide();
                Form3 f = new Form3(label1.Text, label2.Text);
                f.Show();
            }
            else
            {
                MessageBox.Show("error otp,enter correct otp");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
