using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEvalEasy
{
    class SumofPrimes
    {
        private int numOfPrimes;

        public int NumOfPrimes
        {
            get { return numOfPrimes; }
            set { numOfPrimes = value; }
        }

        public SumofPrimes(int N)
        {
            this.NumOfPrimes = N;

        }

        public long Sum()
        {
            long sum = 0;
            long current = 2;
            long primes = 0;
            while (primes < NumOfPrimes)
            {
                if (isPrime(current))
                {
                    sum += current;
                    primes++;
                }
                current++;

            }
            return sum;
        }

        public bool isPrime(long n)
        {
            if (n <= 1) { return false; }
            else if (n <= 3) { return true; }
            else if (n % 2 == 0 || n % 3 == 0) { return false; }

            for (int i = 5; i < n; i++) {
                if (n % i == 0) { return false; } 
            }

            return true;
        }
    }
}
