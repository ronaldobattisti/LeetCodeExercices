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
            int result = 4;
            int before = 3;
            if (n <= 3)
            {
                return n;
            }
            else if (n == 4)
            {
                return 5;
            }
            for (int i = 5; i > n; i++)
            {

                result = result + i + before;
                //result += i-1;
            }
            return before;
        }
    }
}
