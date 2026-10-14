// Last updated: 14/10/2026, 10:17:13
1public class Solution {
2    public string MaxSumOfSquares(int num, int sum) {
3
4       if (sum > num * 9) return "";
5
6        char[] n = new char[num];
7        int i = 0;
8        while (sum > 9)
9        {
10            n[i++] = '9';
11            sum -= 9;
12        }
13
14        if (i < num && sum > 0)
15        {
16            n[i++] = (char)('0' + sum);
17        }
18
19        while (i < num)
20        {
21            n[i++] = '0';
22        }
23
24        return new string(n);
25    }
26}