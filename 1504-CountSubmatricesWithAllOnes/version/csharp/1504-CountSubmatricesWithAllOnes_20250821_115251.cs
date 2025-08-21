// Last updated: 21/08/2025, 11:52:51
public class Solution {
    public int NumSubmat(int[][] mat) {
        int row = mat.Length;
        int col = mat[0].Length;
        int subMat = 0;
        int[] heights = new int[col];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                heights[j] = (mat[i][j] == 0) ? 0  : heights[j] + 1;
            }

            for (int j = 0; j < col; j++)
            {
                int minHeight = int.MaxValue;
                for (int k = j; k >= 0 && heights[k] > 0; k--)
                {
                    if (heights[k] < minHeight) minHeight = heights[k];
                    subMat += minHeight;
                }
            }
        }

        return subMat;
    }
}