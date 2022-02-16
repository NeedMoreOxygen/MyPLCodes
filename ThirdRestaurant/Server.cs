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
        Drink drink;
        string drinkName;
        static int customer = 1;
        public void Receive(int chickenQuantity, int eggQuantity, string drink)
        {
            this.drinkName = drink;
            if (drink == "Tea")
                this.drink = new Tea();
            else if (drink == "Coca-Cola")
                this.drink = new CocaCola();
            else if (drink == "Pepsi")
                this.drink = new Pepsi();

            for(int i = 1; i <= chickenQuantity; i++)
            {
                Chicken chicken = new Chicken();
                tableRequest.Add(customer, chicken);
            }
            for(int i = 1; i <= eggQuantity; i++)
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
            catch(Exception ex)
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
                int chickenQuantity = 0;
                int eggQuantity = 0;
                for (int j = 0; j < tableRequest[i].Length; j++)
                {
                    if (tableRequest[i][j] is Chicken)
                        chickenQuantity++;
                    else if (tableRequest[i][j] is Egg)
                        eggQuantity++;
                }
                if(drink != null)
                    drink.Obtain();
                s += $"Customer {i} is served {chickenQuantity} chicken, {eggQuantity} egg, {drinkName}\n";
            }
            s += $"Please enjoy your food!\n\n";
            tableRequest = new TableRequests();
            customer = 1;
            return s;
        }
    }
}