// Last updated: 26/08/2026, 11:28:48
1public class Solution {
2    public int[] CreateTargetArray(int[] nums, int[] index) {
3        List<int> target = new List<int>();
4
5        for (int i = 0; i < nums.Length; i++)
6        {
7            target.Insert(index[i], nums[i]);
8        }
9
10        return target.ToArray();
11    }
12}