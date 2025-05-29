// Last updated: 29/05/2025, 12:05:01
public class Solution {
    public int MinReorder(int n, int[][] connections) {
        int reorders = 0;

        List<(int dir, int node)>[] adj = new List<(int dir, int node)>[n];
        bool[] visited = new bool[n];

        foreach (int[] road in connections)
        {
            if (adj[road[0]] == null)
            {
                adj[road[0]] = new List<(int dir, int node)>();
            }
            if (adj[road[1]] == null)
            {
                adj[road[1]] = new List<(int dir, int node)>();
            }

            adj[road[0]].Add((1, road[1])); // outgoing (original direction)
            adj[road[1]].Add((-1, road[0])); // incoming (reversed direction)
        }

        DFS(0);

        return reorders;
        

        void DFS(int current)
        {
            visited[current] = true;

            if (adj[current] != null)
            {
                foreach (var neighbour in adj[current])
                {
                    if (!visited[neighbour.node])
                    {
                        if (neighbour.dir == 1) reorders++;
                        DFS(neighbour.node);
                    }
                }
            }
        }

    }
}