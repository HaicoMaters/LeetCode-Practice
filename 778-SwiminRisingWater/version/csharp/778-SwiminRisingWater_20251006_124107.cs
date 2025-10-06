// Last updated: 06/10/2025, 12:41:07
public class Solution {
    int[][] dirs = new int[][]{new int[]{1,0}, new int[]{-1,0}, new int[]{0,-1}, new int[]{0,1}};

    public int SwimInWater(int[][] grid) {
        int n = grid.Length;

        bool[,] visited = new bool[n,n];

        PriorityQueue<(int row, int col), int> pq = new();
        pq.Enqueue((0, 0), grid[0][0]);

        int time = 0;

        while(pq.Count > 0)
        {
            (int row, int col) = pq.Dequeue();

            if (visited[row,col]) continue;

            visited[row,col] = true;
            time = Math.Max(time, grid[row][col]);

            if (row == n -1 && col == n-1) return time;

            foreach (int[] dir in dirs)
            {
                int nextRow = row + dir[0];
                int nextCol = col + dir[1];
                if (nextRow >= 0 && nextRow < n && nextCol >= 0 && nextCol < n && !visited[nextRow, nextCol])
                {
                    pq.Enqueue((nextRow, nextCol), grid[nextRow][nextCol]);
                }
            }
        }

        return -1;
    }
}