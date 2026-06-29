// Last updated: 29/06/2026, 09:08:37
1public class Solution {
2    public int NumOfStrings(string[] patterns, string word) {
3        int strings = 0;
4        
5        foreach (string pattern in patterns)
6        {
7            if (word.Contains(pattern)) strings++;
8        }
9
10        return strings;
11    }
12}