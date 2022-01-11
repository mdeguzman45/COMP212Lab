using System;
using System.Collections.Generic;
using System.Linq;

namespace Marc_DeGuzman_Exercise03
{
    public class FilterMapReduceTest
    {
        public static void Main(string[] args)
        {
            // Generate random integer number
            var intList = new List<int>(10);

            Random random = new Random();
            int intNumber;
            for (int i = 0; i < 10; i++)
            {
                intNumber = random.Next(1, 100);
                // check if we already got that number
                if (!intList.Contains(intNumber))
                {
                    intList.Add(intNumber);
                }
                else
                {
                    i--;
                }
            }

            Console.Write("Original values: ");
            intList.Display(); // call Display extension method

            // values > 50 and add 10 to each values then display in sorted order
            Console.Write("\nFind all values > 50 and add 10 to each values: ");
            intList.Where(value => value > 50) // find values that are greater than 50
               .Select(value => value + 10) // then add 10 to each values
               .OrderBy(value => value) // sort the remaining values
               .Display(); // show results

        }
    }

    // declares an extension method (From FilterMapReduce Example)
    static class Extensions
    {
        // extension method that displays all elements separated by spaces
        public static void Display<T>(this IEnumerable<T> data)
        {
            Console.WriteLine(string.Join(" ", data));
        }
    }
}
