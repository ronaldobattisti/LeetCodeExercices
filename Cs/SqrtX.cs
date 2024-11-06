using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCs
{
    internal class SqrtX
    {
        public int MySqrt(int x)
        {
            const int maxValue = 46341;
            int actual = 0;
            long next = 0;
            int i = 0;
            do
            {
                actual = i * i;
                next = (i + 1) * (i + 1);
                if (next > x || i == maxValue - 1)
                {
                    return i;
                }
                i++;
            } while (x >= actual);
            return 0;
        }
    }
}
