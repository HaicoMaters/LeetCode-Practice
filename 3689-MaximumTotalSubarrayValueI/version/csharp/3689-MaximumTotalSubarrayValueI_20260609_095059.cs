// Last updated: 09/06/2026, 09:50:59
1public class Solution {
2    public long MaxTotalValue(int[] nums, int k) {
3        // just pick the whole array as a subarray k times
4        long value = nums.Max() - nums.Min();
5        return value * k;
6    }
7}