using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MultucurrencyConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our system! You can choose currency for calculation between BGN, USD, EUR and GBP");

            string Continue; //all variables
            string CurrentCurrency;
            string TargetCurrency;
            double MoneyAmount;
            double BGNtoUSD = 1.79549;
            double BGNtoEUR = 1.95583;
            double BGNtoGBP = 2.53405;
            double MoneyInvertedInBGN = 0;
            double FinalSum = 0;

            do
            {
                do
                {
                    Console.WriteLine("Please enter the current currency for conversion.");
                    CurrentCurrency = Console.ReadLine().ToUpper();
                    if (CurrentCurrency != "BGN" && CurrentCurrency != "EUR" && CurrentCurrency != "USD" && CurrentCurrency != "GBP")
                    {
                        Console.WriteLine("Invalid choose, please try again.");
                    }
                }
                while (CurrentCurrency != "BGN" && CurrentCurrency != "EUR" && CurrentCurrency != "USD" && CurrentCurrency != "GBP"); //AntiCrash

                do
                {
                    Console.WriteLine("Please enter your target currency.");
                    TargetCurrency = Console.ReadLine().ToUpper();
                    if (TargetCurrency != "BGN" && TargetCurrency != "EUR" && TargetCurrency != "USD" && TargetCurrency != "GBP")
                    {
                        Console.WriteLine("Invalid choose, please try again.");
                    }
                }
                while(TargetCurrency != "BGN" && TargetCurrency != "EUR" && TargetCurrency != "USD" && TargetCurrency != "GBP"); //AntiCrash

                Console.WriteLine("Please enter the amount of money for conversion: ");
                MoneyAmount = Convert.ToDouble(Console.ReadLine());

                switch (CurrentCurrency)
                {
                    case "USD":
                        MoneyInvertedInBGN = MoneyAmount * BGNtoUSD;
                        break;
                    case "EUR":
                        MoneyInvertedInBGN = MoneyAmount * BGNtoEUR;
                        break;
                    case "GBP":
                        MoneyInvertedInBGN = MoneyAmount * BGNtoGBP;
                        break;
                    case "BGN":
                        MoneyInvertedInBGN = MoneyAmount;
                        break;
                }

                switch (TargetCurrency)
                {
                    case "USD":
                        FinalSum = MoneyInvertedInBGN / BGNtoUSD;
                        break;
                    case "EUR":
                        FinalSum = MoneyInvertedInBGN / BGNtoEUR;
                        break;
                    case "GBP":
                        FinalSum = MoneyInvertedInBGN / BGNtoGBP;
                        break;
                    case "BGN":
                        FinalSum = MoneyInvertedInBGN;
                        break;
                }
                Console.WriteLine("Thank you. {0} {1} are {2} {3}", MoneyAmount, CurrentCurrency, Math.Round(FinalSum, 2), TargetCurrency);

                do
                {
                    Console.WriteLine("Do you want to continue - YES or NO");
                    Continue = Console.ReadLine().ToUpper();
                    if (Continue != "YES" && Continue != "NO")
                    {
                        Console.WriteLine("Your answer is invalid, please try again.");
                    }
                }
                while (Continue != "YES" && Continue != "NO"); //AntiCrash

            }
            while (Continue != "NO");

            Console.WriteLine("Thank you for using our system. Have a nice day!");
        }
    }
}
