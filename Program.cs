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
            /*int[] sums = { 3,2,3 };
            int target = 6;
            var r = TwoSum(sums,target);
            Array.ForEach(r, Console.WriteLine);*/

            //IsPalindrome variables
            /*int x = 11;
            var res = IsPalindrome(x);
            Console.WriteLine(res);*/

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
            
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] res = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                //int[] subarr = nums.Skip(i+1).ToArray();
                int testsum = nums[i];
                for (int j = i+1; j < nums.Length; j++)
                {
                    var r2 = testsum+nums[j];
                    if (r2==target)
                    {
                        res[0] = i;
                        res[1] = j;
                        return res;
                    }
                }
            }
            return res;
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
