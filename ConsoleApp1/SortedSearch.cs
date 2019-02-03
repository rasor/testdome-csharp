using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    // https://www.testdome.com/tests/c-sharp-algorithms-online-test/21
    class SortedSearch
    {
        public static int CountNumbers(int[] sortedArray, int lessThan)
        {
            var validNumbers = new Dictionary<int,bool>();
            foreach (var number in sortedArray)
            {
                if (number < lessThan)
                {
                    try
                    {
                        // use number as key to catch duplets
                        validNumbers.Add(number, false);
                    }
                    catch (Exception)
                    {
                        // Ignore duplets
                    }
                }
            }
            return validNumbers.Count;
        }

        /// <summary>
        /// SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4) should return 2 
        /// because there are two array elements less than 4.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4));
            Console.ReadKey();
        }
    }

}
