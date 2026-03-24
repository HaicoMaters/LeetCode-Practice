// Last updated: 24/03/2026, 20:34:29
1public class Solution {
2    public string TruncateSentence(string s, int k) {
3        string[] words = s.Split(' ');
4        
5        StringBuilder sb = new StringBuilder();
6        for (int i = 0; i < k; i++)
7        {
8            sb.Append(words[i]);
9
10            if (i == k-1) break;
11            
12            sb.Append(' ');
13        }
14
15        return sb.ToString();
16    }
17}