// Last updated: 16/06/2026, 11:03:28
1public class Solution {
2    public string ProcessStr(string s) {
3        StringBuilder sb = new StringBuilder();
4
5        foreach (char c in s)
6        {
7            switch (c){
8                case '*': // remove last char
9                    if (sb.Length > 0)
10                    {
11                        sb.Length--;
12                    }
13                    break;
14                case '#': // duplicate and append
15                    sb.Append(sb);
16                    break;
17                case '%': // reverse (based on indexes to for speed rather than converting to char array then reversing)
18                    if (sb.Length > 0){
19                        for (int i = 0, j = sb.Length - 1; i < j; i++, j--)
20                        {
21                            (sb[i], sb[j]) = (sb[j], sb[i]);
22                        }
23                    }
24                    break;
25                default:
26                    sb.Append(c);
27                    break;
28            }
29        }
30
31        return sb.ToString();
32    }
33}