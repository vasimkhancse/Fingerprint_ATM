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
    public partial class Form5 : Form
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand com = new SqlCommand();
        public SqlDataReader rd;
        public Form5(String a,String b)
        {
            InitializeComponent();
            label1.Text = a;
            pinl1.Text = b;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            com.Connection = con;
            con.ConnectionString = "Data Source=VASIM\\SQLEXPRESS;Initial Catalog=a;Integrated Security=True";
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (pint1.Text == pinl1.Text)
            {
                if (pint2.Text == pint3.Text)
                {
                    com.Connection = con;
                    com.CommandText = "update a set password='" + pint2.Text + "' where name='" + label1.Text + "'";
                    com.ExecuteNonQuery();

                    com.CommandText = "select * from a where name='" + label1.Text + "' ";
                    rd = com.ExecuteReader();
                    if (rd.Read())
                    {
                        label2.Text = rd.GetString(1);


                    } rd.Close();

                    MessageBox.Show(" update rename password");
                }
                else
                {
                    MessageBox.Show("enter the correct rename password");
                }
            }


            else
            {
                MessageBox.Show("enter password");
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pint1.PasswordChar = '*';
            pint1.MaxLength = 4;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            pint2.PasswordChar = '*';
            pint2.MaxLength = 4;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            pint3.PasswordChar = '*';
            pint3.MaxLength = 4;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (pint1.Text != label2.Text)
                        {
            this.Hide();
            Form3 f = new Form3(label1.Text, label2.Text);
            f.Show();
            }
            else
            {
                this.Hide();
                Form3 f = new Form3(label1.Text, pinl1.Text);
                f.Show();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pinl1_Click(object sender, EventArgs e)
        {

        }
    }
}
