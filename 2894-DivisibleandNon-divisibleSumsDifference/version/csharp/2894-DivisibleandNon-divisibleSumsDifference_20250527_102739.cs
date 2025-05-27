// Last updated: 27/05/2025, 10:27:39
public class Solution {
    public int DifferenceOfSums(int n, int m) {
        int k = n / m;
        return (n * (n + 1) / 2) - (k * (k + 1) * m);
    }
}