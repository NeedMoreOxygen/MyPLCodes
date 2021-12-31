using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayHW4
{
    public partial class Form1 : Form
    {
        static int cars = 0;
        Admin workDay = new Admin();
        string brand = "";
        string model = "";
        string licensePlate = "";
        string driverName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string addition = "";
            foreach (RadioButton rb in groupBox1.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    brand = rb.Text;
                }
            }
            driverName = textBox1.Text;
            model = textBox2.Text;
            licensePlate = textBox3.Text;
            foreach (RadioButton rb in groupBox2.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    addition += $" - {rb.Text}";
                }
            }
            if (textBox4.Text != "")
                addition += $" - {textBox4.Text}";
            string s = workDay.Register(brand, model, licensePlate, driverName, addition);
            cars++;
            listBox1.Items.Add($"{cars}) {s}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label10.Text += $"{workDay.Drive()}";
        }
    }
}
