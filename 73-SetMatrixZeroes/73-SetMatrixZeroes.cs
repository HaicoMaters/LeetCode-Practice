// Last updated: 28/05/2025, 13:18:30
public class Solution {
    public void SetZeroes(int[][] matrix) {
        int m = matrix.Length;
        int n = matrix[0].Length;

        HashSet<int> hs = new HashSet<int>();

        for (int i = 0; i < m; i++) 
        {
            for (int j = 0; j < n; j++) 
            {
                if (matrix[i][j] == 0) 
                {
                    hs.Add(i);
                    hs.Add(201 + j); // m,n <= 200 so can use 201 + j
                }
            }
        }

        for (int i = 0; i < m; i++) 
        {
            for (int j = 0; j < n; j++) 
            {
                if (hs.Contains(i) || hs.Contains(201 + j)) 
                {
                    matrix[i][j] = 0;
                }
            }
        }
        
        return;
    }
}