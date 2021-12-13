using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myRestaurant
{
    public partial class Form1 : Form
    {
        Employee order = new Employee();
        object myObj1;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                myObj1 = order.NewRequest(Convert.ToInt32(textBox1.Text), "Chicken");
                label3.Text = order.Inspect(myObj1);

            }
            else
            {
                myObj1 = order.NewRequest(Convert.ToInt32(textBox1.Text), "Egg");
                label3.Text = order.Inspect(myObj1);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                label5.Text += order.PrepareFood(myObj1) + "\n";
            }
            catch(Exception ex3)
            {
                label5.Text += ex3.Message + "\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                myObj1 = order.CopyRequest();
                label3.Text = order.Inspect(myObj1);
            }
            catch(Exception ex2)
            {
                label5.Text += ex2.Message + "\n";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}