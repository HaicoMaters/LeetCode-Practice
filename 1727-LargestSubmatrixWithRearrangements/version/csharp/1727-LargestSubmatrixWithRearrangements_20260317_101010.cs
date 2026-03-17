// Last updated: 17/03/2026, 10:10:10
1public class Solution {
2    public int LargestSubmatrix(int[][] matrix) {
3        int m = matrix.Length;
4        int n = matrix[0].Length;
5
6        // get counts of 1s above i
7        for (int i = 1; i < m; i++)
8        {
9            for (int j = 0; j < n; j++)
10            {
11                matrix[i][j] = matrix[i][j] == 0 ? 0 : matrix[i-1][j] + 1;
12            } 
13        }
14
15        int largest = 0;
16        for (int i = 0; i < m; i++) // sort row by decending
17        {
18            Array.Sort(matrix[i]);
19            for (int j = n - 1; j >=0; j--)
20            {
21                largest = Math.Max(largest, matrix[i][j] * (n-j));
22            }
23        }
24
25        return largest;
26    }
27}