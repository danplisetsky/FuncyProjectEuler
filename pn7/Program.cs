/* By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
 * What is the 10 001st prime number?
 */

using System.Linq;
using Shared;

namespace pn7
{
    class Program
    {
        const int COUNT = 10001;

        static void Main(string[] args)
        {
            long result = GetPrimeNumber(COUNT);
            System.Console.WriteLine(result);
        }

        private static long GetPrimeNumber(int count) =>
            StrangeEnumerable.RangePrimes(long.MaxValue)
            .Take(count)
            .Last();
    }
}
