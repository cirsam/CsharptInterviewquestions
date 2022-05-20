using System;
using System.Linq;

namespace testsinterview
{
    /***
     Samuel,

Could you please solve this puzzle and send me a solution?

Optionally, please use LINQ to memory.

Task

In this task, you need to restore a string from a list of its copies.

You will receive an array of strings. All of them are supposed to be the same as the original but, unfortunately, they were corrupted which means some of the characters were replaced with asterisks ("*").

You have to restore the original string based on non-corrupted information you have. If in some cases it is not possible to determine what the original character was, use "#" character as a special marker for that.

If the array is empty, then return an empty string.

Examples:

input = [

  "a*cde",

  "*bcde",

  "abc*e"

]

result = "abcde"

 

 

input = [

  "a*c**",

  "**cd*",

  "a*cd*"

]

result = "a#cd#"
     
     **/
    public class FindAndReplaceMissingString
    {
        private readonly string StandardWord = "abcde";
        public FindAndReplaceMissingString()
        {
            string[] input = { "a*cde", "*bcde", "abc*e" };
            var result = GetWord(input);
            Console.WriteLine("This will output results abcde = {0}", result);

            string[] input2 = { "a*c**", "**cd*", "a*cd*" };
            var result2 = GetWord(input2);
            Console.WriteLine("This will output results a#c## = {0}", result2);
        }

        private string GetWord(string[] input)
        {
            string theWord = string.Empty;
            foreach (var (inputString, SplitInputString, SplitStandardString, NumberOfAsteriks) in from string inputString in input
                                                                                                   let SplitInputString = inputString.ToCharArray()
                                                                                                   let SplitStandardString = StandardWord.ToCharArray()
                                                                                                   let NumberOfAsteriks = 0
                                                                                                   select (inputString, SplitInputString, SplitStandardString, NumberOfAsteriks))
            {
                theWord = (inputString != StandardWord) ? CheckAndMatchLetters(inputString, SplitInputString, SplitStandardString, NumberOfAsteriks) : inputString;
            }

            return theWord;
        }

        private static string CheckAndMatchLetters(string inputString, char[] SplitInputString, char[] SplitStandardString,  int NumberOfAsteriks)
        {
            for (int i = 0; i < SplitInputString.Length; i++)
            {
                if (SplitInputString[i] == '*')
                {
                    SplitInputString[i] = SplitStandardString[i];
                    NumberOfAsteriks += 1;
                }
            }

            return ((string.Join(',', SplitInputString) == string.Join(',', SplitStandardString)) && NumberOfAsteriks == 1)? string.Join("", SplitInputString): inputString.Replace("*", "#");
        }
    }
}
