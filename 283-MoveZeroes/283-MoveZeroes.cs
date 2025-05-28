// Last updated: 28/05/2025, 13:17:35
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