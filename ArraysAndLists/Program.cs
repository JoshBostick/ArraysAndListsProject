using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int array and populate it with numbers 1-10
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create a list of type int
             * Name the list "evens"
             */
            var evens = new List<int>();
            
            /* Create another list of type int
             * Name the list "odds"
             */
             var odds = new List<int>();

             /* Using either a foreach or for loop,
             * iterate through the array you populated with 10 numbers.
             * Inside the scope of the loop,
             * check to see if each number in the array is even or odd.
             * If the number is even, add it to the evens list.
             * If the number is odd, add it to the odds list.
             */
             foreach (var num in numbers)
             {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
             }


            /* Using a foreach loop,
             * display the numbers in your "evens" list
             */
            foreach (var evenNumber in evens)
            {
                Console.WriteLine($"{evenNumber} is even");
            }
                        /* Using a for loop,
             * display the numbers in your "odds" list
             */
            foreach (var oddNumber in odds)
            {
                Console.WriteLine($"{oddNumber} is odd");
            }
        }
    }
}
