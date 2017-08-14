/* A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
 * Find the largest palindrome made from the product of two 3-digit numbers. * 
 */

using System.Collections.Generic;
using System.Linq;
using Shared;

namespace pn4
{
    class Program
    {
        const int START = 100, END = 1000, COUNT = END - START;

        static void Main(string[] args)
        {
            int result = FindPalindromeFromProducts(START, COUNT).Max();
            System.Console.WriteLine(result);
        }

        private static IEnumerable<int> FindPalindromeFromProducts(int start, int count) =>
            Enumerable.Range(start, count)
            .SelectMany(
                n => Enumerable.Range(start, count)
                .Where(x => (x * n).IsPalindrome())
                .Select(x => x * n));
    }
}
