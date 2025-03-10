public class Solution {
    public bool IsRectangleCover(int[][] rectangles) {
        HashSet<(int, int)> cornerSet = new HashSet<(int, int)>();
        
        int areaSum = 0;
        
        int leftMost = rectangles[0][0];
        int lowest = rectangles[0][1];
        int rightMost = rectangles[0][2];
        int highest = rectangles[0][3];
        
        foreach (var rect in rectangles) {
            areaSum += (rect[2] - rect[0]) * (rect[3] - rect[1]);
            
            // Update the bounding box
            leftMost = Math.Min(leftMost, rect[0]);
            lowest = Math.Min(lowest, rect[1]);
            rightMost = Math.Max(rightMost, rect[2]);
            highest = Math.Max(highest, rect[3]);
            
            // Add the corners of the current rectangle to the cornerSet
            AddCorner(cornerSet, rect[0], rect[1]);
            AddCorner(cornerSet, rect[0], rect[3]);
            AddCorner(cornerSet, rect[2], rect[1]);
            AddCorner(cornerSet, rect[2], rect[3]);
        }
        
        // The expected area should be the area of the bounding box
        int expectedArea = (rightMost - leftMost) * (highest - lowest);
        if (areaSum != expectedArea) {
            return false;
        }
        
        // Check that only the four corners of the bounding box appear once
        var corners = new (int, int)[] { (leftMost, lowest), (leftMost, highest), (rightMost, lowest), (rightMost, highest) };
        
        foreach (var corner in corners) {
            if (!cornerSet.Contains(corner)) {
                return false;
            }
            cornerSet.Remove(corner); // Remove the bounding box corners
        }
        
        // All other corners should appear exactly twice
        return cornerSet.Count == 0;
    }

    private void AddCorner(HashSet<(int, int)> cornerSet, int x, int y) {
        var corner = (x, y);
        if (cornerSet.Contains(corner)) {
            cornerSet.Remove(corner);  // If it's already in the set, remove it (because we expect even count)
        } else {
            cornerSet.Add(corner);  // Otherwise, add it (odd count)
        }
    }
}
