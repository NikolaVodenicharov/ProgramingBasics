using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ConcatenateDate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter your first name: ");
            string FirstName = Console.ReadLine();
            //Console.WriteLine("Please enter your last name: ");
            string LastName = Console.ReadLine();
            //Console.WriteLine("Please enter your age: ");
            var Age = Console.ReadLine();
            //Console.WriteLine("Please enter your town: ");
            string Town = Console.ReadLine();
            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", FirstName, LastName, Age, Town);
        }
    }
}
