using System;
using System.Linq;

namespace testsinterview
{
    public class CountEvenAndOddNumbersInArray
    {
        /* Test to count even and odd numbers in an array of intergers */

        public CountEvenAndOddNumbersInArray()
        {
            Console.WriteLine("COUNT EVEN NUMBERS IN A STRING");

            int[] numbers = { 1, 2, 3, 4, 5 };
            int[] results = OddEven(numbers);
            Console.WriteLine("Count even numbers = {0}, Count odd numbers = {1} in array  in 1, 2, 3, 4, 5", results[0], results[1]);

            int[] numbers2 = { 1, 2, 2, 3, 4, 5, 6, 9, 27 };
            int[] results2 = OddEven(numbers2);
            Console.WriteLine("Count even numbers = {0}, Count odd numbers = {1} in array  in 1, 2, 2, 3, 4, 5, 6, 9, 27", results2[0], results2[1]);

            //Using lambda expression
            int cn_even_numbers = numbers2.Count(n => n % 2 == 0);
            int cn_odd_numbers = numbers2.Count(n => n % 2 == 1);
            Console.WriteLine($"Using Lambda Expressiong count of even numbers = {cn_even_numbers} and count of odd numbers i= {cn_odd_numbers} in 1, 2, 2, 3, 4, 5, 6, 9, 27 \n\n\n");

        }

        static int[] OddEven(int[] numbers)
        {
            int count_even = 0;
            int count_odd = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    count_even++;
                }
                else
                {
                    count_odd++;
                }
            }

            return new int[] { count_even, count_odd };
        }
    }
}
