// Last updated: 29/07/2026, 10:25:44
1public class Solution {
2    public int NumberOfMatches(int n) {
3        int matches = 0;
4
5        while (n > 1)
6        {
7            if ((n & 1) == 0)
8            {
9                matches += n/2;
10                n /= 2;
11            }
12            else
13            {
14                matches += (n-1)/2;
15                n = (n-1)/2 + 1;
16            }
17        }
18
19        return matches;
20    }
21}