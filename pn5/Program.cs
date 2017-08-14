/* 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
 * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
 */

using System.Linq;
using Shared;

namespace pn5
{
    class Program
    {
        const int START = 2, END = 20;

        static void Main(string[] args)
        {
            int result = FindSmallestEvenblyDivisibleNumber(START, START, END);
            System.Console.WriteLine(result);
        }

        private static int FindSmallestEvenblyDivisibleNumber(int num, int divisor, int end) =>
            divisor > end
                ? num
                : FindSmallestEvenblyDivisibleNumber(
                    Enumerable.Range(num, int.MaxValue - num)
                    .Where(n => n.IsEvenlyDivisibleBy(num))
                    .First(n => n.IsEvenlyDivisibleBy(divisor)),
                    ++divisor,
                    end);
    }
}
