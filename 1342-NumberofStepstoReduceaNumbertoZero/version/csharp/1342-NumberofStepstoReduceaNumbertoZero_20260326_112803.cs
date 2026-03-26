// Last updated: 26/03/2026, 11:28:03
1public class Solution {
2    public int NumberOfSteps(int num) {
3        int count = 0;
4
5        while (num > 0)
6        {
7            count++;
8
9            if (num % 2 == 0)
10            {
11                num /= 2;
12            }
13            else
14            {
15                num--;
16            }
17        }
18
19        return count;
20    }
21}