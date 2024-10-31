using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCs
{
    internal class Length_Last_Word
    {
        public int LengthOfLastWord(string s)
        {
            int count = 0;
            bool startCount = false;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ' && startCount == true)
                {
                    return count;
                }
                else if (s[i] != ' ')
                {
                    startCount = true;
                    count ++;
                }
                else
                {
                    count = 0;
                }
            }
            return count;
        }
    }
}
