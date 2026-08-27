// Last updated: 27/08/2026, 12:58:53
1public class Solution {
2    public int MostWordsFound(string[] sentences) {
3        int max = 0;
4
5        foreach (string sentence in sentences)
6        {
7            int cnt = 1;
8            foreach (char c in sentence)
9            {
10                if (c == ' ')
11                {
12                    cnt++;
13                }
14            }
15            max = Math.Max(max, cnt);
16        }
17
18        return max;
19    }
20}