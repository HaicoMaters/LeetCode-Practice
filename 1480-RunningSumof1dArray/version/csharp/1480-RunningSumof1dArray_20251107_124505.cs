// Last updated: 07/11/2025, 12:45:05
public class Solution {
    public int[] RunningSum(int[] nums) {
        int n  = nums.Length;
        int[] runningSum = new int[n];
        runningSum[0] = nums[0];

        for (int i = 1; i < n; i++)
        {
            runningSum[i] = runningSum[i-1] + nums[i];
        }   

        return runningSum;
    }
}