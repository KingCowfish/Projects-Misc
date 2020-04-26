using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Question
    {
        static public string Query(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
    }
}
