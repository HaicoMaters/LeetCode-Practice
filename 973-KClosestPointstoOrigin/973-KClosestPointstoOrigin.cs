public class Solution {
    public int[][] KClosest(int[][] points, int k) {

        PriorityQueue<int, int> pq = new PriorityQueue<int,int>(); // Index and Squared distance
        int[][] closest = new int[k][];

        // Add points to queue
        for (int i = 0; i < points.Length; i++){
            pq.Enqueue(i, EuclidanSquaredDistance(points[i]));
        }

        // Add the closest points to the array
        for(int i = 0; i < k; i++){
            closest[i] = points[pq.Dequeue()];
        } 

        return closest;
    }

    // Return squared distance as is faster to compute and is the squared distance from origin
    int EuclidanSquaredDistance(int[] point){
        if (point.Length !=2) return -1;
        return (point[0] * point[0]) + (point[1] * point[1]);
    }
}