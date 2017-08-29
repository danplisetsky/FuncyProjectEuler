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

        public static double Pow(this int x, int pow) =>
            Math.Pow(x, pow);

        public static bool IsNarcissistic(this int x, int pow) =>
            x.ToString()
            .Select(c => Convert.ToInt32(Math.Pow(Char.GetNumericValue(c), pow))).Sum() == x;

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
            StrangeEnumerable.Range(2, x.GetCeiling())
            .Where(n => x.IsEvenlyDivisibleBy(n))
            .SelectMany(n =>
                (x / n).IsPrime()
                ? n.IsPrime()
                    ? n != x / n ? new[] { n, x / n } : new[] { n }
                    : new[] { x / n }
                : n.IsPrime()
                    ? new[] { n }
                    : new long[] { });
        /* Since we're only checking the numbers from x to sqrt of x,
         * it's necessary to also check the quotient for being a prime number,
         * e.g.: let's find all the prime factors of 10. Check that 2, 3 are factors (since sqrt of 10 is ~ 3). 2 is a factor,
         * hence check that 10 / 2 = 5 is prime. It is, so we add it to the resulting sequence. 3 is not a factor,
         * so the result is 2 and 5.
         */

        public static int GetNumberOfFactors(this long x) =>
            x.GetFactors().Count();

        private static IEnumerable<long> GetFactors(this long x) =>
            StrangeEnumerable.Range(1, x.GetCeiling())
            .Where(n => x.IsEvenlyDivisibleBy(n))
            .SelectMany(n =>
                n != x / n
                ? new[] { n, x / n }
                : new[] { n });

        public static IEnumerable<long> GetFactorsNotIncluding(this long x) =>
            x.GetFactors().Where(f => f != x);

        public static bool IsAmicablePairOf(this long a, long b) =>
            a == b
                ? false
                : a.GetFactorsNotIncluding().Sum() == b &&
                b.GetFactorsNotIncluding().Sum() == a;

        public static int CollatzSequenceLength(this long x) =>
            x == 1
            ? 1
            : x.IsEven()
                ? 1 + CollatzSequenceLength(x / 2)
                : 1 + CollatzSequenceLength(x * 3 + 1);

        public static bool IsAbundant(this long x) =>
            x.GetFactorsNotIncluding().Sum() > x;

        #endregion long

        #region tuple

        public static long Product(this (int a, int b, int c) triplet) =>
            triplet.a * triplet.b * triplet.c;

        public static bool IsPythagoreanTriplet(this (int a, int b, int c) triplet) =>
            triplet.a.Pow(2) + triplet.b.Pow(2) == triplet.c.Pow(2);

        #endregion tuple

    }
}
