// Last updated: 28/05/2025, 13:13:55
public class Solution {
    public bool IsZeroArray(int[] nums, int[][] queries) {
        int n = nums.Length;
        int[] differences = new int[n + 1];

        foreach (var q in queries) // build difference array
        {
            int l = q[0];
            int r = q[1];

            differences[l]++;

            if (r < n) differences[r + 1]--;
        }

        int sum = 0;
        for (int i = 0; i < n; i++) // prefix sum check against nums
        {
            sum += differences[i];
            if (sum < nums[i]) return false; // not enough to decrement to zero
        }

        return true;
    }
}