// Last updated: 12/06/2025, 10:27:21
public class Solution {
    public int MaxAdjacentDistance(int[] nums) {
        int n = nums.Length;
        int maxDist = Math.Abs(nums[0] - nums[n - 1]);

        for (int i = 1; i < n; i++)
        {
            maxDist = Math.Max(maxDist, Math.Abs(nums[i] - nums[i-1]));
        }

        return maxDist;
    }
}