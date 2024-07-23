using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouSourceCodingExam.Class
{
    public class QuickSortStrategy : ISortStrategy
    {

        //QUICK SORT STRATEGY
        public string Sort(string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input), "Input cannot be null.");
            if (input.Length == 0)
                return input;

            char[] str = input.ToCharArray();
            QSort(str, 0, str.Length - 1);
            return new string(str);
        }

        private void QSort(char[] str, int l, int h)
        {
            if (l < h)
            {
                int pi = Split(str, l, h);

                //Iterate repetitively before spllitting
                QSort(str, l, pi - 1);
                QSort(str, pi + 1, h);
            }
        }


        //Method to split or partition the string array
        private int Split(char[] str, int l, int h)
        {
            char p = str[h]; 
            int i = (l - 1); //smaller element

            for (int j = l; j < h; j++)
            {
                //if current is smaller than or equal to p
                if (str[j] < p)
                {
                    i++;
                    char t = str[i];
                    str[i] = str[j];
                    str[j] = t;
                }
            }

            char s = str[i + 1];
            str[i + 1] = str[h];
            str[h] = s;

            return i + 1;
        }
    }
}
