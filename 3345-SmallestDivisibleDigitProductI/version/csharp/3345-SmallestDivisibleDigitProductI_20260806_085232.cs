// Last updated: 06/08/2026, 08:52:32
1public class Solution {
2    public int SmallestNumber(int n, int t) {
3        while (DigitProduct(n) % t != 0)
4        {
5            n++;
6        }
7
8        return n;
9    }
10
11    public int DigitProduct(int n)
12    {
13        int prod = 1;
14        while (n > 0)
15        {
16            prod *= n % 10;
17            n /= 10;
18        }
19        return prod;
20    }
21}