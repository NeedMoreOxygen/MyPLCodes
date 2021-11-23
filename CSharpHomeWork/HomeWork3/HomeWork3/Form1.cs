using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int seconds = int.Parse(textBox1.Text);
            int hours = seconds / 3600;
            int minsFromHour = seconds / 60 % 60;
            int secondsFromMin = seconds % 60;
            label5.Text = hours.ToString();
            label6.Text = minsFromHour.ToString();
            label7.Text = secondsFromMin.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
