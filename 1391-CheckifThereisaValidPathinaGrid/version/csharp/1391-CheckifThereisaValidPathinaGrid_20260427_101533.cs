// Last updated: 27/04/2026, 10:15:33
1public class Solution {
2    int[][] dirs = new int[][]{new int[] {0,1}, new int[]{0,-1}, new int[]{1,0}, new int[]{-1,0}};
3    
4    // index = type of street. each val is the possible movements in terms of dirs where the vals are an index in dirs i.e. index 1 == left to right so can move either left or right (index 0 and 1 in dirs)
5   int[][] streets = new int[][]{new int[]{-1,-1}, new int[]{0,1}, new int[]{2,3}, new int[]{1,2}, new int[]{0,2}, new int[]{1,3}, new int[]{0,3}};
6
7    public bool HasValidPath(int[][] grid) {
8        int m = grid.Length;
9        int n = grid[0].Length;
10
11        if (m == 1 && n == 1) return true;
12        
13        bool[,] visited = new bool[m,n];
14        
15        Queue<(int i, int j)> queue = new Queue<(int,int)>();
16        queue.Enqueue((0,0));
17        visited[0,0] = true;
18
19        while(queue.Count > 0)
20        {
21            (int i, int j) = queue.Dequeue();
22
23            int type = grid[i][j];
24            if (type < 1 || type > 6) continue;
25
26            foreach (int dir in streets[type])
27            {
28                int ni = i + dirs[dir][0];
29                int nj = j + dirs[dir][1];
30
31                if (ni < 0 || nj < 0 || ni >= m || nj >= n || visited[ni,nj]) continue;
32
33                // check that it connects backwards i.e. not a straight into a corner facing away
34                int nextType = grid[ni][nj];
35                if (nextType < 1 || nextType > 6) continue;
36                bool connectsBackwards = false;
37
38                foreach (int d in streets[nextType])
39                {
40                    if (ni + dirs[d][0] == i && nj + dirs[d][1] == j)
41                    { 
42                        connectsBackwards = true;
43                        break;
44                    }
45                }
46
47                if (!connectsBackwards) continue;
48
49                if (ni == m-1 && nj == n-1) return true;
50
51                visited[ni, nj] = true;
52                queue.Enqueue((ni,nj));
53            }
54        }
55
56        // mark traversed spaces as 0 and skip over those traversed
57        return false;
58    }
59}