using System;
using System.Collections.Generic;

namespace Shared
{
    public static class StrangeEnumerable
    {
        public static IEnumerable<long> RangeTwoAndOdd(long end)
        {
            for ( long i = 2; i <= end; i++ )
            {
                if ( !i.IsEven() || i == 2 )
                    yield return i;
            }
        }

        public static IEnumerable<long> RangePrimes(long end)
        {
            for ( long i = 2; i <= end; i++ )
            {
                if ( i.IsPrime() )
                    yield return i;
            }
        }

        public static IEnumerable<long> Range(long start, long end)
        {
            for ( long i = start; i <= end; i++ )
            {
                yield return i;
            }
        }

        public static IEnumerable<(int a, int b)> RangeDuplet(int start, int end)
        {
            for ( int i = start; i < end; i++ )
            {
                for ( int j = start; j < end; j++ )
                {
                    yield return (i, j);
                }
            }
        }

        public static IEnumerable<long> RangeTriangleNumber(long end)
        {
            for ( long i = 1; i <= end; i++ )
            {
                yield return GetTriangleNumber(i);
            }
        }

        private static long GetTriangleNumber(long n) =>
            (n * (n + 1)) / 2; // https://en.wikipedia.org/wiki/Triangular_number
    }
}
