using System;
using System.Globalization;

namespace Day26
{
    class Solution
    {
        static int calculateFine(DateTime actual, DateTime expected)
        {
            if (actual <= expected)
                return 0;

            if (actual.Year > expected.Year)
                return 10000;

            if (actual.Month > expected.Month)
                return 500 * (actual.Month - expected.Month);
            else 
                return 15 * (actual.Day - expected.Day);
        }

        static void Main(string[] args)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime ActuallyReturn = DateTime.ParseExact(Console.ReadLine(), "d m yyyy", provider);
            DateTime ExpectedReturn = DateTime.ParseExact(Console.ReadLine(), "d m yyyy", provider);

            Console.WriteLine(calculateFine(ActuallyReturn, ExpectedReturn));

            Console.ReadKey();
        }
    }
}
