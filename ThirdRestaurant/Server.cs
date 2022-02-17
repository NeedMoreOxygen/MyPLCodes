using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdRestaurant
{
    class Server
    {
        Cook cook = new Cook();
        public int quality { get; private set; }
        TableRequests tableRequest = new TableRequests();
        Drink[] drinks = new Drink[0];
        static int customer = 1;
        public void Receive(int chickenQuantity, int eggQuantity, string drink)
        {
            Array.Resize<Drink>(ref drinks, drinks.Length + 1);
            if (drink == "Tea")
                drinks[customer - 1] = new Tea();
            else if (drink == "Coca-Cola")
                drinks[customer - 1] = new CocaCola();
            else if (drink == "Pepsi")
                drinks[customer - 1] = new Pepsi();
            else
                drinks[customer - 1] = null;

            for (int i = 1; i <= chickenQuantity; i++)
            {
                Chicken chicken = new Chicken();
                tableRequest.Add(customer, chicken);
            }
            for (int i = 1; i <= eggQuantity; i++)
            {
                Egg egg = new Egg();
                tableRequest.Add(customer, egg);
            }
            customer++;
        }
        public void Send()
        {
            try
            {
                cook.Process(tableRequest);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                quality = cook.quality;
            }
        }
        public string Serve()
        {
            string s = "";
            for (int i = 0; i < tableRequest.table.Length; i++)
            {
                CookedFood[] customRequest = tableRequest[i];
                string currentDrink = "No drink";
                int chickenQuantity = 0;
                int eggQuantity = 0;
                for (int j = 0; j < customRequest.Length; j++)
                {
                    if (customRequest[j] is Chicken)
                        chickenQuantity++;
                    else if (customRequest[j] is Egg)
                        eggQuantity++;
                }
                if (drinks[i] != null)
                {
                    drinks[i].Obtain();
                    if (drinks[i] is Tea)
                        currentDrink = "Tea";
                    else if (drinks[i] is CocaCola)
                        currentDrink = "Coca-Cola";
                    else
                        currentDrink = "Pepsi";
                }
                s += $"Customer {i} is served {chickenQuantity} chicken, {eggQuantity} egg, {currentDrink}\n";
                currentDrink = "No drink";
            }
            s += $"Please enjoy your food!\n\n";
            tableRequest = new TableRequests();
            drinks = new Drink[0];
            customer = 1;
            return s;
        }
    }
}