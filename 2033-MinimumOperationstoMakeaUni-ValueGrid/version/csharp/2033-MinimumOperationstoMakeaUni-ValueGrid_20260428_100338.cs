// Last updated: 28/04/2026, 10:03:38
1public class Solution {
2    public int MinOperations(int[][] grid, int x) {
3        int m = grid.Length;
4        int n = grid[0].Length;
5        int[] values = new int[m*n]; // make 1D to process
6        int allowedMod = grid[0][0] % x; // must have the same remainder when dividing by x
7
8        for (int i = 0; i < m; i++)
9        {
10            for (int j = 0; j < n; j++)
11            {
12                if (grid[i][j] % x != allowedMod) return -1;
13                values[j + (i*n)] = grid[i][j];
14            }
15        }
16
17        Array.Sort(values);
18        int targetNum = values[(m*n)/2];
19        int minOperations = 0;
20        
21        foreach (int num in values)
22        {
23            int diff = Math.Abs(num - targetNum);
24            minOperations += diff/x;
25        }
26
27        return minOperations;
28    }
29}