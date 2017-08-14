using System;
using System.Collections.Generic;
using System.Linq;
/*
 * Problem 1
 * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
 * Find the sum of all the multiples of 3 or 5 below 1000.
 */

namespace pn1
{
    class Program
    {
        private delegate IEnumerable<int> Multiples(params int[] nums);
        const int CEILING = 1000, n1 = 3, n2 = 5;

        static void Main(string[] args)
        {
            int result = GetSumFor(CEILING, n1, n2);
            Console.WriteLine(result);
        }

        private static int GetSumFor(int ceiling, params int[] nums) =>
            GetMultiplesBelow(ceiling)(nums).Sum();

        private static Multiples GetMultiplesBelow(int ceiling) =>
            nums => 
            Enumerable.Range(1, ceiling - 1)
            .Where(i => nums.Any(n => i % n == 0));

    }
}
