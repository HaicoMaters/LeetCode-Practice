// Last updated: 26/09/2025, 14:26:19
public class Solution {
    public int TriangleNumber(int[] nums) {
        // side1 + side2 > largestSide;
        Array.Sort(nums);
        int n = nums.Length;
        int count = 0;

        for (int i = n - 1; i >= 2; i--)
        {
            int left = 0;
            int right = i - 1;
            int num = nums[i];

            while (left < right)
            {
                if (nums[left] + nums[right] > num)
                {
                    count += right - left; // all using current right value will be within range
                    right--;
                }
                else
                {
                    left++;
                }
            }
        }

        return count;
    }
}