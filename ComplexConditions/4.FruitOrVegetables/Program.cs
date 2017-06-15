using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.FruitOrVegetables
{
    class Program
    {
        static void Main(string[] args)
        {
            string Product = Console.ReadLine();

            if (Product == "banana" || Product == "apple" || Product == "kiwi" || Product == "cherry" || Product == "lemon" || Product == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (Product == "tomato" || Product == "cucumber" || Product == "pepper" || Product == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
