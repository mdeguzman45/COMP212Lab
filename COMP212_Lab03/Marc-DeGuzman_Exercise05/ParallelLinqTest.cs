using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marc_DeGuzman_Exercise05
{
    public class ParallelLinqTest
    {
        public static void Main(string[] args)
        {
            var random = new Random();
            // create array of random integers in the range 1-500
            int[] intArray = Enumerable.Range(1, 10000000)
                                     .Select(x => random.Next(1, 500))
                                     .ToArray();
            // time the Sum and Count distinct elements via LINQ and Paralle LINQ

            Console.WriteLine($"intArray size: {intArray.Length}");

            Console.WriteLine("\nSum and distinct elements with LINQ to Objects using a single core");
            // get time before method calls
            var linqStart = DateTime.Now;

            // set return as double in lambda to avoid overflow exception
            var linqSum = intArray.Sum(s => (double)s);
            // var linqAverage = intArray.Average(a => (double)a);
            var linqDistinctCount = intArray.Distinct().Count();

            // get time after method calls
            var linqEnd = DateTime.Now;
            
            // display results and total time in milliseconds
            var linqTime = linqEnd.Subtract(linqStart).TotalMilliseconds;
            Console.WriteLine($"Sum: {linqSum}\nDistinct Element Count: {linqDistinctCount}\nTotal time in milliseconds: {linqTime:F}");

            Console.WriteLine("\nSum and distinct elements with PLINQ using multiple cores");
            // get time before method calls
            var pLinqStart = DateTime.Now;

            // set return as double in lambda to avoid overflow exception
            var pLinqSum = intArray.AsParallel().Sum(s => (double)s);
            // var pLinqAverage = intArray.AsParallel().Average(a => (double)a);
            var pLinqDistinctCount = intArray.AsParallel().Distinct().Count();

            // get time after method calls
            var pLinqEnd = DateTime.Now; 

            // display results and total time in milliseconds
            var plinqTime = pLinqEnd.Subtract(pLinqStart).TotalMilliseconds;
            Console.WriteLine($"Sum: {pLinqSum}\nDistinct Element Count: {pLinqDistinctCount}\nTotal time in milliseconds: {plinqTime:F}");

            // display time difference as a percentage
            Console.WriteLine("\nPLINQ took " + $"{((linqTime - plinqTime) / linqTime):P0} less time than LINQ");
        }
    }
}
