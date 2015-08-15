using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEvalHard
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = "XMJYAUZ;MZJAWXU";
            //var expected = "MJAU";

            LCS longestSequence = new LCS(input1);

            Console.WriteLine("{0}", longestSequence.LongestCommonSequence);

        }
    }
}
