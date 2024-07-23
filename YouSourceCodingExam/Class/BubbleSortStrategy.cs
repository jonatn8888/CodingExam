using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace YouSourceCodingExam.Class
{
    public class BubbleSortStrategy : ISortStrategy
    {

        //BUBBLE SORT STRATEGY
        public string Sort(string input)
        {
            //Repeatedly steps through the list, compares elements, and swaps them if they are 
            //in the wrong order.This process is repeated until the list is sorted.

            if (string.IsNullOrEmpty(input)) return input;

            char[] str = input.ToCharArray();
            for (int i = 0; i < str.Length - 1; i++)
            {
                for (int j = 0; j < str.Length - i - 1; j++)
                {
                    if (str[j] > str[j + 1])
                    {
                        // Swap str[j] and str[j+1]
                        char t = str[j];
                        str[j] = str[j + 1];
                        str[j + 1] = t;
                    }
                }
            }

            return new string(str);

            //OR USING LINQ
            var sortedChars = input.OrderBy(c => c);
            return new string(sortedChars.ToArray());


        }
    }
}
