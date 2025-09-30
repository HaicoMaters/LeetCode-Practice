// Last updated: 30/09/2025, 13:29:13
public class Solution {
    public int TriangularSum(int[] nums) {
        int n = nums.Length;

        for (int size = n; size > 1; size--) // the length of each row (decreasing each depth by 1)
        {
            for (int i = 0; i < size - 1; i++)
            {
                nums[i] = (nums[i] + nums[i+1]) % 10;
            }
        }

        return nums[0];
    }
}