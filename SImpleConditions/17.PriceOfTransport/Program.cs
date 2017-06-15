using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.PriceOfTransport
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double TaxiCost = 0;
            double BusCost = 0;
            double TrainCost = 0;
            string DayNight;
            int Distance;

            //Input information
            Console.WriteLine("Please enter the distance");
            Distance = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Day/Night");
            DayNight = Console.ReadLine();

            //Calculaton
            if (Distance < 20)
            {
                if (DayNight == "day")
                {
                    TaxiCost = 0.70 + (Distance * 0.79);
                }
                else if (DayNight == "night")
                {
                    TaxiCost = 0.70 + (Distance * 0.90);
                }
                Console.WriteLine(TaxiCost);
            }
            else if (Distance >= 20 && Distance < 100)
            {
                BusCost = Distance * 0.09;
                if (DayNight == "day")
                {
                    TaxiCost = 0.70 + (Distance * 0.79);
                }
                else if (DayNight == "night")
                {
                    TaxiCost = 0.70 + (Distance * 0.90);
                }

                if (BusCost < TaxiCost)
                {
                    Console.WriteLine(BusCost);
                }
                else if (BusCost > TaxiCost)
                {
                    Console.WriteLine(TaxiCost);
                }
            }
            else if (Distance >= 100)
            {
                TrainCost = Distance * 0.06;
                BusCost = Distance * 0.09;
                if (DayNight == "day")
                {
                    TaxiCost = 0.70 + (Distance * 0.79);
                }
                else if (DayNight == "night")
                {
                    TaxiCost = 0.70 + (Distance * 0.90);
                }

                if (TrainCost < BusCost && BusCost < TaxiCost)
                {
                    Console.WriteLine(TrainCost);
                }
                else if (TrainCost > BusCost && BusCost < TaxiCost)
                {
                    Console.WriteLine(BusCost);
                }
                else if (TrainCost > BusCost && BusCost > TaxiCost)
                {
                    Console.WriteLine(TaxiCost);
                }
            }
        }
    }
}
