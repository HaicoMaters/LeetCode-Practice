// Last updated: 27/05/2026, 10:56:27
1public class Solution {
2    public int NumberOfSpecialChars(string word) {
3        int[] lastLowerCase = new int[26];
4        int[] firstUpperCase = new int[26];
5
6        for (int i = 0; i < 26; i++)
7        {
8            lastLowerCase[i] = -1;
9            firstUpperCase[i] = -1;
10        }
11
12        for (int i = 0; i < word.Length; i++)
13        {
14            char c = word[i];
15
16            if (c >= 'a' && c <= 'z')
17            {
18                int idx = c - 'a';
19                lastLowerCase[idx] = i;
20            }
21            else
22            {
23                int idx = c - 'A';
24
25                if (firstUpperCase[idx] == -1)
26                {
27                    firstUpperCase[idx] = i;
28                }
29            }
30        }
31
32        int specialCount = 0;
33        for (int i = 0; i < 26; i++)
34        {
35            if (lastLowerCase[i] == -1 || firstUpperCase[i] == -1) continue;
36
37            if (lastLowerCase[i] < firstUpperCase[i])
38            {
39                specialCount++;
40            }
41        }
42
43        return specialCount;
44    }
45}