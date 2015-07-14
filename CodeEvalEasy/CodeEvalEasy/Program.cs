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

            Console.WriteLine();
            Console.WriteLine("Multiples test");
            var m1 = new Multiples(1895, 128);
            var m2 = new Multiples(1030, 16);
            var m3 = new Multiples(1795, 32);
            var m4 = new Multiples(1705, 1024);
            var m5 = new Multiples(1751, 64);
            var m6 = new Multiples(1705, 8);
            var m7 = new Multiples(1257, 2);
            var m8 = new Multiples(1343, 256);
            var m9 = new Multiples(1569, 512);
            var m10 = new Multiples(1214, 4);

            //var m1 = new Multiples(13,8);
            Console.WriteLine("Multiple : {0}", m1.SmallestMultiple);
            //var m2 = new Multiples(17, 16);
            Console.WriteLine("Multiple : {0}", m2.SmallestMultiple);
            Console.WriteLine("Multiple : {0}", m3.SmallestMultiple);
            Console.WriteLine("Multiple : {0}", m4.SmallestMultiple);
            Console.WriteLine("Multiple : {0}", m5.SmallestMultiple);
            Console.WriteLine("Multiple : {0}", m6.SmallestMultiple);
            Console.WriteLine("Multiple : {0}", m7.SmallestMultiple);
            Console.WriteLine("Multiple : {0}", m8.SmallestMultiple);
            Console.WriteLine("Multiple : {0}", m9.SmallestMultiple);
            Console.WriteLine("Multiple : {0}", m10.SmallestMultiple);

            Console.WriteLine();
            Console.WriteLine("Bit Positions Test");
            var bp = new BitPositions(86, 2, 3);
            Console.WriteLine("{0}",bp.isSameBitPosition());
            var bp2 = new BitPositions(125, 1, 2);
            Console.WriteLine("{0}", bp2.isSameBitPosition());
        }

         
     
    }
}
