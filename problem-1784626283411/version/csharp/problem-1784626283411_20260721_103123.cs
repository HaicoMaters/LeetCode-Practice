// Last updated: 21/07/2026, 10:31:23
1public class Solution {
2    public IList<IList<int>> ShiftGrid(int[][] grid, int k) {
3        int m = grid.Length;
4        int n = grid[0].Length;
5        int cells = m * n;
6
7        int[][] shifted = new int[m][];
8
9        for (int i = 0; i < m; i++)
10        {
11            shifted[i] = new int[n];
12        }
13
14        for (int i = 0; i < m; i++)
15        {
16            for (int j = 0; j < n; j++)
17            {
18                int newCell = (i * n + j + k) % cells;
19                int row = newCell / n;
20                int col = newCell % n;
21
22                shifted[row][col] = grid[i][j];
23            }
24        }
25
26        return shifted;
27    }
28}