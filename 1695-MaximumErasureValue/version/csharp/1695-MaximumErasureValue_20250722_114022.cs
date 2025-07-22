// Last updated: 22/07/2025, 11:40:22
public class Solution {
    public int MaximumUniqueSubarray(int[] nums) {
        int max = 0;
        int current = 0;
        int l = 0;
        HashSet<int> seen = new HashSet<int>();

        for (int r = 0; r < nums.Length; r++)
        {
            while (seen.Contains(nums[r]))
            {
                seen.Remove(nums[l]);
                current -= nums[l];
                l++;
            }

            current += nums[r];
            max = Math.Max(max, current);
            seen.Add(nums[r]);
        }

        return max;
    }
}