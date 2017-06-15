using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isPrime = true;

        if (n < 2)
        {
            Console.WriteLine("not prime");
        }
        else
        {
            for (int divisor = 2; divisor <= Math.Sqrt(n); divisor++)
            {
                if (n % divisor == 0)
                {
                    isPrime = false;
                }
            }
            Console.WriteLine(isPrime ? "prime" : "not prime");
        }
    }
}

