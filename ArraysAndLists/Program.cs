using System;
using System.Collections.Generic;
namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("\nThe numbers in the array are:");

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            var evens = new List<int>();
            var odds = new List<int>();

            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                    evens.Add(num);
                else 
                    odds.Add(num);
                
            }
            Console.WriteLine("\nEven Number List:");

            foreach (var even in evens)
            {
                Console.WriteLine(even);
            }
            
            Console.WriteLine("\nOdd Number List:");

            foreach (var n in odds)
            {
                Console.WriteLine(n);
            }
            
        }
    }
}
