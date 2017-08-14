using System;
using System.Linq;
using Shared;
/*
* The prime factors of 13195 are 5, 7, 13 and 29.
* What is the largest prime factor of the number 600851475143 ?
*/

namespace pn3
{
    class Program
    {
        const long NUMBER = 600_851_475_143;

        static void Main(string[] args)
        {
            long result = NUMBER.GetPrimeFactors().Last();
            Console.WriteLine(result);
        }
    }
}
