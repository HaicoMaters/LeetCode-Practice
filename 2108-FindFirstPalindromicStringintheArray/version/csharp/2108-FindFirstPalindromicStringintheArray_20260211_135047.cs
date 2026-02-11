// Last updated: 11/02/2026, 13:50:47
1public class Solution {
2    public string FirstPalindrome(string[] words) {
3        foreach (string word in words)
4        {
5            if (IsPalindrome(word))
6            {
7                return word;
8            }
9        }
10
11        return "";
12    }
13
14    public bool IsPalindrome(string s)
15    {
16        int n = s.Length;
17        int L = 0;
18        int R = n-1;
19
20        while (L < R)
21        {
22            if (s[L] != s[R])
23            {
24                return false;
25            }
26            L++;
27            R--;
28        }
29
30        return true;
31    }
32}