public class Solution {
    public int FindCenter(int[][] edges) {
        bool[] hasEdge = new bool[edges.Length + 2]; // Mark each index i is node i

        for (int i = 0; i < edges.Length; i++)
        {
            if (hasEdge[edges[i][0]]) return edges[i][0];
            else hasEdge[edges[i][0]] = true;
            if (hasEdge[edges[i][1]]) return edges[i][1];
            else hasEdge[edges[i][1]] = true;
        }

        return -1;
    }
}