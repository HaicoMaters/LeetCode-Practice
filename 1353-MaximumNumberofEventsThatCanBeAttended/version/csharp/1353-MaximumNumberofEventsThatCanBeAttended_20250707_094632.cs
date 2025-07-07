// Last updated: 07/07/2025, 09:46:32
public class Solution {
    public int MaxEvents(int[][] events) {
        
        Array.Sort(events, (a,b) => a[0].CompareTo(b[0]));
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        int i = 0, count = 0, day = 1;

        while (pq.Count > 0 || i < events.Length)
        {
            while (i < events.Length && events[i][0] == day)
            {
                pq.Enqueue(events[i][1], events[i][1]);
                i++;
            }

            while (pq.Count > 0 && pq.Peek() < day)
            {
                pq.Dequeue();
            }

            if (pq.Count > 0)
            {
                pq.Dequeue();
                count++;
            }
            day++;
        }

        return count;
    }
}