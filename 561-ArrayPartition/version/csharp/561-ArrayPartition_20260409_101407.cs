// Last updated: 09/04/2026, 10:14:07
1public class Solution {
2    public int ArrayPairSum(int[] nums) {
3        Array.Sort(nums);
4
5        int sum = 0;
6        for (int i = 0; i < nums.Length; i+=2)
7        {
8            sum += nums[i];
9        }
10
11        return sum;
12    }
13}