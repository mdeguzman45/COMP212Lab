using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marc_DeGuzman_Exercise02
{
    public class Program
    {
        // delegate for a function that receives a double and returns bool
        public delegate bool GradePredicate(double grade);
        public static void Main(string[] args)
        {
            // define student's grade array between 10 and 100
            double[] studentgrade = { 49.16, 78.59, 87.23, 35.63, 51.82, 50.01, 77.46, 88.19, 91.03, 95.86 };
            double[] studentGrade2 = { 23.19, 45.92, 16.85, 50.00, 51.28, 95.57, 49.99, 9.23, 77.64, 100.00 };

            // define a predicate to filter grades that are greater than or equal to 50
            GradePredicate gradePredicate = grade => grade >= 50;

            // test the filter
            GradesFilter(studentgrade, gradePredicate);
            GradesFilter(studentGrade2, gradePredicate);

        }

        // display grades that will meet the predicate condition
        public static void GradesFilter(double[] gradesArray, GradePredicate predicate)
        {
            Console.WriteLine("Displaying grades that are greater than or equal to 50:");
            foreach(double grade in gradesArray)
            {
                // display the grade that meets the predicate condition
                if (predicate(grade))
                {
                    Console.Write($"{grade.ToString("#.00")} ");
                }
            }
            Console.WriteLine(""); // new line
        }
    }
}
