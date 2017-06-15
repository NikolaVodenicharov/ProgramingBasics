using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.AreaOfRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var SideA = decimal.Parse(Console.ReadLine());
            var SideB = Convert.ToDecimal(Console.ReadLine());
            decimal AreaOfRectangle = SideA * SideB;
            Console.WriteLine(AreaOfRectangle);
        }
    }
}
