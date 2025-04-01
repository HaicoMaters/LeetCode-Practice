// Last updated: 01/04/2025, 16:36:51
public class Solution {
    public bool PredictTheWinner(int[] nums) {
        int n = nums.Length;

        int[,] dp = new int[n, n]; // max score difference between two players

        for (int i = 0; i < n; i++)
        {
            dp[i, i] = nums[i];
        }

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < n - i; j++)
            {
                int k = i + j;
                // Calculate the maximum score difference if Player 1 chooses nums[j] or nums[k]
                dp[j, k] = Math.Max(nums[j] - dp[j + 1, k], nums[k] - dp[j, k - 1]);
            }
        }

        // If dp[0, n-1] is greater than or equal to 0, Player 1 can win the game
        return dp[0, n-1] >= 0;
    }
}