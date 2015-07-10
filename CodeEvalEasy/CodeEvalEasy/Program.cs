using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEvalEasy
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz");
            string in1 = "3 5 10";
            string in2 = "2 7 15";

            var fb1 = new FizzBuzz(in1);
            Console.WriteLine();
            var fb2 = new FizzBuzz(in2);
            Console.Write("\n");

            Console.WriteLine("LargestPrimePalindrome");
            int num1 = 101;
            int num2 = 1000;

            var lpp1 = new LargestPrimePalindrome(num1);
            // this should be a palindrome
            if (lpp1.isPalindrome(num1)) { Console.WriteLine("Should be Palindrome Passed"); }
            else { Console.WriteLine("Should be Palindrome Failed"); }

            var lpp2 = new LargestPrimePalindrome(num2);
            Console.WriteLine(lpp2.LargestPP);

            Console.WriteLine();
            Console.WriteLine("Sum of Primes Test");
            var sop = new SumofPrimes(1000);
            Console.WriteLine("Sum : {0}", sop.Sum());

            Console.WriteLine();
            Console.WriteLine("Reverse Words Test");
            var rw = new ReverseWords("Hello World");
            Console.WriteLine("{0}", rw.ReversedWords);
        }
         
     
    }
}
