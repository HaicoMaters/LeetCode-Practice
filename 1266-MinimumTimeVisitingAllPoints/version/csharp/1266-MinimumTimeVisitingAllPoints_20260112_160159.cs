// Last updated: 12/01/2026, 16:01:59
1public class Solution {
2    public int MinTimeToVisitAllPoints(int[][] points) {
3        int time = 0;
4
5        for (int i = 0; i < points.Length-1; i++)
6        {
7            int dx = Math.Abs(points[i+1][0] - points[i][0]);
8            int dy = Math.Abs(points[i+1][1] - points[i][1]);
9            time += Math.Max(dx, dy);
10        }
11
12        return time;
13    }
14}