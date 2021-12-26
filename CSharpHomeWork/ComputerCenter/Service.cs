using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerCenter
{
    class Service
    {
        static Random r = new Random();
        static int papersAmount = r.Next(0, 100);
        int amount = 0;
        int paintLevel;
        Document newDoc;
        string s;

        public Service(int amount, int lB, int rB, int uB, int dB)
        {
            Document newDoc = new Document(lB, rB, uB, dB);
            this.amount = amount;
            this.paintLevel = r.Next(0, 5);
        }
        public Service(int amount)
        {
            Document newDoc = new Document();
            this.amount = amount;
            this.paintLevel = r.Next(0, 5);
        }
        public void Inspect() { }

        public bool AmountCheck()
        {
            bool isCompatible;
            isCompatible = (amount > 20) ? false : true;
            return isCompatible;
        }
        public bool IsEnoughPaper()
        {
            bool isEnough;
            isEnough = (amount > papersAmount) ? false : true;
            papersAmount -= amount;
            return isEnough;
        }
        public string PaintLevelCheck()
        {
            if (paintLevel < 3)
            {
                throw new Exception("The Level Of Paint Is Awful!");
            }
            else
                return "The Level Of Paint Is OK!";
        }
        public string Raspechatka()
        {
            for (int i = 0; i <= amount; i++)
            {
                Inspect();
            }
            Machine newPrint = new Machine(newDoc);
            s = (AmountCheck() == false) ? "The Employee Can\'t Work With So Many Papers!" : (IsEnoughPaper() == false) ? "The Service Has Not Enough Paper To Print!" : newPrint.Print();
            return s;
        }
        public string Copy()
        {
            Machine newPrint = new Machine(newDoc);
            for (int i = 0; i <= amount; i++)
            {
                newPrint.Copy();
            }
            s = (IsEnoughPaper() == false)? "The Service Has Not Enough Paper To Print!" : "Copied!";
            return s;
        }
    }
}
