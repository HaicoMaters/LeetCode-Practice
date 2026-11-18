// Last updated: 18/11/2026, 08:21:37
1public class Solution {
2    public int MinChanges(string s) {
3        int changes = 0;
4
5        for (int i = 1; i < s.Length; i += 2)
6        {
7            if (s[i] != s[i-1]) changes++;
8        }
9
10        return changes;
11    }
12}