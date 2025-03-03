public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int n = nums.Length;
        int length = n + 1;
        int L = 0;
        int currentSum = 0;

        for (int R = 0; R < n; R++)
        {
            currentSum += nums[R];

            while (currentSum >= target)
            {
                length = Math.Min(length, R - L + 1);
                currentSum -= nums[L];
                L++;
            }
        }

        return (length > n) ? 0 : length;
    }
}