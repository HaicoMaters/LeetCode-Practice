// Last updated: 30/04/2026, 09:30:34
1public class Solution {
2    int[][] dirs = new int[][]{new int[]{1,0}, new int[]{-1,0}, new int[]{0,-1}, new int[]{0,1}};
3    
4    public int MinimumEffortPath(int[][] heights) {
5        int m = heights.Length;
6        int n = heights[0].Length;
7        int minEffort = 0;
8        bool[,] visited = new bool[m,n]; // no need to revisit the min effort to reach that space will already be found
9
10
11        PriorityQueue<(int row, int col, int effort), int> pq = new PriorityQueue<(int,int,int), int>(); // cell and absolute difference required
12        pq.Enqueue((0,0,0),0); // no cost to start
13
14        while (pq.Count > 0)
15        {
16            (int i, int j, int effort) = pq.Dequeue();
17            visited[i,j] = true;
18            minEffort = Math.Max(minEffort, effort);
19
20            if (i == m-1 && j == n-1) return minEffort;
21
22            foreach (int[] dir in dirs)
23            {
24                int ni = i + dir[0];
25                int nj = j + dir[1];
26
27                if (ni >= 0 && ni < m && nj >= 0 && nj < n && !visited[ni,nj])
28                {
29                    int requiredEffort = Math.Abs(heights[i][j] - heights[ni][nj]);
30                    pq.Enqueue((ni,nj,requiredEffort), requiredEffort);
31                }
32            }
33        }
34
35        return minEffort;
36    }
37}