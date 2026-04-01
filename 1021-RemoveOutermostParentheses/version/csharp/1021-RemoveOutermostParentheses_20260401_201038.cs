// Last updated: 01/04/2026, 20:10:38
1public class Solution {
2    public string RemoveOuterParentheses(string s) {
3        StringBuilder res = new StringBuilder();
4        int idx = 0;
5
6        foreach (char c in s)
7        {
8            if (c == '(' && idx++ > 0) res.Append(c);
9            else if (c == ')' && idx-- > 1) res.Append(c);
10        }
11
12        return res.ToString();
13    }
14}