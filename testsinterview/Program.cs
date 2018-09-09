using System;
using System.Text;

namespace testsinterview
{
    class Program
    {
        static void Main(string[] args)
        {
            MergeStringsOrStringInterlace mergestrings = Factory.CreateMergeStringsOrStringInterlace();
            CountEvenAndOddNumbersInArray countEvenAndOdd = Factory.CreateCountEvenAndOddNumbersInArray();
            GetFirstStringThatDoesNotRepeat getnonerepeatedstring = Factory.CreateGetFirstStringThatDoesNotRepeat();
        }
    }
}
