// Last updated: 18/02/2026, 13:04:34
1public class Solution {
2    public bool HasAlternatingBits(int n) {
3        bool lastBit = ((n & 1) == 1); //false -> 0 true -> 1;
4        n = n >> 1;
5
6        while(n != 0)
7        {
8            if (((n & 1) == 1) == lastBit) return false;
9
10            lastBit = !lastBit;
11            n = n >> 1; 
12        }
13
14        return true;
15    }
16}