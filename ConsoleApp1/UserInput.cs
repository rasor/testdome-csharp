using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class UserInput
    {
        // https://www.testdome.com/tests/c-sharp-online-test/18

        public static void Main02(string[] args)
        {
            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.GetValue());
        }
    }

    public class NumericInput : TextInput
    {
        public override void  Add(char v)
        {
            int i;
            try
            {
                i = Convert.ToInt32(v.ToString());
                res.Add(v);
            }
            catch (Exception)
            {
            }
        }
    }

    public class TextInput
    {
        public TextInput()
        {
            res = new List<char>();
        }
        internal List<char> res;
        public virtual void Add(char v)
        {
            res.Add(v);
        }

        public string GetValue()
        {
            return string.Concat(res);
        }
    }


}
