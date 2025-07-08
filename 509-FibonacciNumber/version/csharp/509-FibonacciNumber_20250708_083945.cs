// Last updated: 08/07/2025, 08:39:45
public class Solution {
    public int Fib(int n) {
        if (n <= 1) return n;

        int[] fibNums = new int[n+1];

        fibNums[0] = 1;
        fibNums[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            fibNums[i] = fibNums[i-1] + fibNums[i-2];
        }

        return fibNums[n-1];
    }
}