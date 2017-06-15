using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SecondsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int FirstAthlete;
            int SecondAthlete;
            int ThirdAthlete;
            int SumTimeInSec;
            int Minutes;
            int Seconds;

            //Input information
            //Console.WriteLine("Please enter the finish time of 3 athletes.");
            FirstAthlete = int.Parse(Console.ReadLine());
            SecondAthlete = int.Parse(Console.ReadLine());
            ThirdAthlete = int.Parse(Console.ReadLine());

            //Calculations and printings
            SumTimeInSec = FirstAthlete + SecondAthlete + ThirdAthlete;
            Minutes = SumTimeInSec / 60;
            Seconds = SumTimeInSec % 60;
            //Console.WriteLine("{0}:{1}", Minutes, Seconds.ToString().PadLeft(2,'0'));
            Console.WriteLine("{0}:{1:d2}", Minutes, Seconds);
        }
    }
}
