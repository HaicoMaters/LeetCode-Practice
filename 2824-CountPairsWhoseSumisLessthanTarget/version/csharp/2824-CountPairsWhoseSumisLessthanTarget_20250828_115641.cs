// Last updated: 28/08/2025, 11:56:41
public class Solution {
    public int CountPairs(IList<int> nums, int target) {
        int count = 0;

        nums = nums.OrderBy(x => x).ToList();

        int left = 0;
        int right = nums.Count -1;

        while (left < right)
        {
            if (nums[left] + nums[right] < target)
            {
                count += right-left; // all nums left of and including right are going to be less than target with current value at left
                left++;
            }
            else
            {
                right--;
            }
        }

        return count;
    }
}