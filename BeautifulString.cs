using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BeautifulString
{
    internal static class BeautifulString
    {
        /// <summary>
        /// Compare if the string is beautiful by checking whether the predecessor letter has fewer occurrences than the successor letter.
        /// </summary>
        /// <param name="inputString">string in wich will be compared</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">inputString that contains char that not represent letter</exception>
        internal static bool IsBeautifulString(this string inputString)
        {
            if (!Regex.IsMatch(inputString, "^[a-zA-Z]+$"))
                throw new ArgumentException("Invalid input string");

            var letterCountCollection = inputString.OrderBy(x => x)
                                                   .GroupBy(x => x).Select(x => x.ToList().Count)
                                                   .ToList();
            var isBeautiful = true;
            for (int i = 0; letterCountCollection.Count-1 > i; i++) 
            {
                if(letterCountCollection[i] > letterCountCollection[i + 1])
                {
                    isBeautiful = false;
                    break;
                }
            }
            return isBeautiful;
        }
    }
}
