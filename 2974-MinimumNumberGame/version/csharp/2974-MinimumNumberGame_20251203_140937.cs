// Last updated: 03/12/2025, 14:09:37
1public class Solution {
2    public int[] NumberGame(int[] nums) {
3        Array.Sort(nums);
4        int n = nums.Length;
5        int[] arr = new int[n];
6
7        for (int i = 0; i < nums.Length; i += 2)
8        {
9            arr[i] = nums[i+1];
10            arr[i + 1] = nums[i];
11        }
12
13        return arr;
14    }
15}