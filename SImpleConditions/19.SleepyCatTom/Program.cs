using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.SleepyCatTom
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int FreeDays;
            int PlayTime;
            int TimeGap;
            int Hours;
            int Minutes;

            //Console.WriteLine("Please enter the number of free days");
            FreeDays = int.Parse(Console.ReadLine());

            PlayTime = (365 - FreeDays) * 63 + FreeDays * 127;
            TimeGap = Math.Abs(30000 - PlayTime);
            Hours = TimeGap / 60;
            Minutes = TimeGap % 60;

            if (PlayTime > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", Hours, Minutes);
            }
            else if (PlayTime < 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", Hours, Minutes);

            }

        }
    }
}
