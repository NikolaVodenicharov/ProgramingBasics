using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.PointInTheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int x1 = 0;
            int y1 = 0;
            int x2 = h * 3;
            int y2 = h * 1;
            int x3 = h * 1;
            int y3 = h * 1;
            int x4 = h * 2;
            int y4 = h * 4;

            if (((x > x1 && x < x2) && (y > y1 && y < y2)) || 
                ((x > x3 && x < x4) && (y > y3 && y < y4)) || 
                ((x > x3 && x < x4) && (y == y3)))
            {
                Console.WriteLine("inside");
            }
            else if (((x < x1 || x > x2) || (y < y1 || y > y2)) && 
                     ((x < x3 || x > x4) || (y < y3 || y > y4)))
            {
                Console.WriteLine("outside");
            }
            else 
            {
                Console.WriteLine("border");
            }
        }
    }
}
