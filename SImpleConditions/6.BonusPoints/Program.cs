using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int Score;
            double BasicBonus = 0;
            double AdditionalBonus = 0;
            double TotalBonus;
            double TotalScore;

            //input information
            //Console.WriteLine("Enter the score.");
            Score = int.Parse(Console.ReadLine());

            //basic bonus score
            if (Score <= 100)
            {
                BasicBonus = 5;
            }
            else if (Score <= 1000)
            {
                BasicBonus = Score * 0.20;
            }
            else if (Score > 1000)
            {
                BasicBonus = Score * 0.10;
            }

            //Additional bonus score
            if ((Score % 2) == 0)
            {
                AdditionalBonus = 1;
            }
            else if (Score % 10 == 5)
            {
                AdditionalBonus = 2;
            }

            //Calculations and printings
            TotalBonus = BasicBonus + AdditionalBonus;
            TotalScore = Score + TotalBonus;
            Console.WriteLine("Bonus score: {0}", TotalBonus);
            Console.WriteLine("Total score: {0}", TotalScore);


            //Console.WriteLine("Total score: {0}", (int)TotalScore);
            //Console.WriteLine("Total score: {0}", Math.Round(TotalScore, 2));
            //Console.WriteLine("Total score: {0}", TotalScore);
            //Console.WriteLine("Total score: {0}", Math.Floor(TotalScore));
            //Console.WriteLine("Total score: {0}", Math.Ceiling(TotalScore));
        }
    }
}
