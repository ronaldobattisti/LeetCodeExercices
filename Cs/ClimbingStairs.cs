using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCs
{
    internal class Climbing_Stairs
    {
        public int ClimbStairs(int n)
        {
            int m2 = 0;
            int m1 = 0;
            int ans = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    ans = 1;
                }
                else if (i == 2)
                {
                    m1 = ans;
                    ans = 2;
                }
                else
                {
                    m2 = m1;
                    m1 = ans;
                    ans = m1 + m2;
                }
            }
            return ans;
        }
    }
}
