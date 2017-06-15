using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int num = 1;
        for (int r = 1; true; r++)
        {
            if (num <=n)
            {
                for (int c = 0; c < r; c++)
                {
                    if (num <= n)
                    {
                        Console.Write(num + " ");
                        num++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                break;
            }
            Console.WriteLine();
        }
    }
}
