using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace CodeEvalEasy
{
    class ReverseWords
    {
        private List<String> words;
        private string reversedWords;
        
        public string ReversedWords
        {
            get { return reversedWords; }
            set { reversedWords = value; }
        }

        public ReverseWords(string s)
        {
            if (!s.Equals(""))
            {
                this.words = s.Split(' ').ToList<String>();
                
                var reversed = new StringBuilder();
                bool first = true;
                foreach(string w in words.Reverse<String>())
                {
                    if (first)
                    {
                        first = false;
                        reversed.Append(w);
                    }
                    else
                    {
                        reversed.Append(" ");
                        reversed.Append(w);
                    }
                    
                }

                this.ReversedWords = reversed.ToString();
            }
        }

    }
}
