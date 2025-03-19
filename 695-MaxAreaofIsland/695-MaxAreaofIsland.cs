public class Solution {
    int[][] directions = new int[][]{new int[]{0, 1}, new int[]{0, -1}, new int[]{1, 0}, new int[]{-1, 0}};

    public int MaxAreaOfIsland(int[][] grid) {
        int maxArea = 0;
        int m = grid.Length;
        int n = grid[0].Length;

        // 0 is water, 1 is unchecked land, 2 is checked land
        Queue<(int, int)> queue = new Queue<(int, int)>();

        for (int i = 0; i < m; i++){
            for (int j = 0; j < n; j++){
                if (grid[i][j] == 1){
                    // BFS for area of island
                    int area = 0;

                    queue.Enqueue((i, j));
                    grid[i][j] = 2;

                    while(queue.Count > 0){
                        (int, int) coord = queue.Dequeue();
                        
                        int ci = coord.Item1;
                        int cj = coord.Item2;
                        
                        area++;

                        foreach (int[] dir in directions){
                            int ni = ci + dir[0];
                            int nj = cj + dir[1];

                            if(ni > -1 && nj > -1 && ni < m && nj < n && grid[ni][nj] == 1)
                            {
                                queue.Enqueue((ni, nj));
                                grid[ni][nj] = 2;
                            }
                        }
                    }
                    maxArea = Math.Max(area, maxArea);
                }
            }
        }

        return maxArea;
    }
}