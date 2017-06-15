using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.MrAndMs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter the age");
            double Age = double.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the gender m/f");
            string Gender = Console.ReadLine();

            if (Age >= 16)
            {
                if (Gender == "m") Console.WriteLine("Mr.");
                else if (Gender == "f") Console.WriteLine("Ms.");
            }
            else if (Age < 16)
            {
                if (Gender == "m") Console.WriteLine("Master");
                else if (Gender == "f") Console.WriteLine("Miss");
            }
        }
    }
}
