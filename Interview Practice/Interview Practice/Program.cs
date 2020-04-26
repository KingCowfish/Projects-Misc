using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add all odd numbers of an array.

            //int[] p = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int j = 0;
            //for (int i = 0; i < 9; i++)
            //{
            //    if (p[i] % 2 == 1)
            //    {
            //        j += p[i];
            //    }
            //}
            //Console.WriteLine(j);

            // Add all numbers in an array.

            //int[] v = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int r = 0;
            //for (int i = 0; i < v.Length; i++)
            //{
            //    r += v[i];
            //}
            //Console.WriteLine(r);

            // Reverse the order of a string.

            //string f = ".xob a ni stnaP";
            //char[] arr = f.ToCharArray();
            //Array.Reverse(arr);
            //string g = "";
            //foreach (char b in arr)
            //{
            //    g += b;
            //}
            //Console.WriteLine(g);

            //Fizz Buzz

            //int k = 0;
            //while (k < 31)
            //{
            //    k += 1;
            //    if (k%3 == 0 && k%5 != 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (k%5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(k);
            //    }
            //}

            // Prime Numbers.

            //for (int x = 2; x < 101; x++)
            //{
            //    int isPrime = 0;
            //    for (int y = 1; y < x; y++)
            //    {
            //        if (x % y == 0)
            //            isPrime++;

            //        if (isPrime == 2) break;
            //    }
            //    if (isPrime != 2)
            //        Console.WriteLine(x);

            //    isPrime = 0;
            //}

            // Fibonacci Sequence

            //int a = 0;
            //int b = 1;
            //int n = 10;
            //for (int i = 0; i < n; i++)
            //{
            //    int temp = a;
            //    a = b;
            //    b = temp + b;
            //    Console.WriteLine(a);
            //}

            int[] arr = new int[] { 9, 8, 7, 6, 5, 4, 3 };
            int h = 0;
            int j = 0;
            int tmp = 0;
            for (h = 0; h < arr.Length-1; h++)
            {
                for (j = 0; j<arr.Length-1; j++)
                {
                    if (arr[j+1]<arr[j])
                    {
                        tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }
            }
            Console.WriteLine(arr);
            Console.ReadLine();
        }
    }
}
