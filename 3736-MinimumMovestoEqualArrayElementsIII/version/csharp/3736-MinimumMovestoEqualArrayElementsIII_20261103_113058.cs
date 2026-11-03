// Last updated: 03/11/2026, 11:30:58
1public class Solution {
2    public int MinMoves(int[] nums) {
3        int max = nums.Max();   
4        int moves = 0;
5
6        foreach (int num in nums)
7        {
8            moves += Math.Abs(max - num);
9        }
10
11        return moves;
12    }
13}