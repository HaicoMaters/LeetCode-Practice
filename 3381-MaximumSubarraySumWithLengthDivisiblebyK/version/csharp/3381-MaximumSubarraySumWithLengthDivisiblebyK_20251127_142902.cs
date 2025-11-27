// Last updated: 27/11/2025, 14:29:02
1public class Solution {
2    public long MaxSubarraySum(int[] nums, int k) {
3        long[] minPrefix = new long[k];
4
5        for (int i = 0; i < k; i++)
6        {
7            minPrefix[i] = long.MaxValue;
8        }
9
10        minPrefix[0] = 0;
11
12        long prefix = 0;
13        long max = long.MinValue;
14
15        for (int i = 0; i < nums.Length; i++)
16        {
17            prefix += nums[i];
18            int mod = (i + 1) % k;
19
20            if (minPrefix[mod] != long.MaxValue)
21            {
22                max = Math.Max(max, prefix - minPrefix[mod]);
23            }
24
25            if (prefix < minPrefix[mod])
26            {
27                minPrefix[mod] = prefix;
28            }
29        }
30
31        return max;
32    }
33}