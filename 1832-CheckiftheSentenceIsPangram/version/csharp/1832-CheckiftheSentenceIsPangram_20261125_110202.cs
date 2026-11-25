// Last updated: 25/11/2026, 11:02:02
1public class Solution {
2    public bool CheckIfPangram(string sentence) {
3        bool[] appears = new bool[26];
4
5        foreach(char c in sentence)
6        {
7            appears[c - 'a'] = true;
8        }
9
10        for (int i = 0; i < 26; i++)
11        {
12            if (!appears[i]) return false;
13        }
14
15        return true;
16    }
17}