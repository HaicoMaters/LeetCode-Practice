// Last updated: 16/02/2026, 12:29:28
1public class Solution {
2    public int ReverseBits(int n) {
3        // Take the last bit from n and put at the end of reversed then continously shift
4        int reversed = 0;
5        for (int i = 0; i < 32; i++)
6        {
7            reversed = reversed << 1; //Shift left
8            reversed += n & 1; // Get last bit
9            n = n >> 1; // Shift n right
10        }
11        return reversed;
12    }
13}