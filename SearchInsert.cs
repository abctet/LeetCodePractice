using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    public static class SearchInsert
    {
        /*
         Time Complexity: O(log n)
         Space Complexity: O(1)
         */
        public static int SearchInsertOS(int[] nums, int target)
        {
            int right = nums.Length - 1;
            int left = 0;
            while (left <= right)
            {
                int mid = (right + left) / 2;

                if (target > nums[mid])
                { left = mid + 1; }
                else if (target < nums[mid])
                { right = mid - 1; }
                else { return mid; }
            }
            return left;
        }
    }
}
