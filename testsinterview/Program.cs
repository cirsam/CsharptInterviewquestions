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
            FindAndReplaceMissingString findAndReplaceMissingString = Factory.FindAndReplaceMissingString();
            producEntity TestproductEntity = new producEntity
            {
                ProductCategoryId = 1,
                ProductPrice = 100,
                ProductCategoryName = "test category",
                ProductCategoryDescription = "this is the category description",
                ProductName = "test product",
                ProductDescription = "this is the description",
            };


            Console.ForegroundColor = ConsoleColor.Green;
            // Use ANSI escape codes for bolding text
            string startBold = "\u001b[1m";
            string endBold = "\u001b[0m";
            Console .WriteLine("\n\n\n");
            Console.WriteLine($"This is the product details of the {startBold} productEntity class{endBold}\n\n");
           Console.WriteLine("below is the results from the extention methed TestproductEntity.GetProductSpecifications()\n\n");
           
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine( TestproductEntity.GetProductSpecifications());
            Console.ResetColor();
        }
      
    }
}