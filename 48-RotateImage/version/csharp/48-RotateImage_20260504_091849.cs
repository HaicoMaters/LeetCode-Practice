// Last updated: 04/05/2026, 09:18:49
1public class Solution {
2    public void Rotate(int[][] matrix) {
3        int n = matrix.Length;
4
5        // Transpose matrix
6        for (int i = 0; i < n; i++)
7        {
8            for (int j = i; j < n; j++)
9            {
10                // Swap elements across the diagonal i,j swap with j,i
11                int ij = matrix[i][j];
12                matrix[i][j] = matrix[j][i];
13                matrix[j][i] = ij;
14            }
15        }
16
17        // Reverse each row
18        for (int i = 0; i < n; i++)
19        {
20            for (int j = 0; j < n / 2; j++)
21            {
22                // Swap elements for reversal
23                int ij = matrix[i][j];
24                matrix[i][j] = matrix[i][n - j -1];
25                matrix[i][n - j - 1] = ij;
26            }
27        }
28    }
29}