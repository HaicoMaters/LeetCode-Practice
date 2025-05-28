// Last updated: 28/05/2025, 13:15:00
public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) {
        int m = mat.Length;
        int n = mat[0].Length;
        int[] rows = new int[k];

        var pq = new PriorityQueue<int, (int sum, int index)>(Comparer<(int sum, int index)>.Create(
            (a, b) => a.sum != b.sum ? a.sum.CompareTo(b.sum) : a.index.CompareTo(b.index)
        ));

        for (int i = 0; i < m; i++) {
            int sum = 0;
            for (int j = 0; j < n; j++) {
                sum += mat[i][j];
            }
            pq.Enqueue(i, (sum, i));
        }

        for (int i = 0; i < k; i++)
        {
            rows[i] = pq.Dequeue();
        }

        return rows;
    }
}