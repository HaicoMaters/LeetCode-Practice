public class Solution {
    public int MinPathSum(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;

        // All from top row (row 0) only comes from left fill top row accordingly
        for (int j = 1; j < n; j++) {
            grid[0][j] += grid[0][j - 1];
        }

        // All from left column (column 0) only comes from above fill left column accordingly
        for (int i = 1; i < m; i++) {
            grid[i][0] += grid[i - 1][0];
        }

        // Fill the rest of the grid based of minimum of the tiles above and left of each tile
        for (int i = 1; i < m; i++) {
            for (int j = 1; j < n; j++) {
                grid[i][j] += Math.Min(grid[i - 1][j], grid[i][j - 1]);
            }
        }

        // Bottom-right cell has the answer
        return grid[m - 1][n - 1];
    }
}