using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public static class Extensions
    {
        #region int 

        public static bool IsEven(this int x) =>
            x % 2 == 0;

        #endregion int

    }
}
