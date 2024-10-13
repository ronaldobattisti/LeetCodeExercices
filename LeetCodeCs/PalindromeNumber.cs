using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCs
{
    internal class Palindrome_Number
    {
        public bool PalindromeNumber(int number)
        {
            string value = number.ToString();
            bool isPalindrome = true;
            Console.WriteLine(value + value.GetType());
            for (int i = 0; i < value.Length; i++)
            {
                int j = value.Length - i - 1;
                char vi = value[i];
                char vj = value[j];
                Console.WriteLine($"i={vi}|j={vj}");
                if (vi != vj)
                {
                    isPalindrome = false;
                    return isPalindrome;
                }
            }
            return isPalindrome;
        }
    }
}
