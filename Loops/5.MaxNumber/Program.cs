using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            int Max = 0;

            Max = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i += 1)
            {
                num = int.Parse(Console.ReadLine());
                if (Max < num)
                {
                    Max = num;
                }
            }
            Console.WriteLine(Max);
        }
    }
}
