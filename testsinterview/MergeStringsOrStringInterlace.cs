using System;
using System.Text;

namespace testsinterview
{
    public class MergeStringsOrStringInterlace
    {
        /* Marge two strings and return their interlaced values eg. "abc" and "def" will be adbecf*/

        public MergeStringsOrStringInterlace()
        {
            Console.WriteLine("MERGE TWO STRING INTERLACE");
            string exampleOne = this.InterLaceString("abc", "def");
            Console.WriteLine($"abc merged with def = {exampleOne}");
            string exampleTwo = this.InterLaceString("abcHIJ", "def");
            Console.WriteLine($"abcHIJ merged with def = {exampleTwo}");
            string exampleThree = this.InterLaceString("abc", "defGHIJ");
            Console.WriteLine($"abc merged with defGHIJ = {exampleThree}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

        }

        public string InterLaceString(string a, string b)
        {
            StringBuilder string_bulider = new StringBuilder();

            int get_max_value = Math.Max(a.Length, b.Length);

            for (int i = 0; i < get_max_value; i++)
            {
                if (i < a.Length)
                {
                    string_bulider.Append(a[i]);
                }

                if (i < b.Length)
                {
                    string_bulider.Append(b[i]);
                }
            }

            return string_bulider.ToString();
        }

    }
}
