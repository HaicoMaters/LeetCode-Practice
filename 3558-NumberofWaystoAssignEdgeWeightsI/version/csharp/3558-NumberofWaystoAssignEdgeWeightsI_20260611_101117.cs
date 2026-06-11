// Last updated: 11/06/2026, 10:11:17
1public class Solution {
2    public int AssignEdgeWeights(int[][] edges) {
3        int n = edges.Length + 1;
4
5        List<List<int>> adj = new List<List<int>>();
6        for (int i = 0; i < n + 1; i++)
7        {
8            adj.Add(new List<int>());
9        }
10
11        foreach (int[] edge in edges)
12        {
13            int u = edge[0];
14            int v = edge[1];
15            adj[u].Add(v);
16            adj[v].Add(u);
17        }
18
19        int maxDepth = DFS(adj, 1, 0);
20        return ModPow(2, maxDepth - 1);  // ways is (2 ^ (maxDepth-1)) % MOD
21
22    }
23
24    public int DFS(List<List<int>> adj, int node, int parent)
25    {
26        int maxDepth = 0;
27        foreach (int n in adj[node])
28        {
29            if (n == parent) continue;
30            maxDepth = Math.Max(maxDepth, DFS(adj, n, node) + 1);
31        }
32        return maxDepth;
33    }
34    
35    // applying the mod here to prevent overflow
36    public int ModPow(long baseValue, long exp)
37    {
38        int mod = 1000000007;
39        long res = 1;
40        long b = baseValue % mod;
41
42        while (exp > 0)
43        {
44            if ((exp & 1) == 1) res = (res * b) % mod;
45            b = (b * b) % mod;
46            exp >>= 1;
47        }
48
49        return (int) res;
50    }
51}