// Last updated: 12/11/2025, 11:49:23
public class Solution {
    public int MinOperations(int[] nums, int k) {
        int ops = 0;

        foreach (int num in nums)
        {
            if (num < k) ops++;
        }

        return ops;
    }
}