using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEvalEasy
{
    class LargestPrimePalindrome
    {
        private int largestPP;
        public int LargestPP
        {
            get { return largestPP; }
            set { largestPP = value; }
        }

        public LargestPrimePalindrome(int N)
        {
            largestPP = 0;

            for (int i = 2; i < N; i++)
            {
                if (isPrime(i))
                {
                    if (isPalindrome(i))
                    {
                        largestPP = i;
                    }
                }
            }
        }

        
        public bool isPrime(int n)
        {
            if (n <= 1) { return false; }
            else if (n <= 3) { return true; }
            else if (n % 2 == 0 || n % 3 == 0) { return false; }

            for (int i = 5; i * i < n; i++) {
                if (n % i == 0) { return false; } 
            }

            return true;
        }

        public bool isPalindrome(string s)
        {
            //Console.WriteLine("s: {0}",s);
            if (s.Length <= 1) { return true; }
            else if (s.ElementAt(0) == s.ElementAt(s.Length - 1)) { return isPalindrome(s.Substring(1, s.Length - 2)); }
            else { return false; }
        }

        public bool isPalindrome(int i)
        {
            string s = i.ToString();
            return isPalindrome(s);
        }
    }
}
