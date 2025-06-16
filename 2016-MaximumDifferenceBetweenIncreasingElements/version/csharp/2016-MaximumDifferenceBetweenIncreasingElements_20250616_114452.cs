// Last updated: 16/06/2025, 11:44:52
public class Solution {
    public int MaximumDifference(int[] nums) {
        int maxDiff = -1;
        int minNum = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] <= minNum)
            {
                minNum = nums[i];
            }
            else
            {
                maxDiff = Math.Max(maxDiff, nums[i] - minNum);
            }
        }

        return maxDiff;
    }
}