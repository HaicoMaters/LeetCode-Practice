// Last updated: 10/11/2026, 07:33:39
1public class Solution {
2    public int ClimbStairs(int n, int[] costs) {
3        int[] dp = new int[n+1];
4        Array.Fill(dp, int.MaxValue);
5        dp[0] = 0;
6        
7        for (int i = 1; i <= n; i++)
8        {
9            for (int j = 1; j <= 3; j++)
10            {
11                if (i-j < 0) break;
12                dp[i] = Math.Min(dp[i], dp[i-j] + costs[i-1] + (j*j));
13            }
14        }
15
16        return dp[n];
17    }
18}