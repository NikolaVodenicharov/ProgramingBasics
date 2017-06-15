using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.VegetablesMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double VegetablesPrice;
            double FruitsPrice;
            double VegetablesQuantity;
            double FruitsQuantity;
            double BGNtoEUR = 1.94;
            double TotalRevenuesInEUR;
            double Restriction0 = 0;
            double Restriction1000 = 1000;

            //input information with restrictions
            do
            {
                Console.WriteLine("Enter the price of vegetables.");
                VegetablesPrice = Convert.ToDouble(Console.ReadLine());
            }
            while (VegetablesPrice < Restriction0 || VegetablesPrice > Restriction1000);
            do
            {
                Console.WriteLine("Enter the price of fruits.");
                FruitsPrice = Convert.ToDouble(Console.ReadLine());
            }
            while (FruitsPrice < Restriction0 || FruitsPrice > Restriction1000);
            do
            {
                Console.WriteLine("Enter the quantity of vegetables.");
                VegetablesQuantity = Convert.ToDouble(Console.ReadLine());
            }
            while (VegetablesQuantity < Restriction0 || VegetablesQuantity > Restriction1000);
            do
            {
                Console.WriteLine("Enter the quantity of fruits.");
                FruitsQuantity = Convert.ToDouble(Console.ReadLine());
            }
            while (FruitsQuantity < Restriction0 || FruitsQuantity > Restriction1000);

            //Calculation and priting
            TotalRevenuesInEUR = ((VegetablesPrice * VegetablesQuantity) + (FruitsPrice * FruitsQuantity)) / BGNtoEUR;
            Console.WriteLine("The total revenues in euro are: {0}", Math.Round(TotalRevenuesInEUR, 2));
        }
    }
}
