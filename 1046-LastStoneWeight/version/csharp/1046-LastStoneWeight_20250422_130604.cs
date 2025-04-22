// Last updated: 22/04/2025, 13:06:04
public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

        foreach (int stone in stones)
        {
            pq.Enqueue(stone, -stone); // Start with heaviest
        }

        while (pq.Count > 1)
        {
            int size = pq.Dequeue() - pq.Dequeue(); // smash stones together to get size of combination

            if (size != 0)
            {
                pq.Enqueue(size, -size);
            }
        }

        if (pq.Count == 0) return 0;

        return pq.Dequeue();
    }
}