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
    }
}
