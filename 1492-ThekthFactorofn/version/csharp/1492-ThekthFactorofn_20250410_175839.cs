// Last updated: 10/04/2025, 17:58:39
public class Solution {
    public int KthFactor(int n, int k) { // Question has small bounds n <= 1000 so at most 1000 numbers will be checked
        int factors = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                factors++;
                if (factors == k) return i;
            }
        }
        return -1;
    }
}