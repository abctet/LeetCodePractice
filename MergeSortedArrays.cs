using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    public static class MergeSortedArrays
    {
        /*
         Time Complexity: O(n+m)
         Space Complexity: O(1)
         */
        public static void MergeSortedArraysOS(int[] nums1, int m, int[] nums2, int n)
        {
            int l = m + n - 1;
            m -= 1;
            n -= 1;
            for (int i = l; i >= 0; i--)
            {
                if (n < 0)
                {
                    break;
                }
                if (m >= 0 && nums1[m] > nums2[n])
                {
                    nums1[i] = nums1[m];
                    m--;
                }
                else
                {
                    nums1[i] = nums2[n];
                    n--;
                }
            }
        }
    }
}
