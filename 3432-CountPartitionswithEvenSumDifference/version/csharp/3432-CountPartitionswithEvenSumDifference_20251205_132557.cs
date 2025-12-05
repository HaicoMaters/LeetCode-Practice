// Last updated: 05/12/2025, 13:25:57
1public class Solution {
2    public int CountPartitions(int[] nums) {
3        int n = nums.Length;
4        int total = 0;
5
6        for (int i = 0; i < n; i++)
7        {
8            total += nums[i];
9        }
10
11        int count = 0;
12        int leftTotal = 0;
13        for (int i = 0; i < n - 1; i++)
14        {
15            leftTotal += nums[i];
16            int rightTotal = total - leftTotal;
17
18            if ((leftTotal - rightTotal) % 2 == 0) count++;
19        }
20
21        return count;
22    }
23}