using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //TwoSum variables
            /*int[] nums = { 2, 7, 11, 15, 3 };
            int target = 10;
            var r = TwoSum.TwoSumOS(nums, target);
            Array.ForEach(r, Console.WriteLine);*/

            //SearchInsert
            /*int[] nums = { 1, 3, 5, 6 };
            int target = 6;
            Console.WriteLine(SearchInsert.SearchInsertOS(nums,target));*/

            //Merge Sorted Arrays
            /*int[] nums1 = { 3, 5, 0, 0, 0, 0 }, nums2 = { 1, 2, 6, 7};
            int m = 2, n = 4;
            MergeSortedArrays.MergeSortedArraysOS(nums1, m, nums2, n);
            Array.ForEach(nums1, Console.WriteLine);*/

            //Max Sub Array
            /*int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            var res = MaxSubArray.MaxSubArrayOS(nums);
            Console.WriteLine(res);*/

            //Nth number of a Fibonacci series
            Console.WriteLine(DynamicProgramming_Fibonacci.FibonacciNthNumber_Recursion_DP(9));

            //IsPalindrome variables
            /*int x = 11;
            var res = IsPalindrome(x);
            Console.WriteLine(res);*/

            /*
            //RomanToInt variables
            while (true)
            {
                Console.WriteLine("Enter a Roman Numeral");
                string s = Console.ReadLine();
                if (s.ToLower()=="exit")
                {
                    break;
                }
                var res = RomanToInt(s);
                Console.WriteLine(res);
            }
            */

        }

        public static bool IsPalindrome(int x)
        {
            bool res = true;
            string s = x.ToString();

            if (x<0)
            {
                res = false;
            }
            else
            {
                for (int i = 0; i < s.Length/2; i++)
                {
                    int endindex = s.Length - (i+1);
                    if (s[i] != s[endindex])
                    {
                        res = false;
                        return res;
                    }
                }
            }
            return res;
        }

        public static int RomanToInt(string s)
        {
            int res = 0;
            Dictionary<string, int> dict = new Dictionary<string, int> { {"I",1 }, { "IV", 4 }, { "V",5 }, { "IX", 9 }, { "X",10 }, { "XL", 40 }, { "L", 50 }, { "XC", 90 }, { "C", 100 }, { "CD", 400 }, { "D", 500 }, { "CM", 900 }, { "M", 1000 } };

            for (int i = 0; i < s.Length; i++)
            {
                char currval = s[i];
                char nextval='z';
                char prevval = 'a';
             
                if (i<s.Length-1)
                {
                    nextval = s[i + 1];
                }

                if (i > 0)
                {
                    prevval = s[i - 1];
                }

                if (new char[] { 'V', 'X' }.Contains(currval))
                {
                    if (prevval=='I')
                    {
                        continue;
                    }                    
                }

                if (new char[] { 'L', 'C' }.Contains(currval))
                {
                    if (prevval == 'X')
                    {
                        continue;
                    }
                }

                if (new char[] { 'D', 'M' }.Contains(currval))
                {
                    if (prevval == 'C')
                    {
                        continue;
                    }
                }

                if (currval=='I')
                {                    
                    if (nextval == 'V')
                    {
                        res += dict.GetValueOrDefault("IV");
                    }
                    else if (nextval == 'X')
                    {
                        res += dict.GetValueOrDefault("IX");
                    }
                    else
                    {
                        res += dict.GetValueOrDefault("I");
                    }
                }
                else if (currval == 'X')
                {
                    if (nextval == 'L')
                    {
                        res += dict.GetValueOrDefault("XL");
                    }
                    else if (nextval == 'C')
                    {
                        res += dict.GetValueOrDefault("XC");
                    }
                    else
                    {
                        res += dict.GetValueOrDefault("X");
                    }
                }
                else if (currval == 'C')
                {
                    if (nextval == 'D')
                    {
                        res += dict.GetValueOrDefault("CD");
                    }
                    else if (nextval == 'M')
                    {
                        res += dict.GetValueOrDefault("CM");
                    }
                    else
                    {
                        res += dict.GetValueOrDefault("C");
                    }
                }
                else
                {
                    res += dict.GetValueOrDefault(currval.ToString());
                }

            }
            return res;
        }
    }
}
