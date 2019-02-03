using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    // https://www.testdome.com/tests/c-sharp-online-test/18
    class Palindrome
    {
        public static bool IsPalindrome(string word)
        {
            string w2 = "";
            for (int i = 0; i < word.Length; i++)
            {
                w2 += word.Substring(word.Length - i - 1, 1);
            }
            return word.ToLower() == w2.ToLower();
        }

        public static void Main01(string[] args)
        {
            Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
            Console.ReadKey();
        }
    }

}
