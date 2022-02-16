using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThirdRestaurant
{
    public partial class Form1 : Form
    {
        Server server = new Server();
        int iS = 0;
        int quality;
        string s;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (iS == 8)
                button1.Enabled = false;
            else
            {
                iS++;
                int chickCount = Convert.ToInt32(textBox1.Text);
                int eggCount = Convert.ToInt32(textBox2.Text);
                string drink = comboBox1.Text;
                server.Receive(chickCount, eggCount, drink);
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                server.Send();
            }
            catch(Exception ex)
            {
                s = ex.Message;
            }
            finally
            {
                quality = server.quality;
                label2.Text = quality.ToString();
            }
            button2.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text += server.Serve();
            label2.Text = s;
            s = "";
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            iS = 0;
        }
    }
}
