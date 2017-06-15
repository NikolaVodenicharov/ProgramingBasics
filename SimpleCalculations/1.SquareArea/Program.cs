using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please write the side of square, a = ");
            int SideOfSquare = Convert.ToInt32(Console.ReadLine());
            int AreaOfSquare = SideOfSquare * SideOfSquare;
            Console.WriteLine("Square area is {0}", AreaOfSquare);
        }
    }
}
