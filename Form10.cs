using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Data.SqlClient;

namespace WindowsFormsApplication4
{
    public partial class Form10 : Form
    {
        public SqlCommand com = new SqlCommand();
        public SqlConnection con = new SqlConnection();
        public SqlDataReader rd;
        public Form10(string a, string b)
        {
            InitializeComponent();
            label1.Text = a;
            label2.Text = b;
            
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            com.Connection = con;
            con.ConnectionString = "Data Source=VASIM\\SQLEXPRESS;Initial Catalog=a;Integrated Security=True";
            con.Open();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Random ran = new Random();
                int no = ran.Next(9999);
                label5.Text = Convert.ToString(no);
                textBox3.Text = " ATM OTP";
                textBox4.Text = "Your OTP Number is:" + label5.Text;
                com.CommandText = "update  a set  otp='" + label5.Text + "'  where name='" + label1.Text + "' and password='" + label2.Text + "'  ";
                com.ExecuteNonQuery();
                com.CommandText = "select * from a where name='" + label1.Text + "' and password='" + label2.Text + "' ";
                rd = com.ExecuteReader();
                if (rd.Read())
                {
                    textBox5.Text = rd.GetString(11);
                } rd.Close();

                SmtpClient client = new SmtpClient("Smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("vasimkhancse2@gmail.com", "vasim786");
                if (textBox5.Text == textBox1.Text && textBox2.Text==label2.Text)
                {
                    MailMessage msg = new MailMessage();
                    msg.To.Add(textBox1.Text);
                    msg.From = new MailAddress("vasimkhancse2@gmail.com");
                    msg.Subject = textBox3.Text;
                    msg.Body = textBox4.Text;
                    client.Send(msg);
                    MessageBox.Show("successfully send message");
                    this.Hide();
                    Form11 f = new Form11(label1.Text,label2.Text);
                    f.Show();
                }
                else
                {
                    MessageBox.Show(" eeror email and password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
