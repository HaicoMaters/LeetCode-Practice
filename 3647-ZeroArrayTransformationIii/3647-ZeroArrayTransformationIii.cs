// Last updated: 28/05/2025, 13:13:54
public class Solution {
    public int MaxRemoval(int[] nums, int[][] queries) {
        int n = nums.Length;

        Array.Sort(queries, (a, b) => a[0] - b[0]);

        PriorityQueue<int,int> pq = new PriorityQueue<int, int>();

        int[] changes = new int[n+1];
        int operations = 0;

        int j = 0;
        for (int i = 0; i < n; i++)
        {
            operations += changes[i];

            while (j < queries.Length && queries[j][0] == i) // Enqueues all queries that start at current index i.
            {
                pq.Enqueue(queries[j][1], -queries[j][1]);
                j++;
            }
            while (operations < nums[i] && pq.Count > 0 && pq.Peek() >= i) 
            {
                operations++;
                changes[pq.Dequeue() + 1]--;
            }
            if (operations < nums[i])
            {
                return -1;
            }
        }
        return pq.Count;
    }
}