using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.NumberOutOfRange_Error
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.Write("Enter a number in the range [1...100]: ");
                num = int.Parse(Console.ReadLine());
                if (num >= 1 && num <= 100)
                {
                    Console.WriteLine($"The number is: {num}");
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            } while (num < 1 || num > 100);
        }
    }
}
