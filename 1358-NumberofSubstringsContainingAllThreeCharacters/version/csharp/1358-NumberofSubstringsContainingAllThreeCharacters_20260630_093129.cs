// Last updated: 30/06/2026, 09:31:29
1public class Solution {
2    public int NumberOfSubstrings(string s) {
3        int count = 0;
4        Dictionary<char, int> charCount = new Dictionary<char, int>(){{'a', 0}, {'b', 0}, {'c', 0}};
5        int n = s.Length;
6        int L = 0;
7
8        for (int R = 0; R < n; R++)
9        {
10            charCount[s[R]]++;
11
12            while (charCount['a'] > 0 && charCount['b'] > 0 && charCount['c'] > 0)
13            {
14                count += n - R;
15                charCount[s[L]]--;
16                L++;
17            }
18        }
19
20        return count;
21    }
22}