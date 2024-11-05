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
            string sL = "";
            string sB = "";
            string zeros = "";
            string strSum = "";
            int intSum = 0;
            int size = 0;
            bool rest = false;
            if (a.Length >= b.Length)
            {
                size = a.Length;
                sB = a;
                sL = b;

            }
            else
            {
                size = b.Length;
                sB = b;
                sL = a;
            }
            while (sL.Length + zeros.Length < sB.Length)
            {
                zeros += '0';
            }
            sL = zeros + sL;

            for (int i = sL.Length - 1; i>= 0; i--)
            {
                intSum = int.Parse(sL[i].ToString()) + int.Parse(sB[i].ToString());
                if (intSum == 0 && rest == false)
                {
                    strSum += '0';
                } else if (intSum == 0 && rest == true)
                {
                    strSum += "1";
                    rest = false;
                } else if (intSum == 1 && rest == false)
                {
                    strSum += '1';
                } else if (intSum == 1 && rest == true)
                {
                    strSum += '0';
                    rest = true;
                }
                else if (intSum > 1 && rest == false)
                {
                    strSum += '0';
                    rest = true;
                }
                else if (intSum > 1 && rest == true)
                {
                    strSum += '1';
                    rest = true;
                }
            }
            if (rest == true)
            {
                strSum += '1';
            }
            string resultInverted = "";
            for (int i = strSum.Length - 1; i>=0; i--)
            {
                resultInverted += strSum[i];
            }

            return resultInverted;

            }
        }
}
