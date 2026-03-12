// Last updated: 12/03/2026, 12:18:15
1public class Solution {
2    public string RemoveTrailingZeros(string num) {
3        int count = 0;
4        int n = num.Length;
5        int i = n-1;
6
7        while (num[i] == '0')
8        {
9            count++;
10            i--;
11        }
12
13        return num.Substring(0, n - count);
14    }
15}