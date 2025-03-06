public class Solution {
    Random rand;
    double[] center;
    double radius;
    double radiusSquared;

    public Solution(double radius, double x_center, double y_center) {
        rand = new Random();
        this.radius = radius;
        this.radiusSquared = radius * radius;
        this.center = new double[2] { x_center, y_center };
    }

    public double[] RandPoint() {
        while (true) {
            // Generate random x, y in the square [-radius, radius] around the center
            double x = (rand.NextDouble() * 2 - 1) * radius;
            double y = (rand.NextDouble() * 2 - 1) * radius;
            
            // Check if the point is inside the circle
            if (x * x + y * y <= radiusSquared) {
                return new double[] { center[0] + x, center[1] + y };
            }
        }
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(radius, x_center, y_center);
 * double[] param_1 = obj.RandPoint();
 */