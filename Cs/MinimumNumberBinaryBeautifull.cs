using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCs
{
    internal class MinimumNumberBinaryBeautifull
    {
        public int MinChanges(string s)
        {
            int cont = 0;
            bool isValid = false;
            for (int i = 1; i <= s.Length - 1; i = i + 2)
            {
                isValid = (s[i - 1] == '0' && s[i] == '0') || (s[i - 1] == '1' && s[i] == '1');
                if (isValid == false)
                {
                    cont++;
                }
            }
            return cont;
        }
    }
}
