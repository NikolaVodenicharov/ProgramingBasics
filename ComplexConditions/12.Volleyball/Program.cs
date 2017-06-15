using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string YearType = Console.ReadLine(); //leap or normal
            int Holidays = int.Parse(Console.ReadLine());
            int WeekendsAtHome = int.Parse(Console.ReadLine());
            double GameNumber = 0;

            if (YearType == "normal")
            {
                GameNumber = (48 - WeekendsAtHome) * (3.0 / 4) + WeekendsAtHome + (Holidays * (2.0 / 3));
            }
            else if (YearType == "leap")
            {
                GameNumber = ((48 - WeekendsAtHome) * (3.0 / 4) + WeekendsAtHome + (Holidays * (2.0 / 3))) * 1.15;
            }
            Console.WriteLine(Math.Truncate(GameNumber));
        }
    }
}
