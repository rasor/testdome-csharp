using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class ProgrNy
    {
        // https://www.testdome.com/tests/c-sharp-online-test/18
        public static bool IsPalindrome(string word)
        {
            string w2 = "";
            for (int i = 0; i < word.Length; i++)
            {
                w2 += word.Substring(word.Length - i - 1, 1);
            }
            return word.ToLower() == w2.ToLower();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(ProgrNy.IsPalindrome("Deleveled"));
        }
    }

}
