using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.SquareOfAsterisks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter the side of the Square");
            int SideOfSquare = Convert.ToInt32(Console.ReadLine());
            int Row;
            int Column;

            for (Row = 1; Row <= SideOfSquare; Row++)
            {
                if (Row == 1 || Row == SideOfSquare)
                {
                    for (Column = 1; Column <= SideOfSquare; Column++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                else
                {
                    for (Column = 1; Column <= SideOfSquare; Column++)
                    {
                        if (Column == 1 || Column == SideOfSquare)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
