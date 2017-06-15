using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            int LeftSum = 0;
            int RightSum = 0;
            int AreTheyEquals = 0;

            for (int i = 1; i <= n; i++)
            {
                num = int.Parse(Console.ReadLine());
                LeftSum += num;
            }
            for (int i = 1; i <= n; i++)
            {
                num = int.Parse(Console.ReadLine());
                RightSum += num;
            }

            AreTheyEquals = Math.Abs(LeftSum - RightSum);

            if (AreTheyEquals == 0)
            {
                Console.WriteLine("Yes, sum = {0}", LeftSum);
            }
            else if (AreTheyEquals != 0)
            {
                Console.WriteLine("No, diff = {0}", AreTheyEquals);
            }

        }
    }
}
