using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondRestaurant
{
    class Server
    {
        bool everyThinkIsOk = false;
        Egg egg;
        Chicken chicken;
        int chickenQuantity = 0;
        int eggQuantity = 0;
        public enum Table { Chicken, Egg, Coffee, Cola, Tea };
        Table[][] tableOrder = new Table[0][];
        public void Receive(int chickCount, int eggCount, string drink)
        {
            chickenQuantity += chickCount;
            eggQuantity += eggCount;
            Array.Resize(ref tableOrder, tableOrder.Length + 1);
            if (drink == "No drink")
                Array.Resize(ref tableOrder[tableOrder.Length - 1], eggCount + chickCount);
            else
            {
                Array.Resize(ref tableOrder[tableOrder.Length - 1], eggCount + chickCount + 1);
                tableOrder[tableOrder.Length - 1][tableOrder[tableOrder.Length - 1].Length - 1] = (drink == "Coffee") ? (Table)2 : (drink == "Cola") ? (Table)3 : (Table)4;
            }
            int j;
            for (j = 0; j < chickCount; j++)
            {
                tableOrder[tableOrder.Length - 1][j] = (Table)0;
            }
            for (int i = j; i < eggCount + j; i++)
            {
                tableOrder[tableOrder.Length - 1][i] = (Table)1;
            }
        }
        public void Send()
        {
            Cook cook = new Cook();
            if (chickenQuantity > 0)
            {
                chicken = (Chicken)cook.Submit(chickenQuantity, "Chicken");
                cook.PrepareFood(chicken);
                chickenQuantity = 0;
            }
            if (eggQuantity > 0)
            {
                egg = (Egg)cook.Submit(eggQuantity, "Egg");
                cook.PrepareFood(egg);
                eggQuantity = 0;
            }
        }
        public string Serve()
        {
            string s = "";
            for (int i = 0; i < tableOrder.Length; i++)
            {
                int chickCount = 0;
                int eggCount = 0;
                string drink = "";
                for (int j = 0; j < tableOrder[i].Length; j++)
                {
                    switch (tableOrder[i][j])
                    {
                        case (Table)0:
                            chickCount++;
                            chicken.SubtractQuantity();
                            break;
                        case (Table)1:
                            eggCount++;
                            egg.SubtractQuantity();
                            break;
                        case (Table)2:
                            drink = "Coffee";
                            break;
                        case (Table)3:
                            drink = "Cola";
                            break;
                        case (Table)4:
                            drink = "Tea";
                            break;
                    }
                }
                s += $"Costumer {i + 1} is served: ";
                if (chickCount + eggCount == 0 && drink == "")
                    s += "1 Tasty air";
                else
                {
                    if (chickCount > 0)
                    {
                        s += $"{chickCount} Chicken";
                    }
                    if (eggCount > 0)
                    {
                        if (chickCount > 0)
                        {
                            s += ", ";
                        }
                        s += (eggCount == 1) ? $"{eggCount} Egg" : $"{eggCount} Eggs";
                    }
                    if (drink != "")
                    {
                        if (chickCount + eggCount > 0)
                        {
                            s += ", ";
                        }
                        s += drink;
                    }
                }
                s += $"\n";
            }
            if (egg.GetQuantity() == 0 && chicken.GetQuantity() == 0)
                everyThinkIsOk = true;
            tableOrder = new Table[0][];
            return s;
        }
    }
}