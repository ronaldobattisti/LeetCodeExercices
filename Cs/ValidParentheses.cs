using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCs
{
    internal class Valid_Parentheses
    {
        public bool ValidParentheses(string s)
        {
            string[] closings = { "()", "[]", "{}" };
            int cropIndex = 0;
            for (int i = 0; i < s.Length; i++)
            {
                foreach (string item in closings)
                {
                    if (s.Contains(item))
                    {
                        cropIndex = s.IndexOf(item, 0);
                        s.Remove(cropIndex);
                        s.Remove(cropIndex);
                    }
                }
            }
            if (s.Length > 0)
            {
                return false;
            }
            else return true;
        }
    }
}
