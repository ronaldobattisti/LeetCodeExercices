using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCs
{
    internal class Remove_Duplicates_From_Sorted_Array
    {
        public int RemoveDuplicates(int[] nums)
        {
            int[] numsBuf = (int[])nums.Clone();
            int pointer = 0;
            bool haveZero = false;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = 0;
            }

            foreach (int item in numsBuf)
            {
                //if item not in nums
                if (Array.IndexOf(nums, item) == -1)
                {
                    nums[pointer] = item;
                    pointer++;
                }
                else if (item == 0 && haveZero == false)
                {
                    nums[pointer] = 0;
                    pointer++;
                    haveZero = true;
                }
            }
            return pointer;
        }
    }
}
