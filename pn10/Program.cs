/* The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
 * Find the sum of all the primes below two million.
 */

using System.Linq;
using Shared;

namespace pn10
{
    class Program
    {
        const int CEILING = 2_000_000;

        static void Main(string[] args)
        {
            long result = StrangeEnumerable.RangePrimes(CEILING).Sum();
            System.Console.WriteLine(result);
        }
    }
}
