// Last updated: 17/07/2025, 19:40:16
public class Solution {
    public int MaximumLength(int[] nums, int k) {

        int maxLength = 0;

        for (int i = 0; i < k; i++)
        {
            int[] dp = new int[k];
            foreach (int num in nums)
            {
                int mod = num % k;
                int prev = (i - mod + k) % k; // prev remainder that is valid
                dp[mod] = dp[prev] + 1;
                maxLength = Math.Max(maxLength, dp[mod]);
            }
        }

        return maxLength;
    }
}