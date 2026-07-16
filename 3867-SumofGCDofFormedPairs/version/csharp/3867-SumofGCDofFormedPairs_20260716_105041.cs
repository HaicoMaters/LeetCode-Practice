// Last updated: 16/07/2026, 10:50:41
1public class Solution {
2    public long GcdSum(int[] nums) {
3        int n = nums.Length;
4
5        int[] mx = new int[n];
6        mx[0] = nums[0];
7
8        for (int i = 1; i < n; i++)
9        {
10            mx[i] = Math.Max(mx[i-1], nums[i]);
11        }
12
13        int[] prefixGcd = new int[n];
14
15        for (int i = 0; i < n; i++)
16        {
17            prefixGcd[i] = Gcd(nums[i], mx[i]);
18        }
19
20        Array.Sort(prefixGcd);
21
22        long sum = 0;
23
24        int l = 0;
25        int r = n-1;
26        while (l < r)
27        {
28            sum += Gcd(prefixGcd[l], prefixGcd[r]);
29            l++;
30            r--;
31        }
32
33
34        return sum;
35    }
36
37    public int Gcd(int a, int b)
38    {
39        while (b != 0)
40        {
41            int temp = a;
42            a = b;
43            b = temp % b;
44        }
45        return a;
46    }
47}