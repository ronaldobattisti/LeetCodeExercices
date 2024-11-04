using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCs
{
    internal class Add_Binary
    {
        public string AddBinary(string a, string b)
        {
            int aInt = BinaryToInt(a);
            int bInt = BinaryToInt(b);
            int sum = aInt + bInt;
            string resultInv = "";
            string result = "";

            while (sum > 0)
            {
                resultInv += char.Parse((sum % 2).ToString());
                sum = sum / 2;
            }
            for (int i = resultInv.Length - 1; i >= 0; i--)
            {
                result += resultInv[i];
            }
            if (result != "")
            {
                return result;
            }
            else return "0";
        }

        public int BinaryToInt(string bin)
        {
            int result = 0;
            int target = bin.Length - 1;
            int pow = 0;
            int mult = 0;
            for (int i = target; i >= 0; i--)
            {
                pow = target - i;
                mult = int.Parse(bin[i].ToString());
                result += (int)Math.Pow((double)2, pow) * mult;
            }
            return result;
        }
    }
}
