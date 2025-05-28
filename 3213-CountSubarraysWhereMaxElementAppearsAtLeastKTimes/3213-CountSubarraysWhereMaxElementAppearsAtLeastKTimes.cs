// Last updated: 28/05/2025, 13:14:06
public class Solution {
    public long CountSubarrays(int[] nums, int k) {

        int L = 0;
        long subarrays = 0;
        int maxElement = 0; // nums[i] >= 1
        long maxOccur = 0; // num of occurances of max element in current window

        foreach (int num in nums)
        {
            maxElement = Math.Max(maxElement, num);
        }

        for (int R = 0; R < nums.Length; R++)
        {
            if (nums[R] == maxElement)
            {
                maxOccur++;
            }

            while(maxOccur >= k) // shrink window from left
            {
                subarrays += nums.Length - R; // All subarrays ending at or after r
                if (nums[L] == maxElement)
                {
                    maxOccur--;
                }
                L++;
            }
        }

        return subarrays;
    }
}