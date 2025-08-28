// Last updated: 28/08/2025, 11:50:07
public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n = nums.Length;
        int[] concat = new int[2 * n];

        for (int i = 0; i < n; i++)
        {
            concat[i] = nums[i];
            concat[i+n] = nums[i];
        }

        return concat;
    }
}