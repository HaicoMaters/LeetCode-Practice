// Last updated: 28/05/2025, 13:14:20
public class Solution {
    public int MatrixSum(int[][] nums) {
        int n = nums.Length;
        int m = nums[0].Length;

        for(int i = 0; i < n; i++) 
        {
            Array.Sort(nums[i]);
        }

        int score = 0;
        for (int j = 0; j < m; j++)
        {
            int max = nums[0][j];
            for (int i = 1; i < n; i++)
            {
                if (nums[i][j] > max)
                {
                    max = nums[i][j];
                }
            }
            score += max;
        }

        return score;
    }
}