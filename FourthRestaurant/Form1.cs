using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FourthRestaurant
{
    public partial class Form1 : Form
    {
        Server server = new Server();
        Cook cook = new Cook();
        int iS = 0;
        string text;
        public Form1()
        {
            InitializeComponent();
            server.Ready += (TableRequests orders) => cook.Process(orders);
            cook.Processed += Cook_Processed;
            button2.Enabled = false;
        }
        void Cook_Processed()
        {
            text = server.Serve();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int chickCount = Convert.ToInt32(textBox1.Text);
            int eggCount = Convert.ToInt32(textBox2.Text);
            string name = textBox3.Text;
            string drink = comboBox1.Text;
            server.Receive(chickCount, eggCount, drink, name);
            iS++;
            if (iS == 8)
                button1.Enabled = false;
            button2.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            server.Send();
            label6.Text += text;
            iS = 0;
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    internal class MenuItemComparer : IComparer<IMenuItem>
    {
        public int Compare(IMenuItem x, IMenuItem y)
        {
            if (x is Drink)
            {
                return -1;
            }
            else if (y is Drink)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
