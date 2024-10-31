using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCs
{
    internal class Find_Index_First_Occurence
    {
        public int StrStr(string haystack, string needle)
        {
            //int occurences = 0;
            int nLeng = needle.Length;
            if (haystack == needle)
            {
                return 0;
            }
            for (int i = 0; i < haystack.Length - nLeng + 1; i++)
            {
                int range = i + nLeng;
                if (/*needle.Length == 1 && */needle == haystack[i].ToString())
                {
                    return i;
                }
                else if (haystack[i..range].ToString() == needle && needle.Length > 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
