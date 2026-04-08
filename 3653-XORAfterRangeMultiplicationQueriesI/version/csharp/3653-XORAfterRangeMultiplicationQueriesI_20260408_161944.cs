// Last updated: 08/04/2026, 16:19:44
1public class Solution {
2    public int XorAfterQueries(int[] nums, int[][] queries) {
3        foreach (int[] query in queries)
4        {
5            int idx = query[0];
6            int r = query[1];
7            int k = query[2];
8            int v = query[3];
9
10            while (idx <= r)
11            {
12                long temp = nums[idx];
13                nums[idx] = (int)((temp * v) % (1000000007));
14                idx += k;
15            }
16        }
17
18        int xor = nums[0];
19
20        for (int i = 1; i < nums.Length; i++)
21        {
22            xor ^= nums[i];
23        }
24
25        return xor;
26    }
27}