using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string ProjectionType = Console.ReadLine(); //Premiere, Normal, Discount
            int RowsInHall = int.Parse(Console.ReadLine());
            int ColumnsInHall = int.Parse(Console.ReadLine());
            double Result = 0;

            if (ProjectionType == "Premiere")
            {
                Result = (RowsInHall * ColumnsInHall) * 12.00;
            }
            else if (ProjectionType == "Normal")
            {
                Result = (RowsInHall * ColumnsInHall) * 7.50;
            }
            else if (ProjectionType == "Discount")
            {
                Result = (RowsInHall * ColumnsInHall) * 5.00;
            }

            //Console.WriteLine("{0:f2}", Result);
            Console.WriteLine($"{Result:f2}");
        }
    }
}
