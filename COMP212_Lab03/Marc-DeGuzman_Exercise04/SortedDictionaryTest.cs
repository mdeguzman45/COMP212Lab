using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Marc_DeGuzman_Exercise04
{
    public class SortedDictionaryTest
    {
        public static void Main(string[] args)
        {
            // create sorted dictionary based on user input
            SortedDictionary<string, int> dictionary = CollectWords();

            // sort the dictionary to show words that repeated more than once
            var filteredDictionary = new SortedDictionary<string, int>(dictionary.Where(word => word.Value > 1)
                .ToDictionary(word => word.Key, word => word.Value));

            // display only the filtered dictionary
            DisplayDictionary(filteredDictionary);
        }

        // create sorted dictionary from user input
        private static SortedDictionary<string, int> CollectWords()
        {
            // create a new sorted dictionary
            var dictionary = new SortedDictionary<string, int>();

            Console.WriteLine("Enter a string: "); // prompt for user input
            string input = Console.ReadLine(); // get input

            // split input text into tokens
            string[] words = Regex.Split(input, @"\s+");

            // processing input words
            foreach (var word in words)
            {
                var key = word.ToLower(); // get word in lowercase

                // if the dictionary contains the word
                if (dictionary.ContainsKey(key))
                {
                    ++dictionary[key];
                }
                else
                {
                    // add new word with a count of 1 to the dictionary
                    dictionary.Add(key, 1);
                }
            }

            return dictionary;
        }

        // display dictionary content
        private static void DisplayDictionary<K, V>(
           SortedDictionary<K, V> dictionary)
        {
            Console.WriteLine(
               $"\nSorted dictionary contains:\n{"Key",-12}{"Value",-12}");

            // generate output for each key in the sorted dictionary
            // by iterating through the Keys property with a foreach statement
            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine($"{key,-12}{dictionary[key],-12}");
            }

            Console.WriteLine($"\nsize: {dictionary.Count}");
        }
    }
}
