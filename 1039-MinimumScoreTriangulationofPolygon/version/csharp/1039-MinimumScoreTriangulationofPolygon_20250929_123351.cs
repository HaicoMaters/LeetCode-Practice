// Last updated: 29/09/2025, 12:33:51
public class Solution {
    public int MinScoreTriangulation(int[] values) {
        int n = values.Length;
        int[,] dp = new int[n,n]; // the min scores

        for (int len = 2; len < n; len++)
        {
            for (int i = 0; i < n - len; i++)
            {
                int j = i + len;
                dp[i,j] = int.MaxValue;

                for (int k = i + 1; k < j; k++)
                {
                    int score = values[i] * values[j] * values[k] + dp[i,k] + dp[k,j];
                    dp[i,j] = Math.Min(dp[i,j], score);
                }
            }
        }

        return dp[0,n-1];
    }
}