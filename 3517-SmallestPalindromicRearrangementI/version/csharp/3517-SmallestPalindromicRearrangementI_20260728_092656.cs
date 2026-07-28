// Last updated: 28/07/2026, 09:26:56
1public class Solution {
2    public string SmallestPalindrome(string s) {
3        int[] counts = new int[26];
4        int len = s.Length;
5
6        foreach (char c in s)
7        {
8            counts[c - 'a']++;
9        }
10
11        char[] rearrangement = new char[len];
12        int idx = 0;
13
14        for (int i = 0; i < 26; i++)
15        {
16            while (counts[i] > 0)
17            {
18                char ch = (char) ('a' + i);
19                if (counts[i] >= 2)
20                {
21                    rearrangement[idx] = ch;
22                    rearrangement[len - idx - 1] = ch;
23                    idx++;
24                    counts[i] -= 2;
25                }
26                if (counts[i] % 2 != 0)
27                {
28                    rearrangement[len/2] = ch;
29                    counts[i]--;
30                }
31            }
32        }
33
34        return new string(rearrangement);
35    }
36}