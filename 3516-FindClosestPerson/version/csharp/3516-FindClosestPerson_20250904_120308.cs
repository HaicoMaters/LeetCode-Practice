// Last updated: 04/09/2025, 12:03:08
public class Solution {
    public int FindClosest(int x, int y, int z) {
        if (Math.Abs(x - z) < Math.Abs(y - z)) return 1;
        if (Math.Abs(x - z) > Math.Abs(y - z)) return 2;
        return 0;
    }
}