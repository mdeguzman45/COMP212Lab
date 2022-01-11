using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marc_DeGuzman_Exercise02
{
    public class StringBuilderTest
    {
        static void Main(string[] args)
        {
            StringBuilder sb1 = new StringBuilder("This is to test whether the extension method count can return a right answer or not");
            StringBuilder sb2 = new StringBuilder("You can define extension methods for user defined types as well as predefined types");

            Console.WriteLine($"StringBuilder object 1: {sb1}");
            Console.WriteLine($"The number of words contained in stringbuilder object 1 is {sb1.WordCount()}");

            Console.WriteLine($"StringBuilder object 2: {sb2}");
            Console.WriteLine($"The number of words contained in stringbuilder object 2 is {sb2.WordCount()}");
        } // end main
    } // end class
} // end namespace
