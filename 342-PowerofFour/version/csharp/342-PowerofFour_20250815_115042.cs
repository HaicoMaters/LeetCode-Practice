// Last updated: 15/08/2025, 11:50:42
public class Solution {
    public bool IsPowerOfFour(int n) {
        if (n <= 0) return false;

        while (n % 4 == 0)
        {
            n /= 4;
        }

        return n == 1;
    }
}