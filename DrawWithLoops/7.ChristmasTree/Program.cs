using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int r = 0; r <= n; r++)
            {
                for (int i = 0; i < (n - r); i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < r; i++)
                {
                    Console.Write("*");
                }
                Console.Write(" | ");
                for (int i = 0; i < r; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
