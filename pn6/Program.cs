/*The sum of the squares of the first ten natural numbers is,
 *      1^2 + 2^2 + ... + 10^2 = 385
 * The square of the sum of the first ten natural numbers is,
 *      (1 + 2 + ... + 10)^2 = 55^2 = 3025
 * Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
 * Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
 */

using System;
using System.Linq;
using Shared;

namespace pn6
{
    class Program
    {
        const int COUNT = 100;
        const int POW = 2;

        static void Main(string[] args)
        {
            double result = DifferenceBetweenPowerOfTheSumAndSumOfThePower(POW, COUNT);
            Console.WriteLine(result);
        }

        private static double DifferenceBetweenPowerOfTheSumAndSumOfThePower(int pow, int count) =>
            PowerOfTheSum(pow)(count) - SumOfThePower(pow)(count);

        private static Func<int, double> SumOfThePower(int pow) =>
            count =>
                Enumerable.Range(1, count)
                .Sum(n => n.Pow(pow));

        private static Func<int, double> PowerOfTheSum(int pow) =>
            count =>
                Enumerable.Range(1, count)
                .Sum()
                .Pow(pow);
    }
}
