/*
A perfect number is a number for which the sum of its proper divisors is exactly equal to the number. 
For example, the sum of the proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.

A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if this sum exceeds n.

As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as the sum of two abundant numbers is 24. 
By mathematical analysis, it can be shown that all integers greater than 28123 can be written as the sum of two abundant numbers. 
However, this upper limit cannot be reduced any further by analysis even though it is known that the greatest number that cannot be expressed 
as the sum of two abundant numbers is less than this limit.

Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using Shared;

namespace pn23
{
    class Program
    {
        const int CEILING = 28123;
        const int FIRST_ABUNDANT_NUMBER = 12;
        const int COUNT = CEILING - FIRST_ABUNDANT_NUMBER;

        static void Main(string[] args)
        {
            var abundantNumbers = AbundantNumbersUnder(COUNT).ToList();
            var sums = SumsOfTwoAbundantNumbers(abundantNumbers);
            long result = SumOfNumbersNotSumOfTwoAbundantNumbers(CEILING, sums);

            Console.WriteLine(result);
        }

        private static List<long> AbundantNumbersUnder(int count) =>
            StrangeEnumerable.Range(1, count).Where(n => n.IsAbundant()).ToList();

        private static IEnumerable<long> SumsOfTwoAbundantNumbers(List<long> abundantNumbers) =>
            abundantNumbers.SelectMany(n1 => abundantNumbers.Select(n2 => n1 + n2));

        private static long SumOfNumbersNotSumOfTwoAbundantNumbers(int ceiling, IEnumerable<long> sumsOfTwoAbundantNumbers) =>
            StrangeEnumerable.Range(1, ceiling)
            .Except(sumsOfTwoAbundantNumbers)
            .Sum();
    }
}
