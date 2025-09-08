// Last updated: 08/09/2025, 11:28:04
public class Solution {
    public int[] GetNoZeroIntegers(int n) {
        int p1 = 1;
        int p2 = n - 1;

        while (p1.ToString().Contains("0") || p2.ToString().Contains("0"))
        {
            p1++;
            p2--;
        }

        return new int[]{p1, p2};
    }
}