// Last updated: 09/03/2026, 11:25:44
1public class Solution {
2    public string ReversePrefix(string word, char ch) {
3        int idx = word.IndexOf(ch);
4
5        if (idx == -1) return word;
6
7        string pre = word.Substring(0, idx+1);
8        StringBuilder sb = new StringBuilder();
9
10        foreach (char c in pre)
11        {
12            sb.Insert(0, c);
13        }
14
15        for (int i = idx+1; i < word.Length; i++)
16        {
17            sb.Append(word[i]);
18        }
19
20        return sb.ToString();
21    }
22}