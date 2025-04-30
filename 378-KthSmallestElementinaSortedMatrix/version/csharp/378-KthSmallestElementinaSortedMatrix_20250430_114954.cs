// Last updated: 30/04/2025, 11:49:54
public class Solution {
    public int KthSmallest(int[][] matrix, int k) { // Inital not great solution with some slight performance enhancement than plain n^2
        // rows/columns are in non-decreasing order so need to look no further than k along in each row/column
        // if k = 4 will never be the last col(starting 8), or row(starting 5) in this matrix
        // 1 3 4 7 8
        // 2 4 6 7 9
        // 3 7 7 9 10
        // 4 5 8 10 14
        // 5 8 9 12 15

        PriorityQueue<int, int> pq = new PriorityQueue<int,int>();

        int n = matrix.Length;
        n = Math.Min(n, k); // Only need to search up to k columns/rows

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                pq.Enqueue(matrix[i][j], matrix[i][j]);
            }
        }

        for (int i = 1; i < k; i++)
        {
            pq.Dequeue();
        }
        
        return pq.Dequeue();
    }
}