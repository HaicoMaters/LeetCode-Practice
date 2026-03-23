// Last updated: 23/03/2026, 20:43:08
1public class Solution {
2    public int MirrorDistance(int n) {
3        int reverse = 0;
4        int temp = n;
5
6        while (temp > 0)
7        {
8            reverse *= 10;
9            reverse += temp % 10;
10            temp /= 10;
11        }
12
13        return Math.Abs(n - reverse);
14    }
15}