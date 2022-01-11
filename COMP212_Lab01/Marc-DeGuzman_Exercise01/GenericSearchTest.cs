    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marc_DeGuzman_Exercise01
{
    public class GenericSearchTest
    {
        static void Main(string[] args)
        {
            // Generate random integer number
            int[] intArray = new int[10];
            Random random = new Random();
            int intNumber;
            for (int i = 0; i < 10; i++)
            {
                intNumber = random.Next(1, 500);
                // check if we already got that number
                if (!intArray.Contains(intNumber))
                {
                    intArray[i] = intNumber;
                }
                else
                {
                    i--;
                }
            }
                        
            String generatedInt = "[";
            for (int i = 0; i < intArray.Length; i++)
            {
                generatedInt += $"{intArray[i]} ";
            }

            generatedInt += "]";

            Console.WriteLine($"Generated integer numbers: {generatedInt}");

            Console.WriteLine("Enter integer item to search:");
            String integerInput = Console.ReadLine();
            int parsedIntegerInput;

            // handle invalid integer
            while (!int.TryParse(integerInput, out parsedIntegerInput))
            {
                Console.WriteLine("Please enter a valid integer!");
                integerInput = Console.ReadLine();
            }

            Console.WriteLine($"Position of search value {parsedIntegerInput}: {search(intArray, parsedIntegerInput)}");

            // Generate Double numbers
            double[] doubleArray = new double[10];
            double doubleNumber;

            for (int i = 0; i < 10; i++)
            {
                doubleNumber = random.NextDouble(1.00, 500.00);
                // check if we already got that number
                if (!doubleArray.Contains(doubleNumber))
                {
                    doubleArray[i] = doubleNumber;
                }
                else
                {
                    i--;
                }
            }

            String generatedDouble = "[";
            for (int i = 0; i < doubleArray.Length; i++)
            {
                generatedDouble += $"{doubleArray[i]} ";
            }

            generatedDouble += "]";

            Console.WriteLine($"Generated double numbers: {generatedDouble}");

            Console.WriteLine("Enter double item to search:");
            String doubleInput = Console.ReadLine();
            double parsedDoubleInput;

            // handle invalid integer
            while (!double.TryParse(doubleInput, out parsedDoubleInput))
            {
                Console.WriteLine("Please enter a valid double!");
                doubleInput = Console.ReadLine();
            }

            Console.WriteLine($"Location of search value {parsedDoubleInput}: {search(doubleArray, parsedDoubleInput)}");

            String[] stringArray = { "apple", "mango", "peach", "grapes", "watermelon", "melon", "blueberry", "strawberry", "pineapple", "banana" };
            String generatedString = "[";
            for (int i = 0; i < stringArray.Length; i++)
            {
                generatedString += $"{stringArray[i]} ";
            }
            generatedString += "]";
            Console.WriteLine($"Generated strings: {generatedString}");
            Console.WriteLine("Please enter a string value:");
            String stringInput = Console.ReadLine();
            Console.WriteLine($"Location of search value {stringInput}: {search(stringArray, stringInput)}");

        } // end main

        private static int search<T>(T[] dataArray, T searchKey)
            where T : IComparable<T>
        {
            // default to -1 so that we can determine the search is successful when it becomes a positive value
            int arrayPosition = -1;
            for (int x = 0; x < dataArray.Length; x++)
            {
                T arrayElement = dataArray[x];
                // Console.WriteLine($"CompareTo result: {searchValue.CompareTo(arrayElement)}");
                if (searchKey.CompareTo(arrayElement) == 0)
                {
                    // value is found
                    arrayPosition = x;
                    break;
                }
            }
            return arrayPosition;
        } // end searchValue
    } // end Program class
} // end namespace
