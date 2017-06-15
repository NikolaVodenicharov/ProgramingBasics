using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PointInFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int x1 = 4;
            int y1 = -5;
            int x2 = 10;
            int y2 = 3;
            int x3 = 2;
            int y3 = -3;
            int x4 = 12;
            int y4 = 1;

            if (((x >= x1 && x <= x2) && (y >= y1 && y <= y2)) ||
                ((x >= x3 && x <= x4) && (y >= y3 && y <= y4)))
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
        }
    }
}
