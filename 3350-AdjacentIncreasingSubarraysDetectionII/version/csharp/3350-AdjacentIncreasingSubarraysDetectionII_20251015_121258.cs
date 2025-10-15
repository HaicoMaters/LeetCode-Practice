// Last updated: 15/10/2025, 12:12:58
public class Solution {
    public int MaxIncreasingSubarrays(IList<int> nums) {
        int n = nums.Count;
        int k = 0;
        int sub1 = 1;
        int sub2 = 1;

        for (int i = 1; i < nums.Count; i++)
        {
            if (nums[i] > nums[i-1])
            {
                sub2++;
            }
            else
            {
                sub1 = sub2;
                sub2 = 1;
            }

            k = Math.Max(k, Math.Max(Math.Min(sub1, sub2), sub2 / 2));
        }
        
        return k;
    }
}