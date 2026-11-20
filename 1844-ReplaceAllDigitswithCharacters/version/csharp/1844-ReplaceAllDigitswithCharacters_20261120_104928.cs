// Last updated: 20/11/2026, 10:49:28
1public class Solution {
2    public string ReplaceDigits(string s) {
3        char[] replaced = s.ToCharArray();
4
5        for (int i = 1; i < s.Length; i += 2)
6        {
7            char c = replaced[i-1];
8            int x = replaced[i] - '0';
9
10            replaced[i] = (char)(c + x);
11        }
12
13        return new string(replaced);
14    }
15}