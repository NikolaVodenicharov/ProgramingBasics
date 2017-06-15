using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string Town = Console.ReadLine();
            double Sells = double.Parse(Console.ReadLine());
            double Comission = -1;

            if (Town == "Sofia")
            {
                if (Sells >= 0 && Sells <= 500)
                {
                    Comission = Sells * 0.05;
                }
                else if (Sells > 500 && Sells <= 1000)
                {
                    Comission = Sells * 0.07;
                }
                else if (Sells > 1000 && Sells <= 10000)
                {
                    Comission = Sells * 0.08;
                }
                else if (Sells > 10000)
                {
                    Comission = Sells * 0.12;
                }
            }
            else if (Town == "Varna")
            {
                if (Sells >= 0 && Sells <= 500)
                {
                    Comission = Sells * 0.045;
                }
                else if (Sells > 500 && Sells <= 1000)
                {
                    Comission = Sells * 0.075;
                }
                else if (Sells > 1000 && Sells <= 10000)
                {
                    Comission = Sells * 0.10;
                }
                else if (Sells > 10000)
                {
                    Comission = Sells * 0.13;
                }
            }
            else if (Town == "Plovdiv")
            {
                if (Sells >= 0 && Sells <= 500)
                {
                    Comission = Sells * 0.055;
                }
                else if (Sells > 500 && Sells <= 1000)
                {
                    Comission = Sells * 0.08;
                }
                else if (Sells > 1000 && Sells <= 10000)
                {
                    Comission = Sells * 0.12;
                }
                else if (Sells > 10000)
                {
                    Comission = Sells * 0.145;
                }
            }

            if (Comission >= 0)
            {
                Console.WriteLine("{0:f2}", Comission);
            }
            else if (Comission < 0)
            {
                Console.WriteLine("error");
            }
            
        }
    }
}
