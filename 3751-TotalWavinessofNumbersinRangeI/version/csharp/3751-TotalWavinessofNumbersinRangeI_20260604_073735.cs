// Last updated: 04/06/2026, 07:37:35
1public class Solution {
2    public int TotalWaviness(int num1, int num2) {
3        int total = 0;
4
5        for (int i = num1; i <= num2; i++)
6        {
7            int num = i;
8            int waviness = 0;
9
10            while (num >= 100)
11            {
12                int right = num % 10;
13                int mid = (num/10) % 10;
14                int left = (num / 100) % 10;
15
16                if ((left < mid && right < mid) || (left > mid && right > mid))
17                {
18                    waviness++;
19                }
20
21                num /= 10;
22            }
23
24            total += waviness;
25        }
26
27        return total;
28    }
29}