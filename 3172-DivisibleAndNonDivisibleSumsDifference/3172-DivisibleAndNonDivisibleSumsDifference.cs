// Last updated: 28/05/2025, 13:14:08
public class Solution {
    public int DifferenceOfSums(int n, int m) {
        int k = n / m;
        return (n * (n + 1) / 2) - (k * (k + 1) * m);
    }
}