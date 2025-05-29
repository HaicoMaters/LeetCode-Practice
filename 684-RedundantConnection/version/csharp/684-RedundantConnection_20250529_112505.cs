// Last updated: 29/05/2025, 11:25:05
public class Solution {
    public int[] FindRedundantConnection(int[][] edges) { // Solution using union find
        int n = edges.Length;
        int[] parent = new int[n + 1];

        for (int i = 0; i <= n; i++)
        {
            parent[i] = i;
        }

        foreach (var edge in edges) 
        {
            int u = edge[0];
            int v = edge[1];

            // Find roots
            int rootU = Find(parent, u);
            int rootV = Find(parent, v);

            if (rootU == rootV) // If roots are the same it is a redundant connection
            {
                return edge;
            }

            // Union
            parent[rootU] = rootV;
        }

        return new int[0]; // No redundant connections
    }

    int Find(int[] parent, int x)
    {
        if (parent[x] != x) 
        {
            parent[x] = Find(parent, parent[x]); 
        }

        return parent[x];
    }

}