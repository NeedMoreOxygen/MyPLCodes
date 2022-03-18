using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthRestaurant
{
    class Server
    {
        private TableRequests tableRequest { get; set; } = new TableRequests();

        public delegate void OrderReady(TableRequests request);
        public event OrderReady Ready;
        public void Receive(int chickenQuantity, int eggQuantity, string drink, string name)
        {
            for (int i = 1; i <= chickenQuantity; i++)
            {
                Chicken chicken = new Chicken();
                tableRequest.Add<Chicken>(name);
            }
            for (int i = 1; i <= eggQuantity; i++)
            {
                Egg egg = new Egg();
                tableRequest.Add<Egg>(name);
            }
            switch (drink)
            {
                case "Tea":
                    tableRequest.Add<Tea>(name);
                    break;
                case "Coffee":
                    tableRequest.Add<Coffee>(name);
                    break;
                case "Cola":
                    tableRequest.Add<Cola>(name);
                    break;
            }
        }
        public void Send()
        {
            Ready?.Invoke(tableRequest);
        }
        MenuItemComparer menuItemComparer = new MenuItemComparer();
        public string Serve()
        {
            string s = "";
            foreach (var name in tableRequest)
            {
                int chickenQuantity = 0;
                int eggQuantity = 0;
                s += $"{name} is served: ";
                var items = tableRequest[name];
                items.Sort(menuItemComparer);
                foreach (var i in items)
                {
                    if (i is Chicken)
                        chickenQuantity++;
                    else if (i is Egg)
                        eggQuantity++;
                    else if (i is Tea)
                        s += "Tea, ";
                    else if (i is Coffee)
                        s += "Coffee, ";
                    else if (i is Cola)
                        s += "Cola, ";
                }
                s += $"{chickenQuantity} chicken, {eggQuantity} egg\n";
            }
            s += $"Please enjoy your food!\n\n";
            tableRequest = new TableRequests();
            return s;
        }

    }
}
