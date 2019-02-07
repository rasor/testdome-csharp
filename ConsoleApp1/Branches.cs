using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    // https://www.testdome.com/tests/c-sharp-online-test/18
    class Branches
    {
        public static int Count(params int[] tree)
        {
            var branchList = new Dictionary<int, bool>();
            var query = tree.GroupBy(n => n);
            foreach (var group in query)
            {
                if (group.Count() == 2)
                {
                    branchList.Add(group.First(), false);
                }
            }
            var count = branchList.Keys.Count;
            if (tree.Length == 0) return 0;
            if (count == 0 && tree.Length > 0) return 1;
            return count;
        }

        public static void Main13(string[] args)
        {
            Console.WriteLine(Branches.Count(1, 3, 1, -1, 3));
            Console.WriteLine(Branches.Count(-1));
            Console.WriteLine(Branches.Count());
            Console.ReadKey();
        }
    }

}
