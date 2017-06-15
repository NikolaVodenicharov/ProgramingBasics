using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.TimePlus15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int StartHour;
            int StartMinutes;
            int IntermediateMinutes;
            int FinalHour;
            int FinalMinutes;

            //Input information
            Console.WriteLine("Please enter hour");
            StartHour = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter minutes");
            StartMinutes = int.Parse(Console.ReadLine());

            IntermediateMinutes = StartMinutes + 15;

            if (IntermediateMinutes > 59)
            {
                FinalMinutes = IntermediateMinutes - 60;
                FinalHour = StartHour + 1;
                if (FinalHour > 23)
                {
                    FinalHour = FinalHour - 24;
                }
            }
            else
            {
                FinalMinutes = IntermediateMinutes;
                FinalHour = StartHour;
            }
            Console.WriteLine("{0}:{1:D2}", FinalHour, FinalMinutes);
        }
    }
}
