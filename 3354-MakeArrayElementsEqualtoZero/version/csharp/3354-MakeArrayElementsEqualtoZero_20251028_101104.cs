// Last updated: 28/10/2025, 10:11:04
public class Solution {
    public int CountValidSelections(int[] nums) {
        int n = nums.Length;
        int count = 0;
        int sum = nums.Sum();
        int leftSum = 0;
        int rightSum = sum;

        for (int i  = 0; i < n; i++)
        {
            if (nums[i] != 0)
            {
                leftSum += nums[i];
                rightSum -= nums[i];
                continue;
            }

            if (leftSum == rightSum || leftSum == rightSum + 1)
            {
                count++;
            }

            if (rightSum == leftSum || rightSum == leftSum + 1)
            {
                count++;
            }
        }

        return count;
    }
}