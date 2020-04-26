using System;
using System.Collections.Generic;


namespace ExceptionHandling
{


    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Pick a number.");
            //    int numberOne = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Pick a second number.");
            //    int numberTwo = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Dividing the two..");
            //    int numberThree = numberOne / numberTwo;
            //    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree + ".");
            //    Console.ReadLine();
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message); //or ("Please type a whole number")
            //    return;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Please don't divide by zero.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.ReadLine(); //log to database
            //}

            try
            { 
                List<int> numbers = new List<int>();
                numbers.Add(22);
                numbers.Add(43);
                numbers.Add(2);
                numbers.Add(67);
                numbers.Add(210);
                Console.WriteLine("Please pick a number.");
                int num = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.WriteLine(numbers[i] / num);
                }
                Console.ReadLine();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please only enter a single number.");
            }
            finally
            {
                Console.WriteLine("Good day to you!");
                Console.ReadLine();
            }
            
        }
    }
}

