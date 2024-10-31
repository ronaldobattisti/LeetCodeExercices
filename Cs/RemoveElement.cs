using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCs
{
    internal class Remove_Element
    {
        public int RemoveElement(int[] nums, int val)
        {
            int pointer = 0;
            int[] temp = (int[])nums.Clone();
            Array.Fill(nums, 0);

            //rearange values in nums array
            pointer = 0;
            foreach (int item in temp)
            {
                if (item != val)
                {
                    nums[pointer] = item;
                    pointer++;
                }
            }
            return pointer;
        }
    }
}
