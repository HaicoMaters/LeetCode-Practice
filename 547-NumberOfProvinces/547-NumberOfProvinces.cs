// Last updated: 28/05/2025, 13:16:20
public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        int provinces = 0;

        int n = isConnected.Length;
        bool[] visited = new bool[n];

        for (int i = 0; i < n; i++)
        {
            if (!visited[i])
            {
                DFS(i, isConnected, visited);
                provinces++;
            }
        }

        return provinces;
    }

    private void DFS(int node, int[][] adj, bool[] visited)
    {
        visited[node] = true;

        for (int i = 0; i < visited.Length; i++)
        {
            if (adj[node][i] == 1 && !visited[i])
            {
                DFS(i, adj, visited);
            }
        }
    }
}