using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form3 : Form
    {
        public Form3(string value,string a)

        {
            InitializeComponent();
            tral1.Text = value;
            tral2.Text = a;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f = new Form4(tral1.Text, tral2.Text);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f = new Form5(tral1.Text, tral2.Text);
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f = new Form6(tral1.Text, tral2.Text);
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f = new Form7(tral1.Text, tral2.Text);
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f = new Form8(tral1.Text, tral2.Text);
            f.Show();
        }
    }
}
