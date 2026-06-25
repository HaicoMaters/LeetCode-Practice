// Last updated: 25/06/2026, 10:33:14
1public class Solution {
2    public int CountMajoritySubarrays(int[] nums, int target) {
3        int n = nums.Length;
4        int majorityCount = 0;
5        
6        for (int i = 0; i < n; i++)
7        {
8            int majorityDiff= 0;
9            for (int j = i; j < n; j++)
10            {
11                if (nums[j] == target)
12                {
13                    majorityDiff++;
14                }
15                else
16                {
17                    majorityDiff--;
18                }
19
20                if (majorityDiff > 0) // if is a majority target
21                {
22                    majorityCount++;
23                }
24            }
25        }
26
27        return majorityCount;
28    }
29}