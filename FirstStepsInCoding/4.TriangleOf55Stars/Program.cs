using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.TriangleOf55Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int Rows = 1; Rows <= 10; Rows++)
            {
                for (int Columns = 1; Columns <= Rows; Columns++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            /*int AsteriskNumber = 1;
            while (AsteriskNumber <= 10)
            {
                string PrintAsterisk = new string('*', AsteriskNumber);
                Console.WriteLine(PrintAsterisk);
                AsteriskNumber = AsteriskNumber + 1;
            }*/
        }
    }
}
