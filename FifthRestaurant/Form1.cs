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
        Task task1;
        Server server1 = new Server();
        Server server2 = new Server();
        List<Server> servers = new List<Server>();
        int iS = 0;
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            servers.Add(server1);
            servers.Add(server2);
            foreach (var i in servers)
            {
                i.Put();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            while(servers.Where(i => i.tables.Where(b => b.isGone == true).Count() == 3).Count() == 3)
            {
                await Task.Delay(25);
            }
            Server currentS = servers.Where(i => i.tables.Where(b => b.isGone == false).Count() > 0).First();
            int chickCount = Convert.ToInt32(textBox1.Text);
            int eggCount = Convert.ToInt32(textBox2.Text);
            string name = textBox3.Text;
            string drink = comboBox1.Text;
            int num = -1;
            currentS.amBusy = true;
            foreach (var i in currentS.tables)
            {
                if (i.isGone == true)
                {
                    continue;
                }
                num = currentS.tables.IndexOf(i);
                task1 = Task.Run(() => currentS.Receive(chickCount, eggCount, drink, name, num));
                i.isBusy = true;
                break;
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
            button2.Enabled = false;
            Server currentS = servers.Where(i => i.amBusy == true).First();
            while (currentS.tables.Where(i => i.Count() > 0 && i.isGone == false).Count() == 0)
            {
                await Task.Delay(25);
            }
            int numIndex = currentS.tables.IndexOf(currentS.tables.Where(i => i.Count() > 0 && i.isGone == false).First());
            string text;
            currentS.tables[numIndex].isGone = true;
            Cook currentCook = currentS.cooks.Where(i => i.busy == false).First();
            int index = currentS.cooks.IndexOf(currentCook);
            currentCook.busy = true;
            await Task.Delay(5000);
            currentS.Peek(index);
            Task task2 = task1.ContinueWith(currentS.Send);
            currentCook.busy = false;
            text = task2.ContinueWith(currentS.Serve).Result.Result;
            currentS.amBusy = false;
            await Task.Delay(5000);
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
