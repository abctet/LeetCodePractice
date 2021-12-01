using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    public static class MaxSubArray
    {
        /*
         Find a contiguous subarray with the largest sum, within a given one-dimensional array

         Dynamic Programming, Kadane's Algorithm
         */
        public static int MaxSubArrayOS(int[] nums)
        {
            int globalMax = nums[0], localMax = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                localMax = Math.Max(nums[i],localMax+nums[i]);
                globalMax = Math.Max(localMax,globalMax);
            }
            return globalMax;
        }

        /*
         Time Complexity: O(n2)
         Space Complexity: O(1)
         */
        public static int MaxSubArrayBruteForce(int[] nums)
        {
            int globalMax = int.MinValue;
            for(int i=0; i<nums.Length;i++)
            {
                int localMax = nums[i];
                for(int j=i+1; j<nums.Length;j++)
                {
                    localMax += nums[j];
                    if(localMax>globalMax)
                    { globalMax = localMax; }
                }
            }
            return globalMax;
        }        

    }
}
