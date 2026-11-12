// Last updated: 12/11/2026, 10:33:42
1public class Solution {
2    public int LongestMonotonicSubarray(int[] nums) {
3        int longest = 1;
4        int increase = 1;
5        int decrease = 1;
6        int n = nums.Length;
7
8        for (int i = 1; i < n ; i++)
9        {
10            if (nums[i] > nums[i-1])
11            {
12                increase++;
13                decrease = 1;
14            }
15            else if (nums[i] < nums[i-1])
16            {
17                decrease++;
18                increase = 1;
19            }
20            else
21            {
22                increase = 1;
23                decrease = 1;
24            }
25            
26            longest = Math.Max(longest, Math.Max(increase, decrease));
27        }
28
29        return longest;
30    }
31}