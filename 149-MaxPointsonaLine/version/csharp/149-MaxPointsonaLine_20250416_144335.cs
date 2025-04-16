// Last updated: 16/04/2025, 14:43:35
public class Solution {
    public int MaxPoints(int[][] points) {
        // Calculate a line between each point, calc the gradient find all the points within that line

        if (points.Length == 0) return 0;
        if (points.Length == 1) return 1;

        HashSet<(int x, int y)> pointLocations = new HashSet<(int x, int y)>(); // For Easy lookups

        int maxPoints = 0;

        foreach (var point in points)
        {
            pointLocations.Add((point[0], point[1]));
        }

        
        for (int i = 0; i < points.Length; i++)
        {
            for (int j = i + 1; j < points.Length; j++)
            {
                int x1 = points[i][0];
                int y1 = points[i][1];
                int x2 = points[j][0];
                int y2 = points[j][1];

                int dx = x2 - x1;
                int dy = y2 - y1;

                int gcd = GCD(Math.Abs(dx), Math.Abs(dy)); // USe GCD to count minimum step for each as a int, ig. dx/dy = 2/3, move 2 x for 3 y as the step
                int stepX = dx / gcd;
                int stepY = dy / gcd;

                int x = x1;
                int y = y1;
                int pointsInLine = 0;

                for (int k = 0; k <= gcd; k++) // from start to end inclusive
                {
                    if (pointLocations.Contains((x, y)))
                    {
                        pointsInLine++;
                    }

                    x += stepX;
                    y += stepY;
                }

                maxPoints = Math.Max(maxPoints, pointsInLine);
            }
        }

        return maxPoints;
    }

    private int GCD(int a, int b)
    {
        return b == 0 ? a : GCD(b, a % b);
    }
}