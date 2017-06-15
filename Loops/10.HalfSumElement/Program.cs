using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {

            double n = double.Parse(Console.ReadLine());
            double num = 0;
            double sum = 0;
            double max = 0;
            

            max = double.Parse(Console.ReadLine());
            sum += max;
            for (int i = 1; i < n; i += 1)
            {
                num = int.Parse(Console.ReadLine());
                if (max < num)
                {
                    max = num;
                }
                sum += num;
            }

            if (sum/2 == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", max);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs((sum - max) - max));
            }
        }
    }
}
