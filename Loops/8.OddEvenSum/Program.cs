using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int OddSum = 0;
            int EvenSum = 0;
            int num = 0;
            int AreTheyEquals = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    num = int.Parse(Console.ReadLine());
                    OddSum += num;
                }
                else if (i % 2 == 0)
                {
                    num = int.Parse(Console.ReadLine());
                    EvenSum += num;
                }
            }

            AreTheyEquals = Math.Abs(OddSum - EvenSum);
            if (AreTheyEquals == 0)
            {
                Console.WriteLine("Yes, sum = {0}", OddSum);
            }
            else if (AreTheyEquals != 0)
            {
                Console.WriteLine("No, diff = {0}", AreTheyEquals);
            }
        }
    }
}
