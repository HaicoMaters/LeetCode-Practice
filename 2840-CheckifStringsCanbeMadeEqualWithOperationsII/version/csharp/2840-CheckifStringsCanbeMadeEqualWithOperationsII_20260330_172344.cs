// Last updated: 30/03/2026, 17:23:44
1public class Solution {
2    public bool CheckStrings(string s1, string s2) {
3        if (s1.Length != s2.Length) return false;
4
5        int[] oddFreq = new int[26];
6        int[] evenFreq = new int[26];
7
8        for (int i = 0; i < s1.Length; i++)
9        {
10            if (i % 2 == 0)
11            {
12                evenFreq[s1[i] - 'a']++;
13            }
14            else
15            {
16                oddFreq[s1[i] - 'a']++;
17            }
18        }
19
20
21        for (int i = 0; i < s2.Length; i++)
22        {
23            if (i % 2 == 0)
24            {
25                if (evenFreq[s2[i] - 'a'] > 0)
26                {
27                    evenFreq[s2[i] - 'a']--;
28                }
29                else
30                {
31                    return false;
32                }
33            }
34            else
35            {
36                if (oddFreq[s2[i] - 'a'] > 0)
37                {
38                    oddFreq[s2[i] - 'a']--;
39                }
40                else
41                {
42                    return false;
43                }
44            }
45        }
46
47        return true;
48    }
49}