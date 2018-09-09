using System;
using System.Collections.Generic;
using System.Linq;

namespace testsinterview
{
    public class GetFirstStringThatDoesNotRepeat
    {
        /* Given a string find the first non-repeated character. */

        public GetFirstStringThatDoesNotRepeat()
        {
            Console.WriteLine("GET FIRST NON_REPEATED CHARACTER");
            Console.WriteLine("The string sTress = {0}", GetString("sTress"));
            Console.WriteLine("The string Samuels = {0}", GetString("Samuels"));
            Console.WriteLine("The string Trying out = {0}", GetString("Trying out")+"\n\n\n");
        }

        public static string GetString(string mystring)
        {
            var count_letter = mystring.ToUpper().GroupBy(a =>a);
            string get_letter = "";

            foreach(var item in count_letter){
                if(item.Count()==1)
                {
                    get_letter = item.Key.ToString();
                    break;
                }
            }

            return get_letter;
        }
    }
}
