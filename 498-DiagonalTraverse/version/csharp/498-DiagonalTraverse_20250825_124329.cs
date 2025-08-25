// Last updated: 25/08/2025, 12:43:29
public class Solution {
    public int[] FindDiagonalOrder(int[][] mat) {
        int[][] dir = new int[][]{new int[]{-1, 1}, new int[]{1,-1}}; 
        int nextDir = 0; // 0 as up right, 1 as down left
        int m = mat.Length;
        int n = mat[0].Length;

        int index = 0; // index of where to place next number in order
        int[] order = new int[n * m];

        int row = 0;
        int col = 0;

        while (index < n * m)
        {
            order[index++] = mat[row][col];

            row += dir[nextDir][0];
            col += dir[nextDir][1];

            if (row >= m)
            { 
                row = m - 1; 
                col += 2; 
                nextDir = 1 - nextDir; 
            }
            if (col >= n) 
            { 
                col = n - 1; 
                row += 2; 
                nextDir = 1 - nextDir; 
            }
            if (row < 0)  
            { 
                row = 0; 
                nextDir = 1 - nextDir; 
            }
            if (col < 0) 
            {   col = 0; 
                nextDir = 1 - nextDir; 
            }
        }

        return order;
    }
}