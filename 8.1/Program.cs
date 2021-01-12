using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите колорийность продукта на 100г веса: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите вес продукта в граммах: ");
            double m = double.Parse(Console.ReadLine());
            Class1 class1 = new Class1(c,m);
            class1.Print();
            Console.ReadKey();
        }
    }
}
