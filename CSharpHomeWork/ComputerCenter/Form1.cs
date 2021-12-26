using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerCenter
{
    public partial class Form1 : Form
    {
        Service newOrder;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(textBox5.Text);
            if (textBox1.Text != "")
            {
                int lB = Convert.ToInt32(textBox1.Text);
                int rB = Convert.ToInt32(textBox2.Text);
                int uB = Convert.ToInt32(textBox3.Text);
                int dB = Convert.ToInt32(textBox4.Text);
                newOrder = new Service(amount, lB, rB, uB, dB);
            }
            else
            {
                newOrder = new Service(amount);
            }
            listBox1.Items.Add("Submitted Successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add(newOrder.PaintLevelCheck());
            }
            catch(Exception ex1)
            {
                listBox1.Items.Add(ex1.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(newOrder.Raspechatka());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(newOrder.Copy());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
