// Last updated: 12/12/2025, 03:16:50
1public class Solution {
2    public int MinPartitions(string n) {
3        int greatestDigit = 0;
4
5        foreach(char c in n)
6        {
7            greatestDigit = Math.Max(c - '0', greatestDigit);
8
9            if (greatestDigit == 9) return 9;
10        }
11
12        return greatestDigit;
13    }
14}