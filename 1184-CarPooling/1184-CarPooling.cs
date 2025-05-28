// Last updated: 28/05/2025, 13:15:42
public class Solution {
    public bool CarPooling(int[][] trips, int capacity) {
        // passengers, from, to
        int passengersInCar = 0;
        List<int[]> events = new List<int[]>();

        foreach (int[] trip in trips)
        {
            events.Add(new int[]{trip[1], trip[0]}); // Add passengers at pickup time
            events.Add(new int[]{trip[2], -trip[0]}); // Remove passengers at drop off time
        }
        
        // sort by event times
        events.Sort((a, b) =>
        {
            if (a[0] == b[0]) // Events at the same time should prioritise drop offs first
            {
                return a[1] - b[1];
            }
            return a[0] - b[0]; // (- if a first, 0 if equal, + if b first for comparer returns) 
        });

        foreach (int[] e in events)
        {
            passengersInCar += e[1];

            if (passengersInCar > capacity)
            {
                return false;
            }
        }

        return true;
    }
}