// Last updated: 05/02/2026, 13:24:07
1public class Solution {
2    public int[] ConstructTransformedArray(int[] nums) {
3        int n = nums.Length;
4        int[] transformed = new int[n];
5
6        for (int i = 0; i < n; i++)
7        {
8            transformed[i] = nums[((i + nums[i])  % n + n) % n];
9        }
10        return transformed;
11    }
12}