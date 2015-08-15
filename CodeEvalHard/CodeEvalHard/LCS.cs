using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEvalHard
{
    public class LCS
    {
        private string sequence1;
        private string sequence2;
        private int[,] table;

        public string FindSequence(string str1, string str2)
        {
            string sub1 = str1.Substring(0, (str1.Length - 1 < 0) ? 0 : str1.Length - 1);
            string sub2 = str2.Substring(0, (str2.Length - 1 < 0) ? 0 : str2.Length - 1);

            if (str1.Length == 0 || str2.Length == 0) { return ""; }
            else if (str1[str1.Length - 1] == str2[str2.Length - 1])
            {
                // if the last char is the same, add concat it to the string
                return FindSequence(sub1, sub2) + str1[str1.Length - 1];
            }
            else
            {
                // break it down into smaller strings to check
                string firstSeq = FindSequence(str1, sub2);
                string secondSeq = FindSequence(sub1, str2);
                return (firstSeq.Length > secondSeq.Length) ? firstSeq : secondSeq;
            }
            
        }

        /*
         * This is a classic dynamic programming question
         * I used a basic dynamic programming table to save previous values
         * and construct a string
         */
        public string FindSequenceDynamic()
        {
            int len1 = sequence1.Length;
            int len2 = sequence2.Length;

            table = new int[len1+1, len2+1];

            for (int i = 0; i <= len1; i++)
            {
                for (int j = 0; j <= len2; j++)
                {
                    if (i == 0 || j == 0) 
                    { 
                        table[i, j] = 0; 
                    }
                    else if (sequence1[i - 1] == sequence2[j - 1]) 
                    { 
                        table[i, j] = table[i - 1, j - 1] + 1; 
                    }
                    else 
                    { 
                        table[i, j] = Math.Max(table[i - 1, j], table[i, j - 1]); 
                    }
                }

            }
         
                return findSubsequence(len1, len2);
        }

        private string findSubsequence(int cell1, int cell2)
        {
            if (cell1 == 0 || cell2 == 0) 
            { 
                return ""; 
            }
            else if (sequence1[cell1-1] == sequence2[cell2-1]) 
            { 
                return findSubsequence(cell1 - 1, cell2 - 1) + sequence1[cell1-1]; 
            }
            else if (table[cell1 - 1, cell2] > table[cell1, cell2 - 1]) 
            {
                return findSubsequence(cell1 - 1, cell2);
            }
            else
            {
                return findSubsequence(cell1, cell2 - 1);
            }

        }

        private string longestCommonSequence;
        public string LongestCommonSequence
        {
            get { return longestCommonSequence; }
            // make it a private set, this will only be set by the process
            //set { longestCommonSequence = value; }
        }

        public LCS(string values)
        {
            var strings = new string[2];
            strings = values.Split(';');

            sequence1 = strings[0];
            sequence2 = strings[1];

            this.longestCommonSequence = FindSequenceDynamic();

        }

        

    }
}
