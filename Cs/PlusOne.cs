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
            int number = 0;
            int mult = digits.Length;
            for (int i = 0; i < digits.Length; i++)
            {
                number += Pow(digits[i], digits.Length-1-i);
            }
            number += 1;
            int[] ret = new int[number.ToString().Length];
            int nLen = number.ToString().Length;
            for (int i = 0; i < number.ToString().Length; i++)
            {
                ret[i] = (int)Math.Floor(number / nLen);
            }
            return digits;
        }

        public int Pow(int number, int pow)
        {
            for (int i = 1; i<= pow; i++)
            {
                number = number * 10;
            }
            return number;
        }

        
    }
}
