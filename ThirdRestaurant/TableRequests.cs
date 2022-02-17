using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdRestaurant
{
    class TableRequests
    {
        public IMenuItem[][] table = new IMenuItem[0][];
        public void Add(int customer, IMenuItem i)
        {
            Array.Resize(ref table, customer);
            if (table[customer - 1] == null)
                Array.Resize<IMenuItem>(ref table[customer - 1], 1);
            else
                Array.Resize<IMenuItem>(ref table[customer - 1], table[customer - 1].Length + 1);
            table[customer - 1][table[customer - 1].Length - 1] = i;
        }
        public IMenuItem[] this[IMenuItem i]
        {
            get
            {
                if (i is Chicken)
                {
                    Chicken[] chickens = new Chicken[0];
                    for (int k = 0; k < table.Length; k++)
                    {
                        for (int j = 0; j < table[k].Length; j++)
                        {
                            if (table[k][j] is Chicken)
                            {
                                Array.Resize<Chicken>(ref chickens, chickens.Length + 1);
                                chickens[chickens.Length - 1] = (Chicken)table[k][j];
                            }
                        }
                    }
                    return chickens;
                }
                else if (i is Egg)
                {
                    Egg[] eggs = new Egg[0];
                    for (int k = 0; k < table.Length; k++)
                    {
                        for (int j = 0; j < table[k].Length; j++)
                        {
                            if (table[k][j] is Egg)
                            {
                                Array.Resize<Egg>(ref eggs, eggs.Length + 1);
                                eggs[eggs.Length - 1] = (Egg)table[k][j];
                            }
                        }
                    }
                    return eggs;
                }
                else
                    return null;
            }
        }
        public CookedFood[] this[int customer]
        {
            get
            {
                CookedFood[] orders = new CookedFood[0];
                for (int i = 0; i < table[customer].Length; i++)
                {
                    Array.Resize<CookedFood>(ref orders, i+1);
                    orders[i] = (CookedFood)table[customer][i];
                }
                return orders;
            }
        }
    }
}