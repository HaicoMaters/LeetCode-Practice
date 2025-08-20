// Last updated: 20/08/2025, 11:30:21
public class Solution {
    public int ProjectionArea(int[][] grid) {
        int n = grid.Length;
        int totalArea = 0;

        for (int row = 0; row < n; row++)
        {
            int maxColHeight = 0;
            int maxRowHeight = 0;

            for (int col = 0; col < n; col++)
            {
                if(grid[row][col] > 0)
                {
                    totalArea++;
                }

                maxRowHeight = Math.Max(maxRowHeight, grid[row][col]);
                maxColHeight = Math.Max(maxColHeight, grid[col][row]);
            }
            totalArea += maxRowHeight + maxColHeight;
        }

        return totalArea;
    }
}