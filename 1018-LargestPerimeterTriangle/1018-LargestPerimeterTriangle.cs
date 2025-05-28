// Last updated: 28/05/2025, 13:15:49
public class Solution {
    public int LargestPerimeter(int[] nums) {
        if (nums.Length < 3) return 0;
        // To form a valid triangle the largest edge must be less than the sum of the two other edges

        Array.Sort(nums);

        for (int i = nums.Length - 1; i >= 2; i--) {
            if (nums[i] < nums[i - 1] + nums[i - 2]) { 
                return nums[i] + nums[i - 1] + nums[i - 2];
            }
        }

        return 0;
    }
}