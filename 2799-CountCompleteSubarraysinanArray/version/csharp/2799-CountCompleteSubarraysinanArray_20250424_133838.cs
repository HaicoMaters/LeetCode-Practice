// Last updated: 24/04/2025, 13:38:38
public class Solution {
    public int CountCompleteSubarrays(int[] nums) {
        int subarrays = 0;
        int n = nums.Length;
        Dictionary<int, int> numCounts = new Dictionary<int, int>();
        HashSet<int> uniques = new HashSet<int>(nums);
        int distinctNums = uniques.Count;
        int l = 0;
        int r = 0;

        while (r < n)
        {
            if (!numCounts.ContainsKey(nums[r]))
            {
                numCounts[nums[r]] = 0;
            }
            numCounts[nums[r]]++;

            while (numCounts.Count == distinctNums)
            {
                subarrays += n - r;
                numCounts[nums[l]]--;
                
                if (numCounts[nums[l]] == 0)
                {
                    numCounts.Remove(nums[l]);
                }
                l++;
            }
            r++;
        }

        return subarrays;
    }
}