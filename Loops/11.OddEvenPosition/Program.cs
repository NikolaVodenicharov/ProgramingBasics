using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double Number = 0;
            double OddSum = 0;
            double OddMin = 1000000000.0;
            double OddMax = -1000000000.0;
            double EvenSum = 0;
            double EvenMin = 1000000000.0;
            double EvenMax = -1000000000.0;

            if (n > 0)
            {
                OddMax = double.Parse(Console.ReadLine());
                OddMin = OddMax;
                OddSum += OddMax;
            }
            if (n > 1)
            {
                EvenMax = double.Parse(Console.ReadLine());
                EvenMin = EvenMax;
                EvenSum += EvenMax;
            }

            for (int i = 1; i < (n-1); i++)
            {
                if (i % 2 == 1)
                {
                    Number = double.Parse(Console.ReadLine());
                    if (OddMax < Number)
                    {
                        OddMax = Number;
                    }
                    else if (OddMin > Number)
                    {
                        OddMin = Number;
                    }
                    OddSum += Number;
                }
                else if (i % 2 == 0)
                {
                    Number = double.Parse(Console.ReadLine());
                    if (EvenMax < Number)
                    {
                        EvenMax = Number;
                    }
                    else if (EvenMin > Number)
                    {
                        EvenMin = Number;
                    }
                    EvenSum += Number;
                }
            }

            Console.WriteLine($"OddSum={OddSum}");
            if (OddMin != 1000000000.0)
            {
                Console.WriteLine($"OddMin={OddMin}");
            }
            else if (OddMin == 1000000000.0)
            {
                Console.WriteLine("OddMin=No,");
            }
            if (OddMax != -1000000000.0)
            {
                Console.WriteLine($"OddMax={OddMax}");
            }
            else if (OddMax == -1000000000.0)
            {
                Console.WriteLine("OddMax=No,");
            }
            Console.WriteLine($"EvenSum={EvenSum}");
            if (EvenMin != 1000000000.0)
            {
                Console.WriteLine($"EvenMin={EvenMin}");
            }
            else if (EvenMin == 1000000000.0)
            {
                Console.WriteLine("EvenMin=No,");
            }
            if (EvenMax != -1000000000.0)
            {
                Console.WriteLine($"EvenMax={EvenMax}");
            }
            else if (EvenMax == -1000000000.0)
            {
                Console.WriteLine("EvenMax=No,");
            }

            //Better solution !

            //double n = double.Parse(Console.ReadLine());
            //double oddSum = 0.0;
            //double evenSum = 0.0;
            //double oddMax = double.MinValue;
            //double evenMax = double.MinValue;
            //double oddMin = double.MaxValue;
            //double evenMin = double.MaxValue;

            //for (int i = 1; i <= n; i++)
            //{
            //    double num = double.Parse(Console.ReadLine());
            //    if (i % 2 == 0)
            //    {
            //        if (num > evenMax)
            //        {
            //            evenMax = num;
            //        }
            //        if (num < evenMin)
            //        {
            //            evenMin = num;
            //        }
            //        evenSum += num;

            //    }
            //    else
            //    {

            //        if (num > oddMax)
            //        {
            //            oddMax = num;
            //        }
            //        if (num < oddMin)
            //        {
            //            oddMin = num;
            //        }

            //        oddSum += num;
            //    }
            //}
            //Console.WriteLine("OddSum={0}", oddSum);


            //if (oddMin == double.MaxValue)
            //{

            //    Console.WriteLine("OddMin=No");
            //}
            //else
            //{
            //    Console.WriteLine("OddMin={0}", oddMin);
            //}
            //if (oddMax == double.MinValue)
            //{

            //    Console.WriteLine("OddMax=No");
            //}
            //else
            //{
            //    Console.WriteLine("OddMax={0}", oddMax);
            //}
            //Console.WriteLine("EvenSum={0}", evenSum);
            //if (evenMin == double.MaxValue)
            //{

            //    Console.WriteLine("EvenMin=No");
            //}
            //else
            //{
            //    Console.WriteLine("EvenMin={0}", evenMin);
            //}
            //if (evenMax == double.MinValue)
            //{

            //    Console.WriteLine("EvenMax=No");
            //}
            //else
            //{
            //    Console.WriteLine("EvenMax={0}", evenMax);
            //}


        }
    }
}
