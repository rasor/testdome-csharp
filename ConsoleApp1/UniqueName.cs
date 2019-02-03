using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    // https://www.testdome.com/tests/c-sharp-online-test/18
    class UniqueName
    {
        public static string FirstUniqueName(string[] names)
        {
            string retVal = null;
            var onlyOneList = new Dictionary<string, bool>();
            var query = names.GroupBy(w => w);
            foreach (var group in query)
            {
                if (group.Count() == 1 )
                {
                    onlyOneList.Add(group.First(), false);
                }
            }
            // None found
            if (onlyOneList.Keys.Count == 0) return retVal;

            // Find first w
            foreach (var name in names)
            {
                if (onlyOneList.Keys.Contains(name))
                {
                    retVal = name;
                    break;
                }
            }
            return retVal;
        }

        public static void Main12(string[] args)
        {
            Console.WriteLine(FirstUniqueName(new string[] { "Abbi", "Adeline", "Abbi", "Adalia" }));
            Console.ReadKey();
        }
    }

}
