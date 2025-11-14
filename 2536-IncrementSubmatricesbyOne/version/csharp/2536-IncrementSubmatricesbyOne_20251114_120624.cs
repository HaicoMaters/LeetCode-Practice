// Last updated: 14/11/2025, 12:06:24
public class Solution {
    public int[][] RangeAddQueries(int n, int[][] queries) {
        int[,] diff = new int[n+1,n+1];

        // start handling queries
        foreach(int[] query in queries)
        {
            int row1 = query[0];
            int col1 = query[1];
            int row2 = query[2];
            int col2 = query[3];

            diff[row1,col1]++;
            if (col2 + 1 < n) diff[row1, col2 + 1]--;
            if (row2 + 1 < n) diff[row2 + 1, col1]--;
            if (row2 + 1 < n && col2 + 1 < n) diff[row2 + 1, col2 + 1]++;
        }

        // horizontal prefix sum
        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j < n; j++)
            {
                diff[i,j] += diff[i,j-1];
            }
        }

        // vertical prefix sum
        for (int j = 0; j < n; j++)
        {
            for (int i = 1; i < n; i++)
            {
                diff[i,j] += diff[i-1, j];
            }
        }

        // build final matrix
        int[][] mat = new int[n][];
        for (int i = 0; i < n; i++)
        {
            mat[i] = new int[n];
            for (int j = 0; j < n; j++)
            {
                mat[i][j] = diff[i,j];
            }
        }

        return mat;
    }
}