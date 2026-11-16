// Last updated: 16/11/2026, 10:12:47
1public class Solution {
2    public string DigitSum(string s, int k) {
3        if (s.Length <= k) return s;
4
5        string str = "";
6
7        for (int i = 0; i < s.Length; i += k)
8        {
9            int num = 0;
10
11            for (int j = i; j < i + k && j < s.Length; j++)
12            {
13                num += s[j] - '0';
14            }
15
16            str += num;
17        }
18
19        return DigitSum(str, k);
20    }
21}