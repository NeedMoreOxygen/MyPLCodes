using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myRestaurant
{
    class Employee
    {
        int copyQuantity;
        string copyItem;
        int? copyQuality;
        bool anyReq = false;
        int news = 0;
        int preps = 0;
        public object NewRequest(int quantity, string menuItem)
        {
            news++;
            preps = news - 1;
            anyReq = true;
            copyQuantity = quantity;
            copyItem = menuItem;
            if (news % 3 == 0)
            {
                if (menuItem == "Chicken")
                {
                    EggOrder egg1 = new EggOrder(quantity);
                    copyQuality = egg1.GetQuality();
                    return egg1;
                }
                else
                {
                    ChickenOrder chick1 = new ChickenOrder(quantity);
                    return chick1;
                }
            }
            else
            {
                if (menuItem == "Chicken")
                {
                    ChickenOrder chick1 = new ChickenOrder(quantity);
                    return chick1;
                }
                else
                {
                    EggOrder egg1 = new EggOrder(quantity);
                    copyQuality = egg1.GetQuality();
                    return egg1;
                }
            }
        }
        public object CopyRequest()
        {
            if (!anyReq)
            {
                throw new Exception("No Previous Requests Yet!");
            }
            else
            {
                news++;
                preps = news - 1;
                if (copyItem == "Egg")
                {
                    EggOrder eggCopy = new EggOrder(copyQuantity);
                    eggCopy.quality = copyQuality;
                    return eggCopy;
                }
                else
                {
                    ChickenOrder chickCopy = new ChickenOrder(copyQuantity);
                    return chickCopy;
                }
            }
        }
        public string Inspect(object order)
        {
            if(order is EggOrder)
            {
                return ((EggOrder)order).GetQuality().ToString();
            }
            else
            {
                return "No Inspection is Required!";
            }
        }
        public string PrepareFood(object order)
        {
            preps++;
            if (preps > news)
            {
                throw new Exception("Emplyee Can't Cook The Already Prepared Order!");
            }
            else {
                if (order is ChickenOrder)
                {
                    int i;
                    for (i = 0; i < ((ChickenOrder)order).GetQuantity(); i++)
                    {
                        ((ChickenOrder)order).CutUp();
                    }
                ((ChickenOrder)order).Cook();
                    return i + " Chicken Are Cooked!";
                }
                else
                {
                    string s = " ";
                    int i;
                    for (i = 0; i < ((EggOrder)order).GetQuantity(); i++)
                    {
                        try
                        {
                            ((EggOrder)order).Crack();
                        }
                        catch (Exception ex1)
                        {
                            s = ex1.Message;
                        }
                        ((EggOrder)order).DiscardShell();
                    }
                    ((EggOrder)order).Cook();
                    s = (s == " ")? i + " " + s + "Eggs Are Cooked!" : i + " " + s + " Eggs Are Cooked!";
                    return s;
                }
            }        }
    }
}