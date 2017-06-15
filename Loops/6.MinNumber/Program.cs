using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            int Min = 0;

            Min = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i += 1)
            {
                num = int.Parse(Console.ReadLine());
                if (Min > num)
                {
                    Min = num;
                }
            }
            Console.WriteLine(Min);
        }
    }
}
