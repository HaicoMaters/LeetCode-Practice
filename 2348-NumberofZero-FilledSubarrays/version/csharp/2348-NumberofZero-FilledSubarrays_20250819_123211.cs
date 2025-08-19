// Last updated: 19/08/2025, 12:32:11
public class Solution {
    public long ZeroFilledSubarray(int[] nums) {
        long subarrays = 0;
        int streak = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)// (sums as k*(k+1)/2) (where k is the length of the streak)
            {
                streak++;
                subarrays += streak;
            }
            else
            {
                streak = 0;
            }
        }

        return subarrays;
    }
}