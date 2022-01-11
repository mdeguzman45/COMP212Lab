using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marc_DeGuzman_Exercise01
{
    public static class RandomExtensions
    {
        public static double NextDouble(this Random RandGenerator, double MinValue, double MaxValue)
        {
            return Math.Round(RandGenerator.NextDouble() * (MaxValue - MinValue) + MinValue, 2);
        } //end NextDouble
    } // end RandomExtensions class 
} // end namespace
