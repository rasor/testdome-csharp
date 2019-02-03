using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    // https://www.testdome.com/tests/c-sharp-algorithms-online-test/21
    class TwoSum
    {
        public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
        {
            int leftVal;
            int rightVal;
            // Create sets of all pairs
            List<Tuple<int, int>> pairIndexes = new List<Tuple<int, int>>();
            //List<Tuple<int, int>> pairValues = new List<Tuple<int, int>>();
            for (int left = 0; left < list.Count -1; left++)
            {
                for (int right = left+1; right < list.Count; right++)
                {
                    leftVal = list[left];
                    rightVal = list[right];
                    if (leftVal + rightVal == sum)
                    {
                        //pairValues.Add(new Tuple<int, int>(leftVal, rightVal));
                        pairIndexes.Add(new Tuple<int, int>(left, right));
                    }
                }
            }

            if (pairIndexes.Count == 0) return null;
            return pairIndexes[0];
        }

        /// <summary>
        /// 0 and 3 (or 3 and 0) as 3 + 7 = 10
        /// 1 and 5 (or 5 and 1) as 1 + 9 = 10
        /// 2 and 4 (or 4 and 2) as 5 + 5 = 10
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Tuple<int, int> indices = FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
            if (indices != null)
            {
                Console.WriteLine(indices.Item1 + " " + indices.Item2);
            }
            Console.ReadKey();
        }
    }

}
