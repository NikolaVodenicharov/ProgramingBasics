using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DateAfter5Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int day;
            int month;

            if (m == 2)
            {
                if (d + 5 > 28)
                {
                    day = (d + 5) - 28;
                    month = m + 1;
                }
                else
                {
                    day = d + 5;
                    month = m;
                }
            }
            else if (m == 4 || m == 6 || m == 9 || m == 11)
            {
                if (d + 5 > 30)
                {
                    day = (d + 5) - 30;
                    month = m + 1;
                }
                else
                {
                    day = d + 5;
                    month = m;
                }
            }
            else if (m == 12)
            {
                if (d + 5 > 31)
                {
                    day = (d + 5) - 31;
                    month = m -11;
                }
                else
                {
                    day = d + 5;
                    month = m;
                }
            }
            else
            {
                if (d + 5 > 31)
                {
                    day = (d + 5) - 31;
                    month = m + 1;
                }
                else
                {
                    day = d + 5;
                    month = m;
                }
            }
            Console.WriteLine("{0}.{1:d2}", day, month);
        }
    }
}
