using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PointOnLine
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());

            if (first > second)
            {
                if ((point < first && point > second) || (point == first) || (point == second))
                {
                    Console.WriteLine("in");
                }
                else
                {
                    Console.WriteLine("out");
                }
                Console.WriteLine(Math.Min(Math.Abs(first - point), Math.Abs(second - point)));
            }
            else if (first < second)
            {
                if ((point > first && point < second) || (point == first) || (point == second))
                {
                    Console.WriteLine("in");
                }
                else
                {
                    Console.WriteLine("out");
                }
                Console.WriteLine(Math.Min(Math.Abs(first - point), Math.Abs(second - point)));
            }

        }
    }
}
