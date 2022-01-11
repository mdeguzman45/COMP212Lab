using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marc_DeGuzman_COMP212_Sec002_Lab02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // create built in delegate via Function
            Func<string, string, string, string> minimumString = Minimum;
            // create built in delegate via Action
            Action<double, double, double> actionAverage = AvgGrade;

            String string1 = "apple";
            String string2 = "orange";
            String string3 = "mango";

            //get the minimum string
            Console.WriteLine($"The smallest string values between {string1}, {string2}, {string3} is {minimumString(string1, string2, string3)}");

            // check average grade
            actionAverage(85.92, 76.40, 95.03);
        }

        // returns the smallest string  value
        public static String Minimum(String string1, String string2, String string3)
        {
            string min = string1;
            if (string2.CompareTo(min) < 0)
            {
                min = string2;
            }

            if (string3.CompareTo(min) < 0)
            {
                min = string3;
            }

            return min;
        }

        // display the average of 3 grades
        public static void AvgGrade(double grade1, double grade2, double grade3)
        {
            double averageGrade = (grade1 + grade2 + grade3) / 3;
            Console.WriteLine($"The average grade of {grade1}, {grade2}, {grade3} is {averageGrade.ToString("0.##")}");
        }
    }
}
