// Last updated: 07/07/2026, 10:03:05
1public class Solution {
2    public long SumAndMultiply(int n) {
3        long sum = 0;
4        long x = 0;
5        int mult = 1;
6
7        while(n > 0)
8        {
9            int digit = n % 10;
10            sum += digit;
11            if (digit != 0)
12            {
13                x += digit * mult;
14                mult *= 10;
15            }
16
17            n /= 10;
18        }
19
20        return x * sum;
21    }
22}