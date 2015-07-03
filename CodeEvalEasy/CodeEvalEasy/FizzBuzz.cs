using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEvalEasy
{
    class FizzBuzz
    {
        private int X;
        private int Y;
        private int N;
        private string[] nums = new string[3];

        public FizzBuzz(string input)
        {
           
            nums = input.Split(' ');
            Int32.TryParse(nums[0], out X);
            Int32.TryParse(nums[1], out Y);
            Int32.TryParse(nums[2], out N);

            for (int i = 1; i <= N; i++)
            {
                var fb = new StringBuilder();

                bool b = false;
                if (i % X == 0)
                {
                    fb.Append("F");
                    b = true;
                }
                if (i % Y == 0)
                {
                    fb.Append("B");
                    b = true;
                }
                if (!b) { fb.Append(i); }

                if (i == N) { Console.Write("{0}", fb); }
                else { Console.Write("{0} ", fb); }

            }

        }
    }
}
