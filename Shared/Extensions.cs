using System;
using System.Collections.Generic;
using System.Linq;

namespace Shared
{
    public static class Extensions
    {
        #region int 

        public static bool IsEven(this int x) =>
            x.IsEvenlyDivisibleBy(2);

        public static bool IsPalindrome(this int x) =>
            x.ToString()
            .SequenceEqual(
                x.ToString().Reverse());

        public static bool IsEvenlyDivisibleBy(this int x, int divisor) =>
            x % divisor == 0;

        #endregion int

        #region long

        public static bool IsEven(this long x) =>
           x.IsEvenlyDivisibleBy(2);

        public static bool IsEvenlyDivisibleBy(this long x, long divisor) =>
           x % divisor == 0;

        public static bool IsPrime(this long x) =>
            x <= 1
                ? false
                : x <= 3
                    ? true
                    : !StrangeEnumerable.RangeTwoAndOdd(x.GetCeiling())
                    .Any(n => x.IsEvenlyDivisibleBy(n));


        private static long GetCeiling(this long x) =>
            (long)Math.Floor(Math.Sqrt(x));

        public static IEnumerable<long> GetPrimeFactors(this long x) =>
            StrangeEnumerable.RangePrimes(x.GetCeiling())
            .Where(n => x.IsEvenlyDivisibleBy(n))
            .SelectMany(n => (x / n).IsPrime() ? new[] { n, x / n } : new[] { n });
        /* Since we're only checking the numbers from x to sqrt of x (in RangePrimes),
         * it's necessary to also check the quotient for being a prime number,
         * e.g.: let's find all the prime factors of 10. Check that 2, 3 are factors (since sqrt of 10 is ~ 3). 2 is a factor,
         * hence check that 10 / 2 = 5 is prime. It is, so we add it to the resulting sequence. 3 is not a factor,
         * so the result is 2 and 5.
         */

        #endregion long

    }
}
