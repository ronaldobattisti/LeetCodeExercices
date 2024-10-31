using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCs
{
    internal class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                //If pointer is in the first item
                if (nums.Length == 1 && target <= nums[0])
                {
                    return 0;
                }
                else if (nums.Length == 1 && target >= nums[0])
                {
                    return 1;
                }

                if (i == 0)
                {
                    //If
                    if (target > nums[i] && target <= nums[i + 1])
                    {
                        return i + 1;
                    }
                    else if (target <= nums[i])
                    {
                        return 0;
                    }
                    //If pointer is in the last item
                }
                else if (i == nums.Length - 1)
                {
                    return i + 1;
                }
                else
                {
                    if (nums[i - 1] <= target && nums[i + 1] >= target)
                    {
                        return i + 1;
                    }
                }
            }
            return 0;
        }
    }
}
