using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.SameWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please write two words");
            string FirstWord = Console.ReadLine().ToLower();
            string SecondWord = Console.ReadLine().ToLower();

            if (FirstWord == SecondWord)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
