﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Program
    {
        public static string title = "C# Essential Training";
        public static int whichPart { get; set; }

        static void Main(string[] args)
        {
            whichPart = 2;
            var message = string.Format("Welcome to {0} Part {1}!", title, whichPart);
            Console.WriteLine(message);
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }
    }
}
