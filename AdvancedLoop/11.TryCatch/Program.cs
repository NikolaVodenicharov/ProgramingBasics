using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int evenNum;
            do
            {
                Console.Write("Enter even number: ");
                try
                {
                    evenNum = int.Parse(Console.ReadLine());
                    if (evenNum % 2 == 0)
                    {
                        Console.WriteLine($"Even number entered: {evenNum}");
                    }
                    else if (evenNum % 2 == 1)
                    {
                        Console.WriteLine("The number is not even.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number!");
                    evenNum = -1;
                }
            } while (evenNum % 2 != 0);


        }
    }
}
