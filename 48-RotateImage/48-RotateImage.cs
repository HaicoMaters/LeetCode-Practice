public class Solution {
    public void Rotate(int[][] matrix) {
        int n = matrix.Length;

        // Transpose matrix
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                // Swap elements across the diagonal i,j swap with j,i
                int ij = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = ij;
            }
        }

        // Reverse each row
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n / 2; j++)
            {
                // Swap elements for reversal
                int ij = matrix[i][j];
                matrix[i][j] = matrix[i][n - j -1];
                matrix[i][n - j - 1] = ij;
            }
        }
    }
}