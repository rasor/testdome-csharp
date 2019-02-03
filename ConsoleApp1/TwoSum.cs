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
            var found = false;
            //int leftVal;
            //int rightVal;
            // Create sets of all pairs
            //List<Tuple<int, int>> pairIndexes = new List<Tuple<int, int>>();
            //List<Tuple<int, int>> pairValues = new List<Tuple<int, int>>();
            var pairIndexesArr = new Tuple<int, int>[list.Count * 3];
            int outputArrIndex = 0;
            for (int left = 0; left < list.Count -1; left++)
            {
                for (int right = left+1; right < list.Count; right++)
                {
                    // Add to output, if sum match
                    //leftVal = list[left];
                    //rightVal = list[right];
                    if (list[left] + list[right] == sum)
                    {
                        //pairValues.Add(new Tuple<int, int>(leftVal, rightVal));
                        //pairIndexes.Add(new Tuple<int, int>(left, right));
                        pairIndexesArr[outputArrIndex] = new Tuple<int, int>(left, right);
                        outputArrIndex++;
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }
            if (pairIndexesArr.Length == 0) return null;
            return pairIndexesArr[0];

            //if (pairIndexes.Count == 0) return null;
            //return pairIndexes[0];
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
