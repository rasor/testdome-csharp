using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    // https://www.testdome.com/tests/c-sharp-online-test/18
    class Prefix
    {
        public static IEnumerable<string> Prefixes(IEnumerable<string> words, int length)
        {
            var list = words.Where(w => w.Length > 2).Select(w => w.Substring(0, 3)).Distinct();
            return list;
        }

        public static void Main10(string[] args)
        {
            foreach (var p in Prefixes(new string[] { "many", "manly", "men", "maybe", "my" }, 3))
                Console.WriteLine(p);
            Console.ReadKey();
        }
    }

}
