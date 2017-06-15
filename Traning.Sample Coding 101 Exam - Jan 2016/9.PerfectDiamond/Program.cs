using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.PerfectDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int r = 1; r <= n; r++)
            {
                string space = new string(' ', n-r);
                Console.Write(space);
                Console.Write("*");
                for (int i = 1; i < r; i++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }
            for (int r = 1; r < n; r++)
            {
                string space = new string(' ', r);
                Console.Write(space);
                Console.Write("*");
                for (int i = 1; i < n-r; i++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }
        }
    }
}
