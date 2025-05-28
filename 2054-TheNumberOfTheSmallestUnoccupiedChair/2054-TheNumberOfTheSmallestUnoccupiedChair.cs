// Last updated: 28/05/2025, 13:14:37
public class Solution {
    public int SmallestChair(int[][] times, int targetFriend) {
        
        int n = times.Length;

        // Create list of events: arrival, leaving, friendIndex
        var events = new List<(int arrival, int leaving, int friendIndex)>();
        for (int i = 0; i < n; i++)
        {
            events.Add((times[i][0], times[i][1], i));
        }
        // Sort events by arrival time
        events.Sort((a, b) => a.arrival.CompareTo(b.arrival));
        // PriorityQueue for available chairs
        var availableChairs = new PriorityQueue<int, int>();
        for (int i = 0; i < n; i++)
        {
            availableChairs.Enqueue(i, i);
        }

        // PriorityQueue for occupied chairs: (leavingTime, chair)
        var occupiedChairs = new PriorityQueue<(int leavingTime, int chair), int>();

        foreach (var (arrival, leaving, friendIndex) in events)
        {
            // Free chairs of friends who have already left
            while (occupiedChairs.Count > 0 && occupiedChairs.Peek().leavingTime <= arrival)
            {
                var (_, chair) = occupiedChairs.Dequeue();
                availableChairs.Enqueue(chair, chair);
            }
            // Get the smallest available chair
            int assignedChair = availableChairs.Dequeue();
            // If this is the target friend, return the assigned chair
            if (friendIndex == targetFriend)
            {
                return assignedChair;
            }
            // Mark the chair as occupied until the friend leaves
            occupiedChairs.Enqueue((leaving, assignedChair), leaving);
        }

        return -1; // Should never happen for valid input
    }
}