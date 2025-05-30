// Last updated: 30/05/2025, 12:10:00
public class Solution {
    public int ClosestMeetingNode(int[] edges, int node1, int node2) {
        int n = edges.Length;

        int minDistance = int.MaxValue;
        int closestNode = -1;

        int[] distNode1 = new int[n];
        int[] distNode2 = new int[n];

        for (int i = 0; i < n; i++)
        {
            distNode1[i] = -1;
            distNode2[i] = -1;
        }

        // DFS from both nodes to get distances
        DFS(node1, 0, edges, distNode1);
        DFS(node2, 0, edges, distNode2);

        for (int i = 0; i < n; i++)
        {
            if (distNode1[i] >= 0 && distNode2[i] >= 0)
            {
                int maxDist = Math.Max(distNode1[i], distNode2[i]); // The largest distance the node is away from one of the two nodes

                if (maxDist < minDistance) // Minimise the largest distance one of the two nodes is away from it
                {
                    minDistance = maxDist;
                    closestNode = i;
                }
            }
        }

        return closestNode;
    }

    public void DFS(int node, int distance, int[] edges, int[] dist)
    {
        while (node != -1 && dist[node] == -1) // Unvisited nodes only
        {
            dist[node] = distance++;
            node = edges[node];
        }
    }
}