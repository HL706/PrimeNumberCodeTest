using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberCodeTest.Utilities
{
    interface IPrimeGenerator
    {
        List<uint> GeneratePrimes(int numberOfPrimesToGenerate);
    }
}
