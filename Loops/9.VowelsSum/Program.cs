using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Equals('a'))
                {
                    sum += 1;
                }
                else if (text[i].Equals('e'))
                {
                    sum += 2;
                }
                else if (text[i].Equals('i'))
                {
                    sum += 3;
                }
                else if (text[i].Equals('o'))
                {
                    sum += 4;
                }
                else if (text[i].Equals('u'))
                {
                    sum += 5;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
