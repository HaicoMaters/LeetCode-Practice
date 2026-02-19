// Last updated: 19/02/2026, 14:36:00
1public class Solution {
2    public int CountBinarySubstrings(string s) {
3        int count = 0;
4        int prev = 0;
5        int current = 1;
6
7        for (int i = 1; i < s.Length; i++)
8        {
9            if (s[i] == s[i-1])
10            {
11                current++;
12            }
13            else
14            {
15                count += Math.Min(prev, current);
16                prev = current;
17                current = 1;
18            }
19        }
20
21        return count + Math.Min(prev, current);
22    }
23}