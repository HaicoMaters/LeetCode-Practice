// Last updated: 08/12/2025, 14:17:43
1public class Solution {
2    public int CountTriples(int n) {
3        int count = 0;
4
5        for (int a = 1; a <= n; a++)
6        {
7            for (int b = 1; b <= n; b++)
8            {
9                int c = (int)Math.Sqrt(a*a + b*b);
10                if (c <= n && c * c == a * a + b * b){
11                    count++;
12                }
13            }
14        }
15
16        return count;
17    }
18}