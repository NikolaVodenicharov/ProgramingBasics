using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    num = r + c + 1;
                    if (num <= n)
                    {
                        Console.Write(num + " ");
                    }
                    else
                    {
                        Console.Write(2 * n - num + " ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
