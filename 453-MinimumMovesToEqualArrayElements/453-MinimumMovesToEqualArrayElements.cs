// Last updated: 28/05/2025, 13:16:36
public class Solution {
    public int MinMoves(int[] nums) {
        int moves = 0;
        int n = nums.Length;
        int min = nums[0];

        for (int i = 1; i < n; i++)
        {
            min = Math.Min(min, nums[i]);
        }

        // Incrementing n - 1 elements is equivalent to decrementing 1 element,
        // so the total moves equal the sum of differences between each number and the minimum.
        for (int i = 0; i < n; i++)
        {
            moves += nums[i] - min;
        }

        return moves;
    }
}