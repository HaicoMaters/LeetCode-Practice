// Last updated: 22/08/2025, 13:23:28
public class Solution {
    public int MinimumArea(int[][] grid) {
        int minX = 1001; // max size of grid is 1000 * 1000
        int minY = 1001;
        int maxX = -1;
        int maxY = -1;

        int n = grid.Length;
        int m = grid[0].Length;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (grid[i][j] == 1)
                {
                    minX = Math.Min(minX, i);
                    minY = Math.Min(minY, j);
                    maxX = Math.Max(maxX, i);
                    maxY = Math.Max(maxY, j);
                }
            }
        }

        return (maxX - minX + 1) * (maxY - minY + 1);
    }
}