using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.GenerateRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            if (4 * n * n < m)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int left = -n; left <= n; left++)
                {
                    for (int top = -n; top <= n; top++)
                    {
                        for (int right = left + 1; right <= n; right++)
                        {
                            for (int bottom = top + 1; bottom <= n; bottom++)
                            {
                                double area = (right - left) * (bottom - top);
                                if (area >= m)
                                {
                                    Console.WriteLine($"({left}, {top}) ({right}, {bottom}) -> {area}");
                                }
                            }
                        }
                    }
                }
            }



            //pri vhod 1 2 purvo izliza redut s area = 4, a trqbva da izlezne kato treti red, za tova mi dava 80 to4ki...

            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());

            //int x1 = n * (-1); //left
            //int y1 = n * (-1); //top
            //int x2 = n; //right
            //int y2 = n; //bottom

            //if ((x2 - x1) * (y2 - y1) < m)
            //{
            //    Console.WriteLine("No");
            //}
            //else
            //{
            //    for (int i1 = x1; i1 < x2; i1++)
            //    {
            //        for (int j1 = y1; j1 < y2; j1++)
            //        {
            //            for (int i2 = x2; i2 > x1; i2--)
            //            {
            //                for (int j2 = y2; j2 > y1; j2--)
            //                {
            //                    double area = (i2 - i1) * (j2 - j1);
            //                    if (area >= m)
            //                    {
            //                        Console.WriteLine($"({i1}, {j1}) ({i2}, {j2}) -> {area}");
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
        }
    }
}
