using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCs
{
    internal class Plus_One
    {
        public int[] PlusOne(int[] digits) 
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }

                digits[i] = 0;
            }

            int[] nDigits = new int[digits.Length + 1];
            nDigits[0] = 1;
            return nDigits;
        }
    }
}
