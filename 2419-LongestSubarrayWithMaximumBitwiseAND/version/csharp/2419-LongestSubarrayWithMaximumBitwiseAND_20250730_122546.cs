// Last updated: 30/07/2025, 12:25:46
public class Solution {
    public int LongestSubarray(int[] nums) {

        int maxLength = 0;
        int maxAnd = 0;
        int length = 0;

        foreach(int num in nums) // max AND is just the max number in the subarray
        {
            if (num > maxAnd) maxAnd = num;
        }

        foreach (int num in nums) // get the longest subarray of the max AND
        {
            if (num == maxAnd)
            {
                length++;
                maxLength = Math.Max(maxLength, length);
            }
            else
            {
                length = 0;
            }
        }

        return maxLength;
    }
}