using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MeasureConventor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double mVSmm = 1000;
            double mVScm = 100;
            double mVSmi = 0.000621371192;
            double mVSin = 39.3700787;
            double mVSkm = 0.001;
            double mVSft = 3.2808399;
            double mVSyd = 1.0936133;
            string CurrentMeasure;
            string TargetMeasure;
            double QuantityForConversion = 0;
            double MeasureInvertedInMeters = 0;
            double FinalSum = 0;

            //Input information
            //Console.WriteLine("Welcome to our system. You can choose between m, mm, cm, mi, in, km, ft, yd");
            //Console.WriteLine("Choose the quantity");
            QuantityForConversion = double.Parse(Console.ReadLine());
            //Console.WriteLine("Choose current measure");
            CurrentMeasure = Console.ReadLine();
            //Console.WriteLine("Choose target measure");
            TargetMeasure = Console.ReadLine();
            
            //Working
            switch (CurrentMeasure)
            {
                case "m":
                    MeasureInvertedInMeters = QuantityForConversion;
                    break;
                case "mm":
                    MeasureInvertedInMeters = QuantityForConversion / mVSmm;
                    break;
                case "cm":
                    MeasureInvertedInMeters = QuantityForConversion / mVScm;
                    break;
                case "mi":
                    MeasureInvertedInMeters = QuantityForConversion / mVSmi;
                    break;
                case "in":
                    MeasureInvertedInMeters = QuantityForConversion / mVSin;
                    break;
                case "km":
                    MeasureInvertedInMeters = QuantityForConversion / mVSkm;
                    break;
                case "ft":
                    MeasureInvertedInMeters = QuantityForConversion / mVSft;
                    break;
                case "yd":
                    MeasureInvertedInMeters = QuantityForConversion / mVSyd;
                    break;
            }

            switch (TargetMeasure)
            {
                case "m":
                    FinalSum = MeasureInvertedInMeters;
                    break;
                case "mm":
                    FinalSum = MeasureInvertedInMeters * mVSmm;
                    break;
                case "cm":
                    FinalSum = MeasureInvertedInMeters * mVScm;
                    break;
                case "mi":
                    FinalSum = MeasureInvertedInMeters * mVSmi;
                    break;
                case "in":
                    FinalSum = MeasureInvertedInMeters * mVSin;
                    break;
                case "km":
                    FinalSum = MeasureInvertedInMeters * mVSkm;
                    break;
                case "ft":
                    FinalSum = MeasureInvertedInMeters * mVSft;
                    break;
                case "yd":
                    FinalSum = MeasureInvertedInMeters * mVSyd;
                    break;
            }

            //Calculation and printing
            Console.WriteLine("{0} {1}", FinalSum, TargetMeasure);
            //Console.WriteLine("{0} {1} are {2} {3}", QuantityForConversion, CurrentMeasure, FinalSum, TargetMeasure);
        }
    }
}
