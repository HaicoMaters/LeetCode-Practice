// Last updated: 28/11/2025, 13:09:13
1public class Solution {
2    public int MaxKDivisibleComponents(int n, int[][] edges, int[] values, int k) {
3        List<int>[] adj = new List<int>[n];
4
5        for (int i = 0; i < n; i++)
6        {
7            adj[i] = new List<int>();
8        }
9
10        foreach (int[] edge in edges)
11        {
12            adj[edge[0]].Add(edge[1]);
13            adj[edge[1]].Add(edge[0]);
14        }  
15
16        int count = 0;
17
18        DFS(0, -1, ref count, values, adj, k);
19        return count;
20    }
21
22    long DFS(int u, int parent, ref int count, int[] values, List<int>[] adj, int k)
23    {
24        long sum = values[u];
25
26        foreach (int v in  adj[u])
27        {
28            if (v == parent) continue;
29
30            sum += DFS(v, u, ref count, values, adj, k);
31        }
32
33        if (sum % k == 0)
34        {
35            count++;
36            return 0;
37        }
38
39        return sum;
40    }
41}