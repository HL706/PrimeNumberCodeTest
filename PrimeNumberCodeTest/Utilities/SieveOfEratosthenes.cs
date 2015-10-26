using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberCodeTest.Utilities
{
    public class SieveOfEratosthenes : IPrimeGenerator
    {
        public SieveOfEratosthenes()
        {

        }

        public List<int> GeneratePrimes(int limit)
        {
            // Create a list of numbers from 2 -> N. We'll considerall of these numbers to be prime for now.
            List<int> primeNumbers = Enumerable.Range(2, limit - 1).ToList();

            // Initialise our current and next prime to be 2.
            int prime = primeNumbers[0];
            int nextPrime = primeNumbers[0];

            while (nextPrime <= limit)
            {
                // Increase the prime count to its nearest multiple.
                prime += nextPrime;

                // Do a boundary check and then increase the prime number if we've
                // went passed our limit.
                if (prime > limit)
                {
                    // Iterate through the remaining numbers until we haave a new prime or we've exhausted the list.
                    while (primeNumbers.IndexOf(++nextPrime) == -1 && nextPrime <= limit) ;

                    // Reset the current prime and start the process again.
                    prime = nextPrime;
                }
                else
                {
                    // Remove the current number as it doesn't satisfy the rules of a prime number.
                    primeNumbers.Remove(prime);
                }
            }

            return primeNumbers;
        }
    }
}
