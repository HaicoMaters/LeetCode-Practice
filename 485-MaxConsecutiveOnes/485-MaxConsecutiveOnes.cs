// Last updated: 28/05/2025, 13:16:30
public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int max = 0;
        int current = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                current++;
                max = Math.Max(current, max);
            }
            else
            {
                current = 0;
            }

            
        }

        return max;
    }
}