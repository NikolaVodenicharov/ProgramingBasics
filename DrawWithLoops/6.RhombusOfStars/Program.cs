using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Upper part
            for (int row = 1; row <= n; row++)
            {
                for (int i = 1; i <= (n - row); i++)
                {
                    Console.Write(" ");
                }
                for (int i = 1; i <= row; i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            
            //Down part
            }
            for (int row = 1; row <= (n-1); row++)
            {
                for (int i = 1; i <= row; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 1; i <= (n - row); i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
