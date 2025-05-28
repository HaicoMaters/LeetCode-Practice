// Last updated: 28/05/2025, 13:17:48
public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var pq = new PriorityQueue<int, int>();

        foreach (int num in nums)
        {
            pq.Enqueue(num, -num); // - prio for correct dequeue behaviour
        }

        for (int i = 1; i < k; i++)
        {
            pq.Dequeue();
        }

        return pq.Dequeue();
    }
}