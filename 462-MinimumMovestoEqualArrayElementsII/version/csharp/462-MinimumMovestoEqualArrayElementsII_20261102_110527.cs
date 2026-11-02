// Last updated: 02/11/2026, 11:05:27
1public class Solution {
2    public int MinMoves2(int[] nums) {
3        int n = nums.Length;
4    
5        Array.Sort(nums);
6        int moves = 0;
7        int median = nums[n/2];
8        for(int i = 0; i < n; i++)
9        {
10            moves += (Math.Abs(nums[i] - median));
11        }
12
13        return moves;
14    }
15}