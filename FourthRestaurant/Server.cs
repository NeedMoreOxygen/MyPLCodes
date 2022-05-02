using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FourthRestaurant
{
    class Server
    {
        List<Cook> cooks = new List<Cook>();
        public Dictionary<Cook, TableRequests> service { get; private set; }
        Cook cook1;
        Cook cook2;
        TableRequests table1;
        TableRequests table2;

        public void Put()
        {
            service = new Dictionary<Cook, TableRequests>();
            cook1 = new Cook();
            cook2 = new Cook();
            table1 = new TableRequests();
            table2 = new TableRequests();
            service.Add(cook1, table1);
            service.Add(cook2, table2);
        }
        public void Receive(int chickenQuantity, int eggQuantity, string drink, string name)
        {
            TableRequests currentTable = service.Values.Where(i => i.isBusy == false).First();
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
            TableRequests currentTable = service.Values.Where(i => i.ToList().Count != 0).First();
            Cook currentCook = service.Keys.Where(i => i.busy == false).First();
            currentCook.busy = true;
            currentCook.Process(currentTable);
            currentCook.busy = false;
            currentTable.isBusy = false;
            await task;

        }
        public async Task<string> Serve(Task task)
        {
            TableRequests currentTable = service.Values.Where(i => i.Count() != 0 && i.isBusy == false).First();

            string s = "";
            currentTable.OrderBy(i => i);
            foreach (var name in currentTable)
            {
                var items = currentTable[name];
                items = items.OrderBy(i => i is Drink).ToList();
                s += $"{name} is served: ";
                int chickenQuantity = items.Where(i => i is Chicken).Count();
                int eggQuantity = items.Where(i => i is Egg).Count();
                int drinkCount = items.Where(i => i is Drink).Count();
                if (drinkCount == 1)
                    s += $"{drinkCount} drink, ";
                if (eggQuantity > 0)
                    s += $"{eggQuantity} eggs, ";
                if (chickenQuantity > 0)
                    s += $"{chickenQuantity} chicken\n";
            }
            s += $"Please enjoy your food!\n\n";
            service.Remove(service.Keys.ToList()[service.Values.ToList().IndexOf(currentTable)]);
            Cook cook = new Cook();
            TableRequests table = new TableRequests();
            service.Add(cook, table);
            await task;
            return s;
        }

    }
}
