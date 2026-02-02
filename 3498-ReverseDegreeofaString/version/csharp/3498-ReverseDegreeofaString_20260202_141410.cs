// Last updated: 02/02/2026, 14:14:10
1public class Solution {
2    public int ReverseDegree(string s) {
3        int degree = 0;
4        int idx = 1; // 1-indexed
5
6        foreach (char c in s)
7        {
8            degree += Math.Abs((c - 'a') - 26) * idx;
9            idx++;
10        }
11
12        return degree;
13    }
14}