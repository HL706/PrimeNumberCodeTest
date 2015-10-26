using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberCodeTest.Utilities
{
    interface IPrimeGenerator
    {
        /// <summary>
        /// GGenerates a list of prime numbers.
        /// </summary>
        /// <param name="limit">The max number in the range.</param>
        /// <returns></returns>
        List<int> GeneratePrimes(int limit);
    }
}
