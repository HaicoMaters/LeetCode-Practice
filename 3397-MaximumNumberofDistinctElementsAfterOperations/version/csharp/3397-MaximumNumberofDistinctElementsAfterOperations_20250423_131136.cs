// Last updated: 23/04/2025, 13:11:36
public class Solution {
    public int MaxDistinctElements(int[] nums, int k) {
        Array.Sort(nums); // Sort so can easily get what to add
        HashSet<int> distinctElements = new HashSet<int>();
        int current = nums[0] - k;
        distinctElements.Add(current);

        for (int i = 1; i < nums.Length; i++)
        {
            // Max of the minimum since the last element and the lowest the num can go 
            current = Math.Max(Math.Min(current + 1, nums[i] + k), nums[i] - k);
            if (current <= nums[i] + k) distinctElements.Add(current);
        }

        return distinctElements.Count;
    }
}