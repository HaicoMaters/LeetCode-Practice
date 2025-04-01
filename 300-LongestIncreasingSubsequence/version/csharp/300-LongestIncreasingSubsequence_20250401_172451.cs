// Last updated: 01/04/2025, 17:24:51
public class Solution {
    public int LengthOfLIS(int[] nums) {
        int n = nums.Length;
        if (n == 0) return 0;

        int[] dp = new int[n];

        for (int i = 0; i < n; i++)
        {
            dp[i] = 1;
        }

        int longest = 1;

        for (int i = 1; i < n; i++)
        {
            for (int j = i -1; j >= 0; j--)
            {
                if (nums[i] > nums[j])
                {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }
            longest = Math.Max(dp[i], longest);
        }
        
        return longest;
    }
}