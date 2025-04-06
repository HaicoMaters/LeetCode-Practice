// Last updated: 06/04/2025, 14:43:26
public class Solution {
    public void MoveZeroes(int[] nums) {
        int n = nums.Length;
        int nonzero = 0;

        for (int i = 0; i < n; i++)
        {
            if (nums[i] != 0)
            {
                int temp = nums[i];
                nums[i] = nums[nonzero];
                nums[nonzero] = temp;
                nonzero++;
            }
        }
    }
}