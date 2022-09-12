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
    public partial class Form7 : Form
    {

        public SqlConnection con = new SqlConnection();
        public SqlCommand com = new SqlCommand();
         public SqlDataReader rd;
        public Form7(String a, String b)
        {
            InitializeComponent();
            label1.Text = a;
            ball1.Text = b;
           
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            com.Connection = con;
            con.ConnectionString = "Data Source=VASIM\\SQLEXPRESS;Initial Catalog=a;Integrated Security=True";
            con.Open();


            com.Connection = con;
            com.CommandText = "select  amount " + " from a where name='" + label1.Text + "' ";
            rd = com.ExecuteReader();
            if (rd.Read())
            {
                ball3.Text=(rd["amount"].ToString());
               

            } rd.Close(); 

         
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 F = new Form3(label1.Text, ball1.Text);
            F.Show();

        }
    }
}
