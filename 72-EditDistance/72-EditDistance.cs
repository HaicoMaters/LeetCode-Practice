// Last updated: 28/05/2025, 13:18:32
public class Solution {
    public int MinDistance(string word1, string word2) {
        int n = word1.Length, m = word2.Length;
        int[,] dp = new int[n + 1, m + 1]; // dp[i, j] min # of operations to convert word1[0..i) to word2[0..j)

        for (int i = 0; i <= n; i++) // If word2 is empty remove all
        {
            dp[i, 0] = i;
        }

        for (int j = 0; j <= m; j++) // If word1 is empty insert all
        {
            dp[0, j] = j;
        }

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= m; j++)
            {
                if(word1[i-1] == word2[j-1])
                {
                    dp[i, j] = dp[i - 1, j - 1]; // No change needed
                }
                else
                {   
                    //Replace: add 1 operation to [i-1, j-1]
                    //Delete: add 1 operation to dp[i - 1, j]
                    //Insert: add 1 operation dp[i, j - 1] 
                    dp[i, j] = 1 + Math.Min(dp[i - 1, j - 1], Math.Min(dp[i - 1, j], dp[i, j - 1]));
                }
            }
        }

        return dp[n, m];
    }
}