using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    // https://www.testdome.com/tests/c-sharp-online-test/18
    class Prefix
    {
        //System.Linq.Enumerable.DistinctIterator<string>
        public static IQueryable<string> Prefixes(IEnumerable<string> words, int length)
        {
            IQueryable<string> list = words.Where(w => w.Length > 2).Select(w => w.Substring(0, 3)).Distinct().AsQueryable();
            return list;
        }

        public static void Main(string[] args)
        {
            foreach (var p in Prefixes(new string[] { "many", "manly", "men", "maybe", "my" }, 3))
                Console.WriteLine(p);
            Console.ReadKey();
        }
    }

}
