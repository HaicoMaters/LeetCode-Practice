// Last updated: 20/11/2025, 13:00:55
public class Solution {
    public double MinimumAverage(int[] nums) {
        Array.Sort(nums);
        int n = nums.Length;
        double minAvg = (double)(nums[0] + nums[n-1]) / 2;

        for (int i = 1; i < n / 2; i++)
        {
            minAvg = Math.Min(minAvg, (double)(nums[i] + nums[n-i-1]) / 2);
        }

        return minAvg;
    }
}