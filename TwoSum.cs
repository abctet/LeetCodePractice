using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    public static class TwoSum
    {
        /*
         Time Complexity: O(n)
         Space Complexity: O(n)
         */
        public static int[] TwoSumOS(int[] nums, int target)
        {
            Dictionary<int, int> d = new Dictionary<int, int> { };
            for (int i = 0; i < nums.Length; i++)
            {
                var o2 = target - nums[i];
                if (d.TryGetValue(o2, out int x))
                {
                    return new int[] { x, i };
                }

                if (!d.TryGetValue(nums[i], out _))
                { 
                    d.Add(nums[i], i); 
                }
            }
            return null;
        }

        /*
         Time Complexity: O(n2)
         Space Complexity: O(1)
         */
        public static int[] TwoSumUO(int[] nums, int target)
        {
            int[] res = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                //int[] subarr = nums.Skip(i+1).ToArray();
                int testsum = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    var r2 = testsum + nums[j];
                    if (r2 == target)
                    {
                        res[0] = i;
                        res[1] = j;
                        return res;
                    }
                }
            }
            return res;
        }
    }
}
