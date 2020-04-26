using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static public event Action Posted;

        static void Main(string[] args)
        {

            //First project (if statement) -----------------------------------------------------------
            var stats = new Stats();
            stats.Start();

            var data = new Data();

            Console.WriteLine("What is your name?");
            data.Name = TryAnswer();

            Console.WriteLine("How old are you?");
            data.Age = int.Parse(TryAnswer());

            Console.WriteLine("What month were you born in?");
            data.Month = TryAnswer();

            if (Posted != null)
            {
                Posted();
            }

            data.Display();

            //Second Project (while loop) ------------------------------------------------

            //var password = "";

            //while (password != "secret")
            //{
            //    Console.WriteLine("Please enter your password:");
            //    password = Console.ReadLine();

            //    if (password != "secret")
            //    {
            //        Console.WriteLine("That password is not recognized.");
            //    }
            //}

            //Console.WriteLine("Thank you for logging in.");


            //Third Project (for loop) --------------------------------------------------

            //for (int j = 1; j <= 5; j++)
            //{
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        Console.WriteLine(i);
            //    }

            //    for (int i = 10; i >= 1; i--)
            //    {
            //        Console.WriteLine(i);
            //    }
            //} 

            //Fourth Project(arrays)  ---------------------------------------------------------

            //Switch is best when an if statement has many options ---------------------

            //Console.WriteLine("How many years of experience do you have?");
            //var years = int.Parse(Console.ReadLine());

            //switch(years)
            //{
            //    case 0:
            //        Console.WriteLine("Inexpereinced.");
            //        break;
            //    case 1:
            //        Console.WriteLine("Junior.");
            //        break;
            //    case 2:
            //        Console.WriteLine("Intermediate.");
            //        break;
            //    case 3:
            //        Console.WriteLine("Advanced.");
            //        break;
            //    default:
            //        Console.WriteLine("Senior.");
            //        break;


            //}
        }

        static string TryAnswer()
        {
            var answer = Console.ReadLine();
            if (answer == "")
            {
                Console.WriteLine("You didn't type anything, please try again:");
                return Console.ReadLine();
            }
            return answer;
        }

    }        
    class Data
    {
        public string Name;
        public int Age;
        public string Month;

        public void Display()
        {
            Console.WriteLine("Your name is: {0}.", Name);
            Console.WriteLine("You are {0} years old.", Age);
            Console.WriteLine("You were born in {0}.", Month);

            switch(Month)
            {
                case "march":
                    Console.WriteLine("You are an Aries.");
                    break;
                case "april":
                    Console.WriteLine("You are a Taurus.");
                    break;
                case "may":
                    Console.WriteLine("You are a Gemini.");
                    break;
            }

        }

    }
}
