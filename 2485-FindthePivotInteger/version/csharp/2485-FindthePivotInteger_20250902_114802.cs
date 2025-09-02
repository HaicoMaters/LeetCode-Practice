// Last updated: 02/09/2025, 11:48:02
public class Solution {
    public int PivotInteger(int n) {
        long total = (long) n * (n+1) / 2; // sum of all nums 1 to n
        int x = (int)Math.Sqrt(total); // x should be the squareroot provided it is a perfect square
        return (long) x*x == total ? x : -1;
    }
}