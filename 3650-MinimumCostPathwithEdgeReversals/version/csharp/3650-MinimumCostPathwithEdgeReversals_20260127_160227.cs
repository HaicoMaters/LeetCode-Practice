// Last updated: 27/01/2026, 16:02:27
1public class Solution {
2    public int MinCost(int n, int[][] edges) {
3        List<(int to, int cost)>[] adj = new List<(int, int)>[n];
4
5        for (int i = 0; i < n; i++)
6        {
7            adj[i] = new List<(int,int)>();
8        }
9
10        foreach (var edge in edges)
11        {
12            int u = edge[0];
13            int v = edge[1];
14            int w = edge[2];
15
16            adj[u].Add((v, w));
17            adj[v].Add((u, 2 * w)); // Can reverse edges for double the weight
18        }
19
20        long[] dist = new long[n];
21        for (int i = 0; i < n; i++)
22        {
23            dist[i] = long.MaxValue;
24        }
25        dist[0] = 0;
26
27        PriorityQueue<(int node, long cost), long> pq = new PriorityQueue<(int node, long cost), long>();
28        pq.Enqueue((0,0),0);
29
30        while (pq.Count > 0)
31        {
32            (int node, long cost) = pq.Dequeue();
33
34            if (cost > dist[node]) continue; //skip longer routes
35            if (node == n-1) break; // found path
36
37            foreach (var (neighbour, weight) in adj[node])
38            {
39                if(cost + weight < dist[neighbour])
40                {
41                    dist[neighbour] = cost + weight;
42                    pq.Enqueue((neighbour, cost + weight), cost + weight);
43                }
44            }
45        }
46
47        return (dist[n-1] == long.MaxValue) ? -1 : (int)dist[n-1];
48    }
49}