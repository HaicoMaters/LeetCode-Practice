// Last updated: 01/07/2026, 10:24:13
1public class Solution {
2    // Neighbouring directions just to make easy to iterate over
3    public int[][] directions = {new int[]{0, 1}, new int[]{0, -1},  new int[]{1, 0}, new int[]{-1, 0}};
4
5    public int MaximumSafenessFactor(IList<IList<int>> grid) {
6        int n = grid.Count; // Goal is n-1, n-1
7
8        if (grid[0][0] == 1 || grid[n-1][n-1] == 1) return 0;
9
10        Queue<int[]> queue = new Queue<int[]>();
11        int[,] tiles = new int[n,n]; // Copy of grid as an array to make modifications easier
12
13        // Initalise tiles
14        for (int i = 0; i < n; i++){
15            for (int j = 0; j < n; j++){
16                if(grid[i][j] == 1){
17                    //Add theif coords to queue
18                    queue.Enqueue(new int[]{i,j});
19                    tiles[i,j] = 0; // Add theif to tile (safety value for that space is 0)
20                }
21                else{
22                    tiles[i,j] = -1; // Empty tile (-1 represents an unvisited tile for sake of getting each safety factor)
23                }
24            }
25        }
26
27        // Calc safety factor of each tile using BFS
28        while (queue.Count > 0){
29            int size = queue.Count;
30            while (size-- > 0){
31                int[] current = queue.Dequeue();
32                // Check adjacent neighbouring tiles
33                foreach (int[] dir in directions){
34                    int i = current[0] + dir[0];
35                    int j = current[1] + dir[1];
36                    int val = tiles[current[0], current[1]];
37                    // Check if is a valid cell on the grid and not yet visited (is -1)
38                    if(i >= 0 && i < n && j >= 0 && j < n && tiles[i,j] == -1){
39                        // Update safeness factor and push to queue
40                        tiles[i,j] = val + 1; // Will equal the min number of steps from each thief
41                        queue.Enqueue(new int[]{i,j});
42                    }
43                }
44            }
45        }
46
47        int start = 0;
48        int end = 0;
49        int score = -1; // The Max Safety score
50
51        // Get max potential safety score
52        for (int i = 0; i < n; i++){
53            for (int j = 0; j < n; j++){
54                end = Math.Max(end, tiles[i,j]);
55            }
56        }
57
58        // Binary search for maximum safeness factor
59        while (start <= end){
60            int mid = start + (end - start) / 2;
61            if (ExistsValidPath(tiles, mid)){
62                // Search for larger safeness values
63                score = mid;
64                start = mid + 1; 
65            }
66            else{
67                end = mid - 1;
68            }
69        }
70
71        return score;
72    }
73    
74    // Takes in a safeness value and finds if there is a valid path of that safeness value
75    public bool ExistsValidPath(int[,] tiles, int minSafeness){
76        int n = tiles.GetLength(0);
77
78        if (tiles[0, 0] < minSafeness || tiles[n-1, n-1] < minSafeness) return false; // Need beginning and end to be valid
79
80        Queue<int[]> queue = new Queue<int[]>(); // Queue to handle traversing the grid
81        bool[,] visited = new bool[n,n];
82
83        // Start from [0,0]
84        queue.Enqueue(new int[]{0,0});
85        visited[0,0] = true;
86
87        // BFS to find a valid path
88        while (queue.Count > 0){
89            int[] current = queue.Dequeue();
90            if(current[0] == n-1 && current[1] == n-1){
91                return true; // Valid path found
92            }
93
94            // Check neighbouring tiles
95            foreach (int[] dir in directions){
96                int i = current[0] + dir[0];
97                int j = current[1] + dir[1];
98
99                // Check if valid cell
100                if (i >= 0 && i < n && j >= 0 && j < n && !visited[i,j] && tiles[i,j] >= minSafeness){
101                    visited[i,j] = true;
102                    queue.Enqueue(new int[]{i,j}); // Only enqueue valid and unvisited cells
103                }
104            }
105        }
106        return false; // No path has been found
107    }
108}