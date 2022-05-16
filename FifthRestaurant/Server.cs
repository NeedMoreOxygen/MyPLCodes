using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FourthRestaurant
{
    class Server
    {
        public bool amBusy = false;
        public List<Cook> cooks { get; set; }
        public List<TableRequests> tables { get; set; }
        Cook cook1;
        Cook cook2;
        Cook cook3;
        TableRequests table1;
        TableRequests table2;
        TableRequests table3;
        int currentCookIndex = -1;
        public void Peek(int index)
        {
            currentCookIndex = index;
        }
        public void Put()
        {
            cooks = new List<Cook>();
            tables = new List<TableRequests>();
            cook1 = new Cook();
            cook2 = new Cook();
            cook3 = new Cook();
            table1 = new TableRequests();
            table2 = new TableRequests();
            table3 = new TableRequests();
            cooks.Add(cook1);
            cooks.Add(cook2);
            cooks.Add(cook3);
            tables.Add(table1);
            tables.Add(table2);
            tables.Add(table3);
        }
        public void Receive(int chickenQuantity, int eggQuantity, string drink, string name, int num)
        {
            TableRequests currentTable = tables[num];
            for (int i = 1; i <= chickenQuantity; i++)
            {
                Chicken chicken = new Chicken();
                currentTable.Add<Chicken>(name);
            }
            for (int i = 1; i <= eggQuantity; i++)
            {
                Egg egg = new Egg();
                currentTable.Add<Egg>(name);
            }
            switch (drink)
            {
                case "Tea":
                    currentTable.Add<Tea>(name);
                    break;
                case "Coffee":
                    currentTable.Add<Coffee>(name);
                    break;
                case "Cola":
                    currentTable.Add<Cola>(name);
                    break;
            }
        }
        public async Task Send(Task task)
        {
            TableRequests currentTable = tables.Where(i => i.Count() > 0).Last();
            cooks[currentCookIndex].Process(currentTable);
            await task;
        }
        public async Task<string> Serve(Task task)
        {
            TableRequests currentTable = tables.Where(i => i.Count() > 0).First();
            string s = "";
            currentTable.OrderBy(i => i);
            foreach (var name in currentTable)
            {
                var items = currentTable[name];
                items = items.OrderBy(i => i is Drink).ToList();
                s += $"{name} is served: ";
                int chickenQuantity = items.Where(i => i is Chicken).Count();
                int eggQuantity = items.Where(i => i is Egg).Count();
                Drink drink = (items.Where(i => i is Drink).Count()==1)? (Drink)items.Where(i => i is Drink).Single() : null;
                if (drink != null)
                    s += $"{drink.GetType().Name}, ";
                if (eggQuantity > 0)
                    s += $"{eggQuantity} eggs, ";
                if (chickenQuantity > 0)
                    s += $"{chickenQuantity} chicken\n";
            }
            s += $"Please enjoy your food!\n\n";
            tables.Remove(currentTable);
            TableRequests table = new TableRequests();
            tables.Add(table);
            await task;
            return s;
        }

    }
}
