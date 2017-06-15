using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Increasing4Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (b - a >= 3)
            {
                for (int n1 = a; n1 <= b; n1++)
                {
                    for (int n2 = n1; n2 <= b; n2++)
                    {
                        for (int n3 = n2; n3 <= b; n3++)
                        {
                            for (int n4 = n3; n4 <= b; n4++)
                            {
                                if (a <= n1 && n1 < n2 && n2 < n3 && n3 < n4 && n4 <= b)
                                {
                                    Console.WriteLine($"{n1} {n2} {n3} {n4}");
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
