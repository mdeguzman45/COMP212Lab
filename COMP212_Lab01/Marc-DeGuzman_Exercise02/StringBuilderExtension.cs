using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marc_DeGuzman_Exercise02
{
    public static class StringBuilderExtension
    {
        public static int WordCount(this StringBuilder stringBuilder)
        {
            String strValue = stringBuilder.ToString();

            // for now we count the words that are separated by white space
            String[] wordCount = strValue.Split(' ');

            return wordCount.Length;
        } // end wordCount
    } // end StringBuilderExtension class 
} // end namespace
