using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdRestaurant
{
    class Cook
    {
        static Random r = new Random();
        public int quality { get; private set; }
        public void Process(TableRequests table)
        {
            IMenuItem[] chickenRequest = table[new Chicken()];
            
            foreach (Chicken chicken in chickenRequest)
            {
                chicken.Obtain();
                chicken.CutUp();
                chicken.Cook();
            }
            IMenuItem[] eggRequest = table[new Egg()];
            if (eggRequest.Length > 0)
            {
                Egg checkEgg = (Egg)eggRequest[0];
                checkEgg.quality = r.Next(0, 100);
                quality = checkEgg.quality;
                foreach (Egg egg in eggRequest)
                {
                    egg.quality = quality;
                    egg.Obtain();
                    try
                    {
                        egg.Crack();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    finally
                    {
                        egg.DiscardShell();
                    }
                    egg.Cook();
                }
            }
        }
    }
}
