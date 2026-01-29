// Last updated: 29/01/2026, 16:25:13
1public class Solution {
2    public int MinBitFlips(int start, int goal) {
3        int flips = start ^ goal;
4
5        int count = 0;
6        while (flips != 0)
7        {
8            count += flips & 1;
9            flips >>= 1;
10        }
11        return count;
12    }
13}