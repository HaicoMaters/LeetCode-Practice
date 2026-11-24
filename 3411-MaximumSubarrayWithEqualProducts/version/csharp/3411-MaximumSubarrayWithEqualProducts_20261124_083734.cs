// Last updated: 24/11/2026, 08:37:34
1public class Solution {
2    public int MaxLength(int[] nums) {
3        int n = nums.Length;
4        int len = 0;
5
6        for (int i = 0; i < n; i++)
7        {
8            long prod = 1;
9            long gcd = 0;
10            long lcm = 1;
11
12            for (int j = i; j < n; j++)
13            {
14                prod *= nums[j];
15                gcd = GCD(gcd, nums[j]);
16                lcm = LCM(lcm, nums[j]);
17
18                if (prod == gcd * lcm)
19                {
20                    len = Math.Max(len, j-i+1);
21                }
22            }
23        }
24
25        return len;
26    }
27
28    public long GCD(long a, long b) 
29    {
30        while (b != 0) {
31            long temp = b;
32            b = a % b;
33            a = temp;
34        }
35        return a;
36    }
37
38    public long LCM(long a, long b) 
39    {
40        return a/GCD(a,b)*b;
41    }
42}