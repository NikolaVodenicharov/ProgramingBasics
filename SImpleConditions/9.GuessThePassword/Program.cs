﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.GuessThePassword
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter the password");
            string Password = Console.ReadLine();
            
            if (Password == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
