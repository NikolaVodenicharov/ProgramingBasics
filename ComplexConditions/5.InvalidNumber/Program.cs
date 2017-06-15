using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = int.Parse(Console.ReadLine());
            if (Number != 0 && Number < 100 || Number > 200)
            {
                Console.WriteLine("Invalid");
            }

        }
    }
}
