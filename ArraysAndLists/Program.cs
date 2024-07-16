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
            var numbers = new int[10];
            for (int i = 1; i < 11; i++)
            {
             numbers[i-1] = i;
            }

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
            foreach (var n in numbers)
            {
             if (n % 2 == 0)
             {
              evens.Add(n);
              continue;
             }
             odds.Add(n);
            }


            /* Using a foreach loop,
             * display the numbers in your "evens" list
             */
            Console.WriteLine("Evens:");
            foreach (var n in evens)
            {
             Console.WriteLine(n);
            }


            /* Using a for loop,
             * display the numbers in your "odds" list
             */
            Console.WriteLine("Odds:");
            foreach (var n in odds)
            {
             Console.WriteLine(n);
            }
        }
    }
}
