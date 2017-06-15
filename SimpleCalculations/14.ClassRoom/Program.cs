using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adding variables
            double LongSide;
            double ShortSide;

            //Entering information with some restricts
            do
            {
                Console.WriteLine("Enter the long side");
                LongSide = double.Parse(Console.ReadLine());
                if (LongSide < 3 || LongSide > 100)
                {
                    Console.WriteLine("Invalid number, try again.");
                }
            }
            while (LongSide < 3 || LongSide > 100);

            do
            {
                Console.WriteLine("Enter the short side");
                ShortSide = double.Parse(Console.ReadLine());
                if (ShortSide < 3 || ShortSide > LongSide)
                {
                    Console.WriteLine("Invalid number, try again.");
                }
            }
            while (ShortSide < 3 || ShortSide > LongSide);
            

            //Calculations
            int NumbersOfRows = Convert.ToInt32(LongSide / 1.2);
            int NumbersOfColumns = Convert.ToInt32((ShortSide - 1) / 0.70);
            int FirstRow = NumbersOfColumns - 2;
            int MiddleRows = (NumbersOfRows - 2) * NumbersOfColumns;
            int LastRow = NumbersOfColumns - 1;
            int NumberOfDesk = FirstRow + MiddleRows + LastRow;

            //Print the answer
            Console.WriteLine("Number of desk is {0}", NumberOfDesk);
        }
    }
}
