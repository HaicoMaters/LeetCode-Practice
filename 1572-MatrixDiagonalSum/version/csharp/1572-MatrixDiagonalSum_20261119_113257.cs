// Last updated: 19/11/2026, 11:32:57
1public class Solution {
2    public int DiagonalSum(int[][] mat) {
3        int sum = 0;
4
5        int minLen = Math.Min(mat.Length, mat[0].Length);
6        int k = mat[0].Length - 1;
7
8        for (int i = 0; i < minLen; i++)
9        {
10            sum += mat[i][i];
11            if(k-i != i) sum += mat[k-i][i];
12        }
13
14        return sum;
15    }
16}