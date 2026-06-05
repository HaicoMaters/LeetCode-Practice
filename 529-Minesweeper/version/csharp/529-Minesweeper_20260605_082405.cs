// Last updated: 05/06/2026, 08:24:05
1public class Solution {
2    int[][] dirs = new int[][]{new int[]{0,1}, new int[]{0,-1}, new int[]{1,0}, new int[]{-1,0}, new int[]{1,1}, new int[]{-1,1}, new int[]{1, -1}, new int[]{-1,-1}};
3
4    public char[][] UpdateBoard(char[][] board, int[] click) {
5        if (board[click[0]][click[1]] == 'M')
6        {
7            board[click[0]][click[1]] = 'X';
8            return board;
9        }
10
11        int m = board.Length;
12        int n = board[0].Length;
13        bool[,] visited = new bool[m,n];
14        Queue<(int i,int j)> queue = new Queue<(int, int)>();
15        queue.Enqueue((click[0],click[1]));
16
17        while(queue.Count > 0)
18        {
19            (int i, int j) = queue.Dequeue();
20
21            if (visited[i,j]) continue;
22            visited[i,j] = true;
23            int mines = 0;
24
25            List<(int,int)> next = new List<(int,int)>();
26
27            foreach (int[] dir in dirs)
28            {
29                int ni = i + dir[0];
30                int nj = j + dir[1];
31
32                if (ni < 0 || ni >= m || nj < 0 || nj >= n) continue;
33
34                if(board[ni][nj] == 'M') mines++;
35
36                if(visited[ni,nj]) continue;
37                next.Add((ni,nj));
38            }
39
40            if(mines > 0)
41            {
42                board[i][j] = (char)(mines + '0');
43                continue;
44            }
45
46            board[i][j] = 'B';
47
48            foreach ((int ni, int nj) in next)
49            {
50                queue.Enqueue((ni, nj));
51            }
52        }
53
54        return board;
55    }
56}