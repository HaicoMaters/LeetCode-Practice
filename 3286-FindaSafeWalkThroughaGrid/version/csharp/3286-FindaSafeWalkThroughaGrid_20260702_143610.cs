// Last updated: 02/07/2026, 14:36:10
1public class Solution {
2    int[][] dirs = new int[][]{new int[]{1, 0}, new int[]{-1, 0}, new int[]{0,1}, new int[]{0, -1}};
3    public bool FindSafeWalk(IList<IList<int>> grid, int health) {
4        int m = grid.Count;
5        int n = grid[0].Count;
6
7        bool[,] visited = new bool[m,n];
8
9        PriorityQueue<(int i, int j, int cost), int> pq = new PriorityQueue<(int, int, int), int>();
10        pq.Enqueue((0, 0, grid[0][0]), grid[0][0]);
11
12        while (pq.Count > 0)
13        {
14            (int i, int j, int cost) = pq.Dequeue();
15
16            if (visited[i,j]) continue;
17            visited[i,j] = true;
18
19            if (i == m - 1 && j == n - 1) return true; // valid path found
20
21            foreach (int[] dir in dirs)
22            {
23                int ni = i + dir[0];
24                int nj = j + dir[1];
25
26                if(ni >= 0 && nj >= 0 && ni < m && nj < n && !visited[ni,nj])
27                {
28                    int nextCost = cost + grid[ni][nj];
29
30                    if (nextCost < health)
31                    {
32                        pq.Enqueue((ni, nj, nextCost), nextCost);
33                    }
34                }
35            }
36        }
37
38        return false;
39    }
40}