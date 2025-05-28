// Last updated: 28/05/2025, 13:15:33
public class Solution {
    public int MakeConnected(int n, int[][] connections) {
        if (n == 1) return 0;
        if (connections.Length < n-1) return -1; // Not possible to connect all computers with number of cables

        List<int>[] adjacent = new List<int>[n]; 
        bool[] visited = new bool[n];

        // build adjacency lists
        foreach (int[] connection in connections)
        {
            if (adjacent[connection[0]] == null)
            {
                adjacent[connection[0]] = new List<int>();
            }
            if (adjacent[connection[1]] == null)
            {
                adjacent[connection[1]] = new List<int>();
            }

            adjacent[connection[0]].Add(connection[1]);
            adjacent[connection[1]].Add(connection[0]);
        }

        int count = 0; // count of clusters of computers (including singular ones)
        for (int i = 0; i < n; i++)
        {
            if (!visited[i])
            {
                DFS(i, adjacent, visited);
                count++;
            }
        }

        return count - 1; // count -1 as already confirmed there are enough connections (connections.Length >= n-1) and takes n-1 wires to connect n computers 
    }

    private void DFS(int node, List<int>[] adjacent, bool[] visited)
    {
        visited[node] = true;
        if (adjacent[node] != null)
        {
            foreach (int nd in adjacent[node])
            {
                if (!visited[nd])
                {
                    DFS(nd, adjacent, visited);
                }
            }
        }
    }
}