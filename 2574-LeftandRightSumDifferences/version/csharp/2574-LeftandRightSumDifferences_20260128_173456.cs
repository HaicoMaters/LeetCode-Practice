// Last updated: 28/01/2026, 17:34:56
1public class Solution {
2    public int[] LeftRightDifference(int[] nums) {
3        int n = nums.Length;
4        int[] diff = new int[n];
5        int leftSum = 0;
6        int rightSum = 0;
7
8        for (int i = 0; i < n; i++) rightSum += nums[i];
9
10        for (int i = 0; i < n; i++)
11        {
12            rightSum -= nums[i];
13            diff[i] = Math.Abs(leftSum - rightSum);
14            leftSum += nums[i];        
15        }
16
17        return diff;
18    }
19}