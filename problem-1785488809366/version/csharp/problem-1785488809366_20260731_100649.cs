// Last updated: 31/07/2026, 10:06:49
1public class Solution {
2    public int MinimumPushes(string word) {
3        int[] counts = new int[26];
4        int pushes = 0;
5
6        foreach (char c in word)
7        {
8            counts[c - 'a']++;
9        }
10
11        Array.Sort(counts);
12
13        for (int i = 25; i >= 0; i--)
14        {
15            pushes += ((25 - i) / 8 + 1 ) * counts[i];
16        }
17
18        return pushes;
19    }
20}