// Last updated: 15/12/2025, 17:54:19
1public class Solution {
2    public long GetDescentPeriods(int[] prices) {
3        long streak = 0;
4        int n = prices.Length;
5        long periods = n; // count all single-element subarrays
6
7        for (int i = 0; i < n-1; i++)
8        {
9            if (prices[i] - prices[i+1] == 1)
10            {
11                streak++;
12                periods += streak;
13            }
14            else
15            {
16                streak = 0;
17            }
18        }
19
20        return periods;
21    }
22}