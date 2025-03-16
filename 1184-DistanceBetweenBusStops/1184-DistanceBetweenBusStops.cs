public class Solution {
    public int DistanceBetweenBusStops(int[] distance, int start, int destination) {
        
        // Only calculate distance going forwards (swapped distance is same as counterclockwise)
        if (start > destination) {
            int temp = start;
            start = destination;
            destination = temp;
        }

        int totalDistance = 0;
        int clockwiseDistance = 0;

        for (int i = 0; i < distance.Length; i++) {
            if (i >= start && i < destination) {
                clockwiseDistance += distance[i];
            }
            totalDistance += distance[i];
        }

        int counterClockwiseDistance = totalDistance - clockwiseDistance;

        return Math.Min(clockwiseDistance, counterClockwiseDistance);
    }
}
