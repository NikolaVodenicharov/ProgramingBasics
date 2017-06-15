using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string Fruit = Console.ReadLine();
            string Day = Console.ReadLine();
            double Quantity = double.Parse(Console.ReadLine());
            double Price = -1;

            if (Day == "Monday" || Day == "Tuesday" || Day == "Wednesday" || Day == "Thursday" || Day == "Friday")
            {
                if (Fruit == "banana") Price = 2.50;
                else if (Fruit == "apple") Price = 1.20;
                else if (Fruit == "orange") Price = 0.85;
                else if (Fruit == "grapefruit") Price = 1.45;
                else if (Fruit == "kiwi") Price = 2.70;
                else if (Fruit == "pineapple") Price = 5.50;
                else if (Fruit == "grapes") Price = 3.85;
            }
            else if (Day == "Saturday" || Day == "Sunday")
            {
                if (Fruit == "banana") Price = 2.70;
                else if (Fruit == "apple") Price = 1.25;
                else if (Fruit == "orange") Price = 0.90;
                else if (Fruit == "grapefruit") Price = 1.60;
                else if (Fruit == "kiwi") Price = 3.00;
                else if (Fruit == "pineapple") Price = 5.60;
                else if (Fruit == "grapes") Price = 4.20;
            }

            if (Price >= 0)
            {
                Console.WriteLine("{0:f2}", Price * Quantity);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
