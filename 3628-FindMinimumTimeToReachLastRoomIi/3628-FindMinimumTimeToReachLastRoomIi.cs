// Last updated: 28/05/2025, 13:13:59
public class Solution {
    int[][] directions = new int[][]{new int[]{1, 0}, new int[]{-1, 0}, new int[]{0, 1}, new int[]{0, -1} };

    public int MinTimeToReach(int[][] moveTime) {
        int n = moveTime.Length;
        int m = moveTime[0].Length;

        int timeCost = 1; // starts as 1, then 2, then 1 etc..

        int[,] visited = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                visited[i, j] = int.MaxValue;
            }
        }

        var pq = new PriorityQueue<(int time, int i, int j), int>();

        pq.Enqueue((0,0,0), 0);

        while (pq.Count > 0)
        {
            var (time, i, j) = pq.Dequeue();

            
            if (time >= visited[i, j]) continue;
            visited[i, j] = time;

            if (i == n-1 && j == m-1) return time;

            foreach (var dir in directions)
            {
                int ni = i + dir[0];
                int nj = j + dir[1];

                if (ni >= 0 && ni < n && nj >= 0 && nj < m)
                {
                    int wait = Math.Max(moveTime[ni][nj], time);
                    timeCost = (i + j) % 2 + 1;
                    int total = wait + timeCost;
                    if (total < visited[ni,nj])
                    {
                        pq.Enqueue((total, ni, nj), total);
                    }
                }
            }
        }

        return -1;
    }
}