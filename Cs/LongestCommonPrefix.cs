using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCs
{
    internal class Longest_Common_Prefix
    {
        public string LongestCommonPrefix(string[] list)
        {
            if (list.Length > 1)
            {
                string prefix = "";
                int strLen = 0;
                string lowerString = "";
                foreach (string str in list)
                {
                    if (str.Length > strLen)
                    {
                        lowerString = str;
                    }
                }

                for (int i = 0; i < lowerString.Length; i++)
                {
                    prefix += lowerString[i].ToString();
                    foreach (var item in list)
                    {
                        if (!item.StartsWith(prefix))
                        {
                            return prefix.Substring(0, prefix.Length - 1);
                        }
                    }
                }
                return prefix;
            }
            return list[0];
        }
    }
}
