using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.RectangleWithAsteriskInside
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string topOrBottom = new string('%', 2 * n);
            string percent = new string('%', 1);
            string spaceMiddle = new string(' ', 2*n - 2);
            string spaceRowWithAsterisk = new string(' ', n - 2);
            string rowMiddle = string.Format("{0}{1}{0}", percent, spaceMiddle);
            string rowMiddleWithAsterisk = string.Format($"{percent}{spaceRowWithAsterisk}**{spaceRowWithAsterisk}{percent}");


            if (n % 2 == 1)
            {
                Console.WriteLine(topOrBottom);
                for (int r = 1; r <= n; r++)
                {
                    if (r == Math.Ceiling(n / 2.0))
                    {
                        Console.Write(rowMiddleWithAsterisk);
                    }
                    else
                    {
                        Console.Write(rowMiddle);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(topOrBottom);
            }
            else if (n % 2 == 0)
            {
                Console.WriteLine(topOrBottom);
                for (int r = 1; r <= n - 1; r++)
                {
                    if (r == Math.Ceiling(n / 2.0))
                    {
                        Console.Write(rowMiddleWithAsterisk);
                    }
                    else
                    {
                        Console.Write(rowMiddle);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(topOrBottom);
            }
          
        }
    }
}
