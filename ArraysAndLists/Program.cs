using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> evens = new List<int>();

           List<int> odds = new List<int>();

         foreach(var num in  myArray)
            {
                if(num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }


            Console.WriteLine("Even numbers:");
            foreach(var evenNum in evens)
            {
                Console.WriteLine(evenNum);
            }
            Console.WriteLine("");
            Console.WriteLine("-----");
            Console.WriteLine("");
            Console.WriteLine("Odd numbers:");
            foreach(var oddNum in odds)
            {
                Console.WriteLine(oddNum);
            }
            
        }
    }
}
