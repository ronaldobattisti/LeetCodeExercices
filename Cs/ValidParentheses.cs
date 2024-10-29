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
            if (s.Length > 1)
            {
                string[] pairs = { "()", "[]", "{}" };
                bool boolstatus = false;
                int i = 0;
                do
                {
                    foreach (string item in pairs)
                    {
                        if (s.Contains(item))
                        {
                            boolstatus = true;
                            s = removeValid(s, item);
                            i = 0;
                        }
                    }
                    i++;
                } while (boolstatus == true && i < s.Length);

                if (s.Length == 0)
                {
                    return true;
                }
                else return false;
            }
            else 
            {  
                return false; 
            }
        }

        public string removeValid(string s, string item)
        {
            List<string> sList = new List<string>();
            int cutIndex = 0;
            cutIndex = s.IndexOf(item, 0);
            sList = s.Select(c => c.ToString()).ToList();
            sList.RemoveRange(cutIndex, 2);
            s = String.Join("", sList);
            return s;
        }
    }
}
