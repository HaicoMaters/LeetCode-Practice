// Last updated: 28/05/2025, 13:17:54
public class Solution {
    int[][] directions = new int[][]{new int[]{0, 1}, new int[]{0, -1}, new int[]{1, 0}, new int[]{-1, 0}};

    public int NumIslands(char[][] grid) {
        // 0 = Water, 1 = Unchecked Land, 2 = Checked Land
        int m = grid.Length;
        int n = grid[0].Length;
        int numIslands = 0;

        Queue<(int, int)> queue = new Queue<(int, int)>();

        for (int i = 0; i < m; i++){
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] == '1'){
                    // Do BFS To find total individual island
                    queue.Enqueue((i, j));

                    while (queue.Count > 0){

                        (int , int) coord = queue.Dequeue();
                        int ci = coord.Item1;
                        int cj = coord.Item2;

                        if (grid[ci][cj] == '1')
                        {
                            grid[ci][cj] = '2'; // Has Been Checked
                            foreach (int[] dir in directions){
                                int ni = ci + dir[0];
                                int nj = cj + dir[1];

                                if (ni >= 0 && nj >= 0 && ni < m && nj < n && grid[ni][nj] == '1'){
                                    queue.Enqueue((ni, nj));
                                }
                            }
                        }
                    }

                    numIslands++;
                }
            }
        }
        return numIslands;
    }
}