using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    public static class DynamicProgramming_Fibonacci
    {
        //Find the Nth number of a Fibonacci series
        //1, 1, 2, 3, 5, 8, 13, 21, 34

        public static int FibonacciNthNumber_Recursion_DP(int n)
        {
            Dictionary<int, int> d = new Dictionary<int, int> { };
            return FibonacciNthNumber_Recursion_DP(n, d);
        }

        /* Dynamic Programming - Memoization
         Time Complexity: O(n)
         Space Complexity: O(n)        
         */
        public static int FibonacciNthNumber_Recursion_DP(int n, Dictionary<int,int> memo)
        {
            if (n <= 2)
                return 1;

            if (memo.ContainsKey(n))
                return memo[n];
            else
                memo.Add(n, FibonacciNthNumber_Recursion_DP(n-1, memo) + FibonacciNthNumber_Recursion_DP(n - 2, memo));
            
            return memo[n];
        }


        /*
         Time Complexity: O(n2)
         Space Complexity: O(n)        
         */
        public static int FibonacciNthNumber_Recursion(int n)
        {
            if(n<=2)
            { return 1; }
            return FibonacciNthNumber_Recursion(n - 1) + FibonacciNthNumber_Recursion(n - 2);
        }
    }
}
