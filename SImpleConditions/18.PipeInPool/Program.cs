using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.PipeInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter V, P1, P2 and H");
            var Volume = int.Parse(Console.ReadLine());
            var Pipe1 = int.Parse(Console.ReadLine());
            var Pipe2 = int.Parse(Console.ReadLine());
            double Hours = double.Parse(Console.ReadLine());
            var Water = (Pipe1 + Pipe2) * Hours;

            if (Water <= Volume)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                    Math.Truncate(Water/Volume * 100),
                    Math.Truncate(Pipe1*Hours / Water * 100),
                    Math.Truncate(Pipe2*Hours / Water * 100));
            }
            else if (Water >Volume)
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", Hours, Water - Volume);
            }
        }
    }
}
