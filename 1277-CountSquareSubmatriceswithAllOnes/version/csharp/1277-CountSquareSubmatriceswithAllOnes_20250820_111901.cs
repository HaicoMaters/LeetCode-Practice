// Last updated: 20/08/2025, 11:19:01
public class Solution {
    public int CountSquares(int[][] matrix) {
        int squares = 0;
        int m = matrix.Length;
        int n = matrix[0].Length;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i][j] == 1 && i > 0 && j > 0) // find how long the square is filled with ones from that point and update for finding the next lengths
                {
                    matrix[i][j] = Math.Min(matrix[i-1][j-1], Math.Min(matrix[i-1][j], matrix[i][j-1])) + 1;
                }
                squares += matrix[i][j];
            }
        }

        return squares;
    }
}