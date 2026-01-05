// Last updated: 05/01/2026, 14:54:34
1public class Solution {
2    public long MaxMatrixSum(int[][] matrix) {
3        int min = int.MaxValue;
4        long sum = 0;
5        int negCount = 0;
6        int n = matrix.Length;
7        int m = matrix[0].Length;
8
9        for (int i = 0; i < n; i++)
10        {
11            for (int j = 0; j < m; j++)
12            {
13                if (matrix[i][j] < 0) negCount++;
14
15                min = Math.Min(min, Math.Abs(matrix[i][j]));
16                sum += Math.Abs(matrix[i][j]);
17            }
18        }
19
20        if (negCount % 2 == 0) return sum;
21
22        return sum - 2*min;
23    }
24}