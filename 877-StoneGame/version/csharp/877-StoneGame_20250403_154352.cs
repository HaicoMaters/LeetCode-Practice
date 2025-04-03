// Last updated: 03/04/2025, 15:43:52
public class Solution {
    public bool StoneGame(int[] piles) {
        int n = piles.Length;
        int[,] dp = new int[n, n];

        for (int i = 0; i < n; i++) {
            dp[i, i] = piles[i];    
        }

        for (int d = 1; d < n; d++) { // d is the difference between i and j
            for (int i = 0; i < n - d; i++) {
                int j = i + d;
                dp[i, j] = Math.Max(piles[i] - dp[i + 1, j], piles[j] - dp[i, j - 1]);
            }
        }

        return dp[0, n - 1] > 0;
    }
}
