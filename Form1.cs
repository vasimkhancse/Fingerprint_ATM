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
    public partial class Form1 : Form
    {

        public SqlConnection con = new SqlConnection();
        public SqlCommand com = new SqlCommand();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=VASIM\\SQLEXPRESS;Initial Catalog=a;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from a where name='" + logt1.Text + "' and password='" + logt2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form9 f = new Form9(logt1.Text, logt2.Text);
                f.Show();
            }

            else
            {
                MessageBox.Show("please check your name and password");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            com.Connection = con;
            con.ConnectionString = "Data Source=VASIM\\SQLEXPRESS;Initial Catalog=a;Integrated Security=True";
            con.Open();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            logt2.PasswordChar = '?';
            logt2.MaxLength = 4;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
