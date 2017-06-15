using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two integers.");
            int FirstNumber = int.Parse(Console.ReadLine());
            int SecondNumber = int.Parse(Console.ReadLine());

            if (FirstNumber > SecondNumber)
            {
                Console.WriteLine("The greater number is {0}", FirstNumber);
            }
            else
            {
                Console.WriteLine("The greater number is {0}", SecondNumber);
            }
        }
    }
}
