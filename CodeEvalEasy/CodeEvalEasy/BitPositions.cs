using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEvalEasy
{
    class BitPositions
    {
        private int n;
        private uint p1;
        private uint p2;

        public BitPositions(int N, uint pos1, uint pos2)
        {
            this.n = N;
            this.p1 = pos1;
            this.p2 = pos2;
        }

        /*
         * I feel like there is probably a better way to do this. 
         * this is what i came up with though
        */
        public bool isSameBitPosition()
        {
            // set the bits in the locations
            int bit1 = IntPow(2, (p1 - 1)); 
            int bit2 = IntPow(2, (p2 - 1));

            // find out what the values are
            int bit1AndN = bit1 & n;
            int bit2AndN = bit2 & n;

            return (bit1AndN > 0 && bit2AndN > 0) || (bit1AndN == 0 && bit2AndN == 0);

        }

        private int IntPow(int x, uint pow)
        {
            int ret = 1;
            while (pow != 0)
            {
                if ((pow & 1) == 1)
                    ret *= x;
                x *= x;
                pow >>= 1;
            }
            return ret;
        }
    }
}
