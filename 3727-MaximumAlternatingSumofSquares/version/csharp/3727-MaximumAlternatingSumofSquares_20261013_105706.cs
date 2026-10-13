// Last updated: 13/10/2026, 10:57:06
1public class Solution {
2    public long MaxAlternatingSum(int[] nums) {
3        int n = nums.Length;
4
5        for (int i = 0; i < n; i++)
6        {
7            nums[i] = nums[i] * nums[i];
8        }
9
10        Array.Sort(nums);
11
12        long sum = 0;
13
14        for (int i = 0; i < n / 2; i++)
15        {
16            sum -= nums[i];
17        }
18        
19        for (int i =  n/2; i < n; i++)
20        {
21            sum += nums[i];
22        }
23
24        return sum;
25    }
26}