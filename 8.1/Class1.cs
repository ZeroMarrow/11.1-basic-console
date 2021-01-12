using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1
{
    class Class1
    {
        private double cal;
        private double mas;

        public Class1(double cal, double mas)
        {
            this.cal = cal;
            this.mas = mas;
        }
        private double Cmass()
        {
            return mas * cal / 100;
        }
        public void Print()
        {
            Console.WriteLine("Калорийность продукта:" + Cmass());
        }
    }
}
