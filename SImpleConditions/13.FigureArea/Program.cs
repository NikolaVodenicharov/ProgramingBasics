using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.FigureArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string Figure;
            double FigureArea = 0;

            Console.WriteLine("Please enter the type of the figure. You can choose between - square, rectangle, circle and triangle");
            Figure = Console.ReadLine();

            if (Figure == "square")
            {
                Console.WriteLine("Please enter the side of square: ");
                double SquareSide = double.Parse(Console.ReadLine().ToLower());
                FigureArea = Math.Pow(SquareSide, 2);
            }
            else if (Figure == "rectangle")
            {
                Console.WriteLine("Please enter the sides of the rectangle");
                double SideA = double.Parse(Console.ReadLine().ToLower());
                double SideB = double.Parse(Console.ReadLine().ToLower());
                FigureArea = SideA * SideB;
            }
            else if (Figure == "circle")
            {
                Console.WriteLine("Please enter the radius of the circle");
                double Radius = double.Parse(Console.ReadLine().ToLower());
                FigureArea = Math.PI * (Math.Pow(Radius, 2));
            }
            else if (Figure == "triangle")
            {
                Console.WriteLine("Please enter the side of the triangle \"a\"");
                double a = double.Parse(Console.ReadLine().ToLower());
                Console.WriteLine("Please enter the high of the thiange \"h\"");
                double h = double.Parse(Console.ReadLine().ToLower());
                FigureArea = (a * h) / 2;
            }

            Console.WriteLine("Thea are of the figure is {0:F3}", FigureArea);
        }
    }
}
