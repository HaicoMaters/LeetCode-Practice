// Last updated: 01/04/2025, 16:25:19
public class Solution {
    public int FindMinArrowShots(int[][] points) {
        Array.Sort(points, (a, b) => a[1].CompareTo(b[1]));

        int arrows = 1;
        int lastEnd = points[0][1];

        for (int i = 1; i < points.Length; i++)
        {
            if (points[i][0] > lastEnd)
            {
                arrows++;
                lastEnd = points[i][1];
            }
        }

        return arrows;
    }
}