﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ExcellentOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter your evaluation: ");
            double Evaluation = double.Parse(Console.ReadLine());
            if (Evaluation >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
