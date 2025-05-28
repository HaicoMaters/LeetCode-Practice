// Last updated: 28/05/2025, 13:14:27
public class Solution {
    public int LongestNiceSubarray(int[] nums) {
        // None of the bits have 1 in the same position mask = nums i ^ nums i + 1 compare mask to 
        int mask = 0;
        int longest = 0;
        int currentLength = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if ((mask & nums[i]) == 0) mask |= nums[i]; // Nice number continue and add to mask (|= same as += here)
            else
            {
                longest = Math.Max(currentLength, longest);
                // Remove old numbers in subarray until makes a nice number with nums[i]
                while ((mask & nums[i]) != 0 && currentLength > 0)
                {
                    mask ^= nums[i - currentLength]; // (^= same as -= here)
                    currentLength--;
                }
                if (currentLength == 0) mask = nums[i]; // No nice numbers start from nums[i] as first number in subarray
            }
            currentLength++;
        }
        return Math.Max(currentLength, longest);
    }
}