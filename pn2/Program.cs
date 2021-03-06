﻿/*
 * Problem 2
 * Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
 * 
 * 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
 * 
 * By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
 */

using System;
using Shared;

namespace pn2
{
    class Program
    {
        const int CEILING = 4_000_000;

        static void Main(string[] args)
        {
            int result = FibSumEvenTermsBelow(CEILING)(1, 2);
            Console.WriteLine(result);
        }

        private static Func<int, int, int> FibSumEvenTermsBelow(int ceiling)
        {
            Func<int, int, int> fib = null;
            fib = (m, n) =>
            {
                return n > ceiling
                    ? m.IsEven()
                        ? m
                        : 0
                    : m.IsEven()
                        ? m + fib(n, m + n)
                        : fib(n, m + n);
            };
            return fib;
        }
    }
}
