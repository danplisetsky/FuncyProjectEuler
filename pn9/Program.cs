/* A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
 *      a^2 + b^2 = c^2
 * For example, 32 + 42 = 9 + 16 = 25 = 5^2.
 * 
 * There exists exactly one Pythagorean triplet for which a + b + c = 1000.
 * Find the product abc.
 */
using System.Linq;
using Shared;

namespace pn9
{
    class Program
    {
        const int SUM = 1000;

        static void Main(string[] args)
        {
            long result = FindPythagoreanTripletForSumOf(SUM).Product();
            System.Console.WriteLine(result);
        }

        private static (int a, int b, int c) FindPythagoreanTripletForSumOf(int sum) =>
            StrangeEnumerable.RangeDuplet(1, sum)
            .FirstOrDefault(d => 
                (d.a, d.b)
                .DupletToTriplet(sum)
                .IsPythagoreanTriplet())
            .DupletToTriplet(sum);



    }
}
