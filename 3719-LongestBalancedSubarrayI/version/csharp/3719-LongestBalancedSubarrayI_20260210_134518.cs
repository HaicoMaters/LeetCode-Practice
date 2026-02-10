// Last updated: 10/02/2026, 13:45:18
1public class Solution {
2    public int LongestBalanced(int[] nums) {
3        int n = nums.Length;
4        int longest = 0;
5
6        for (int i = 0; i < n; i++)
7        {
8            HashSet<int> odd = new HashSet<int>();
9            HashSet<int> even = new HashSet<int>();
10
11            for (int j = i; j < n; j++)
12            {
13                int val = nums[j];
14                if (val % 2 == 0)
15                {
16                    even.Add(val);
17                }
18                else 
19                {
20                    odd.Add(val);
21                }
22
23                if (even.Count == odd.Count)
24                {
25                    longest = Math.Max(longest, j - i + 1);
26                }
27            }
28        }
29
30        return longest;
31    }
32}