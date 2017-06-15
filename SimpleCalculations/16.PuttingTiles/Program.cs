using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.PuttingTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double SquareSide;
            double TilesWidth;
            double TilesLenght;
            double TilesSize;
            double TilesNumber;
            double BenchWidth;
            double BenchLenght;
            double LandingArea;
            double PuttingTileTime = 0.2;
            double PuttingTIleTotalTime;

            //Input information
            Console.WriteLine("Please enter the side of squar");
            SquareSide = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the width of tiles");
            TilesWidth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the lenght of tiles");
            TilesLenght = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the width of bench");
            BenchWidth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the lenght of becnh");
            BenchLenght = Convert.ToDouble(Console.ReadLine());

            //Caolculations and printing
            LandingArea = (Math.Pow(SquareSide, 2) - (BenchLenght * BenchWidth));
            TilesSize = TilesWidth * TilesLenght;
            TilesNumber = LandingArea / TilesSize;
            PuttingTIleTotalTime = TilesNumber * PuttingTileTime;
            Console.WriteLine("The nessesery number of tiles is {0} for {1} time.", TilesNumber, PuttingTIleTotalTime);


        }
    }
}
