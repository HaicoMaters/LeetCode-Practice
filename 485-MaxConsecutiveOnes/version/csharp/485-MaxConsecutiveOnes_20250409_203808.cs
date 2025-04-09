// Last updated: 09/04/2025, 20:38:08
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