// Last updated: 16/03/2026, 11:18:58
1public class Solution {
2    public int[] GetBiggestThree(int[][] grid) {
3        int m = grid.Length;
4        int n = grid[0].Length;
5
6        SortedSet<int> biggestThree = new SortedSet<int>();
7
8        for (int i = 0; i < m; i++)
9        {
10            for (int j = 0; j < n; j++)
11            {
12                // get the max size the side can be with this as the centre
13                int maxSideLength = Math.Min(Math.Min(i, m - 1 - i), Math.Min(j, n - 1 - j) );
14
15                for (int sideLength = 0; sideLength <= maxSideLength; sideLength++)
16                {
17                    int sum = GetRhombusSum(grid, i, j, sideLength);
18
19                    if (sum == -1) continue; // should not happen due to calcing max side length, but just incase
20
21                    biggestThree.Add(sum);
22
23                    if (biggestThree.Count > 3)
24                    {
25                        biggestThree.Remove(biggestThree.Min);
26                    }
27                }
28            }
29        }
30
31        int[] result = biggestThree.ToArray();
32        Array.Reverse(result);
33        return result;
34    }
35
36    public int GetRhombusSum(int[][] grid, int i, int j, int sideLength)
37    {
38        if (sideLength == 0) return grid[i][j];
39
40        if (i - sideLength < 0 || i + sideLength >= grid.Length || j - sideLength < 0 || j + sideLength >= grid[0].Length)
41        {
42            return -1;
43        }
44
45        int sum = 0;
46
47        for (int k = 0; k < sideLength; k++)
48        {
49            sum += grid[i-k][j - sideLength + k]; // up right
50            sum += grid[i + sideLength - k][j - k]; // up left
51            sum += grid[i-sideLength + k][j + k]; // down right
52            sum += grid[i+k][j+sideLength-k]; // down left
53        }
54
55        return sum;
56    }
57}