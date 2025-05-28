// Last updated: 28/05/2025, 13:14:35
public class DetectSquares {

    Dictionary<(int, int), int> points; // points and their frequencies
    Dictionary<int, HashSet<int>> yxMap; // y coord of a point, then all possible x coords at those places

    public DetectSquares() {
        points = new Dictionary<(int, int), int>();
        yxMap = new Dictionary<int, HashSet<int>>();
    }
    
    public void Add(int[] point) {
        int px = point[0];
        int py = point[1];

        // Update points dict
        if (!points.ContainsKey((px, py))){
            points[(px, py)] = 1;
        }
        else
        {
            points[(px, py)]++; 
        }

        // Update yxMap
        if (!yxMap.ContainsKey(py)){
            yxMap[py] = new HashSet<int>{px};
        }
        else{
            yxMap[py].Add(px);
        }
    }
    
    public int Count(int[] point) {
        int count = 0;
        int px = point[0];
        int py = point[1];

        // Find the all points with same y coord as current corner
        if (!yxMap.ContainsKey(py)) return 0;
        var possibleX = yxMap[py];

        foreach (int x in possibleX){
            if (x == px) continue; // not possible to make square of length 0

            int distance = (x < px) ? px - x : x - px;

            // Check if positive distance y values
            if (points.ContainsKey((px, py + distance)) && points.ContainsKey((x, py + distance))){
                // Get all possible ways based on the frequencies of each point (always just one from the provided point)
                count += 1 * points[(x, py)] * points[(px, py + distance)] * points[(x, py + distance)];
            }

            // Check if negative distance y values
            if (points.ContainsKey((px, py - distance)) && points.ContainsKey((x, py - distance))){
                // Get all possible ways based on the frequencies of each point (always just one from the provided point)
                count += 1 * points[(x, py)] * points[(px, py - distance)] * points[(x, py - distance)];
            }
        }

        return count;
    }
}

/**
 * Your DetectSquares object will be instantiated and called as such:
 * DetectSquares obj = new DetectSquares();
 * obj.Add(point);
 * int param_2 = obj.Count(point);
 */