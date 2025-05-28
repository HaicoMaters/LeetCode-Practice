// Last updated: 28/05/2025, 13:14:29
public class Solution
{
    // 4 possible movement directions (down, up, right, left)
    int[][] directions = new int[][]{ new int[] { 1, 0 }, new int[] { -1, 0 }, new int[] { 0, 1 }, new int[] { 0, -1 }};

    public int MinimumObstacles(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;

        var queue = new PriorityQueue<int[], int>();
        var visited = new bool[m, n];

        queue.Enqueue(new int[] { 0, 0 }, 0); // start at top-left corner

        while (queue.TryDequeue(out int[] currentPos, out int obstacles)) // find new traversable cells from the cheapest available in the queue
        {
            int i = currentPos[0];
            int j = currentPos[1];

            if (visited[i, j]) continue; // skip already visited cells

            visited[i, j] = true;

            if (i == m - 1 && j == n - 1) return obstacles; // reached bottom-right corner should be best path

            foreach (int[] dir in directions)
            {
                int ni = i + dir[0];
                int nj = j + dir[1];

                if (ni >= 0 && nj >= 0 && ni < m && nj < n && !visited[ni, nj])
                {
                    if (grid[ni][nj] == 0)
                    {
                        queue.Enqueue(new int[] { ni, nj }, obstacles); // no obstacle
                    }
                    else if (grid[ni][nj] == 1) // Requires removal of obstacle to move that direction
                    {
                        queue.Enqueue(new int[] { ni, nj }, obstacles + 1);
                    }
                }
            }
        }

        return -1; // Should not be reached in this problem, occurs when no paths are found
    }
}