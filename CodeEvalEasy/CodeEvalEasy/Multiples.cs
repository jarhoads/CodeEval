using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEvalEasy
{
    class Multiples
    {
        private int smallestMultiple;

        public int SmallestMultiple
        {
            get { return smallestMultiple; }
            set { smallestMultiple = value; }
        }

        public Multiples(int x, int n)
        {
            int m = 1;

            for (int i = 0; (i * n) < x; i++)
            {
                m = i;
            }

            //if ((m * n) == x) 
            //{ 
            //    this.SmallestMultiple = m * n; 
            //}
            //else 
            //{ 
                m++;
                this.SmallestMultiple = m * n;
            //}

            
        }
    }
}
