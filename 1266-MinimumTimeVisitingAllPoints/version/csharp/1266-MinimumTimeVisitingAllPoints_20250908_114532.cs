// Last updated: 08/09/2025, 11:45:32
public class Solution {
    public int MinTimeToVisitAllPoints(int[][] points) {
        int time = 0;

        for (int i = 0; i < points.Length-1; i++)
        {
            int dx = Math.Abs(points[i+1][0] - points[i][0]);
            int dy = Math.Abs(points[i+1][1] - points[i][1]);
            time += Math.Max(dx, dy);
        }

        return time;
    }
}