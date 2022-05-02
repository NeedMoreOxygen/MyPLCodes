using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;

namespace FourthRestaurant
{

    public partial class Form1 : Form
    {
        private readonly EventWaitHandle waitHandle = new AutoResetEvent(false);
        Task task1;
        Server server = new Server();
        int iS = 0;
        bool isDone = false;
        public Form1()
        {
            InitializeComponent();
            server.Put();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {

            int chickCount = Convert.ToInt32(textBox1.Text);
            int eggCount = Convert.ToInt32(textBox2.Text);
            string name = textBox3.Text;
            string drink = comboBox1.Text;
            if (server.service.Values.Where(i => i.isBusy == true).Count() == server.service.Values.Count)
            {
                isDone = false;
                while(isDone == false)
                {
                    button1.Enabled = false;
                    await Task.Delay(25);
                }
            }
            button1.Enabled = true;
            
            lock (server)
            {
                task1 = Task.Run(() => server.Receive(chickCount, eggCount, drink, name));
            }
            iS++;
            if (iS == 8)
                button1.Enabled = false;
            button2.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string text;
            server.service.Values.Where(i => i.ToList().Count != 0).Last().isBusy = true;
            await Task.Delay(2500);
            lock (server)
            {
                Task task2 = task1.ContinueWith(server.Send);
                text = task2.ContinueWith(server.Serve).Result.Result;
                isDone = true;
            }
            await Task.Delay(2500);
            label6.Text += text;
            iS = 0;
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
