// Last updated: 24/08/2026, 09:56:48
1public class Solution {
2    public int StoneGameVIII(int[] stones) {
3        int n = stones.Length;
4        int[] dp = new int[n];
5        dp[0] = stones[0];
6
7        for (int i = 1; i < n; i++)
8        {
9            dp[i] = dp[i-1] + stones[i];
10        }
11
12        int scoreDiff = dp[n-1];
13
14        for (int i = n - 2; i >= 1; i--)
15        {
16            scoreDiff = Math.Max(scoreDiff, dp[i] - scoreDiff);
17        }
18
19        return scoreDiff;
20    }
21}