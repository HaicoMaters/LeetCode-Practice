// Last updated: 21/04/2026, 09:59:51
1public class Solution {
2    public string ReversePrefix(string s, int k) {
3        StringBuilder sb = new StringBuilder();
4        for (int i = 0; i < s.Length; i++)
5        {
6            if (i <= k-1)
7            { 
8                sb.Append(s[k-1-i]);
9            }
10            else
11            {
12                sb.Append(s[i]);
13            }
14        }
15
16        return sb.ToString();
17    }
18}